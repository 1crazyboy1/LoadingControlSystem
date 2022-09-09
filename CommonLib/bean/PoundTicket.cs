using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    public class PoundTicket
    {
        private string serviceType = "";
        private string customer="";
        private string masteril="";
        private string lorryNum="";
        private string roughWeight="";
        private string tareWeight="";
        private string netWeight="";
        private string roughTime="";
        private string tareTime="";

        private string noticeCode="";
        private string orderNum="";
        private string poundCode="";
        private string dedweight="";
        private string dedother="";
        private string signName="";
        private string mine="";
        private string memo="";

        private string batchNum = "";//批号
       
        public string BatchNum
        {
            get
            {
                if (batchNum == null)
                {
                    return "";
                }
                else
                {
                    return batchNum;
                }
            }
            set { batchNum = value; }
        }

        public string mServiceType
        {
            get { return serviceType; }
            set { serviceType = value; }
        }

        /// <summary>
        /// 客户供应商
        /// </summary>
        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        /// <summary>
        /// 物料
        /// </summary>
        public string Masteril
        {
            get { return masteril; }
            set { masteril = value; }
        }
        /// <summary>
        /// 车号
        /// </summary>
        public string LorryNum
        {
            get { return lorryNum; }
            set { lorryNum = value; }
        }
        /// <summary>
        /// 毛重
        /// </summary>
        public string RoughWeight
        {
            get { return roughWeight; }
            set { roughWeight = value; }
        }
        /// <summary>
        /// 皮重
        /// </summary>
        public string TareWeight
        {
            get { return tareWeight; }
            set { tareWeight = value; }
        }
        /// <summary>
        /// 净重
        /// </summary>
        public string NetWeight
        {
            get { return netWeight; }
            set { netWeight = value; }
        }
        /// <summary>
        /// 毛重时间
        /// </summary>
        public string RoughTime
        {
            get { return roughTime; }
            set { roughTime = value; }
        }

        /// <summary>
        /// 净重时间
        /// </summary>
        public string TareTime
        {
            get { return tareTime; }
            set { tareTime = value; }
        }

        /// <summary>
        /// 通知单号
        /// </summary>
        public string NoticeCode
        {
            get { return noticeCode; }
            set { noticeCode = value; }
        }
        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNum
        {
            get { return orderNum; }
            set { orderNum = value; }
        }
        /// <summary>
        /// 磅单号
        /// </summary>
        public string PoundCode
        {
            get { return poundCode; }
            set { poundCode = value; }
        }
        /// <summary>
        /// 扣重
        /// </summary>
        public string Dedweight
        {
            get { return dedweight; }
            set { dedweight = value; }
        }
        /// <summary>
        /// 扣杂
        /// </summary>
        public string Dedother
        {
            get { return dedother; }
            set { dedother = value; }
        }
        /// <summary>
        /// 收料人
        /// </summary>
        public string SignName
        {
            get { return signName; }
            set { signName = value; }
        }
        /// <summary>
        /// 矿口
        /// </summary>
        public string Mine
        {
            get { return mine; }
            set { mine = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get { return memo; }
            set { memo = value; }
        }


    }
}
