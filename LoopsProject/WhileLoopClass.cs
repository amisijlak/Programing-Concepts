using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    class WhileLoopClass
    {
        public void WhileLoop()
        {
            int i = 0; // initialization

            while (i < 10) // condition
            {
                Console.WriteLine("i = {0}", i);

                i++; // increment
            }
        }

        /// <summary>
        /// Demonstrates how to exit the while loop
        /// </summary>
        public void ExitingWhileLoop()
        {
            int i = 0;

            while (true)
            {
                Console.WriteLine("i = {0}", i);

                i++;

                if (i > 10)
                    break;
            }
        }

        public void NestedWhileLoop()
        {
            int i = 0, j = 1;

            while (i < 2)
            {
                Console.WriteLine("i = {0}", i);
                i++;

                while (j < 2)
                {
                    Console.WriteLine("j = {0}", j);
                    j++;
                }
            }
        }
    }
}
