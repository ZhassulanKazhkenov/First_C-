//Скрытие методов и свойств
/*
Person bob = new Person("Bob");
bob.Print();
Employee tom = new Employee("Tom", "Google");
tom.Print();
*/
/*
    class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
        public void Print() 
        {
            Console.WriteLine($"Name: {Name}");
        }
}
class Employee : Person
{
    public string Company { get; set; }
    public Employee(string name, string company) : base(name)
    {
        Company = company;
    }
    public new void Print()
    {
        Console.WriteLine($"Name: {Name} Company: {Company}");
    }
}
*/
//Скрытие свойств
/*
Person bob = new Person("Bob");
Console.WriteLine(bob.Name);    // Bob

Employee tom = new Employee("Tom", "Microsoft");
Console.WriteLine(tom.Name);    // Mr./Ms. Tom

class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
}
class Employee : Person
{
    // скрываем свойство Name базового класса
    public new string Name
    {
        get => $"Mr./Ms. {base.Name}";
        set => base.Name = value;

    }
    public string Company { get; set; }
    public Employee(string name, string company)
                : base(name)
    {
        Company = company;
    }
}
*/
//Скрытие переменных и констант
Console.WriteLine(Person.minAge);     // 1
Console.WriteLine(Person.typeName);   // Person

Console.WriteLine(Employee.minAge);     // 18
Console.WriteLine(Employee.typeName);   // Employee

class Person
{
    public readonly static int minAge = 1;
    public const string typeName = "Person";
}
class Employee : Person
{
    // скрываем поля и константы базового класса
    public new readonly static int minAge = 18;
    public new const string typeName = "Employee";
}