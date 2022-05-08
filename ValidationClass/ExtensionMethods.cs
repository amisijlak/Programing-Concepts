using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationClass
{
    /// <summary>
    /// Define an Extension Method 
    /// </summary>
    public static class IntExtensions
    {
        //For example, the IsGreaterThan() method operates on int, so the first parameter would be, this int i. 
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
