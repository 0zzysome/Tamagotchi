// See https://aka.ms/new-console-template for more information

List<Tamagotchi> tamagotchis = new();
tamagotchis.Add(new Tamagotchi());


Tamagotchi t1 = tamagotchis[0];


t1.Teach(" ");
while(t1.GetAlive()==true)
{
   
    Console.Clear();
    t1.PrintStats();
    Console.WriteLine("Now what do you want to do?");
    Console.WriteLine($"1. Teach {t1.Name}");
    Console.WriteLine($"2. Talk with {t1.Name}");
    Console.WriteLine($"3. Feed {t1.Name}");
    Console.WriteLine($"4. another tama");
    Console.WriteLine($"5. change tama.");
    Console.WriteLine($"6. Do nothing.");

    string action = Console.ReadLine();
    
    if(action == "1")
    {
        Console.WriteLine($"What word do you want to teach {t1.Name}?");
        string word = Console.ReadLine();
        t1.Teach(word);

    }
    else if(action == "2")
    {
        Console.WriteLine($"{t1.Name} said:");
        t1.hi();
    }
    else if(action == "3")
    {
        Console.WriteLine($"{t1.Name} ate some food.");
        t1.Feed();
    }
    else if(action== "4")
    {
        tamagotchis.Add(new Tamagotchi());
    }
    else if(action== "5")
    {
        for (var i = 0; i < tamagotchis.Count; i++)
        {
            
        Console.WriteLine($"{i+1}. {tamagotchis[i].Name} ");        
        }
        string input = Console.ReadLine();
        int TamaChoice;
        bool success = int.TryParse(input, out TamaChoice);
        if(success && TamaChoice>0 && TamaChoice<=tamagotchis.Count)
        {
            t1=tamagotchis[TamaChoice-1];
            Console.WriteLine($"You picked {t1.Name}");
        }
        else
        {
            Console.WriteLine($"You did not pick a tamagotchi.");  
        }

        // Läs in ett val från spelaren (1..listans längd)
        // Göra om valet till en int (int.TryParse)
        // Använd inten som index i listan
        //  t1 = tamagotchis[användarindex-1]
    }
    else
    {
        Console.WriteLine("You did nothing...");
    }
    Console.WriteLine("Press enter to continue.");
    Console.ReadLine(); 
    t1.tick();

}
t1.PrintStats();
Console.ReadLine();