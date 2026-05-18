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
            $"\nMashina ishlab chiqarilgan yili: {this.Year}\nMashina yoqilg'isi: {this.FuelLevel}");
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
}