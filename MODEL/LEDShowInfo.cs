using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class LEDShowInfo
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int ID { set; get; }
        /// <summary>
        /// LED编号
        /// </summary>
        public string ScreenId { set; get; }
        /// <summary>
        /// 控制卡地址码
        /// </summary>
        public int AddressNum { set; get; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime BeginTime { set; get; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { set; get; }
        /// <summary>
        /// 显示内容
        /// </summary>
        public string Content { set; get; }
        /// <summary>
        /// 字体颜色
        /// </summary>
        public string FontColor { set; get; }
        /// <summary>
        /// 字体名称
        /// </summary>
        public string FontName { set; get; }
        /// <summary>
        /// 字体大小
        /// </summary>
        public int FontSize { set; get; }
        /// <summary>
        /// 播放方式
        /// </summary>
        public int ShowStyle { set; get; }
    }
}
