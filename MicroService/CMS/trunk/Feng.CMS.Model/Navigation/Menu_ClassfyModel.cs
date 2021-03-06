﻿using System;
using System.Collections.Generic;

namespace Feng.CMS.Model.Navigation
{
    /// <summary>
    /// 导航菜单
    /// </summary>
    public class Menu_ClassfyModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 导航名
        /// </summary>
        public string class_name { get; set; }
        /// <summary>
        /// 分类code
        /// </summary>
        public string classfy { get; set; }
    }
    public class ReturnMenu_ClassfyModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int id { get; set; }
    }

    public class AddMenu_ClassfyModel
    {
        /// <summary>
        /// 分类名
        /// </summary>
        public string class_name { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
        public string classfy { get; set; }
    }

    /// <summary>
    /// 修改
    /// </summary>
    public class ModifyMenu_ClassfyModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 分类名
        /// </summary>
        public string class_name { get; set; }
    }
}
