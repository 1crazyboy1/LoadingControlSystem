using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    public class QueueTicket
    {
        /// <summary>
        /// 物料
        /// </summary>
        public string materiel { set; get; }
        /// <summary>
        /// 包装类型
        /// </summary>
        public string packagetype { set; get; }

        public string rfid { set; get; }
        /// <summary>
        /// 车牌号
        /// </summary>
        public string vehicleno { set; get; }
        /// <summary>
        /// 通知单号
        /// </summary>
        public string noticecode { set; get; }

    }
}
