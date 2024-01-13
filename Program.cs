using System;
using System.Collections.Generic;
using System.Linq;
using static Linq_hw.Car;

namespace Linq_hw
{

    internal class Program
    {
        static void Task2Test()
        {
            var cars = new List<Car>();
            var customers = new List<Customer>();

            cars.Add(new Car("Toyota", "Camry", 2022, CarColor.Red));
            cars.Add(new Car("Honda", "Civic", 2019, CarColor.Blue));
            cars.Add(new Car("Ford", "Mustang", 2020, CarColor.Yellow));
            cars.Add(new Car("Chevrolet", "Malibu", 2021, CarColor.Black));
            cars.Add(new Car("Tesla", "Model S", 2023, CarColor.White));

            customers.Add(new Customer("John Doe", "1234567890", "Toyota Camry"));
            customers.Add(new Customer("Jane Smith", "9876543210", "Honda Civic"));
            customers.Add(new Customer("Bob Johnson", "5551234567", "Ford Mustang"));
            customers.Add(new Customer("Alice Brown", "9998887777", "Chevrolet Malibu"));
            customers.Add(new Customer("Charlie Davis", "1112223333", "Tesla Model S"));

            Console.WriteLine("enter customer's name:");
            string name = Console.ReadLine();
            var query =
                customers
                .Join(
                    cars,
                    customer => customer.CarModel,
                    car => car.Brand + " " + car.Model,
                    (customer, car) => new
                    {
                        name = customer.Name,
                        phone = customer.PhoneNumber,
                        carBrand = car.Brand,
                        carModel = car.Model,
                        carManufactureYear = car.ManufactureYear,
                        carColor = car.Color,
                    }
                    )
                    .Where(customer => customer.name == name);
            foreach (var item in query)
            {
                Console.WriteLine("Name: " + item.name + "\tPohone number: " + item.phone +
                    "\nCar: " + item.carBrand + " " + item.carModel + "\tYear of manufacture:" + item.carManufactureYear + "\tColor of car: " + item.carColor);
            }
        }
        
        private static void Main(string[] args)
        {
            Task2Test();
        }
    }
}
