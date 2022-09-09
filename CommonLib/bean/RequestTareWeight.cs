using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    public class RequestTareWeight:RFIDTag
    {
        /// <summary>
        /// 数量
        /// </summary>
        public string limit { get; set; }
    }
}
