using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    /// <summary>
    /// 车辆类别和IC卡信息
    /// </summary>
    public class ReICInfo
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        public string vehicle { get; set; }
        /// <summary>
        /// 类别(0：临时，1：固定)
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 卡序号
        /// </summary>
        public string cardno { get; set; }
        /// <summary>
        /// 卡面编号
        /// </summary>
        public string cardcode { get; set; }
    }
}
