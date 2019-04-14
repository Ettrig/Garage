using System;

namespace GarageProject
{
    class Program
    {
        static GarageHandler theHandler = new GarageHandler();

        static void Main(string[] args)
        {
            Console.WriteLine("This is the GARAGE application");
            Console.WriteLine("What do you want to do");
            while (true)
        	{
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                            + "\n1. Build the garage."
                            + "\n2. List the vehicles in the garage."
                            + "\n3. Park a vehicle in the garage."
                            + "\n4. Remove a vehicle from the garage."
                            + "\n5. Store the garage on disk."
                            + "\n6. Show a vehicle."
                            + "\n7 or nothing. Close the program down.");

                var inString = Console.ReadLine(); 
                if (inString.Length==0) 
                {
                    Console.WriteLine("Thank You and Goodbye!");
                    break; 
                }

                switch(inString[0]) 
                {
                    case '1':
                        BuildGarage();
                        break;
                    case '2':
                        ListVehicles();
                        break;
                    case '3':
                        ParkVehicle();
                        break;
                    case '4':
                        RemoveVehicle(inString);
                        break;
                    case '5':
                        PermanentBackup();
                        break;
                    case '6':
                        ShowVehicleData(inString);
                        break;
                    case '7':
                        Console.WriteLine("Thank You and Goodbye!");
                        break;
                    default:
                        break;
                }

                if (inString[0] == '7') break;

        	}
        }

        private static void ShowVehicleData(string inString)
        {
            throw new NotImplementedException();
        }

        private static void PermanentBackup()
        {
            throw new NotImplementedException();
        }

        private static void RemoveVehicle(string inString)
        {
            throw new NotImplementedException();
        }

        private static void ParkVehicle()
        {
            Console.WriteLine("What does the license plate say?");
            string license = Console.ReadLine().ToUpper();
            Console.WriteLine("What color is the vehicle?");
            string color = Console.ReadLine();
            Console.WriteLine("How many wheels does the vehicle have?");
            string inString = Console.ReadLine();
            int wheels; 
            if (!int.TryParse(inString, out wheels))
            {
                Console.WriteLine("The input cannot be interpreted as a nnumber.");
                Console.WriteLine("The vehicle cannot be parked.");
                return; 
            }
            Console.WriteLine("What kind of vehicle is being parked?"
                        + "\nAeroplane, Bus, Boat, Car or MC?");
            inString = Console.ReadLine().ToLower(); 
            if (inString=="aeroplane" || inString=="airplane" || inString=="plane")
            {

            }

        }

        private static void ListVehicles()
        {
            throw new NotImplementedException();
        }

        private static void BuildGarage()
        {
            Console.WriteLine("How many vehicles can the garage take?");
            var inString = Console.ReadLine();
            int capacity; 
            if (int.TryParse( inString, out capacity))
            {
                if (capacity > 1000000)
                {
                    Console.WriteLine("The garage cannot be bigger than one million vehicles.");
                }
                else if (capacity < 1)
                {
                    Console.WriteLine("The garage must be able to hold at least one vehicle.");
                }
                else theHandler.CreateGarage(capacity);
            }
            else Console.WriteLine("The input text could not be interpreted as an integer.");
        }

    }
}
