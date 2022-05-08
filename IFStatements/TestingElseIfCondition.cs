using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFStatements
{
    class TestingElseIfCondition
    {
        int i = 20, j = 20;
        /// <summary>
        /// The following example demonstrates else if statements
        /// </summary>
        public void ElseIfStatement()
        {
            int i = 10, j = 20;

            if (i == j)
            {
                WriteMessage("i is equal to j");
            }
            else if (i > j)
            {
                WriteMessage("i is greater than j");
            }
            else if (i < j)
            {
                WriteMessage("i is less than j");
            }
        }

        /// <summary>
        /// Demonstrates how the else statement works
        /// </summary>
        public void ElseStatement()
        {
            string Message = "";
            DateTime GivenDate = DateTime.Today;
            if (GivenDate.DayOfWeek == DayOfWeek.Sunday)
            {
                Message = ($"Today is {DayOfWeek.Sunday}, thus a weekend!");
            }
            else if (GivenDate.DayOfWeek == DayOfWeek.Saturday)
            {
                Message = ($"Today is {DayOfWeek.Saturday}, thus a weekend!");
            }
            else
            {
                Message = ($"Today {DayOfWeek.Saturday}, is a weekday!");
            }

            WriteMessage(Message);
        }

        /// <summary>
        /// We have use ternary operator to tranform the method above into the one below
        /// </summary>
        public void TernaryOperator()
        {
            WriteMessage((i > j) ? "i is greater than j" : (i < j ? "i is less than j" : "i is equal to j"));
        }

        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
