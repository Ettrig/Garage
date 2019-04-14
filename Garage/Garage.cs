using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GarageProject
{
    //Garage contains only Vehicle, so the generic type is pointless
    class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private int capacity;
        public int Capacity {get => capacity; set => capacity=value;}
        private int count;
        public int Count {get => count; set => count=value;}
        private Vehicle[] vehicles;

        public Garage(int cap)
        {
            capacity = cap; 
            vehicles = new Vehicle[capacity];
        }

        private class EnumeratorGarage

        public void AddVehicle(Vehicle theVehicle)
        {
            int i=0; 
            while (vehicles[i] != null) i++;
            vehicles[i] = theVehicle; 
        }

        // It is stated that T is Vehicle in this class
        public IEnumerator<Vehicle> GetEnumerator()
        {
            throw new NotImplementedException();
        }

 //       IEnumerator IEnumerable.GetEnumerator() 
 //       {
 //           return (IEnumerator) GetEnumerator();
 //       }

    }
}
