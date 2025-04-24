using System;

class Car
{
    static void Main()
    {
        Car myCar = new Car();      // создаём объект
        myCar.Print();          // вызываем метод для вывода информации

        // Можно также изменить значения полей:
        myCar.brand = "BMW";
        myCar.model = "X5";
        myCar.year = 2023;

        Console.WriteLine("\nОбновлённая информация:");
        myCar.Print();
    }
}