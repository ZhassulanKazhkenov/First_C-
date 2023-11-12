//Exception Handling
//Construction try..catch..finally
/*
try
{
    int x = 5;
    int y = x / 0;
    Console.WriteLine($"Результат: {y}");
}
catch
{
    Console.WriteLine("Возникло исключение!");
}
finally
{
    Console.WriteLine("Блок finally");
}
Console.WriteLine("Конец программы");
*/
//Exception handling and conditional constructions

Square("12"); // Квадрат числа 12: 144
Square("ab"); // Некорректный ввод

void Square(string data)
{
    if (int.TryParse(data, out var x))
    {
        Console.WriteLine($"Квадрат числа {x}: {x * x}");
    }
    else
    {
        Console.WriteLine("Некорректный ввод");
    }
}