/*
void SayHello()
{
    Console.WriteLine("Hello");
}

SayHello();
*/

void SayHelloRu()
{
    Console.WriteLine("Привет");
}
void SayHelloEn()
{
    Console.WriteLine("Hello");
}

void SayHelloFr()
{
    Console.WriteLine("Salut");
}

string language = "en";

switch (language)
{
    case "en":
        SayHelloEn();
        break;
    case "ru":
        SayHelloRu();
        break;
    case "fr":
        SayHelloFr();
        break;
}

void SayHello() => Console.WriteLine("Hello");
SayHello();