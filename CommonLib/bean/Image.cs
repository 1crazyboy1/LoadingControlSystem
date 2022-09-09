using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    public class Image
    {
        /// <summary>
        /// 图片字节流
        /// </summary>
        public byte[] FileByte { get; set; }

        /// <summary>
        /// 通知单号
        /// </summary>
        public string billcode { get; set; }

        /// <summary>
        /// 通知单类型
        /// </summary>
        public string billtype { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string type { get; set; }
    }
}
