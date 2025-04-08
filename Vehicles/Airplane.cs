using System;
using Vehicles;

namespace Vehicles{
    public class Airplane : Vehicle
    {
        public int Altitude;
        
        public Airplane (string Name, string Price, double Speed, string VehicleType, int Altitude) : 
        base(Name, Price, Speed, VehicleType)
        {
            this.Altitude = Altitude;
        }

        public int GetAltitude()
        {
            return Altitude;
        }
        public void SetAltitude(int altitude)
        {
            Altitude = altitude;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Altitude: {Altitude}");
        }

        public override double CalculateTax(){
            return Price * 0.15;
        }

    }
}
