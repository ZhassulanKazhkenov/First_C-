/*
 * Person tom = new Person();
tom.Print();

struct Person
{
    public string name = "Zhas";  
    public int age = 1;
    public Person() { } //Вызов конструктора по умолчанию
    public void Print()=> Console.WriteLine($"Имя: {name} Возраст: {age}");
    /*{
        Console.WriteLine($"Имя: {name} Возраст: {age}");
    }
}
*/
/*
Person tom = new Person();
tom.Print();
struct Person
{
    public string name;
    public int age;

    public Person() 
    {
        name = "Tom";
        age = 37;
    }
    public void Print() => Console.WriteLine($"Имя: {name} Возраст: {age}");
}
*/
/*
Person tom = new Person();
Person bob = new Person("Bob");
Person sam = new Person("Sam", 25);

tom.Print();
bob.Print();
sam.Print();

struct Person
{
    public string name;
    public int age;

    public Person() :this("Tom")
    { }
    public Person(string fullName) : this(fullName, 1)
    { }
    public Person(string fullName, int fullAge)
    {
        this.name = fullName;
        this.age = fullAge;
    }
    public void Print() => Console.WriteLine($"Имя: {name} Возраст: {age}");
}
*/
Person tom = new Person { name = "Tom", age = 22};
tom.Print();
struct Person
{
    public string name;
    public int age;
    public void Print() => Console.WriteLine($"Имя: {name} Возраст: {age}");
}