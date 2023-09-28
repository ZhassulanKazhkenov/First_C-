/*
for (var i = 1; i<4; i++)
{
    Console.WriteLine(i);
}
*/
/*
for (var i = 1; i < 4; i++)
    Console.WriteLine(i);
*/
/*
for (var i = 1; i < 4; i++) Console.WriteLine(i);
*/
/*
var i = 1;

for (Console.WriteLine("Начало выполнения цикла") ; i < 4; Console.WriteLine($"i={i}"))
{
    i++;
}
*/
/*
int i = 6;

do
{
    Console.WriteLine(i);
    i--;
}
while (i > 0);
*/
/*
int i = 6;

while (i > 0)
{
    Console.WriteLine(i);
    i--;
}
*/
/*
foreach(var c in "Tom")
{
    Console.WriteLine(c);
}
*/
/*
for (int i=0; i<9; i++)
{
    if (i == 5)
        break;
    Console.WriteLine(i);
}
*/
/*
for (int i = 0; i < 9; i++)
{
    if (i == 5)
        continue;
    Console.WriteLine(i);
}
*/

for (int i=1; i<10; i++)
{
    for (int j=1; j<10; j++)
    {
        Console.WriteLine($"{i + j} \t");
    }
    Console.WriteLine();
}