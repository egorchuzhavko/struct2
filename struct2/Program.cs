static void Show(Computer comp)
{
    Console.WriteLine($"Имя: {comp.name}\nЧастота: {comp.frequency}\nОбъем ОЗУ: {comp.volume}" +
        $"\nНаличие DVD ROM: {comp.dvd}\nСтоимость: {comp.price}\n");
}

Computer comp1 = new Computer();
comp1.name = "Genius";
comp1.frequency = 2.7;
comp1.volume = 8;
comp1.dvd = true;
comp1.price = 2000;
Computer comp2 = new Computer();
comp2.name = "owo";
comp2.frequency = 3.8;
comp2.volume = 148;
comp2.dvd = true;
comp2.price = 80000;
Computer comp3 = new Computer();
comp3.name = "Tuntunpum";
comp3.frequency = 3.9;
comp3.volume = 16;
comp3.dvd = false;
comp3.price = 35000;
int count = 0;
if (comp1.volume > 10)
{
    count++;
    Show(comp1);
}
if(comp2.volume > 10)
{
    count++;
    Show(comp2);
}
if(comp3.volume > 10)
{
    count++;
    Show(comp3);
}
Console.WriteLine($"Кол-во компьютеров с объемом оперативной памяти больше 10 Гбайт = " + count);