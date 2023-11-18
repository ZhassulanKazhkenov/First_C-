//Lambdas
/*
Message hello = () => Console.WriteLine("Hello Pidr!!!");
hello();
hello();
hello();
*/
/*
Message hello = () =>
{
    Console.WriteLine("Hi ");
    Console.WriteLine("Hitler!!!");
};

hello();

delegate void Message();
*/
/*
var hello = () => Console.WriteLine("Hello");
hello();
hello();
hello();
*/
Operation sum = (x, y) => Console.WriteLine($"{x}+{y} = {x + y}");
sum(1,2);
sum(22,14);

delegate void Operation(int x, int y);
