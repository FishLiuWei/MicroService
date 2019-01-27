﻿using System;
using System.Collections.Generic;

namespace Feng.CMS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AdvertModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 归属广告位置编号
        /// </summary>
        public string adPosId { get; set; }
        /// <summary>
        /// 位置标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 类型,0图片,1视频,2文字
        /// </summary>
        public int adType { get; set; }
        /// <summary>
        /// 类型内容
        /// </summary>
        public string adContent { get; set; }
        /// <summary>
        /// 访问URL
        /// </summary>
        public string visitUrl { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? startDate { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? endDate { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int displayOrder { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public bool status { get; set; }
        /// <summary>
        /// 扩展字段1
        /// </summary>
        public string extfield1 { get; set; }
        /// <summary>
        /// 扩展字段2
        /// </summary>
        public string extfield2 { get; set; }
        /// <summary>
        /// 扩展字段3
        /// </summary>
        public string extfield3 { get; set; }
        /// <summary>
        /// 扩展字段4
        /// </summary>
        public string extfield4 { get; set; }
    }

    public class AddAdvertModel
    {
        /// <summary>
        /// 归属广告位置编号
        /// </summary>
        public string adPosId { get; set; }
        /// <summary>
        /// 位置标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 类型,0图片,1视频,2文字
        /// </summary>
        public int adType { get; set; }
        /// <summary>
        /// 类型内容
        /// </summary>
        public string adContent { get; set; }
        /// <summary>
        /// 访问URL
        /// </summary>
        public string visitUrl { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? startDate { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? endDate { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int displayOrder { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public bool status { get; set; }
        /// <summary>
        /// 扩展字段1
        /// </summary>
        public string extfield1 { get; set; }
        /// <summary>
        /// 扩展字段2
        /// </summary>
        public string extfield2 { get; set; }
        /// <summary>
        /// 扩展字段3
        /// </summary>
        public string extfield3 { get; set; }
        /// <summary>
        /// 扩展字段4
        /// </summary>
        public string extfield4 { get; set; }
    }

    public class ReturnAdvertModel {
        /// <summary>
        /// 编号
        /// </summary>
        public int id { get; set; }
    }

    public class QueryAdvertModel {
        /// <summary>
        /// 位置标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 类型,0图片,1视频,2文字
        /// </summary>
        public int adType { get; set; }
        /// <summary>
        /// 类型内容
        /// </summary>
        public string adContent { get; set; }
        /// <summary>
        /// 访问URL
        /// </summary>
        public string visitUrl { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? startDate { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? endDate { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int displayOrder { get; set; }
        /// <summary>
        /// 扩展字段1
        /// </summary>
        public string extfield1 { get; set; }
        /// <summary>
        /// 扩展字段2
        /// </summary>
        public string extfield2 { get; set; }
        /// <summary>
        /// 扩展字段3
        /// </summary>
        public string extfield3 { get; set; }
        /// <summary>
        /// 扩展字段4
        /// </summary>
        public string extfield4 { get; set; }
    }


    public class AdvertPositionModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 位置标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 位置描述
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 排序，默认0
        /// </summary>
        public int displayOrder { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public bool status { get; set; }
    }
    public class AddAdvertPositionModel {
        /// <summary>
        /// 位置标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 位置描述
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 排序，默认0
        /// </summary>
        public int displayOrder { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public bool status { get; set; }
    }
    public class ReturnAdvertPositionModel {
        /// <summary>
        /// 编号
        /// </summary>
        public string id { get; set; }
    }
    
    public class QueryAdvertPositionModel {
        /// <summary>
        /// 编号
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 位置标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 排序，默认0
        /// </summary>
        public int displayOrder { get; set; }

        public List<QueryAdvertModel> adList = new List<QueryAdvertModel>();

    }

}
