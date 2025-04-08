using Vehicles;

namespace IndependentClasses
{
    public class TaxCalculator
    {
        public static double GetTax(Vehicle vehicle)
        {
            return vehicle.CalculateTax();
        }
    }
}
