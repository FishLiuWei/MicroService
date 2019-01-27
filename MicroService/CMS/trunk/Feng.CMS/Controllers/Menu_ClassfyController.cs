﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Feng.Basic;
using Feng.CMS.IService;
using Feng.CMS.Model;
using Feng.CMS.Model.Navigation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Feng.CMS.Controllers.v1
{
    /// <summary>
    /// 菜单导航
    /// </summary>
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/[controller]")]
    [ApiController]
    public class Menu_ClassfyController : ControllerBase
    {
        public readonly IMenu_ClassfyService menu_Classfy;

        public Menu_ClassfyController(IMenu_ClassfyService menu_Classfy)
        {
            this.menu_Classfy = menu_Classfy;
        }


        /// <summary>
        /// 获取导航分类
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("querylist")]
        public ReturnResult<List<Menu_ClassfyModel>> GetMenu_Classfy()
        {
            if (string.IsNullOrEmpty(Utils.Extensions.Plat))
                return new ReturnResult<List<Menu_ClassfyModel>>((int)ErrorCodeEnum.Parameter_Missing, null, "请求参数异常!");

            return menu_Classfy.GetClassfyList(Utils.Extensions.Plat);
        }

        /// <summary>
        /// 新增导航分类
        /// </summary>
        /// <returns></returns>
        [HttpPost, Route("add")]
        public ReturnResult<ReturnMenu_ClassfyModel> AddMenu_Classfy(AddMenu_ClassfyModel model)
        {
            return menu_Classfy.Insert(Utils.Extensions.Plat, model);
        }

        /// <summary>
        /// 修改导航分类
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost, Route("modify")]
        public ReturnResult ModifyMenu_Classfy(ModifyMenu_ClassfyModel model)
        {
            return menu_Classfy.Change(Utils.Extensions.Plat, model);
        }

        /// <summary>
        /// 删除导航分类
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("del")]
        public ReturnResult RemoveMenu_Classfy(int id)
        {
            return menu_Classfy.Delete(Utils.Extensions.Plat, id);
        }
    }
}