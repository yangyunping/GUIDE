using DAL;
using MODEL;
using System.Data;

namespace BLL
{
    public class BllLedShowInfo
    {
        DalLedShowInfo dalLedShowInfo = new DalLedShowInfo();
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="lEDShowInfo"></param>
        /// <returns></returns>
        public bool InsertLedShowInfo(LEDShowInfo  lEDShowInfo)
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
        /// 查询
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public DataTable GetLEDShowInfos(string key)
        {
            string sKey = string.Empty;
            if (!string.IsNullOrEmpty(key))
            {
                sKey = $@"  and  ShowContent like '%{key}%'";
            }
            return dalLedShowInfo.GetLEDShowInfos(sKey);
        }
    }
}
