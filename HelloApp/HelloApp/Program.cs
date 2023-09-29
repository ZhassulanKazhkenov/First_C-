/*
int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int i in numbers)
{
    Console.WriteLine(i);
}
*/

/*
int[] numbers = { 1, 2, 3, 4, 5 };
for (int i = 0; i<numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
*/
/*
int[] numbers = { 1, 2, 3, 4, 5 };
for (int i = 0; i < numbers.Length; i++)
{
        numbers[i] = numbers[i] * 2;
    Console.WriteLine(numbers[i]);
}
*/
/*
int[] numbers = { 1, 2, 3, 4, 5 };
int i = 0;
while(i < numbers.Length)
{
    Console.WriteLine(numbers[i]);
    i++;
}
*/
/*
int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };

int rows = numbers.GetUpperBound(0)+1;
int columns = numbers.GetUpperBound(1)+1;
for (int i = 0; i < rows; i++)
{
    for(int j = 0; j < columns; j++)
    {
        Console.Write($"{numbers[i, j]} \t");
    }
    Console.WriteLine();
}
*/

int[][] numbers = new int[3][];
numbers[0]=new int[] {1,2};
numbers[1] = new int[] { 1, 2, 3 };
numbers[2] = new int[] { 1, 2, 3, 4, 5 };

for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < numbers[i].Length; j++)
    {
        Console.Write($"{numbers[i][j]} \t");
    }
    Console.WriteLine();
}