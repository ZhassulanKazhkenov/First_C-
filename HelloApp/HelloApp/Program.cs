//Различие переопределения и скрытия методов
//Переопределение

Person tom = new Employee("Tom", "Microsoft");
tom.Print();
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
    public Employee(string name, string company) : base(name)
    {
        Company = company;
    }

    public new void Print()
    {
        Console.WriteLine($"{Name} работает в {Company}");
    }
}
//Скрытие
