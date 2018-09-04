using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MODEL
{
    public class GetOrSetConfig
    {
        /// <summary>
        /// 写配置文件
        /// </summary>
        /// <param name="section">存放名称</param>
        /// <param name="key">存放KEY</param>
        /// <param name="value">存放的路径</param>
        /// <param name="filePath">配置文件路径</param>
        /// <returns></returns>
        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

        /// <summary>
        /// 读配置文件
        /// </summary>
        /// <param name="section">读取的名称</param>
        /// <param name="key">读取KEY</param>
        /// <param name="def"></param>
        /// <param name="value">读取路径</param>
        /// <param name="size"></param>
        /// <param name="filePath">配置文件路径</param>
        /// <returns></returns>
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder value, int size, string filePath);
    }
}
