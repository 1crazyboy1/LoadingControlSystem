using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    /// <summary>
    /// 袋装排队数据
    /// </summary>
    public class QueryWaiting
    {
        /// <summary>
        /// 小票号
        /// </summary>
        public string queuenumber { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public string vehicleno { get; set; }

        /// <summary>
        /// 物料ID
        /// </summary>
        public string materialpk { get; set; }

        /// <summary>
        /// 物料名称
        /// </summary>
        public string materialname { get; set; }

        /// <summary>
        /// 预提量
        /// </summary>
        public string takeamount { get; set; }

        /// <summary>
        /// 批号
        /// </summary>
        public string spraycode { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        public string customername { get; set; }

        /// <summary>
        /// 入厂时间
        /// </summary>
        public string entertime { get; set; }

    }
}
