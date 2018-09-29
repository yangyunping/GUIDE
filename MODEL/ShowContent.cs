using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ShowContent
    {
        /// <summary>
        /// 配置编号
        /// </summary>
        public string ConfigName { set; get; }
        /// <summary>
        /// 区域名
        /// </summary>
        public string AreaName { set; get; }
        /// <summary>
        /// 编组
        /// </summary>
        public int GroupNum { set; get; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public string BeginTime { set; get; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndTime { set; get; }
        /// <summary>
        /// 显示内容
        /// </summary>
        public string Content { set; get; }
        /// <summary>
        /// 显示顺序
        /// </summary>
        public int ByOrder { set; get; }
        /// <summary>
        /// 显示屏幕
        /// </summary>
        public int ScreenID { set; get; }
    }
}
