//Абстрактные классы и члены классов
//Абстрактные классы
/*
Transport car = new Car("машина");
Transport ship = new Ship("корабль");
Transport aircraft = new Aircraft("самолет");

car.Move();         // машина движется
ship.Move();        // корабль движется
aircraft.Move();    // самолет движется
abstract class Transport
{
    public string Name { get; }
    // конструктор абстрактного класса Transport
    public Transport(string name)
    {
        Name = name;
    }
    public void Move() => Console.WriteLine($"{Name} движется");
}
// класс корабля
class Ship : Transport
{
    // вызываем конструктор базового класса
    public Ship(string name) : base(name) { }
}
// класс самолета
class Aircraft : Transport
{
    public Aircraft(string name) : base(name) { }
}
// класс машины
class Car : Transport
{
    public Car(string name) : base(name) { }
}
*/
//Абстрактные методы

Transport car = new Car();
Transport ship = new Ship();
Transport aircraft = new Aircraft();

car.Move();         // машина едет
ship.Move();        // корабль плывет
aircraft.Move();    // самолет летит

abstract class Transport
{
    public abstract void Move();
}
// класс корабля
class Ship : Transport
{
    // мы должны реализовать все абстрактные методы и свойства базового класса
    public override void Move()
    {
        Console.WriteLine("Корабль плывет");
    }
}
// класс самолета
class Aircraft : Transport
{
    public override void Move()
    {
        Console.WriteLine("Самолет летит");
    }
}
// класс машины
class Car : Transport
{
    public override void Move()
    {
        Console.WriteLine("Машина едет");
    }
}
