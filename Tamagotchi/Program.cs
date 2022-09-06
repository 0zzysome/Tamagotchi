// See https://aka.ms/new-console-template for more information

Tamagotchi t1 = new Tamagotchi();


Console.WriteLine("Name your Tamagotchi: ");
t1.Name = Console.ReadLine();
t1.Teach(" ");
while(t1.GetAlive()==true)
{
   
    Console.Clear();
    t1.PrintStats();
    Console.WriteLine("Now what do you want to do?");
    Console.WriteLine("1. Teach "+t1.Name);
    Console.WriteLine("2. Talk with "+t1.Name);
    Console.WriteLine("3. Feed "+t1.Name);
    Console.WriteLine("4. Do nothing.");
    string action = Console.ReadLine();

    if(action == "1")
    {
        Console.WriteLine("What word do you want to teach "+t1.Name+"?");
        string word = Console.ReadLine();
        t1.Teach(word);

    }
    else if(action == "2")
    {
        Console.WriteLine(t1.Name+" said:");
        t1.hi();
    }
    else if(action == "3")
    {
        Console.WriteLine(t1.Name+" ate some food.");
        t1.Feed();
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