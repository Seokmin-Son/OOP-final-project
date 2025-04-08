using System;
using Vehicles;

namespace Vehicles{
    public class Truck : Vehicle
    {
        public int loadCapacity;
        public Truck(string Name, string Price, double Speed, string VehicleType, int loadCapacity) : 
        base(Name, Price, Speed, VehicleType)
        {
            this.loadCapacity = loadCapacity;
        }
        public int GetLoadCapacity()
        {
            return loadCapacity;
        }
        public void SetLoadCapacity(int loadCapacity)
        {
            this.loadCapacity = loadCapacity;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Load Capacity: {loadCapacity}");
        }
        public override double CalculateTax(){
            return Price * 0.20;
        }
    }
}

