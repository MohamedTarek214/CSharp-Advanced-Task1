using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal static class StringExtensionMethod
    {
        public static bool IsPalindrome(this string name)
        {
            for (int i = 0; i < name.Length / 2; i++)
            {
                if (name[i] != name[name.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
