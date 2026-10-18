using System;
using System.Windows.Forms;

namespace FuzzyByte.NokiaCooker
{
    public class Notes
    {
        static public void ShowWarning(string str1, string str2="")
        {
            Console.WriteLine($"W: {str1}: {str2}");
            MessageBox.Show(str1 + " " + str2, str1, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        static public void ShowError(string str1, string str2 = "")
        {
            Console.WriteLine($"E! {str1}: {str1}");
            MessageBox.Show(str1 + " " + str2, str1, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        static public void ShowInfo(string str1, string str2 = "")
        {
            Console.WriteLine($"i: {str1}: {str2}");
            MessageBox.Show(str1 + " " + str2, str1, MessageBoxButtons.OK,MessageBoxIcon.Information);
            return;
        }
    }
}