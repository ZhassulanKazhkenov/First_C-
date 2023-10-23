//Константы, поля и структуры для чтения

//Константы классы
/*
Person zhas = new Person();
zhas.name = "Aziza";
zhas.Print();

Console.WriteLine(Person.type);
//Person.type = "Human";
class Person
{
    public const string type = "Person";
    public string name = "Astana";
    public void Print()
    {
        Console.WriteLine($"{type}: {name}");
    }
}
*/

/*
//Поля для чтения и модификатор readonly:

Person zhas = new Person("Aziza");
Console.WriteLine(zhas.name);
//zhas.name = "Jax";

class Person
{
    public readonly string name = "Undefined";
    public Person(string fullName)
    { 
        name = fullName;
    }
    public void ChangeName(string otherName)
    {
        //name = otherName;
    }
}
*/

//Структуры для чтения
/*
readonly struct Person
{
    public readonly string Name;
    public Person(string fullName)
    {
        Name = fullName;
    }
}
*/
readonly struct Person
{
    public readonly string Name { get; }
    public int Age { get; }
    public Person(string fullName, int fullAge)
    {
        Name = fullName;
        Age = fullAge;
    }
}