using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce_system
{
    public class InitialFiles
    {
        //imported function
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder returnValue, int size, string filePath);

        //imported function
        [DllImport("kernel32")]

        private static extern uint GetPrivateProfileSectionNames(IntPtr returnValue, uint size, string filePath);

        //imported function
        [DllImport("kernel32")]

        private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

        private const string FILE_PATH = ".\\item.ini";

        //read .ini file data
        public string ReadInitial(string section, string key, string defaultValue = Constants.NULL_STRING)
        {
            const int BUFFER_SIZE = 255;
            StringBuilder temp = new StringBuilder(BUFFER_SIZE);
            GetPrivateProfileString(section, key, defaultValue, temp, BUFFER_SIZE, FILE_PATH);
            return temp.ToString();
        }

        //write data back to ini file
        public void WriteInitial(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, FILE_PATH);
        }

        //get all section in .ini file
        public string[] GetSectionNames()
        {
            const uint MAX_BUFFER = 32767;
            IntPtr pointerReturnedString = Marshal.AllocCoTaskMem((int)MAX_BUFFER);
            uint bytesReturned = GetPrivateProfileSectionNames(pointerReturnedString, MAX_BUFFER, FILE_PATH);
            return ConvertBytesToStringArray(pointerReturnedString, bytesReturned);
        }

        //int pointer to string array
        private string[] ConvertBytesToStringArray(IntPtr pointerReturnedString, uint bytesReturned)
        {
            const char END_CHAR = '\0';
            if (bytesReturned == 0)
            {
                Marshal.FreeCoTaskMem(pointerReturnedString);
                return null;
            }
            string local = Marshal.PtrToStringAnsi(pointerReturnedString, (int)bytesReturned).ToString();
            Marshal.FreeCoTaskMem(pointerReturnedString);
            return local.Substring(0, local.Length - 1).Split(END_CHAR);
        }
    }
}
