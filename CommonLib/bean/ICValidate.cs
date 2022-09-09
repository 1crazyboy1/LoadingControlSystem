using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib
{
    public class ICValidate
    {
        /// <summary>
        /// 卡面编号
        /// </summary>
        public string cardCode { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        public string cardType { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public string isValid { get; set; }
    }

}
