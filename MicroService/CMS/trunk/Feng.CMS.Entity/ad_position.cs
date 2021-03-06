﻿using SqlSugar;
using System;

namespace Feng.CMS.Entity
{
    /// <summary>
    /// 广告位置表
    /// </summary>
    [SugarTable("ad_position")]
    public class ad_position
    {
        /// <summary>
        /// 自增主键编号
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string id { get; set; }
        /// <summary>
        /// 归属平台？其他
        /// </summary>
        public string appid { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int order { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public bool status { get; set; }
    }
}

