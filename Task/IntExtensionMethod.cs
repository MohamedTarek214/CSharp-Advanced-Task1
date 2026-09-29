using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task
{
    internal static class IntExtensionMethod
    {
        public static bool IsPrime(this int num)
        {
            if (num < 2)
                return false;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
        
            
        
    }
    
}
