﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Feng.Order.Model
{
    /// <summary>
    /// 订单表
    /// </summary>
    public class OrdersWebModel : AddOrdersWebModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public string order_status { get; set; }
        /// <summary>
        /// 支付状态
        /// </summary>
        public string pay_status { get; set; }
        /// <summary>
        /// 订单审核人
        /// </summary>
        public string approve_by { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary>
        public string pay_method { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? create_time { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? update_time { get; set; }
        /// <summary>
        /// 支付时间
        /// </summary>
        public DateTime? pay_time { get; set; }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime? approve_time { get; set; }
        /// <summary>
        /// 交易完成时间
        /// </summary>
        public DateTime? end_time { get; set; }
        /// <summary>
        /// 交易关闭时间
        /// </summary>
        public DateTime? close_time { get; set; }

    }

    public class OrderPrimaryModel
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public int user_id { get; set; }
        /// <summary>
        /// 下单用户
        /// </summary>
        public string user_name { get; set; }
        /// <summary>
        /// 客户姓名
        /// </summary>
        public string realUserName { get; set; }
        /// <summary>
        /// 成交价
        /// </summary>
        public decimal final_price { get; set; }
        /// <summary>
        /// 原价
        /// </summary>
        public decimal original_price { get; set; }
        /// <summary>
        /// 购买方式
        /// </summary>
        public int buy_method { get; set; }
        /// <summary>
        /// 购买时长
        /// </summary>
        public int buy_period { get; set; }
        /// <summary>
        /// 用户备注
        /// </summary>
        public string remark { get; set; }
    }


    /// <summary>
    /// 新增订单表
    /// </summary>
    public class AddOrdersWebModel
    {
        public AddOrdersWebModel()
        {
            orderPrimary = new OrderPrimaryModel();
            addO_UserInfoWeb = new AddO_UserInfoWebModel();
        }

        public OrderPrimaryModel orderPrimary { get; set; }

        public AddO_UserInfoWebModel addO_UserInfoWeb { get; set; }
        /// <summary>
        /// 订单详情
        /// </summary>
        public List<AddOrdersDetailWebModel> addOrdersDetailsList { get; set; }

    }
    public class ReturnOrdersWebModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string id { get; set; }
    }
 
    /// <summary>
    /// 取消订单
    /// </summary>
    public class CancelOrdersWebModel
    {
        /// <summary>
        /// 非自增主键
        /// </summary>
        public string id { get; set; }
    }

    public class AddO_UserInfoWebModel
    {
        /// <summary>
        /// 收货人
        /// </summary>
        public string receive_name { get; set; }
        /// <summary>
        /// 用户电话
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 收货省名称
        /// </summary>
        public string province { get; set; }
        /// <summary>
        /// 收货市名称
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 收货区名称
        /// </summary>
        public string area { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// 邮政编码
        /// </summary>
        public int zip { get; set; }
        /// <summary>
        /// 区域编号
        /// </summary>
        public int region_id { get; set; }
    }
}
