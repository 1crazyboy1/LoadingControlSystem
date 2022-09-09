using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    /// <summary>
    /// 调用接口返回结果公共类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Result<T>
    {
        /// <summary>
        /// 接口处理状态：000000为处理成功
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// 错误信息: 处理状态为非000000时  使用
        /// </summary>
        public string error { get; set; }
        /// <summary>
        /// 处理结果：对象
        /// </summary>
        public T returnData { get; set; }
        /// <summary>
        /// 服务器处理时间
        /// </summary>
        public string serviceTime { get; set; }
    }
}
