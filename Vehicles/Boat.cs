using system;
using Vehicles;

namespace Vehicles{
    public class Boat : Vehicle
    {
        public int SeatingCapacity;
        public Boat(string Name, string Price, double Speed, string VehicleType, int SeatingCapacity) : 
        base(Name, Price, Speed, VehicleType)
        {
            this.SeatingCapacity = SeatingCapacity;
        }
        public int GetSeatingCapacity()
        {
            return SeatingCapacity;
        }
        public void SetSeatingCapacity(int seatingCapacity)
        {
            SeatingCapacity = seatingCapacity;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Seating Capacity: {SeatingCapacity}");
        }
        public void double CalculateTax()
        {
            
        }

    }
}
