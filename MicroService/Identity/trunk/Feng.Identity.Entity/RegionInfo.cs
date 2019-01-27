﻿using SqlSugar;

namespace Feng.Identity.Entity
{
    /// <summary>
    /// 区域信息类
    /// </summary>
    [SugarTable("tb_regions")]
    public class RegionInfo
    {
        /// <summary>
        /// 区域唯一标示符
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public short regionid { get; set; }
        /// <summary>
        /// 区域名称
        /// </summary>
        public string name { get; set; }
        /// 
        /// </summary>
        public string spell { get; set; }
        /// 
        /// </summary>
        public string shortspell { get; set; }
        /// 排序
        /// </summary>
        public short displayorder { get; set; }
        /// 父类
        /// </summary>
        public short parentid { get; set; }
        /// 区域名称
        /// </summary>
        public short layer { get; set; }
        /// 省编号
        /// </summary>
        public short provinceid { get; set; }
        /// 省名称
        /// </summary>
        public string provincename { get; set; }
        /// 市编号
        /// </summary>
        public short cityid { get; set; }
        /// 市名称
        /// </summary>
        public string cityname { get; set; }
    }
}