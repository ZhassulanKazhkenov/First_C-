// See https://aka.ms/new-console-template for more information
/*
    Работа с консольем
 */
/*
{
    string hello = "Привет мир";
    Console.WriteLine(hello);
    Console.WriteLine("Добро пожаловать в C#!");
    Console.WriteLine("Пока мир...");
    Console.WriteLine(24.5);
}
{
    string name = "Tom";
    int age = 34;
    double heigth = 1.7;
    Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {heigth}m");

    Console.WriteLine("Имя: {0} Возраст: {2} Рост: {1}m", name, heigth, age);
    
    Console.Write($"Имя: {name} Возраст: {age} Рост: {heigth}m");
}

{
    Console.Write("Введите свое имя: ");
    string? name = Console.ReadLine();
    Console.WriteLine($"Привет {name}");
}
*/
{
    Console.Write("Введите имя: ");
    string? name = Console.ReadLine();

    Console.Write("Введите возраст: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите рост: ");
    double heigth = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите размер зарплаты: ");
    decimal salary = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {heigth}м Зарплата: {salary}$");
}