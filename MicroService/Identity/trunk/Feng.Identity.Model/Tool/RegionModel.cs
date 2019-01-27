﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Feng.Identity.Model.Tool
{
    public class RegionModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        public short RegionId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string RegionName { get; set; }
    }

    public class AllRegionModel
    {
        /// <summary>
        /// 区域编号
        /// </summary>
        public short RegionId { get; set; }
        /// <summary>
        /// 区域名称
        /// </summary>
        public string RegionName { get; set; }
        /// <summary>
        /// 省编号
        /// </summary>
        public short ProvinceId { get; set; }
        /// 省名称
        /// </summary>
        public string ProvinceName { get; set; }
        /// 市编号
        /// </summary>
        public short CityId { get; set; }
        /// 市名称
        /// </summary>
        public string CityName { get; set; }

    }
}