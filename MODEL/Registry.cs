using System;

namespace Model
{
    /// <summary>
    /// 注册表获取信息
    /// </summary>
    public class Registry
    {
        private readonly string _keyName;
        public Registry(string pathRoot)
        {
            _keyName = pathRoot;
        }
        /// <summary>
        /// 获取登录名记录信息
        /// </summary>
        /// <param name="valueName"></param>
        /// <returns></returns>
        public string[] GetRegistry(string valueName)
        {
            try
            {
                return Microsoft.Win32.Registry.GetValue(_keyName, valueName, null) as string[];
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// 添加登录名记录
        /// </summary>
        /// <param name="valueName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetRegistry(string valueName, object value)
        {
            try
            {
                Microsoft.Win32.Registry.SetValue(_keyName, valueName, value);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
