using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFStatements
{
    class TestingIfStatement
    {
        /// <summary>
        /// The conditional expression must return a boolean value, otherwise C# compiler will give a compile-time error.
        /// In the above example, a boolean condition in the first if statement i < j evaluates to true, so the C# compiler will execute the following code block.
        /// The second if statement's condition i > j evaluates to false, so the compiler will not execute its code block. 
        /// </summary>
        public void IfStatement()
        {
            int i = 10, j = 20;

            if (i < j)
            {
                Console.WriteLine("i is less than j");
            }

            if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }
        }
        //this method calls calls a function from an if condition
        public void CallingFunctionAsCondition()
        {
            int i = 10, j = 20;

            if (isGreater(i, j))
            {
                Console.WriteLine("i is less than j");
            }

            if (isGreater(j, i))
            {
                Console.WriteLine("j is greater than i");
            }
        }

        //This is a function that test if I is greater than j
        private bool isGreater(int i, int j)
        {
            return i > j;
        }
    }
}
