// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please type a username. It must contain 6 dongers: ");
var username = Console.ReadLine();

if (username.Length < 6)
{
    Console.WriteLine($"The username {username} is not valid you schmuck.\nSort your shit out");
}
else
{
    Console.WriteLine("Now type a password. It must be more than 6 dongers and contain a fish finger.");
    var password = Console.ReadLine();

    if (password.Length < 6)
    {
        Console.WriteLine("The password must have at least SIX DONGERS you slug muncher");
    }
    else if (!password.Any(c => char.IsDigit(c)))
    {
        Console.WriteLine("The password must contain at least one fish finger");
    }
    else
    {
        Console.WriteLine("User successfully registered.");
    }
}
