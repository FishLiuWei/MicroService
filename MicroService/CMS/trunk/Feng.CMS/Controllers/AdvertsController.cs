﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Feng.Basic;
using Feng.CMS.IService;
using Feng.CMS.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Feng.CMS.Controllers.v1
{
    /// <summary>
    /// 广告管理
    /// </summary>
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/[controller]")]
    [ApiController]
    public class AdvertsController : ControllerBase
    {
        public readonly IAdvertService _advertService;
        public AdvertsController(IAdvertService advertService) {
            _advertService = advertService;
        }
        /// <summary>
        /// 添加广告位
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost,Route("addpos")]
        public ReturnResult<ReturnAdvertPositionModel> AddAdvertPosition( [FromBody]AddAdvertPositionModel model) {
            return _advertService.AddAdvertPosition(Utils.Extensions.Plat, model);
        }
        /// <summary>
        /// 根据编号删除广告位
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet,Route("delpos")]
        public ReturnResult RemoveAdvertPosition( string id) {
            return _advertService.RemoveAdvertPosition(Utils.Extensions.Plat, id);
        }
        /// <summary>
        /// 修改广告位
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost,Route("modifypos")]
        public ReturnResult ModifyAdvertPosition( [FromBody]AdvertPositionModel model) {
            return _advertService.ModifyAdvertPosition(Utils.Extensions.Plat, model);
        }
        /// <summary>
        /// 分页获取广告位
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="title"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        [HttpGet,Route("listpos")]
        //[Authorize("permission")]
        public ReturnResult<PageList<AdvertPositionModel>> QueryAllAdvertPosition( int pageSize, int pageIndex, string title = "", int status = -1) {
            return _advertService.QueryAllAdvertPosition(Utils.Extensions.Plat, pageSize, pageIndex,title,status);
        }
        ///// <summary>
        ///// 根据位置查询广告信息
        ///// </summary>
        ///// <param name="ids"></param>
        ///// <returns></returns>
        //[HttpGet, Route("pos")]
        //public ReturnResult<AdvertListModel> QueryAdvertPositionByIds( string ids) {
        //    return _advertService.QueryAdvertPositionByIds(Utils.Extensions.Plat, ids);
        //}
        /// <summary>
        /// 修改广告位状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        [HttpGet, Route("statuspos")]
        public ReturnResult ModifyAdvertPositionStatus(string id, bool status) {
            return _advertService.ModifyAdvertPositionStatus(Utils.Extensions.Plat, id, status);
        }

        /// <summary>
        /// 添加广告
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost,Route("add")]
        public ReturnResult<ReturnAdvertModel> AddAdvert([FromBody]AddAdvertModel model) {
            return _advertService.AddAdvert(Utils.Extensions.Plat, model);
        }
        /// <summary>
        /// 根据编号删除广告
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet,Route("del")]
        public ReturnResult RemoveAdvert( int id) {
            return _advertService.RemoveAdvert(Utils.Extensions.Plat, id);
        }
        /// <summary>
        /// 修改广告信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost,Route("modfiy")]
        public ReturnResult ModifyAdvert([FromBody]AdvertModel model) {
            return _advertService.ModifyAdvert(Utils.Extensions.Plat, model);
        }
        /// <summary>
        /// 根据广告位查询广告
        /// </summary>
        /// <param name="posId"></param>
        /// <returns></returns>
        [HttpGet,Route("list")]
        public ReturnResult<List<AdvertModel>> QueryAdvertByPosition(string posId) {
            return _advertService.QueryAdvertByPosition(Utils.Extensions.Plat, posId);
        }
        /// <summary>
        /// 修改广告状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        [HttpGet,Route("status")]
        public ReturnResult ModifyAdvertStatus( int id, bool status) {
            return _advertService.ModifyAdvertStatus(Utils.Extensions.Plat, id, status);
        }

    }
}