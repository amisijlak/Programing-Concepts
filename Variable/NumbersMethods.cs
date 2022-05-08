using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    public static class NumbersMethods
    {
        public static float ImplicitConversion()
        {
            int i = 345;
            float f = i;
            return f; //Should retrun : 345
        }

        //The below example, integer i is converted to uint explicitly by specifying uint in the brackets (uint)
        //This will convert an integer to uint. 
        public static (uint, double) ExplicitConversion()
        {
            string stringNumber = "20.9";
            int i = 100;
            uint u = (uint)i;
            double floatNumber = Convert.ToDouble(stringNumber);
            return (u, floatNumber);
        }

        public static (string, string) VariableAndExpression()
        {
            int i = 100;

            int j = i + 20; // j = 120

            i = 200;
            j = i + 20;// j = 220

            i = 300;
            return ($"{j}", $"{i}");
        }

        /// <summary>
        /// Return the maximum up and lower value of sbyte and byte
        /// </summary>
        /// <returns>(255,0,127,-128)</returns>
        public static (byte, byte, sbyte, sbyte) ByteAndSbyte()
        {
            //byte byteNumber = -128;// compile-time error: Constant value '-128' cannot be converted to a 'byte'
            return (Byte.MaxValue, Byte.MinValue, SByte.MaxValue, SByte.MinValue);
        }
        /// <summary>
        /// Return the maximum up and lower value of short and ushort
        /// </summary>
        /// <returns></returns>
        public static (short, short, ushort, ushort) ShortAndUshort()
        {
            //short s3 = 35000;//Compile-time error: Constant value '35000' cannot be converted to a 'short'
            //ushort us2 = -32000; //Compile-time error: Constant value '-32000' cannot be converted to a 'ushort'

            return (Int16.MaxValue, Int16.MinValue, UInt16.MaxValue, UInt16.MinValue);
        }
        /// <summary>
        /// Returns the maximum and minimum value of an int and Uint
        /// </summary>
        /// <returns></returns>
        public static (int, int, uint, uint) IntAndUInt()
        {
            //int k = 4294967295; //Compile-time error: Cannot implicitly convert type 'uint' to 'int'.
            //uint ui2 = -1; //Compile-time error: Constant value '-1' cannot be converted to a 'uint'

            return (Int32.MaxValue, Int32.MinValue, UInt32.MaxValue, UInt32.MinValue);
        }

        //Return an int represent from an Hexadecimal and binary value
        public static (int, int) HexadecimalBinary()
        {
            int hex = 0x2F;
            int binary = 0b_0010_1111;

            return (hex, binary);
        }
        /// <summary>
        /// returns the maximum and minimum value of a long and ulong
        /// </summary>
        /// <returns></returns>
        public static (long, long, ulong, ulong) LongAndULong()
        {
            return (Int64.MaxValue, Int64.MinValue, UInt64.MaxValue, UInt64.MinValue);
        }

        /// <summary>
        /// Returns numbers to show the difference between a float, double and decimal types
        /// </summary>
        /// <returns></returns>
        public static (float,double, decimal) FloatDoubleDecimalDataType()
        {
            float f = 134.45E-2f;  //float data type // output: 1.3445
            double d = 0.42e2;    //double data type // output 42            
            decimal m = 1.5E6m;   //decimal data type // output: 1500000

            return (f, d, m);
        }
    }
}
