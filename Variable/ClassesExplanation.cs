
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationalConcepts
{
    public class EmployeeClass
    {
        public string EmployeeName = string.Empty;

        public EmployeeClass()
        {
        }

        public int GetTheAgeBetweenTwoDate(DateTime dateOfBirth)
        {
           return DateTime.Today.Year - dateOfBirth.Year;
        }
        public void MyMethod(int parameter1, string parameter2)
        {
            Console.WriteLine("First Parameter {0}, second parameter {1}", parameter1, parameter2);
        }

        //Auto-implemented Property
        public DateTime? DateOfBirth { get; set; }

        private bool _employeeIsMinor;

        //Property in C#
        public int EmployeeAgeProperty
        {
            get { return GetTheAgeBetweenTwoDate(DateOfBirth.Value); }
            set
            {
                if (value <= 0)
                    _employeeIsMinor = true;
                else
                    _employeeIsMinor = false;
            }
        }
    }
}
