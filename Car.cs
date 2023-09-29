using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork04
{
    public partial class Car
    {
        private string make;
        private string model;
        private int year;
        private double engineSize;
        private bool isRunning;

        public static int TotalCarsCreated = 0;
        public static string CompanyName = "CarCompany";

        public Car()
        {
            TotalCarsCreated++;
        }

        // Перегруженные конструкторы
        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            TotalCarsCreated++;
        }

        public Car(string make, string model, int year, double engineSize)
            : this(make, model, year)
        {
            this.engineSize = engineSize;
        }

        //Методы доступа к закрытым полям
        public string GetMake()
        {
            return make;
        }

        public void SetMake(string make)
        {
            this.make = make;
        }

        public string GetModel()
        {
            return model;
        }

        public void SetModel(string model)
        {
            this.model = model;
        }

        //Методы управления классом
        public void Start()
        {
            isRunning = true;
        }

        public void Stop()
        {
            isRunning = false;
        }

        public void PrintCarInfo()
        {
            Console.WriteLine($"Make: {make}, Model: {model}, Year: {year}, Engine Size: {engineSize}L, Is Running: {isRunning}");
        }

        //Статический конструктор
        static Car()
        {
            Console.WriteLine("Вызван статический конструктор.");
        }
    }
}
