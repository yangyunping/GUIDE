using MODEL;
using System.Data;

namespace DAL
{
    /// <summary>
    /// 定时显示表
    /// </summary>
    public class DalLedShowInfo
    {
        Server server = new Server();
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="ledShowInfo"></param>
        /// <returns></returns>
        public bool InsertLedShowInfo(LEDShowInfo ledShowInfo)
        {
            string sSql = $@"Insert into LedShowInfo(ScreenId,AddressNum,BeginTime,EndTime,Content,FontColor,FontName,FontSize,ShowStyle) 
values('{ledShowInfo.ScreenId}','{ledShowInfo.AddressNum}','{ledShowInfo.BeginTime.ToShortTimeString()}','{ledShowInfo.EndTime.ToShortTimeString()}',
'{ledShowInfo.Content}','{ledShowInfo.FontColor}','{ledShowInfo.FontName}','{ledShowInfo.FontSize}','{ledShowInfo.ShowStyle}')";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteLedShowInfo(int id)
        {
            string sSql = $@"Delete from LEDShowInfo where ID = '{id}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public DataTable GetLEDShowInfos(string key)
        {
            string sSql = $@"select * from  View_LEDOnTimeShow where 1=1 {key}";
            return server.ExecuteQuery(sSql).Tables[0];
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool UpdateLEDShowInfo(int id, int stateCnt)
        {
            string sSql = $@"Update LEDShowInfo set Tag = {stateCnt}  where ID = '{id}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
    }
}
