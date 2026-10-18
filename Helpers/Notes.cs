using System;

namespace Helpers
{
    class Notes
    {
        static private void ShowWarning(string str1, string str2="")
        {
            Console.WriteLine($"W: {str1}: {str2}");
            return;
        }
        static private void ShowError(string str1, string str2 = "")
        {
            Console.WriteLine($"E! {str1}: {str2}");
            return;
        }
        static private void ShowInfo(string str1, string str2 = "")
        {
            Console.WriteLine($"i: {str1}: {str2}");
            return;
        }
    }
}