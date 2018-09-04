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
        public DataTable GetConfigInfo(string sKey,int type)
        {
            string sSql = string.Empty;
            if (!string.IsNullOrEmpty(sKey))
            {
                switch (type)
                {
                    case 0:
                        sSql = $@"  and  ConfigValue like '{sKey}%'";
                        break;
                    case 1:
                        sSql = $@"  and  ParConfigNO = '{sKey}%'";
                        break;
                }
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
