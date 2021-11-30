static void Show(Car car)
{
    Console.WriteLine($"Марка: {car.Marka}\nПроизводитель: {car.Producer}\nТип: {car.Type}\n" +
        $"Год выпуска: {car.Year}\nДата регистрации: {car.date.ToShortDateString()}\n");
}

Car car1 = new Car();
Car car2 = new Car();
Car car3 = new Car();

car1.Marka = "R8";
car1.Producer = "Audi";
car1.Type = "Sport car";
car1.Year = 2020;
car1.date = new DateTime(2020, 05, 05);

car2.Marka = "kopeyka";
car2.Producer = "Lada";
car2.Type = "Sport car";
car2.Year = 2000;
car2.date = new DateTime(2000, 11, 11);

car3.Marka = "m5";
car3.Producer = "BMW";
car3.Type = "Sport car";
car3.Year = 2019;
car3.date = new DateTime(2019, 10, 10);

if(car1.Year<2005 & car1.date.Year == car1.Year)
{
    Show(car1);
}
if (car2.Year < 2005 & car2.date.Year == car2.Year)
{
    Show(car2);
}
if (car3.Year < 2005 & car3.date.Year == car3.Year)
{
    Show(car3);
}