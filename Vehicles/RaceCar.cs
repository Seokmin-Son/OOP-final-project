using System;
using Vehicles;

namespace Vehicles{
    public class RaceCar : Car
    {
        public int TurboBoost;
        public RaceCar(string Name, string Price, double Speed, string VehicleType,string Model, int HoresePower, int TurboBoost) : 
        base(Name, Price, Speed, VehicleType, Model, HoresePower)
        {
            this.TurboBoost = TurboBoost;
        }
        public int GetTurboBoost()
        {
            return TurboBoost;
        }
        public void SetTurboBoost(int turboBoost)
        {
            TurboBoost = turboBoost;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Turbo Boost: {TurboBoost}");
        }
        public void CalculateTax()
        {
        
        }

    }
}
