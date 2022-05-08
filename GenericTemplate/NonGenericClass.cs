using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTemplate
{
    class NonGenericClass
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }
    }
}
