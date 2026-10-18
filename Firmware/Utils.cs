using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Firmware
{
    public class Utils
    {
        /// <summary>
        /// Split the Path in list of Directories
        /// </summary>
        public static string[] SplitPath(string parentPath)
        {
            if (!parentPath.EndsWith(Path.DirectorySeparatorChar + ""))
                parentPath += Path.DirectorySeparatorChar;

            string pathRoot = Path.GetPathRoot(parentPath);
            if (parentPath.StartsWith(pathRoot))
                parentPath = parentPath.Substring(pathRoot.Length);

            char[] chars = new char[] { Path.DirectorySeparatorChar };
            return parentPath.Split(chars, StringSplitOptions.RemoveEmptyEntries);
        }


        public static byte ComputeDosChk(byte[] name)
        {
            Debug.Assert(name.Length == 11);
            byte sum = 0;
            for (int i = 0; i < name.Length; i++)
            {
                int sum1 = (sum & 1) << 7;
                int sum2 = (sum & 0xfe) >> 1;
                sum = (byte)((sum1 | sum2) + name[i]);
            } 
            return sum;
        }

        public static string CleanDescr(string fname)
        {
            string res = "";
            fname = fname.ToUpper();
            for (int i = 0; i < fname.Length; i++)
                if ((fname[i] >= '0' && fname[i] <= '9') ||
                    (fname[i] >= 'A' && fname[i] <= 'Z'))
                    res += fname[i];
                else
                    res += "_";
            return res;
        }
    }

    public class BytesUtils
    {

        public static string ToString(byte[] b)
        {
            return Encoding.ASCII.GetString(b);
        }

        public static string ToHex(byte b)
        {
            return b.ToString("X2");
        }
        public static string ToHex(ushort b)
        {
            return b.ToString("X4");
        }
        public static string ToHex(uint b)
        {
            return b.ToString("X8");
        }
        public static string ToHex(byte[] b)
        {
            string str = "";
            for (int i = 0; i < b.Length; i++)
            {
                str += b[i].ToString("X2");
            }
            return str;
        }


        public static ushort Hi(uint b)
        {
            return (ushort)(b);
        }
        public static ushort Lo(uint b)
        {
            return (ushort)(b>>16);
        }
        public static UInt32 SwapBytes(UInt32 i)
        {
            byte[] b = { (byte)(i >> 24), (byte)(i >> 16), (byte)(i >> 8), (byte)(i >> 0) };
            return BitConverter.ToUInt32(b, 0);
        }
        public static UInt16 SwapBytes(UInt16 i)
        {
            byte[] b = { (byte)(i >> 8), (byte)(i) };
            return BitConverter.ToUInt16(b, 0);
        }

        public static string GetSizeDescr(params object[] args)
        {
            return "NOT IMPLEMENTED";
        }

        public static UInt32 Round(UInt32 num, int reso)
        {
            UInt32 mod = num & (UInt32)reso;
            return num+(UInt32)reso-mod;
        }
    }
}
