namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        // This is a comment where I can describe what happens next.
        // TODO: hi 
        // Console.WriteLine("Hello, World!");
        // Console.WriteLine("What is your name?");
        // var name = Console.ReadLine();
        // var currentDate = DateTime.Now;
        // Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
        // Console.Write($"{Environment.NewLine}Press any key to exit...");
        // Console.ReadKey(true);

        Console.WriteLine("What kind of thing are we talkinmg about?");
        string a = Console.ReadLine();
        Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
        string b = Console.ReadLine();
        string c = "Doom";
        string d = "3000";
        Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + '!');
        // Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
        // Console.Write($"{Environment.NewLine}Press any key to exit...");
        // Console.ReadKey(true);
    }
}
