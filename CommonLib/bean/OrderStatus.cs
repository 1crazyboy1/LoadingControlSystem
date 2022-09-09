using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    public class OrderStatus
    {
        /// <summary>
        /// 未入厂
        /// </summary>
        public const string UNENTRY = "0";
        /// <summary>
        /// 一次过磅
        /// </summary>
        public const string FIRSTWEIGHTING = "1";
      
        /// <summary>
        /// 二次过磅
        /// </summary>
        public const string SECONDWEIGHTING = "2";
     
        /// <summary>
        /// 作废
        /// </summary>
        public const string CANCEL = "3";
     
        /// <summary>
        /// 出厂
        /// </summary>
        public const string EXIT = "5";

        /// <summary>
        /// 入厂
        /// </summary>
        public const string ENTRY = "6";

        /// <summary>
        /// 确认
        /// </summary>
        public const string PDA_CONFIRM = "7";
            
    }
}
