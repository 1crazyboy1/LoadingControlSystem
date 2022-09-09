using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    public class LorryInfo:RFIDTag
    {


        private string icType = "1"; //默认固定卡
   

        /// <summary>
        /// IC卡面编号
        /// </summary>
        public string ICCode { get; set; }

       
        /// <summary>
        /// 卡类型 0：临时 1：固定卡
        /// </summary>
        public string ICType
        {
            get { return icType; }
            set { icType = value; }
        }

        /// <summary>
        /// 卡序号
        /// </summary>
        public string ICNum { get; set; }

        
    }
}
