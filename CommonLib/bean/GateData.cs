using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.bean
{
    public class GateData
    {
        // 摘要:
        //     Ic卡号
        public string icardno { get; set; }
        //
        // 摘要:
        //     通知单号
        public string notionformcode { get; set; }
        //
        // 摘要:
        //     业务类型
        public string servicetype { get; set; }
        //
        // 摘要:
        //     记录时间
        public string time { get; set; }
        
        ///
        /// <summary>
        ///  门禁类型  入厂：“1” 出厂“2”
        /// </summary>   
        public string type { get; set; }
    }
}
