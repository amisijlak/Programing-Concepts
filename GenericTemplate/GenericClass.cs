using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTemplate
{
    class GenericClass<T>
    {
        public T Data { get; set; }
    }

    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }

    //Below, the AddorUpdate() and the GetData() methods are generic methods. The actual data type of the item parameter will be
    //specified at the time of instantiating the DataStore<T> class, as shown below.
    class GenericMethods<T>
    {
        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }
    }
}
