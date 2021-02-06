using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace HomeWork.Aop.Helper
{
    public class ConfigHelper
    {
        public static string GetConnectionString(string name = "Homework")
        {
            return WebConfigurationManager.ConnectionStrings[name].ToString();
        }
        public static string GetAppSetting(string name)
        {
            return WebConfigurationManager.AppSettings[name];
        }
    }
}
