using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFStatements
{
    class TestingSwitchStatement
    {
        /// <summary>
        /// Below, the switch(x) statement includes a variable x whose value will be matched with the value of each case value. 
        /// The below switch statement contains three cases with constant values 5, 10, and 15. It also contains the default label, 
        /// which will be executed if none of the case value match with the switch variable/expression. Each case starts after: 
        /// and includes one statement to be executed. The value of x matches with the second case case 10: so, the output would 
        /// be Value of x is 10. 
        /// </summary>
        public void SwitchStatement()
        {
            int x = 10;

            switch (x)
            {
                case 5:
                    Console.WriteLine("Value of x is 5");
                    break;
                case 10:
                    Console.WriteLine("Value of x is 10");
                    break;
                case 15:
                    Console.WriteLine("Value of x is 15");
                    break;
                default:
                    Console.WriteLine("Unknown value");
                    break;
            }
        }

        public void SwitchStatementWithExpression()
        {
            int x = 125;

            switch (x % 2)
            {
                case 0:
                    Console.WriteLine($"{x} is an even value");
                    break;
                case 1:
                    Console.WriteLine($"{x} is an odd Value");
                    break;
            }
        }

        /// <summary>
        /// Demonstrates scenario of combined switch cases
        /// </summary>
        public void SwitchWithMultipleCases()
        {
            int x = 5;

            switch (x)
            {
                case 1:
                    Console.WriteLine("x = 1");
                    break;
                case 2:
                    Console.WriteLine("x = 2");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("x = 4 or x = 5");
                    break;
                default:
                    Console.WriteLine("x > 5");
                    break;
            }
        }

        public void SwitchWithReturn()
        {
            int x = 125;
            Console.Write(isOdd(x) ? "Even value" : "Odd value");
        }


        static bool isOdd(int i)
        {
            switch (i % 2)
            {
                case 0:
                    return true;
                case 1:
                    return false;
                default:
                    return false;
            }

            return false;
        }

        /// <summary>
        /// Demonstrating the nested switch ability
        /// </summary>
        public void NestedSwitchStatement()
        {
            int j = 5;

            switch (j)
            {
                case 5:
                    Console.WriteLine(5);
                    switch (j - 1)
                    {
                        case 4:
                            Console.WriteLine(4);
                            switch (j - 2)
                            {
                                case 3:
                                    Console.WriteLine(3);
                                    break;
                            }
                            break;
                    }
                    break;
                case 10:
                    Console.WriteLine(10);
                    break;
                case 15:
                    Console.WriteLine(15);
                    break;
                default:
                    Console.WriteLine(100);
                    break;
            }
        }
    }
}
