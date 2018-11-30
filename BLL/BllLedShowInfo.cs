using DAL;
using MODEL;
using System.Data;

namespace BLL
{
    public class BllLedShowInfo
    {
        /// <summary>
        /// 预显示记录表
        /// </summary>
        DalLedShowInfo dalLedShowInfo = new DalLedShowInfo();
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="lEDShowInfo"></param>
        /// <returns></returns>
        public bool InsertLedShowInfo(LEDShowInfo lEDShowInfo)
        {
            return dalLedShowInfo.InsertLedShowInfo(lEDShowInfo);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteLedShowInfo(int id)
        {
            return dalLedShowInfo.DeleteLedShowInfo(id);
        }
        /// <summary>
        /// 查询显示信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public DataTable GetLayLEDShowInfos(string tag,string key)
        {
            return dalLedShowInfo.GetLayLEDShowInfos(tag, key, "LEDShow");
        }
        /// <summary>
        /// 查询预显示
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public DataTable GetLEDShowInfos(string key)
        {
            return dalLedShowInfo.GeLEDShowInfos(key);
        }
        /// <summary>
        /// 修改状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool UpdateLEDShowInfo(int id,int stateCnt)
        {
            return dalLedShowInfo.UpdateLEDShowInfo(id, stateCnt);
        }
    }
}
