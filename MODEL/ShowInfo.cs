using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MODEL
{
    public class ShowInfo
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int ID { set; get; }
        /// <summary>
        /// 配置编号
        /// </summary>
        public string ConfigName { set; get; }
        /// <summary>
        /// 状态
        /// </summary>
        public int State{ set; get; }
        /// <summary>
        /// 区域名
        /// </summary>
        public string AreaName { set; get; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime BeginTime { set; get; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { set; get; }
        /// <summary>
        /// 顺序
        /// </summary>
        public bool ByOrder { set; get; }
        /// <summary>
        /// 屏幕编号
        /// </summary>
        public int ScreenId { set; get; }
    }
}
