//Делегаты
/*
Message mes;
mes = Hello;
mes();

void Hello() => Console.WriteLine("Hello Metanit.com");

delegate void Message();
*/

Message message1 = Welcome.Print;
Message message2 = new Hello().Display;

message1();
message2();

delegate void Message();

class Welcome
{
    public static void Print() => Console.WriteLine("Welcome");
}
class Hello
{
    public void Display() => Console.WriteLine("Привет");
}
