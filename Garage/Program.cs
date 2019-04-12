using System;

namespace Garage
{
    class Program
    {
        private GarageHandler theGarage = new GarageHandler(); 

        static void Main(string[] args)
        {
            Console.WriteLine("This is the GARAGE application");
            Console.WriteLine("What do you want to do");
            Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                            + "\n1. Build the garage."
                            + "\n2. List the vehicles in the garage."
                            + "\n3. Park a vehicle in the garage."
                            + "\n4. Remove a vehicle from the garage."
                            + "\n5. Store the garage on disk."
                            + "\n6. Show a vehicle."
                            + "\n7. Close down the program.");
        }
    }
}
