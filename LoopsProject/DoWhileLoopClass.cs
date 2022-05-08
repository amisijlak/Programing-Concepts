using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    class DoWhileLoopClass
    {
        /// <summary>
        /// Testing a simple do while loop, how it works
        /// </summary>
        public void DoWhileLoop()
        {
            int i = 0;

            do
            {
                Console.WriteLine("i = {0}", i);
                i++;

            } while (i < 5);
        }

        public void ExitingDoWhileLoop()
        {
            int i = 0;

            do
            {
                Console.WriteLine("i = {0}", i);
                i++;

                if (i > 5)
                    break;

            } while (i < 10);

        }

        public void NestedDoWhileLoop()
        {
            int i = 0;

            do
            {
                Console.WriteLine("Value of i: {0}", i);
                int j = i;

                i++;

                do
                {
                    Console.WriteLine("Value of j: {0}", j);
                    j++;
                } while (j < 2);

            } while (i < 2);

        }
    }
}
