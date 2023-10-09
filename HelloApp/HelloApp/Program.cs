DoOperation(10, 5, Operation.Add);
DoOperation(10, 5, Operation.Subtract);
DoOperation(10, 5, Operation.Multiply);
DoOperation(10, 5, Operation.Divide);
void DoOperation(double x, double y, Operation op)
{
    double result = op switch
    {
        Operation.Add => x + y,
        Operation.Subtract => x - y,
        Operation.Multiply => x * y,
        Operation.Divide => x / y
    };
    Console.WriteLine(result);
}
enum Operation
{
    Add,
    Subtract,
    Multiply,
    Divide
}