using System;
using System.Collections.Generic;
using System.Text;

namespace GarageProject
{
    class Vehicle
    {
        private int color;
        public int Color
        {
            get { return color; }
            set { color = value; }
        }

        private string license; // Must be unique
        public string License { get => license; set => license = value; }

        public int Wheels; 
    }
}
