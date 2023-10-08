/*
void Increment (int n)
{
    n++;
    Console.WriteLine($"Число в методе Increment: {n}");
}
*/
void Increment(ref int n)
{
    n++;
    Console.WriteLine($"Число в методе Increment: {n}");
}

int number = 5;
Console.WriteLine($"Число до методе Increment: {number}");
Increment(ref number);
Console.WriteLine($"Число после метода Increment: {number}");

void Sum(int x, int y, out int result)
{
    result = x + y;
}

int num;
Sum(10, 15, out num);
Console.WriteLine(num);
/*
void GetRectangleData(int width, int heigth, out int rectArea, out int rectPerimetr)
{
    rectArea = width * heigth;
    rectPerimetr = (width + heigth) * 2;
}

GetRectangleData(10, 20, out var area, out var perimetr);
Console.WriteLine(area);
Console.WriteLine(perimetr);
*/
void GetRectangleData(in int width,in int heigth, out int rectArea, out int rectPerimetr)
{
    rectArea = width * heigth;
    rectPerimetr = (width + heigth) * 2;
}
int w = 10;
int h = 20;

GetRectangleData(w, h, out var area, out var perimetr);

Console.WriteLine(area);
Console.WriteLine(perimetr);

