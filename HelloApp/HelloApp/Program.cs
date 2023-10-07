using System.Threading.Tasks.Sources;

void PrintMessage(string message)
{
    Console.WriteLine(message);
}

PrintMessage("Hello work");
PrintMessage("Hello java");
PrintMessage("Hello c#");

/*void Sum(int x, int y)
{
    int result = x + y;
    Console.WriteLine($"{x} + {y} = {result}");
}
*/
void Sum(int x, int y) => Console.WriteLine($"{x} + {y} = { x + y }");
int a = 10, b = 15, c = 6;
Sum(10, 15);
Sum(a, b);
Sum(4, c);
Sum(5, 5+a);

/*void PrintPerson(string name, int age)
{
    Console.WriteLine($"Name: {name} Age: {age}");
}

byte z = 45;
PrintPerson("Tom", z);
*/

void PrintPerson(string name, int age = 1, string company = "Undefined")
{
    Console.WriteLine($"Name: {name} Age: {age} Company: {company}");
}

PrintPerson("Tom", 37, "HP");
PrintPerson("Tom", 37);
PrintPerson("Tom");

PrintPerson("Jerry", company: "Google", age: 56);
PrintPerson(age: 33, name: "Zhassulan");
PrintPerson(company: "Google", age: 56, name: "Aza");