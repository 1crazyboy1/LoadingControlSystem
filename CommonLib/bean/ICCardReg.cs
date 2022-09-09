using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    public class ICCardReg
    {
        string cardNo;
        string cardCode;
        string cardType;

        /// <summary>
        /// 卡序号
        /// </summary>
        public string CardNo
        {
            get { return cardNo; }
            set { cardNo = value; }
        }

        /// <summary>
        /// 卡面编号
        /// </summary>
        public string CardCode
        {
            get { return cardCode; }
            set { cardCode = value; }
        }

        /// <summary>
        /// 卡类型
        /// </summary>
        public string CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }
    }
}
