using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordConcept
{
    public class Employee4
    {
        public string id;
        public string name;

        public Employee4()
        {
        }

        public Employee4(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        public static int employeeCounter;

        public static int AddEmployee()
        {
            return ++employeeCounter;
        }
    }
}
