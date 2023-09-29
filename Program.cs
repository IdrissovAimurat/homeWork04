using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", "Camry", 2022, 2.5);
            Car car2 = new Car("Супра", "А80", 1996, 3.0);

            car1.Start();
            car2.Start();

            car1.PrintCarInfo();
            car2.PrintCarInfo();

            car1.Drive();
            car2.Drive();

            Console.WriteLine($"Создано машин: {Car.TotalCarsCreated}");
        }
    }
}
