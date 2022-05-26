using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POS.Admin
{
    public class Config
    {
        public string DATABASE_PATH = $"{Assembly.GetEntryAssembly().Location.Replace(Assembly.GetEntryAssembly().ManifestModule.ToString(), "")}nanoPOS.admin.sqlite";
    }
}
