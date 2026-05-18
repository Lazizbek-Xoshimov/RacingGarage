using RacingGarage.Models;

namespace RacingGarage;

public class Program
{
    public static void Main(string[] args)
    {
        Car[] cars = new Car[]
        {
            new Car()
            {
                Brand = "Honda",
                Model = "Civic",
                Year = 1972,
                FuelLevel = 50
            },
            new Car()
            {
                Brand = "Ford",
                Model = "F-Series",
                Year = 1948,
                FuelLevel = 100
            },
            new Car()
            {
                Brand = "Toyota",
                Model = "Corolla",
                Year = 1966,
                FuelLevel = 0
            }
        };

        foreach (Car car in cars)
        {
            car.ShowInfo();
            Console.WriteLine();
        }


        foreach (Car car in cars)
        {
            Console.Write($"{car.Model} bilan necha km yurmoqchisiz: ");
            car.Distance = int.Parse(Console.ReadLine());
            Console.WriteLine($"{car.Drive()}");
            Console.WriteLine();
        }


        foreach (Car car in cars)
        {
            Console.Write($"{car.Model} ga qancha yoqilg'i quymoqchisiz: ");
            double amount = double.Parse(Console.ReadLine());
            Console.WriteLine($"{amount} yoqilg'i quygandan so'ng: {car.Rufuel(amount)}% yoqilg'i bo'ldi.");
            Console.WriteLine();
        }
    }
}