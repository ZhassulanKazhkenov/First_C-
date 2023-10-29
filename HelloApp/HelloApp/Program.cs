//Преобразование типов

//Восходящие преобразование. Upcasting
/*
Employee employee = new Employee("Tom", "Google");
Person person = employee;
Console.WriteLine(person.Name);
*/
//Нисходящие преобразования. Downcasting
Employee employee1 = new Employee("Tom", "Zepter");
Person person = employee1;
Employee employee2 = (Employee)person;
class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public void Print()
    {
        Console.WriteLine($"Person {Name}");
    }
}
class Employee : Person
{
    public string Company { get; set;}
    public  Employee(string name, string company) : base(name)
    {
        Company = company;
    }
}

class Client : Person
{
    public string Bank { get; set; }
    public Client(string name, string bank) : base(name)
    {
        Bank = bank;
    }
}
//Наследование


//Доступ к членам базового класса из класса-наследника

//Ключевое слово base