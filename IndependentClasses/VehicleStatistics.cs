using System;
using Vehicles;

namespace IndependentClasses
{
    public class VehicleStatistics
    {
        public void GetAveragePrice(Vehicle[] vehicles)
        {
            if (vehicles.Length == 0)
            {
                Console.WriteLine("No vehicles found.");
                return;
            }

            double total = 0;
            for (int i = 0; i < vehicles.Length; i++)
            {
                total += vehicles[i].Price;
            }

            double average = total / vehicles.Length;
            Console.WriteLine("Average Price of Vehicles: " + average);
        }

        public void GetFastestVehicleByType(Vehicle[] vehicles, string type)
        {
            Vehicle fastest = null;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i].VehicleType == type)
                {
                    if (fastest == null || vehicles[i].Speed > fastest.Speed)
                    {
                        fastest = vehicles[i];
                    }
                }
            }

            if (fastest != null)
            {
                Console.WriteLine("Fastest " + type + ":");
                fastest.DisplayInfo();
            }
            else
            {
                Console.WriteLine("No vehicle of type " + type + " found.");
            }
        }

        public void CountVehiclesByType(Vehicle[] vehicles)
        {
            int carCount = 0;
            int truckCount = 0;
            int boatCount = 0;
            int airplaneCount = 0;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i].VehicleType == "Car")
                    carCount++;
                else if (vehicles[i].VehicleType == "Truck")
                    truckCount++;
                else if (vehicles[i].VehicleType == "Boat")
                    boatCount++;
                else if (vehicles[i].VehicleType == "Airplane")
                    airplaneCount++;
            }

            Console.WriteLine("Car Count: " + carCount);
            Console.WriteLine("Truck Count: " + truckCount);
            Console.WriteLine("Boat Count: " + boatCount);
            Console.WriteLine("Airplane Count: " + airplaneCount);
        }
    }
}
