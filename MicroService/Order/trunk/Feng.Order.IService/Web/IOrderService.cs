﻿using Feng.Basic;
using Feng.Order.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Feng.Order.IService
{
    public partial interface IOrderService
    {
        ReturnResult<ReturnOrdersWebModel> AddOrder(string platkey, AddOrdersWebModel model);
        ReturnResult DeleteOrder(string platkey, string id);
        ReturnResult CancelOrder(string platkey, CancelOrdersModel model);
        ReturnResult ModifySku(string platkey, ModifySkuModel modifySku);
    }
}
