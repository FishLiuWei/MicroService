﻿using Feng.Core;
using Feng.Core.ErrorCode;
using Feng.Core.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
namespace Feng.Basic.Middleware
{
    public class ErrorLogMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        private readonly IErrorCode _errorCodeStore;
        private readonly IJsonHelper _jsonHelper;
        public ErrorLogMiddleware(RequestDelegate next, 
            ILoggerFactory loggerFactory, 
            IErrorCode errorCodeStore,
            IJsonHelper jsonHelper)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<ErrorLogMiddleware>();
            _errorCodeStore = errorCodeStore;
            _jsonHelper = jsonHelper;
        }

        public async Task Invoke(HttpContext context)
        {
            ReturnResult errorInfo = null;
            try
            {
                await _next(context);
            }
            catch (FengException ex)
            {
                var newMsg = _errorCodeStore.StringGet(ex.ErrorCode);
                if (string.IsNullOrWhiteSpace(newMsg))
                    newMsg = ex.ErrorMessage;
                errorInfo = new ReturnResult(newMsg);
            }
            catch (Exception ex)
            {
                errorInfo = new ReturnResult("系统开小差了,请稍后再试");
                _logger.LogError(ex, $"全局异常捕获，状态码：{ context?.Response?.StatusCode}，Url：{context?.Request?.GetDisplayUrl()}");
            }
            finally
            {
                if (errorInfo != null)
                {
                    var Message = JsonConvert.SerializeObject(errorInfo);
                    await HandleExceptionAsync(context, Message);
                }
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, string message)
        {
            context.Response.ContentType = "application/json;charset=utf-8";
            return context.Response.WriteAsync(message);
        }
    }
}
