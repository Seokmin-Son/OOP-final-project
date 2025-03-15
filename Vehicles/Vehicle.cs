using system;

namespace Vehicles
{
    public class Vehicle{
        public string Name {get; set;}
        public double Price 
        {
            get{return Price;}
            set
            {
                if(price > 0){
                Price = price;
                } else{
                    Console.WriteLine("Not a valid number of price");       
                }
            }
        }
        public double Speed {get; set;}
        public string VehicleType {get; set;}

        public Vehicle(string Name, string Price, double Speed, string VehicleType);
        Name = name;
        Price = price;
        Speed = speed;
        VehicleType = vehicletype;

        public void DisplayInfo(){
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"VehicleType: {VehicleType}");
        }

        public void double CalculateTax();{

        }
    }
/*
    class Car : Vehicle{

    }

    class RaceCar : Car{

    }



    class Airplane : Vehicle{

    }

    class CargoAirplane : Airplane {

    }

    class Truck : Vehicle{

    }

    class Boat : Vehicle{

    }

    class LuxuryYacht : Vehicle{

    } */
    
}