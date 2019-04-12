using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private Vehicle[] vehicles;  

        public Garage(int capacity) => vehicles = new Vehicle[capacity];

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
