// See https://aka.ms/new-console-template for more information

{
    int x1 = 2;
    int y1 = 5;
    Console.WriteLine(x1&y1);
}
{
    int x2 = 4;
    int y2 = 5;
    Console.WriteLine(x2 & y2);
}
{
    int x1 = 2;
    int y1 = 5;
    Console.WriteLine(x1 | y1);
}
{
    int x2 = 4;
    int y2 = 5;
    Console.WriteLine(x2 | y2);
}

{
    int x = 45;
    int key = 102;
    int encrypt = x ^ key;
    Console.WriteLine($"Зашифрованное число: {encrypt}");
    int decrypt = encrypt ^ key;
    Console.WriteLine($"Расшифрованное число: {decrypt}");
}
{
    int x = 12;
    Console.WriteLine(~x);
}
{
    int x = 12;
    int y = ~x;
    y += 1;
    Console.WriteLine(y);
}

{
    int a = 16;
    int b = 2;
    int c = a << b;
    Console.WriteLine(c);
    int d = a >> b;
    Console.WriteLine(d);
}
{
    int a = 22;
    int b = 2;
    int c = a << b;
    Console.WriteLine(c);
    int d = a >> b;
    Console.WriteLine(d);
}
{
    int value1 = 3;
    int value2 = 2;
    int value3 = 1;
    int result = 0b0000_0000;
    result = result | value1;
    result = result << 2;
    result = result | value2;
    result = result << 2;
    result = result | value3;

    Console.WriteLine(result);

    result = 0b0011_1001;
    int newValue3 = result & 0b000_0011;
    result = result >> 2;
    int newValue2 = result & 0b000_0011;
    result = result >> 2;
    int newValue1 = result & 0b000_0011;
    Console.WriteLine(newValue1);
    Console.WriteLine(newValue2);
    Console.WriteLine(newValue3);
}