Console.WriteLine("Choose the appropriate format (f/c):");
string userChoice = Console.ReadLine();

Console.WriteLine("Enter an argument:");
int argument = Int32.Parse(Console.ReadLine());

if (userChoice == "f")
{
    ConvertToFahrenheit(argument);
}
else
{
    ConvertToCelsius(argument);
}



static void ConvertToFahrenheit(int argument)
{
    Console.WriteLine($"{argument * 9 / 5 + 32}");
}

static void ConvertToCelsius(int argument)
{
    Console.WriteLine($"{(argument - 32) * 5 / 9}");
}
