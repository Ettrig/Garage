using System;
using System.Collections.Generic;
using System.Text;

namespace GarageProject
{
    class GarageHandler
    {
        Garage<Vehicle> theGarage;
        public void CreateGarage(int capacity)
        {
            theGarage = new Garage<Vehicle>(capacity);
        }

        public void AddVehicle( Vehicle theVehicle )
        {
            theGarage.AddVehicle(theVehicle); 
        }
    }
}
