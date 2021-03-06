﻿using Feng.Basic;
using Feng.CMS.Model;
using System;
using System.Collections.Generic;

namespace Feng.CMS.IService
{
    public partial interface INewsService
    {

        ReturnResult<ReturnNewsCategoryModel> AddNewsCategory(string appid, AddNewsCategoryModel model);

        ReturnResult RemoveNewsCategory(string appid, int id);

        ReturnResult ModifyNewsCategory(string appid, NewsCategoryModel model);

        ReturnResult<List<NewsCateModel>> QueryNewsCategory(string appid, int id = 0);

        ReturnResult<ReturnNewsModel> AddNews(string appid, AddNewsModel model);

        ReturnResult RemoveNews(string appid, int id);

        ReturnResult ModifyNews(string appid, NewsModel model);

        ReturnResult<NewsModel> QueryNewsById(string appid,int id);

        ReturnResult<PageList<QueryNewsListModel>> QueryNewsList(string appid, int pageSize, int pageIndex, string title, int ispub, int cateid);

        ReturnResult PublishNewsCategory(string appid, int id);

    }
}
