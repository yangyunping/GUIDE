using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;
using MODEL;

namespace BLL
{
    public class BllConfig
    {
        DalConfig dalConfig = new DalConfig();
        /// <summary>
        /// 查询配置表
        /// </summary>
        /// <param name="sKey">查询关键字或配置编号</param>
        /// <param name="typeDex">大类别编号</param>
        /// <param name="type">查询 1-大类别  0-类别和配置信息区分 2-所有信息</param>
        /// <returns></returns>
        public DataTable GetConfigInfo(string sKey,string typeDex, int type)
        {
            string sSql = string.Empty;
            switch (type)
            {
                case 0:
                    sSql += @"  and  Tag = 0 ";
                    if (!string.IsNullOrEmpty(sKey))
                    {
                        sSql += $@"  and  ConfigValue like '%{sKey}%'";
                    }
                    if (Int32.TryParse(sKey,out int i))
                    {
                        sSql += $@"  and  ConfigNO = '{sKey}'";
                    }
                    if (!string.IsNullOrEmpty(typeDex) && !typeDex.Equals("-1"))
                    {
                        sSql += $@"  and  ParConfigNO = {typeDex}";
                    }
                    break;
                case 1:
                    sSql += @"  and  Tag = 1 ";
                    if (!string.IsNullOrEmpty(sKey))
                    {
                        sSql += $@"  and  ConfigValue like '{sKey}%'";
                    }
                    break;
                case 2:
                    break;
            }
            return dalConfig.GetConfigInfo(sSql);
        }
        public bool AddOrUpdateConfig(Config config)
        {
            return dalConfig.AddOrUpdateConfig(config);
        }
        public bool DeleteConfig(string configNo)
        {
            return dalConfig.DeleteConfig(configNo);
        }
    }
}