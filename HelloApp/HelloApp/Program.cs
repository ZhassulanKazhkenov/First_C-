/*
Person tom = new();
Person bob = new("Bob");
Person sam = new("Sam", 25);

tom.Print();          // Имя: Неизвестно  Возраст: 18
bob.Print();          // Имя: Bob  Возраст: 18
sam.Print();

class Person
{
    public string name;
    public int age;
    public Person() : this("Неизвестно")    // первый конструктор
    { }
    public Person(string name) : this(name, 18) // второй конструктор
    { }
    public Person(string name, int age)     // третий конструктор
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}
*/
Person tom = new Person { name = "Tom", company = { title = "Microsoft" } };
tom.Print();          // Имя: Tom  Компания: Microsoft

class Person
{
    public string name;
    public Company company;
    public Person()
    {
        name = "Undefined";
        company = new Company();
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Компания: {company.title}");
}

class Company
{
    public string title = "Unknown";
}