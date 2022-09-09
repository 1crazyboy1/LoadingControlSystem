using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    public class DeliveryOrder
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        public string vehicleno { get; set; }

        /// <summary>
        /// 供应商/客户id
        /// </summary>
        public string customerid { get; set; }

        /// <summary>
        /// 供应商/客户名称
        /// </summary>
        public string customer { get; set; }

        /// <summary>
        /// 物料
        /// </summary>
        public string materiel { get; set; }

        /// <summary>
        /// 物料ID
        /// </summary>
        public string materielid { get; set; }
        /// <summary>
        /// 水泥类型
        /// </summary>
        public string cementtype { get; set; }

        /// <summary>
        /// 业务类型 
        /// </summary>
        public string servicetype { get; set; }

        /// <summary>
        /// 通知单号
        /// </summary>
        public string notionformcode { get; set; }

        /// <summary>
        /// 批号
        /// </summary>
        public string batchnumber { get; set; }

        /// <summary>
        /// 是否原发
        /// </summary>
        public string primary { get; set; }

        /// <summary>
        /// 车辆ID
        /// </summary>
        public string vehicleid { get; set; }
        /// <summary>
        /// 矿口
        /// </summary>
        public string minemouth { get; set; }

        /// <summary>
        /// 预提量
        /// </summary>
        public string number { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// 签收状态
        /// </summary>
        public string signStatus { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string billNo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 供应商备注
        /// </summary>
        public string supRemark { get; set; }

        /// <summary>
        /// 是否有无需补包审批
        /// </summary>
        public string isDontFill { get; set; }

        /// <summary>
        /// 无需补包审批状态
        /// </summary>
        public string dontFillStatus { get; set; }

        /// <summary>
        /// 是否有空车出厂审批
        /// </summary>
        public string isEmptyOut { get; set; }

        /// <summary>
        /// 空车出厂审批状态
        /// </summary>
        public string emptyOutStatus { get; set; }		
    }
}
