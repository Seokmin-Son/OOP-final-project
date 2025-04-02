using system;
using Vehicles;

namespace Vehicles{
    public class Train : Vehicle
    {
        public int Units;
        public Train(string Name, string Price, double Speed, string VehicleType, int Units) : 
        base(Name, Price, Speed, VehicleType)
        {
            this.Units = Units;
        }
        public int GetUnits()
        {
            return Units;
        }
        public void SetUnits(int units)
        {
            Units = units;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Units: {Units}");
        }
        public void double CalculateTax();{
            
        }

    }
}
