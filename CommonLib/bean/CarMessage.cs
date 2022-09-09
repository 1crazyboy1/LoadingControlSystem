using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    public class CarMessage
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        public string VehicleNo { get; set; }
        /// <summary>
        /// 车辆类别  0 临时车  1 固定车
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 卡序号
        /// </summary>
        public string IcardNo { get; set; }
        /// <summary>
        /// 卡面编号
        /// </summary>
        public string IcardCode { get; set; }
        /// <summary>
        /// 绑定RFID
        /// </summary>
        public string Rfid { get; set; }

    }
}
