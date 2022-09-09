using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    public class ApiJson<T>
    {
        /// <summary>
        /// 调用接口公共类
        /// </summary>
        public CommonParameters head { get; set; }
        /// <summary>
        /// 调用接口参数类
        /// </summary>
        public T body { get; set; }
        /// <summary>
        /// 防篡改字符
        /// </summary>
        public string sign { get; set; }
    }
}
