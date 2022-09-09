using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib
{
    public class SignDetail
    {
        /// <summary>
        /// 磅单号
        /// </summary>
        public string poundNoteCode { get; set; }
        /// <summary>
        /// 通知单号
        /// </summary>
        public string noticeCode { get; set; }
        /// <summary>
        /// 物料
        /// </summary>
        public string material { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>
        public string supplier { get; set; }
        /// <summary>
        /// 毛重
        /// </summary>
        public double grossweight { get; set; }
        /// <summary>
        /// 皮重
        /// </summary>
        public double tareweight { get; set; }
        /// <summary>
        /// 净重
        /// </summary>
        public double netweight { get; set; }
        /// <summary>
        /// 原发净重
        /// </summary>
        public double originalnetweight { get; set; }
        /// <summary>
        /// 扣重
        /// </summary>
        public double deductionweight { get; set; }
        /// <summary>
        /// 扣杂
        /// </summary>
        public double deductionother { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        public string signPersonName { get; set; }
        /// <summary>
        /// 手持机ID
        /// </summary>
        public string signID { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public string signTime { get; set; }
        /// <summary>
        /// 仓库
        /// </summary>
        public string warehouse { get; set; }
        /// <summary>
        /// 堆场
        /// </summary>
        public string yard { get; set; }

    }
}
