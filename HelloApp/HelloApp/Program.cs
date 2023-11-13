//Types of exceptions. Exception class
 
try
{
    int x = 5;
    int y = x / 0;
    Console.WriteLine($"Результат: {y}");
}
catch (Exception ex)
{
    Console.WriteLine($"Исключение: {ex.Message}");
    Console.WriteLine($"Метод: {ex.TargetSite}");
    Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
}

try
{
    object obj = "you";
    int num = (int)obj;     // System.InvalidCastException
    Console.WriteLine($"Результат: {num}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Возникло исключение DivideByZeroException");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Возникло исключение IndexOutOfRangeException");
}
catch (Exception ex)
{
    Console.WriteLine($"Исключение: {ex.Message}");
}