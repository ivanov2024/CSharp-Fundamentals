using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Xml.Linq;

namespace Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> cars = new List<Vehicle>();
            List<Vehicle> trucks = new List<Vehicle>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] vehicleData = input.Split();

                string typeOfVehicle = vehicleData[0];
                string model = vehicleData[1];
                string color = vehicleData[2];
                int horsepower = int.Parse(vehicleData[3]);

                Vehicle vehicle = new Vehicle(typeOfVehicle, model, color, horsepower);

                if (typeOfVehicle == "car")
                {
                    cars.Add(vehicle);
                }
                else if (typeOfVehicle == "truck")
                {
                    trucks.Add(vehicle);
                }
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                string modelToFind = input;

                Vehicle vehicle = cars.Concat(trucks).FirstOrDefault(v => v.Model == modelToFind);

                if (vehicle != null)
                {
                    Console.WriteLine(vehicle);
                }
            }

            double averageCarHorsepower = cars.Any() ? cars.Average(v => v.Horsepower) : 0.0;
            double averageTruckHorsepower = trucks.Any() ? trucks.Average(v => v.Horsepower) : 0.0;

            Console.WriteLine($"Cars have average horsepower of: {averageCarHorsepower:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorsepower:F2}.");
        }             
    }

    class Vehicle
    {
        private string type;
        public string Type
        {
            get { return char.ToUpper(type[0]) + type.Substring(1); }
            set { type = value; }
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public Vehicle(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public override string ToString()
        {
            return $"Type: {Type}\nModel: {Model}\nColor: {Color}\nHorsepower: {Horsepower}";
        }
    }
}