// See https://aka.ms/new-console-template for more information

Tamagotchi t1 = new Tamagotchi();


Console.WriteLine("Name your Tamagotchi: ");
t1.Name = Console.ReadLine();
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

    }



}