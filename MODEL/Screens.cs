using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Screens
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { set; get; }
        /// <summary>
        /// 屏幕编号
        /// </summary>
        public string ScreenID { set; get; }
        /// <summary>
        /// 区域ID
        /// </summary>
        public int AreaID { set; get; }
        /// <summary>
        /// 地址码
        /// </summary>
        public int AddressNum { set; get; }
        /// <summary>
        /// 排序号
        /// </summary>
        public int OrderNum { set; get; }
    }
}
