using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    /// <summary>
    /// 排队小票
    /// </summary>
    public class PrintTicket
    {
        /// <summary>
        /// 小票号
        /// </summary>
        public string smallticket { get; set; }

        /// <summary>
        /// 排队数
        /// </summary>
        public string queuenumber { get; set; }
    }
}
