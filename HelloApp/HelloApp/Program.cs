string name = "Alex";
switch (name)
{
    case "Tom":
        Console.WriteLine("Ваше имя - Том");
        break;
    case "Zhas":
        Console.WriteLine("Ваше имя - Zhas");
        break;
    case "John":
        Console.WriteLine("Ваше имя - Том");
        break;
    default:
        Console.WriteLine("Неизвестное имя");
        break;
}

int number = 1;
switch (number)
{
    case 1:
        Console.WriteLine("case 1");
        goto case 5;
    case 3:
        Console.WriteLine("case 3");
        break;
    case 5:
        Console.WriteLine("case 5");
        break;
    default:
        Console.WriteLine("default");
        break;
}
/*
int DoOperation(int op, int a, int b)
{
    switch (op)
    {
        case 1: return a + b;
        case 2: return a - b;
        case 3: return a * b;
        default: return 0;
    }
}
*/
int result1 = DoOperation(1, 10, 5);
Console.WriteLine(result1);

int result2 = DoOperation(4, 10, 5);
Console.WriteLine(result2);

int DoOperation(int op, int a, int b)
{
    int result = op switch
    {
        1 => a + b,
        2 => a - b,
        3 => a * b,
        _ => 0
    };
    return result;
}

int DoOperation1(int op, int a, int b) => op switch
{
        1 => a + b,
        2 => a - b,
        3 => a * b,
        _ => 0
};

int result3 = DoOperation1(2, 10, 5);
Console.WriteLine(result3);

int result4 = DoOperation1(4, 10, 5);
Console.WriteLine(result4);