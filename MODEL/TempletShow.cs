using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class TempletShow
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { set; get; }
        /// <summary>
        /// 字体名称
        /// </summary>
        public string FontName { set; get; }
        /// <summary>
        /// 字体大小
        /// </summary>
        public int FontSize { set; get; }
        /// <summary>
        /// 字体颜色
        /// </summary>
        public string FontColor { set; get; }
        /// <summary>
        /// 显示方式
        /// </summary>
        public int ShowStyle { set; get; }
        /// <summary>
        /// 显示内容
        /// </summary>
        public string ShowContent { set; get; }
    }
}
