﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Feng.Basic;
using Feng.Product.IService;
using Feng.Product.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Feng.Product.Areas.web.Controllers.v1
{
    /// <summary>
    /// 产品分类管理
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("{area}/v{version:apiVersion}/[controller]")]
    public class CategoryWebController : ControllerBase
    {
        /// <summary>
        /// 注入
        /// </summary>
        public readonly ICategoryService _categoryService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryService"></param>
        public CategoryWebController(ICategoryService categoryService) {
            _categoryService = categoryService;
        }
        /// <summary>
        /// 获取分类
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("query")]
        public ReturnResult<List<ReturnListCategoryModel>> QueryCategory() {
            string platKey = Utils.Extensions.Plat;
            return _categoryService.QueryCategory(platKey);
        }
    }
}