using DAL;
using MODEL;
using System.Data;

namespace BLL
{
    public class BllScreeenSetting
    {
        DalSreenSetting dalSreenSetting = new DalSreenSetting();
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="ledShowInfo"></param>
        /// <returns></returns>
        public bool InsertScreenSetting(ScreenSetting screenSetting)
        {
            return dalSreenSetting.InsertScreenSetting(screenSetting);
        }


        public bool UpdateScreenSetting(ScreenSetting screenSetting)
        {
            return dalSreenSetting.UpdateScreenSetting(screenSetting);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteScreenSetting(int id)
        {
            return dalSreenSetting.DeleteScreenSetting(id);
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public DataTable GetScreenSetting(string key)
        {
            return dalSreenSetting.GetScreenSetting(key);
        }
    }
}
