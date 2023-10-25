//Псевдонимы типов и статический импорт

//Псевдонимы типов

using pechat = System.Console;
using User = Person;

User tom = new User("Tom");
pechat.WriteLine(tom.Name);

class Person
{
    public string Name { get; set; }
    public Person(string name) => Name = name;
}

//Статический импорт:
/*
using static System.Console;
using static Operation;
 
WriteLine(Sum(5, 4));       // 9
WriteLine(Subtract(5, 4));  // 1
WriteLine(Multiply(5, 4)); // 20

static class Operation
{
    public static int Sum(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
}
*/