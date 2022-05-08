using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationalConcepts
{
    public static class EnumsMethods
    {
        public static WeekDays AccessEnum()
        {
            return WeekDays.Monday;
        }
        /// <summary>
        /// returns the text value of the enum and it's corresponding integer value
        /// </summary>
        /// <returns></returns>
        public static (string, int) AccessEnumAsStringAndAsInt()
        {
            return (AccessEnum().ToString(), AccessEnumAsInt());
        }

        /// <summary>
        /// returns the int value of the enum
        /// </summary>
        /// <returns></returns>
        private static int AccessEnumAsInt()
        {
            return (int)AccessEnum();
            
        }
        
        public static (WeekDays, int) EnumConversion(int Day = 22)
        {
            return ((WeekDays)Day,(int)WeekDays.Friday);
        }
        
        public enum WeekDays : byte
        {
            Monday = 20,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
