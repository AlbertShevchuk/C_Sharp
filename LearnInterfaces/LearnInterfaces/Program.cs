using System;

namespace LearnInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan car1 = new Sedan(60);
            Sedan car2 = new Sedan(70);
            Truck truck = new Truck(45, 500);

            Console.WriteLine("Sedan 1 Speed: " + car1.Speed);
            Console.WriteLine("Sedan 1 Wheels: " + car1.Wheels);
            Console.WriteLine("Sedan 1 License Plate: " + car1.LicensePlate);
            Console.WriteLine("");
            Console.WriteLine("Sedan 2 Speed: " + car2.Speed);
            Console.WriteLine("Sedan 2 Wheels: " + car2.Wheels);
            Console.WriteLine("Sedan 2 License Plate: " + car2.LicensePlate);
            Console.WriteLine("");
            Console.WriteLine("Truck Speed: " + truck.Speed);
            Console.WriteLine("Truck Wheels: " + truck.Wheels);
            Console.WriteLine("Truck License Plate: " + truck.LicensePlate);

            car1.SpeedUp();
            car2.SpeedUp();
            truck.SpeedUp();

            Console.WriteLine("");
            Console.WriteLine("Sedan 1 Speed: " + car1.Speed);
            Console.WriteLine("Sedan 2 Speed: " + car2.Speed);
            Console.WriteLine("Truck Speed: " + truck.Speed);
        }
    }
}