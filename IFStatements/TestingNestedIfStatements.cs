using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFStatements
{
    class TestingNestedIfStatements
    {
        public void NestedIfStatement()
        {
            int i = 10, j = 20;

            if (i != j)
            {
                if (i < j)
                {
                    Console.WriteLine("i is less than j");
                }
                else if (i > j)
                {
                    Console.WriteLine("i is greater than j");
                }
            }
            else
                Console.WriteLine("i is equal to j");
        }
    }
}
