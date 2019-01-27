﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Feng.Basic;
using Feng.CMS.IService;
using Feng.CMS.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Feng.CMS.Controllers.web.v1
{
    /// <summary>
    /// 广告管理
    /// </summary>
    [ApiVersion("1.0")]
    [Route("{area}/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class AdvertsWebController : ControllerBase
    {
        public readonly IAdvertService _advertService;
        public AdvertsWebController(IAdvertService advertService) {
            _advertService = advertService;
        }

        /// <summary>
        /// 根据广告位查询广告
        /// </summary>
        /// <param name="posId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        [HttpGet,Route("list")]
        public ReturnResult<List<AdvertModel>> QueryAdvertByPosition(string posId) {
            return _advertService.QueryAdvertByPosition_Web(Utils.Extensions.Plat, posId);
        }
    }
}