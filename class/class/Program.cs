using System.Reflection;
Car myCar = new Car();
myCar.Print();
class Car
{
    public string brand = "Toyota";
    public string model = "Camry";
    public int year = 2020;


    public void Print()
    {
        Console.WriteLine($"marka: {brand}");
        Console.WriteLine($"model: {model}");
        Console.WriteLine($"vipusk: {year}");
    }

}
