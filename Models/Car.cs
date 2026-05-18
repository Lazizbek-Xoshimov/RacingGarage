using System.Runtime.CompilerServices;

namespace RacingGarage.Models;

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    private int _year;
    public int Year {
        get
        {
            return this._year;
        }
        set
        {
            if (value < 1900)
                Console.WriteLine("Juda eski mashina.");
            else if (value > DateTime.Now.Year)
                Console.WriteLine("Hali bunday mashina chiqarilmagan.");
            else
                this._year = value;
        }
    }
    private double _fuelLevel;
    public double FuelLevel 
    {
        get
        {
            return this._fuelLevel;
        }
        set
        {
            if (value < 0)
                Console.WriteLine("Yoqilg'i miqdori manfiy qiymatni olmaydi.");
            else if (value > 100)
                Console.WriteLine("Yoqilg'i 100% dan ko'p bo'la olmaydi.");
            else
                this._fuelLevel = value;
        } 
    }
    private int _speed;
    public int Speed
    {
        get
        {
            return this._speed;
        }
        set
        {
            if (value < 0)
                Console.WriteLine("Tezlik manfiy qiymat olmaydi.");
            else if (value > 250)
                Console.WriteLine("Mashina bunday tezlikda yura olmaydi.");
            else
                this._speed = value;
        }
    }
    private int _distance;
    public int Distance
    {
        get
        {
            return this._distance;
        }
        set
        {
            if (value < 0)
                Console.WriteLine("Masofa manfiy qiymat olishi mumkin emas.");
            else 
                this._distance = value;
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Mashina brendi: {this.Brand}\nMashina modeli: {this.Model}" + 
            $"\nMashina ishlab chiqarilgan yili: {this.Year}\nMashina yoqilg'isi: {this.FuelLevel}\nMashina maksimal tezligi: {this.Speed}");
    }

    public string Drive()
    {
        if (FuelLevel <= 0)
        {
            return "Yoqilg'i yetarli emas.";
        }
        else
        {
            while (Distance >= 10)
            {
                FuelLevel --;
                Distance -= 10;
            }

            return $"{FuelLevel}% yoqilg'i qoldi.";
        }
    }

    public double Rufuel(double amount)
    {
        while (amount > 0)
        {   
            if (FuelLevel == 100)
            {
                Console.WriteLine("Yoqilg'i to'la.");
                return FuelLevel;
            }

            FuelLevel ++;
            amount --;
        }

        return FuelLevel;
    }

    private static void RacingLight()
    {
        DateTime waitingTime = DateTime.Now.AddSeconds(5);
        int count = DateTime.Now.Second;

        while (count < waitingTime.Second)
        {
            if (count == DateTime.Now.Second)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("O|O|O|O|O");
                Console.ResetColor();
                Console.WriteLine("O|O|O|O|O");
                Console.WriteLine("O|O|O|O|O");
                Console.WriteLine("\nDiqqat!");
                count ++;
            }
        }

        waitingTime = DateTime.Now.AddSeconds(5);
        count = DateTime.Now.Second;

        while (count < waitingTime.Second)
        {
            if (count == DateTime.Now.Second)
            {
                Console.Clear();
                Console.WriteLine("O|O|O|O|O");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("O|O|O|O|O");
                Console.ResetColor();
                Console.WriteLine("O|O|O|O|O");
                Console.WriteLine("\nTayyorlaning!");
                count ++;
            }
        }

        waitingTime = DateTime.Now.AddSeconds(5);
        count = DateTime.Now.Second;

        while (count < waitingTime.Second)
        {
            if (count == DateTime.Now.Second)
            {
                Console.Clear();
                Console.WriteLine("O|O|O|O|O");
                Console.WriteLine("O|O|O|O|O");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("O|O|O|O|O");
                Console.ResetColor();
                Console.WriteLine("\nOLG'A!!!");
                count ++;
            }
        }
    }

    public static Car ComparisonSpeed(Car[] cars)
    {
        Car fastestCar = new Car();
        fastestCar.Speed = 0;

        foreach (Car car in cars)
        {
            if (fastestCar.Speed < car.Speed)
                fastestCar = car;
        }

        return fastestCar;
    }

    public static void RacingCars(Car[] cars)
    {
        foreach (Car car in cars)
        {
            if (car.FuelLevel > 0)
                Console.WriteLine($"{car.Model} poyga uchun tayyor...");
            else
                Console.WriteLine($"{car.Model} yoqilg'isi yetarli emas.");
        }

        RacingLight();

        int cursor = 10;

        Console.Clear();
        for (int i = 0; i < 10; i++)
        {
            if (cursor == 10)
            {
                Console.WriteLine($"{cars[0].Model}");
                Console.WriteLine($"{cars[1].Model}");
                Console.WriteLine($"{cars[2].Model}");
            }

            DateTime waitingTime = DateTime.Now.AddSeconds(2);
            int count = DateTime.Now.Second;

            while (count < waitingTime.Second)
            {
                if (count == DateTime.Now.Second)
                {
                    Console.SetCursorPosition(cursor, 0);
                    Console.Write("**");
                    Console.SetCursorPosition(cursor, 1);
                    Console.Write("**");
                    Console.SetCursorPosition(cursor, 2);
                    Console.Write("**");
                    
                    count ++;
                }
            }

            cursor += 2;
        }

        Console.WriteLine($"\n{ComparisonSpeed(cars).Model} yutdi.");
    }
}