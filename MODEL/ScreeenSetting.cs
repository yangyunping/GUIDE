using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ScreenSetting
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int ID { set; get; }
        /// <summary>
        /// 屏幕编号
        /// </summary>
        public string ScreenID { set; get; }
        /// <summary>
        /// 控制卡地址码
        /// </summary>
        public int AddressNum { set; get; }
        /// <summary>
        /// 控制卡类型
        /// </summary>
        public string CarName { set; get; }
        /// <summary>
        /// 屏宽
        /// </summary>
        public int ScreenWidth { set; get; }
        /// <summary>
        /// 屏高
        /// </summary>
        public int ScreenHeight { set; get; }
        /// <summary>
        /// IP地址
        /// </summary>
        public string IpAddress { set; get; }
        /// <summary>
        /// 屏幕颜色类型
        /// </summary>
        public string ColorStyle { set; get; }
        /// <summary>
        /// 屏幕颜色类型
        /// </summary>
        public int FontSize { set; get; }
    }
}
