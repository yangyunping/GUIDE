using DAL;
using System.Data;

namespace BLL
{
    public class BllLedShowInfo
    {
        DalLedShowInfo dalLedShowInfo = new DalLedShowInfo();
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
