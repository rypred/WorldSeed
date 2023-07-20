// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter Season Below:");

string season = Console.ReadLine();

// I don't like that I have the random in under every case? can I make this cleaner
switch(season)
{
    case "Spring":
        Random rnd1 = new Random();
        int weather = rnd1.Next(1, 100);
        Console.WriteLine(weather);
        switch (weather)
            {
            case int i when i < 2:
                    Console.WriteLine("Blizzard");
                 break;
            case int i when i >= 3 && i <= 20:
                    Console.WriteLine("Snow/Rain");
                break;
            case int i when i >= 21 && i <= 30:
                Console.WriteLine("Freezing Cold");
                break;
            case int i when i >= 31 && i <= 40:
                Console.WriteLine("Heavy Clouds");
                break;
            case int i when i >= 41 && i <= 60:
                Console.WriteLine("Light Clouds");
                break;
            case int i when i >= 61 && i <= 99:
                Console.WriteLine("Clear Skies");
                break;
            case int i when i == 3 :
                Console.WriteLine("Strange Phenomena");
                break;
        }
    break;
    case "Summer":
        Random rnd2 = new Random();
        int weather2 = rnd2.Next(1, 100);
        Console.WriteLine(weather2);
        break;
    case "Fall":
        Random rnd3 = new Random();
        int weather3 = rnd3.Next(1, 100);
        Console.WriteLine(weather3);
        break;
    case "Winter":
        Random rnd4 = new Random();
        int weather4 = rnd4.Next(1, 100);
        Console.WriteLine(weather4);
        break;
}


Console.ReadLine();

