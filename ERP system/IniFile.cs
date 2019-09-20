using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_system
{
    public class IniFile
    {
        //imported function
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder returnValue, int size, string filePath);

        //imported function
        [DllImport("kernel32")]
        private static extern uint GetPrivateProfileSectionNames(IntPtr returnValue, uint size, string filePath);

        private const string FILE_PATH = ".\\item.ini";

        //read .ini file data
        public string ReadIni(string section, string key,string default_value= Constants.NULL_STRING)
        {
            const int bufferSize = 255;
            StringBuilder temp = new StringBuilder(bufferSize);
            GetPrivateProfileString(section, key, default_value, temp, bufferSize, FILE_PATH);
            return temp.ToString();
        }

        //get all section in .ini file
        public string[] GetSectionNames()
        {
            const uint MAX_BUFFER = 32767;
            IntPtr pointerReturnedString = Marshal.AllocCoTaskMem((int)MAX_BUFFER);
            uint bytesReturned = GetPrivateProfileSectionNames(pointerReturnedString, MAX_BUFFER, FILE_PATH);
            return IntPtrToStringArray(pointerReturnedString, bytesReturned);
        }

        //int pointer to string array
        private string[] IntPtrToStringArray(IntPtr pointerReturnedString, uint bytesReturned)
        {
            const char endChar = '\0';
            if (bytesReturned == 0)
            {
                Marshal.FreeCoTaskMem(pointerReturnedString);
                return null;
            }
            string local = Marshal.PtrToStringAnsi(pointerReturnedString, (int)bytesReturned).ToString();
            Marshal.FreeCoTaskMem(pointerReturnedString);
            return local.Substring(0, local.Length - 1).Split(endChar);
        }
    }
}
