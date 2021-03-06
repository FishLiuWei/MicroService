﻿using Feng.Basic;
using Feng.CMS.Model;
using System;
using System.Collections.Generic;

namespace Feng.CMS.IService
{
    public partial interface IAdvertService
    {
        #region 后台接口
        ReturnResult<ReturnAdvertPositionModel> AddAdvertPosition(string appid, AddAdvertPositionModel model);

        ReturnResult RemoveAdvertPosition(string appid, string id);

        ReturnResult ModifyAdvertPosition(string appid, AdvertPositionModel model);
        
        ReturnResult<PageList<AdvertPositionModel>> QueryAllAdvertPosition(string appid,int pageSize,int pageIndex,string title, int status);

        //ReturnResult<List<QueryAdvertPositionModel>> QueryAdvertPositionByIds(string appid, string ids);


        ReturnResult ModifyAdvertPositionStatus(string appid, string id,bool status);


        ReturnResult<ReturnAdvertModel> AddAdvert(string appid, AddAdvertModel model);

        ReturnResult RemoveAdvert(string appid, int id);

        ReturnResult ModifyAdvert(string appid, AdvertModel model);

        ReturnResult<List<AdvertModel>> QueryAdvertByPosition(string appid, string posId);

        ReturnResult ModifyAdvertStatus(string appid, int id, bool status);
        #endregion
    }
}
