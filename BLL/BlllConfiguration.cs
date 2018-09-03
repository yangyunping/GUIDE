using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;
using MODEL;

namespace BLL
{
    public class BlllConfiguration
    {
        DalConfiguration DalConfiguration = new DalConfiguration();
        public DataTable GetConfigInfo(string key)
        {
            return DalConfiguration.GetConfigInfo(key);
        }
        public bool DeleteConfig(string configName)
        {
            return DalConfiguration.DeleteConfig(configName);
        }
        public bool InsertOrModifyConfig(Configuration configuration)
        {
            return DalConfiguration.InsertOrModifyConfig(configuration);
        }
    }
}
