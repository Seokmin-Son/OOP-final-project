using System;

namespace Vehicles
{
    public class Vehicle{
        public string Name {get; set;}
        public double Price 
        {
            get{return price;}
            set
            {
                if(value > 0){
                Price = value;
                } else{
                    Console.WriteLine("Not a valid number of price");       
                }
            }
        }
        public double Speed {get; set;}
        public string VehicleType {get; set;}

        public Vehicle(string Name, string Price, double Speed, string VehicleType)
        {
        Name = name;
        Price = price;
        Speed = speed;
        VehicleType = vehicletype;
        }

        public void DisplayInfo(){
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"VehicleType: {VehicleType}");
        }

        public abstract double CalculateTax();
    }
}