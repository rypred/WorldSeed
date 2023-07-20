

// I don't like that I have the random in under every case? can I make this cleaner

for (int loopIndex = 0; loopIndex < 3; loopIndex++)
{
    Console.WriteLine("Enter Season Below or Type Quit:");

    string season = Console.ReadLine();
    switch (season)
    {
        case "Winter":
            Random rnd1 = new Random();
            int weather = rnd1.Next(1, 100);
            randomizeWeather(weather,"Blizzard", "Snow/Rain", "Freezing Cold","Heavy Clouds", "Light Clouds","Clear Skies", "Strange Phenomena");
            break;
        case "Summer":
            Random rnd2 = new Random();
            int weather2 = rnd2.Next(1, 100);
            randomizeWeather(weather2, "Thunderstorm", "Rain", "Light Clouds", "Clear Skies", "High Winds", "Scorching Heat", "Strange Phenomena");
            break;
        case "Fall":
            Random rnd3 = new Random();
            int weather3 = rnd3.Next(1, 100);
            break;
        case "Spring":
            Random rnd4 = new Random();
            int weather4 = rnd4.Next(1, 100);
            break;
    }
}

void randomizeWeather(int weatherNum, string weatherType1, string weatherType2, string weatherType3, string weatherType4, string weatherType5, string weatherType6, string weatherType7)
{
    Console.WriteLine("Called the Randomize Weather Function");
    switch (weatherNum)
    {
        case int i when i < 2:
            Console.WriteLine(weatherType1);
            break;
        case int i when i >= 3 && i <= 20:
            Console.WriteLine(weatherType2);
            break;
        case int i when i >= 21 && i <= 30:
            Console.WriteLine(weatherType3);
            break;
        case int i when i >= 31 && i <= 40:
            Console.WriteLine(weatherType4);
            break;
        case int i when i >= 41 && i <= 60:
            Console.WriteLine(weatherType5);
            break;
        case int i when i >= 61 && i <= 99:
            Console.WriteLine(weatherType6);
            break;
        case int i when i == 100:
            Console.WriteLine(weatherType7);
            break;
    }
}

