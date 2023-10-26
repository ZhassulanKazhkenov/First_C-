//ОПП наследование

//Наследование
/*
Person person = new Person { Name = "Zhas" };
person.Print();
Person azi = new Employee { Name = "Aziza" };
azi.Print();
class Person
{
    private string _name = "";
    public string Name
    { 
        get { return _name; } 
        set { _name = value; }
    }
    public void Print()
    {
        Console.WriteLine(Name);
    }
}
*/
/*
class Employee : Person
{
}
*/

//Доступ к членам базового класса из класса-наследника
/*
class Employee :Person
{
    public void PrintName()
    {
        Console.WriteLine(Name);
    }
}
*/
//Ключевое слово base

/*

Person person = new Person("Zhasik");
person.Print();
Employee employee = new Employee("Aziza", "Bi-group");
employee.Print();
class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public void Print()
    {
        Console.WriteLine(Name);
    }
}

class Employee : Person
{
    public string Company { get; set; }
    public Employee (string name, string company)
        :base(name)
    {
        Company = company;
    }
}
*/
