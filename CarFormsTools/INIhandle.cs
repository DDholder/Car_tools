using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CarFormsTools
{
    public class InIhandle
    {
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defVal, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        public delegate int GetInIHandler(string section, string key, string defVal, StringBuilder retVal, int size, string filePath);

        public readonly GetInIHandler GetInI = GetPrivateProfileString;
        public delegate long WriteIniHandler(string section, string key, string val, string filePath);

        public readonly WriteIniHandler WriteIni = WritePrivateProfileString;
    }
}
