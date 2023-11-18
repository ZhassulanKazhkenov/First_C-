//Anonymous methods
/*
MessageHandler handler = delegate (string mes)
{
    Console.WriteLine(mes);
};
handler("Hai Hitler!!!");

delegate void MessageHandler(string message);
*/
/*
ShowMessage("hai!", delegate (string mes)
{
    Console.WriteLine(mes);
});

static void ShowMessage(string message, MessageHandler handler)
{
    handler(message);
}

delegate void MessageHandler(string message);
*/
/*
MessageHandler handler = delegate
{
    Console.WriteLine("Слава третьему рейху!!!");
};
handler("hello world!");

delegate void MessageHandler(string message);
*/
/*
Operation operation = delegate (int x, int y)
{
    return x + y;
};
int result = operation(4, 5);
Console.WriteLine(result);

delegate int Operation(int x, int y);
*/
int z = 8;
Operation operation = delegate (int x, int y)
{
    return z + x + y;
};
int result = operation(4, 5);
Console.WriteLine(result);

delegate int Operation(int x, int y);