using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    public class PoundDetail:RFIDTag
    {
        /// <summary>
        /// 毛重
        /// </summary>
        public string grossweight { get; set; }

        /// <summary>
        /// 皮重
        /// </summary>
        public string tareweight { get; set; }

        /// <summary>
        /// 净重
        /// </summary>
        public string netweight { get; set; }

        /// <summary>
        /// 轻车时间
        /// </summary>
        public string lighttime { get; set; }

        /// <summary>
        /// 重车时间
        /// </summary>
        public string weighttime { get; set; }

        public string id { get; set; }

        public string code { get; set; }
    }
}
