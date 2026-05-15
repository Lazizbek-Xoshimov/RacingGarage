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
}