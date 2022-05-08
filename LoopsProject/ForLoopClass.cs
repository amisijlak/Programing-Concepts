using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    class ForLoopClass
    {
        /// <summary>
        /// In this example, int i = 0 is an initializer where we define an int variable i and initialize it with 0. 
        /// The second section is the condition expression i < 10, if this condition returns true then it will execute a code block. 
        /// After executing the code block, it will go to the third section, iterator. The i++ is an incremental statement that increases 
        /// the value of a loop variable i by 1. Now, it will check the conditional expression again and repeat the same 
        /// thing until conditional expression returns false. The below figure illustrates the execution steps of the for loop
        /// </summary>
        public void TestForLoop()
        {
            //The following for loop executes a code block 10 times.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }
        }

        public void ForLoopWithOptionalIterator()
        {
            int i = 0;

            for (; ; )
            {
                if (i < 10)
                {
                    Console.WriteLine("Value of i: {0}", i);
                    i++;
                }
                else
                    break;
            }
        }
        /// <summary>
        /// You can exit the loop by specifying the break keywork, like demonstrated in method below
        /// </summary>
        public void ForLoopWithBreaking()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;

                Console.WriteLine("Value of i: {0}", i);
            }
        }

        public void ForLoopWithMultipleExpressions()
        {
            for (int i = 0, j = 0; i + j < 5; i++, j++)
            {
                Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
            }
        }

        /// <summary>
        /// A for loop containing statements as an initializer and iterator.
        /// </summary>
        public void ForLoopWithInitializerAndIteratorStatements()
        {
            int i = 0, j = 5;
            for (Console.WriteLine($"Initializer: i={i}, j={j}");i++ < j--;Console.WriteLine($"Iterator: i={i}, j={j}"))
            {
            }
        }


        public void NestedForLoop()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = i; j < 4; j++)
                    Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
            }
        }
    }
}
