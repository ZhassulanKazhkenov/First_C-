//Events
/*
Account account = new Account(100);
account.Put(20);
Console.WriteLine($"Сумма на счете: {account.Sum}");
account.Take(70);
Console.WriteLine($"Сумма на счете: {account.Sum}");
account.Take(180);
Console.WriteLine($"Сумма на счете: {account.Sum}");
class Account
{
    public int Sum { get; private set; }
    public Account(int sum) => Sum = sum;
    public void Put(int sum)
    {
        Sum += sum;
        Console.WriteLine($"На счет поступило: {sum}");
    }
    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= Sum;
        }
    }
}
*/
/*
Account account = new Account(100);
account.Notify += DisplayMessage;
account.Put(20);
Console.WriteLine($"Сумма на счете: {account.Sum}");
account.Take(70);
Console.WriteLine($"Сумма на счете: {account.Sum}");
account.Take(180);
Console.WriteLine($"Сумма на счете: {account.Sum}");

void DisplayMessage(string message) => Console.WriteLine(message);
*/
Account account = new Account(100);
account.Notify += DisplayMessage;
account.Notify += DisplayRedMessage;
account.Put(20);
account.Notify -= DisplayRedMessage;
account.Put(50);

void DisplayMessage(string message) => Console.WriteLine(message);
void DisplayRedMessage(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ResetColor();
}

class Account
{
    public delegate void AccountHandler(string message);
    public event AccountHandler? Notify;

    public Account(int sum) => Sum = sum;
    public int Sum { get; private set; }
    public void Put(int sum)
    {
        Sum += sum;
        Notify?.Invoke($"На счет поступило: {sum}");
    }
    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= Sum;
            Notify?.Invoke($"Со счета снято: {Sum}");
        }
        else
        {
            Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
        }
    }
}

