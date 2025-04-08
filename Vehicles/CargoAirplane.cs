using System;
using Vehicles;

namespace Vehicles{
    public class CargoAirplane : Airplane
    {
        public int CargoCapacity;
        public CargoAirplane(string Name, string Price, double Speed, string VehicleType, int Altitude, int CargoCapacity) : 
        base(Name, Price, Speed, VehicleType, Altitude)
        {
            this.CargoCapacity = CargoCapacity;
        }
        public int GetCargoCapacity()
        {
            return CargoCapacity;
        }
        public void SetCargoCapacity(int cargoCapacity)
        {
            CargoCapacity = cargoCapacity;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Cargo Capacity: {CargoCapacity}");
        }
        public override double CalculateTax(){
            return Price * 0.15;            
        }

    }
}
