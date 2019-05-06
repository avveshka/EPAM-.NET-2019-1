using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    public class DataSetting
    {
        public static string Connection = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
    }
}
