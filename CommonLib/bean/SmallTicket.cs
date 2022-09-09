using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    public class SmallTicket
    {
        /// <summary>
        /// 小票号
        /// </summary>
        public string smallticket { set; get; }
        /// <summary>
        /// 排队数
        /// </summary>
        public string queuenumber { set; get; }
        /// <summary>
        /// 通知单号
        /// </summary>
        public string noticecode { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string customername { get; set; }
        /// <summary>
        /// 物料id
        /// </summary>
        public string materielid { get; set; }
        /// <summary>
        /// 物料名称
        /// </summary>
        public string materielname { get; set; }
        /// <summary>
        /// 车牌号
        /// </summary>
        public string vehicleno { get; set; }
        /// <summary>
        /// 预提量
        /// </summary>
        public double pretendingtake { get; set; }
        /// <summary>
        /// 当前等待车辆
        /// </summary>
        public int number { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string icardno { get; set; }
        /// <summary>
        /// 卡面编号
        /// </summary>
        public string cardcode { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        public long currentTime { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        public string currentTimeStr { get; set; }

        /// <summary>
        /// 销售组织
        /// </summary>
        public string orgname { get; set; }
    }
}
