using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace CommonLib
{
    /// <summary>
    /// json转换类
    /// </summary>
    public class JsonApi
    {
        /// <summary>
        /// 类转换json
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ice"></param>
        /// <returns></returns>
        public static string ClassToString<T>(T ice)
        {
            return JsonConvert.SerializeObject(ice);
        }
        /// <summary>
        /// json转换类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T StringToClass<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
