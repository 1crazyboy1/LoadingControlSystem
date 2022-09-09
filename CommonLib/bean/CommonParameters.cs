using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    public class CommonParameters
    {
        /// <summary>
        /// 用户ID，登录验证是为空
        /// </summary>
        public string userId { get; set; }
        /// <summary>
        /// 具体系统，例如东门岗、西门岗
        /// </summary>
        public string callSource { get; set; }
        /// <summary>
        /// 子系统分类，例如1门岗，2卡务
        /// </summary>
        public string callType { get; set; }
        /// <summary>
        /// 调用时间，格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string callTime { get; set; }
        /// <summary>
        /// 标识，默认@#!tr2017!#$
        /// </summary>
        public string key { get; set; }
    }
}
