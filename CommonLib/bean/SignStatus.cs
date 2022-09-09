using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    public  class SignStatus
    {
        /// <summary>
        /// 采购到货  整车退货
        /// </summary>
        public const string TOTAL_RETRUN = "0";
       /// <summary>
       /// 采购到货  签收确认
       /// </summary>
        public const string SIGN_CONFIRM = "1";

        /// <summary>
        /// 采购退货  退货确认
        /// </summary>
        public const string RETURN_CONFIRM = "0";
    }
}
