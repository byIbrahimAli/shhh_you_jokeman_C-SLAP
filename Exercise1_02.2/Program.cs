// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hi, I'm Siri!");
Console.WriteLine("Your virtual assistant, here to help with simple requests");
Console.WriteLine("At Apple, we create magic and allow you to wield it 🪄");
Console.WriteLine("");
Console.WriteLine("To start, answer some questions so I know who you are 😍");
Console.WriteLine("");
Console.WriteLine("What's your name?");
var name = Console.ReadLine();
Console.WriteLine($"Well hello {name}");
Console.WriteLine("");
Console.WriteLine("Okay, now which country do you live in?");
var country_of_residence = Console.ReadLine();
Console.WriteLine($"Next time, I'll present you a fun fact about {country_of_residence}");
Console.WriteLine("");
Console.WriteLine("Finally, what's your favourite interest right now?");
var fav_interest = Console.ReadLine();
Console.WriteLine($"Oh, {fav_interest}, awesome! I'll help keep the fire alive by recommending news in {fav_interest}");