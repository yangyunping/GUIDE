using MODEL;
using System.Data;
using System.Data.SqlClient;

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
            string sSql = $@"Insert into LedShowInfo(ScreenId,AddressNum,BeginTime,EndTime,Content,FontColor,FontName,FontSize,ShowStyle,FontBold,Position,Tag,Duration,DeleteUpProgram) 
values('{ledShowInfo.ScreenId}','{ledShowInfo.AddressNum}','{ledShowInfo.BeginTime.ToShortTimeString()}','{ledShowInfo.EndTime.ToShortTimeString()}',
'{ledShowInfo.Content}','{ledShowInfo.FontColor}','{ledShowInfo.FontName}','{ledShowInfo.FontSize}','{ledShowInfo.ShowStyle}','{ledShowInfo.FontBold}',
'{ledShowInfo.Position}','{ledShowInfo.Tag}','{ledShowInfo.Duration}','{ledShowInfo.DeleteUpProgram}')";
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
        /// 存储过程查询显示内容
        /// </summary>
        /// <param name="tag">显示状态</param>
        /// <param name="key">查询条件</param>
        /// <param name="spName">存储过程名</param>
        /// <returns></returns>
        public DataTable GetLayLEDShowInfos(string tag,string key,string spName)
        {
            return server.ExecuteLayQuery(spName, tag, key).Tables[0];
        }
        /// <summary>
        /// 查询显示
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public DataTable GeLEDShowInfos(string key)
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
            string sSql = $@"Update LEDShowInfo set Tag = {stateCnt},CreateDate = Getdate()  where ID = '{id}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
    }
}
