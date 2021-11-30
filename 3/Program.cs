static void Show(ZNAK el)
{
    Console.WriteLine($"Имя: {el.Name}\nЗнак зодиака: {el.ZOD}\nДата рождения: {el.DATE.ToShortDateString()}\n");
}

ZNAK[] mass = new ZNAK[10];

for (int i = 0; i < 10; i++)
{
    mass[i] = new ZNAK();
    Console.Write("Введите имя и фамилию: ");
    mass[i].Name = Console.ReadLine();
    Console.Write("Введите знак зодиака: ");
    mass[i].ZOD = Console.ReadLine();
    Console.WriteLine("Введите дату рождения в формате гггг.мм.дд: ");
    mass[i].DATE = new DateTime(Convert.ToInt32(Console.ReadLine().Split(".")));
}

for (int i = 0; i < 10; i++)
    Show(mass[i]);

for(int i = 1; i < 10; i++)
{
    for(int j = 0; j < 9; j++)
    {
        if (mass[j].DATE > mass[j].DATE)
            (mass[j], mass[j + 1]) = (mass[j + 1], mass[j]);
    }
}

for (int i = 0; i < 10; i++)
    Show(mass[i]);