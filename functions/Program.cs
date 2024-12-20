Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();

if(userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodbay();
}



static void PrintHello() //function / method
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodbay()
{
    Console.WriteLine("See you later, aligator.");
}