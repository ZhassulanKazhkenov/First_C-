//Creating exception classes
using System.Net.Cache;
/*
try
{
    Person person = new Person { Name = "Zhas", Age = 17 };
}
catch(Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

class Person
{
    private int age;
    public string Name { get; set; } = "";
    public int Age
    {
        get => age;
        set
        {
            if (value < 18)
                throw new Exception("Лицам до 18 регистрация запрещена");
            else
                age = value;
        }
    }
}
*/
/*
try
{
    Person person = new Person { Name = "Tom", Age = 17 };
}
catch (PersonException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

class Person
{
    private int age;
    public string Name { get; set; } = "";
    public int Age
    {
        get => age;
        set
        {
            if (value < 18)
                throw new PersonException("Лицам до 18 регистрация запрещена");
            else
                age = value;
        }
    }
}


class PersonException : Exception
{
    public PersonException(string message)
        : base(message) { }
}
*/

try
{
Person person = new Person { Name = "Tom", Age = 17 };
}
catch (PersonException ex)
{
Console.WriteLine($"Ошибка: {ex.Message}");
Console.WriteLine($"Некорректное значение: {ex.Value}");
}

class Person
{
    private int age;
    public string Name { get; set; } = "";
    public int Age
    {
        get => age;
        set
        {
            if (value < 18)
                throw new PersonException("Лицам до 18 регистрация запрещена", value);
            else
                age = value;
        }
    }
}

class PersonException : ArgumentException
{
    public int Value { get; }
    public PersonException(string message, int val)
        : base(message)
    {
        Value = val;
    }
}
