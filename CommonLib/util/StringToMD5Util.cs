using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace CommonLib.util
{
    class StringToMD5Util
    {
        /// <summary>
        /// 字符串MD5加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string StringToMD5(string str)
        {
            byte[] result = Encoding.UTF8.GetBytes(str.Trim());    //获取要加密的字段，并转化为Byte[]数组
            MD5 md5 = new MD5CryptoServiceProvider();//建立加密服务
            byte[] output = md5.ComputeHash(result);//加密Byte[]数组
            return BitConverter.ToString(output).Replace("-", "").ToLower();  //输出加密小写字符
        }

    }
}
