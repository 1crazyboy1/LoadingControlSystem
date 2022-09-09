using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{ 
    public class PoundTicketDetail
    {
        /// <summary>
        /// 磅单号
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// 通知单号
        /// </summary>
        public string noticecode { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string billcode { get; set; }
        /// <summary>
        /// 收货单位
        /// </summary>
        public string receivedepartmentname { get; set; }
        /// <summary>
        /// 发货单位
        /// </summary>
        public string senddepartmentname { get; set; }
        /// <summary>
        /// 供应商名称
        /// </summary>
        public string suppliername { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string customername { get; set; }
        /// <summary>
        /// 物料名称
        /// </summary>
        public string materialname { get; set; }
        /// <summary>
        /// 车号
        /// </summary>
        public string vehicleno { get; set; }
        /// <summary>
        /// 毛重
        /// </summary>
        public string grossweight { get; set; }
        /// <summary>
        /// 净重
        /// </summary>
        public string tareweight { get; set; }
        /// <summary>
        /// 扣重
        /// </summary>
        public string deductionweight { get; set; }
        /// <summary>
        /// 扣杂
        /// </summary>
        public string deductionother { get; set; }
        /// <summary>
        /// 净重
        /// </summary>
        public string netweight { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }
        /// <summary>
        /// 收料人
        /// </summary>
        public string receiverpersonname { get; set; }
        /// <summary>
        /// 矿口
        /// </summary>
        public string minemouthname { get; set; }
        /// <summary>
        /// 供应商备注
        /// </summary>
        public string supplierremark { get; set; }
        public long weighttime { get; set; }
        /// <summary>
        /// 毛重时间
        /// </summary>
        public string weighttimeStr { get; set; }
        public long lighttime { get; set; }
        /// <summary>
        /// 皮重时间
        /// </summary>
        public string lighttimeStr { get; set; }
        /// <summary>
        /// 水泥编号
        /// </summary>
        public string serialnumber { get; set; }
        /// <summary>
        /// 销售组织
        /// </summary>
        public string orgname { get; set; }
    }
}
