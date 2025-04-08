using System;
using Vehicles;

namespace Vehicles{
    public class LuxuryYacht : Boat
    {
        public int Helipad;
        public LuxuryYacht(string Name, string Price, double Speed, string VehicleType, int SeatingCapacity, int Helipad) : 
        base(Name, Price, Speed, VehicleType, SeatingCapacity)
        {
            this.Helipad = Helipad;
        }
        public int GetHelipad()
        {
            return Helipad;
        }
        public void SetHelipad(int helipad)
        {
            Helipad = helipad;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Helipad: {Helipad}");
        }
        public override double CalculateTax()
        {
            return Price * 0.05;
        }


    }
}
