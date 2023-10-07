/*
string GetMessage()
{
    return "Hello";
}
*/
void PrintMessage(string message)
{
    Console.WriteLine(message);
}
PrintMessage(GetMessage());
/*
int Sum(int x, int y)
{
    return x + y;
}
*/
int result = Sum(10, 15);
Console.WriteLine(result);
Console.WriteLine(Sum(5, 6));

string GetMessage() => "hello";
int Sum(int x, int y) => x + y;

string GetHello()
{
    return "Hello";
    Console.WriteLine("After return");
}
GetHello();

void PrintPerson(string name, int age)
{
    if (age > 120 || age < 1)
    {
        Console.WriteLine("Недопустимый  возраст");
        return;
    }
    Console.WriteLine($"Имя: {name} Возраст {age}");
}

PrintPerson("Tom", 38);
PrintPerson("Timmy", 1234);