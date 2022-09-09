using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    /// <summary>
    /// 电子标签元数据
    /// </summary>
    public class RFIDTag
    {
        public const string Key = "9527";

        /// <summary>
        /// RFID
        /// </summary>
        public string rfid { set; get; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public string vehicleno{ set; get;}
    }
}
