using MODEL;
using System.Data;

namespace DAL
{
    /// <summary>
    /// 屏幕参数设置
    /// </summary>
    public class DalSreenSetting
    {
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteScreenSetting(int id)
        {
            string sSql = $@"Delete from ScreenSetting where ID = '{id}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        Server server = new Server();
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="ledShowInfo"></param>
        /// <returns></returns>
        public bool InsertScreenSetting(ScreeenSetting screeenSetting)
        {
            string sSql = $@"Insert into ScreenSetting(ScreenID,AddressNum,CarName,ScreenWidth,ScreenHeight,IpAddress,ColorStyle) 
values('{screeenSetting.ScreenID}','{screeenSetting.AddressNum}','{screeenSetting.CarName}','{screeenSetting.ScreenWidth}','{screeenSetting.ScreenHeight}',
'{screeenSetting.IpAddress}','{screeenSetting.ColorStyle}')";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public DataTable GetScreenSetting(string key)
        {
            string sSql = $@"select * from  ScreenSetting where 1=1 {key}";
            return server.ExecuteQuery(sSql).Tables[0];
        }
    }
}
