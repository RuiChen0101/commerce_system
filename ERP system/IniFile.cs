using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace ERP_system{
    public class IniFile{
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        private const string filepath=".\\item.ini";
        public IniFile(){
        }

        public string readIni(string section, string key,string default_value="null"){
            StringBuilder temp = new StringBuilder(255);
            GetPrivateProfileString(section, key, default_value, temp, 255, filepath);
            return temp.ToString();
        }
    }
}
