using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_system{
    public class IniFile{
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32")]
        private static extern uint GetPrivateProfileSectionNames(IntPtr retVal, uint size, string filePath);

        private const string filepath=".\\item.ini";
        public IniFile(){
        }

        public string readIni(string section, string key,string default_value="null"){
            StringBuilder temp = new StringBuilder(255);
            GetPrivateProfileString(section, key, default_value, temp, 255, filepath);
            return temp.ToString();
        }

        public string[] GetSectionNames(){
            uint MAX_BUFFER = 32767;
            IntPtr pReturnedString = Marshal.AllocCoTaskMem((int)MAX_BUFFER);
            uint bytesReturned = GetPrivateProfileSectionNames(pReturnedString, MAX_BUFFER, filepath);
            return IntPtrToStringArray(pReturnedString, bytesReturned);
        }

        private string[] IntPtrToStringArray(IntPtr pReturnedString, uint bytesReturned){
            if (bytesReturned == 0)
            {
                Marshal.FreeCoTaskMem(pReturnedString);
                return null;
            }
            string local = Marshal.PtrToStringAnsi(pReturnedString, (int)bytesReturned).ToString();
            Marshal.FreeCoTaskMem(pReturnedString);
            return local.Substring(0, local.Length - 1).Split('\0');
        }
    }
}
