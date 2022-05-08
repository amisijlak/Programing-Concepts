using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordConcept
{
    //The following class is declared as static and contains only static methods:
    static class CompanyEmployee
    {
        public static void GetNumberOfFemaleEmployee() { /*...*/ }
        public static void GetNumberOfMaleEmployee() { /*...*/  }
    }

    //This small class is not static, but we create to illustrate the concept accessing static memebers from a non-static class
    public class NotStaticEmployeeClass
    {
        public struct SetNumberOfEmployees
        {
            public static int NumberOfEmployee = 100;
        }
    }
}
