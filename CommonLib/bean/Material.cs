using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    public class Material:RFIDTag
    {
        /// <summary>
        /// 物料
        /// </summary>
        public string materiel { get; set; }

        /// <summary>
        /// 包装类型
        /// </summary>
        public string Packagetype { get; set; }
    }
}
