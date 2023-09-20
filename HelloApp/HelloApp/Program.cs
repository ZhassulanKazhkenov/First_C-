// See https://aka.ms/new-console-template for more information
{
    int x1 = 5;
    int z1 = ++x1;
    Console.WriteLine($"{x1} - {z1}");
}
{
    int x2 = 5;
    int z2 = x2++;
    Console.WriteLine($"{x2} - {z2}");
}
{
    int x1 = 5;
    int z1 = --x1;
    Console.WriteLine($"{x1} - {z1}");
}
{
    int x2 = 5;
    int z2 = x2--;
    Console.WriteLine($"{x2} - {z2}");
}

{
    int a = 3;
    int b = 5;
    int c = 40;
    int d = c---b * a;
    Console.WriteLine($"a={a} b={b} c={c} d={d}");
}
{
    int a = 3;
    int b = 5;
    int c = 40;
    int d = (c-(--b)) * a;
    Console.WriteLine($"a={a} b={b} c={c} d={d}");
}