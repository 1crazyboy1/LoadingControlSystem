using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    public class WeighVerification:RFIDTag
    {
        /// <summary>
        /// 类型：一次或二次磅房
        /// </summary>
        public string type { get; set; }
    }
}
