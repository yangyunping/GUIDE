using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MODEL
{
    public static class CurrentInfo
    {
        /// <summary>
        /// 全局登录人员信息
        /// </summary>
        public static Employee currentEmp = new Employee();
        /// <summary>
        /// 全局登录人员权限
        /// </summary>
        public static Dictionary<int,string> currentPowers = new Dictionary<int, string>();
    }
}
