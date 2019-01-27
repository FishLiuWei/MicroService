﻿using Feng.Basic;
using Feng.Product.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Feng.Product.IService
{
    public interface ICategoryService
    {
        ReturnResult<dynamic> AddCategory(string platKey,AddCategoryModel model);

        ReturnResult ModifyCategory(string platKey, CategoryModel model);

        ReturnResult RemoveCategory(string platKey, string cid);

        ReturnResult<List<ReturnListCategoryModel>> QueryCategory(string platKey);
    }
}
