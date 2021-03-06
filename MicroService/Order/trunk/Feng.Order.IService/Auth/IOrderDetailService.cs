﻿using Feng.Basic;
using Feng.Order.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Feng.Order.IService
{
    public partial interface IOrderDetailService
    {
        ReturnResult<List<OrdersDetailModel>> QueryOrdersDetail(string platkey);
        ReturnResult<OrdersDetailModel> QueryOrderDetailById(string platkey, string id);
        ReturnResult<PageList<OrdersDetailModel>> QueryOrdersDetailList(string platkey, int pageSize, int pageIndex);
    }
}
