// See https://aka.ms/new-console-template for more information
/*
 { 
    Console.Write("Введите число x:");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число y:");
    int y = Convert.ToInt32(Console.ReadLine());
    if (x > y)
    {
        Console.WriteLine($"Число {x} больше числа {y}");
    }
    else if (x < y)
    {
        Console.WriteLine($"Число {x} меньше числа {y}");
    }
    else
    {
        Console.WriteLine("Число x равно числу y");
    }
}
*/
/*
{
    Console.Write("Введите число x:");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 5 & x < 10)
    {
        Console.WriteLine($"Число больше 5 и меньше 10");
    }
    else
    {
        Console.WriteLine("Неизвестное число");
    }
}
*/
/*
{
    Console.Write("Введите число x:");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x == 5 || x == 10)
    {
        Console.WriteLine($"Число либо равно 5, либо равно 10");
    }
    else
    {
        Console.WriteLine("Неизвестное число");
    }
}
*/
{
    Console.Write("Введите сумму вклада:");
    double x = Convert.ToDouble(Console.ReadLine());
    if (x < 100)
    {
        x += x * 0.05;
    }
    else if (x <= 200)
    {
        x += x * 0.07;
    }
    else
    {
        x += x * 0.1;
    }
    Console.WriteLine($"Сумму вклада после начисления процентов: {x+15}");
}