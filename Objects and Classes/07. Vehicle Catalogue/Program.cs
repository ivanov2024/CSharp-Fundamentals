using System.Reflection;

namespace Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] information = input.Split('/');
                string vehicle = information[0];

                if (vehicle == "Car")
                {
                    string brand = information[1];
                    string model = information[2];
                    int horsePower = int.Parse(information[3]);
                    Car car = new Car(brand, model, horsePower);
                    cars.Add(car);
                }
                else
                {
                    string brand = information[1];
                    string model = information[2];
                    int weight = int.Parse(information[3]);
                    Truck truck = new Truck(brand, model, weight);
                    trucks.Add(truck);
                }
            }

            if (trucks.Count == 0)
            {
                Console.WriteLine($"Cars:");
                foreach (Car car in cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                    //"Cars:
                    //{Brand}: {Model} - {Horse Power}hp
                }
            }
            else if (cars.Count == 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (Truck truck in trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                    //"Trucks:
                    //{Brand}: {Model} - {Weight}hp
                }
            }
            else
            {
                Console.WriteLine($"Cars:");
                foreach (Car car in cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                    //"Cars:
                    //{Brand}: {Model} - {Horse Power}hp
                }

                Console.WriteLine($"Trucks:");
                foreach (Truck truck in trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                    //"Trucks:
                    //{Brand}: {Model} - {Weight}hp
                }
            }
        }

        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }

            public Truck(string brand, string model, int weight)
            {
                Brand = brand;
                Model = model;
                Weight = weight;
            }
        }

        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }

            public Car(string brand, string model, int horsePower)
            {
                Brand = brand;
                Model = model;
                HorsePower = horsePower;
            }
        }

        //class Catalog
        //{
        //    public string TruckCollection { get; set; }
        //    public string CarCollection { get; set; }
        //}
    }
}
