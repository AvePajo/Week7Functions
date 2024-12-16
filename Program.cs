string hello = "Hello, world!";

string panic = "Don´t panic!";

//for(int i = 0; i < 5; i++)
//{
//    Console.WriteLine(hello);
//}

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(panic);
//}

PrintStringFiveTimes(hello);
PrintStringFiveTimes(panic);
PrintStringFiveTimes("Ave");

static void PrintStringFiveTimes(string someString)
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(someString);
    }
}