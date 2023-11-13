//Catch block and exception filters
//Block Definition Catch
/*
try
{
    int x = 5;
    int y = x / 0;
    Console.WriteLine($"Результат: {y}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Возникло исключение DivideByZeroException");
}
*/
try
{
    int x = 5;
    int y = x / 0;
    Console.WriteLine($"Результат: {y}");
}
catch(DivideByZeroException ex)
{
    Console.WriteLine($"Возникло исключение {ex.Message}");
}

//Exception Filters

int q = 1;
int w = 0;

try
{
    int result3 = q / w;
    int result4 = w / q;
}
catch(DivideByZeroException) when (w == 0)
{
    Console.WriteLine("w не должен равен 0");
}
catch(DivideByZeroException ez)
{
    Console.WriteLine(ez.Message);
}

int a = 0;
int b = 1;

try
{
    int result5 = a / b;
    int result6 = b / a;
}
catch (DivideByZeroException) when (b == 0)
{
    Console.WriteLine("b не должен равен 0");
}
catch (DivideByZeroException ez)
{
    Console.WriteLine(ez.Message);
}

