using MODEL;
using System.Data;

namespace DAL
{
    /// <summary>
    /// 屏幕参数设置
    /// </summary>
    public class DalSreenSetting
    {
        Server server = new Server();
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
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="ledShowInfo"></param>
        /// <returns></returns>
        public bool InsertScreenSetting(ScreenSetting screeenSetting)
        {
            string sSql = $@"Insert into ScreenSetting(ScreenID,AddressNum,CarName,ScreenWidth,ScreenHeight,IpAddress,ColorStyle,FontSize) 
values('{screeenSetting.ScreenID}','{screeenSetting.AddressNum}','{screeenSetting.CarName}','{screeenSetting.ScreenWidth}','{screeenSetting.ScreenHeight}',
'{screeenSetting.IpAddress}','{screeenSetting.ColorStyle}','{screeenSetting.FontSize}')";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="ledShowInfo"></param>
        /// <returns></returns>
        public bool UpdateScreenSetting(ScreenSetting screenSetting)
        {
            string sSql = $@"Update ScreenSetting  set ScreenID ='{screenSetting.ScreenID}' ,AddressNum ='{screenSetting.AddressNum}' ,
CarName = '{screenSetting.CarName}',ScreenWidth= '{screenSetting.ScreenWidth}' ,ScreenHeight = '{screenSetting.ScreenHeight}'
,IpAddress = '{screenSetting.IpAddress}',ColorStyle= '{screenSetting.ColorStyle}',FontSize = '{screenSetting.FontSize}' where ID = '{screenSetting.ID}'";
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
