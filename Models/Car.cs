namespace RacingGarage.Models;

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double FuelLevel { get; set; }

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