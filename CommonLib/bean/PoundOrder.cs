using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    /// <summary>
    /// 上传磅单数据
    /// </summary>
    public class PoundOrder : RFIDTag
    {
        /// <summary>
        /// 类型：皮重或毛重  1：皮重，2：毛重
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        public string servicetype { get; set; }
        /// <summary>
        /// 通知单号
        /// </summary>
        public string notionformcode { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// 扣重
        /// </summary>
        public string deductionweight { get; set; }
        /// <summary>
        /// 原发
        /// </summary>
        public string originalnetweight { get; set; }
        /// <summary>
        /// 扣杂
        /// </summary>
        public string deductionother { get; set; }
        /// <summary>
        /// 净重
        /// </summary>
        public string netweight { get; set; }
        /// <summary>
        /// 实际净重
        /// </summary>
        public string realweight { get; set; }
    }
}
