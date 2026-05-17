namespace RacingGarage.Models;

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year {
        get
        {
            return this.Year;
        }
        set
        {
            if (value < 1900)
                Console.WriteLine("Juda eski mashina.");
            else if (value > DateTime.Now.Year)
                Console.WriteLine("Hali bunday mashina chiqarilmagan.");
            else
                this.Year = value;
        }
    }
    public double FuelLevel 
    {
        get
        {
            return this.FuelLevel;
        }
        set
        {
            if (value < 0)
                Console.WriteLine("Yoqilg'i miqdori manfiy qiymatni olmaydi.");
            else if (value > 100)
                Console.WriteLine("Yoqilg'i 100% dan ko'p bo'la olmaydi.");
            else
                this.FuelLevel = value;
        } 
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Mashina brendi: {this.Brand}\nMashina modeli: {this.Model}\nMashina ishlab chiqarilgan yili: {this.Year}\nMashina yoqilg'isi: {this.FuelLevel}");
    }

    public string Drive(int distance)
    {
        if (FuelLevel <= 0)
        {
            return "Yoqilg'i yetarli emas.";
        }
        else
        {
            while (distance >= 10)
            {
                FuelLevel --;
                distance -= 10;
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