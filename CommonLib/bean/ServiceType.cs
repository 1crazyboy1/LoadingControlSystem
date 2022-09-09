using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    public class ServiceType
    {
        /// <summary>
        /// 采购到货
        /// </summary>
        public const string PURCHASE_IN = "0";
        /// <summary>
        /// 采购退货
        /// </summary>
        public const string PURCHASE_OUT = "1";
        /// <summary>
        /// 销售提货
        /// </summary>
        public const string SALE_PICKUP = "2";
        /// <summary>
        /// 销售退货
        /// </summary>
        public const string SALE_RETURN = "3";
        /// <summary>
        /// 厂内盘运
        /// </summary>
        public const string IN_TRANSPORT = "4";

        /// <summary>
        /// 工程车辆
        /// </summary>
        public const string ENGINEERING_VEHICLE = "9";

        /// <summary>
        /// 其他入库
        /// </summary>
        public const string OTHER_IN = "5";

        /// <summary>
        /// 其他出库
        /// </summary>
        public const string OTHER_OUT = "7";
    }
}
