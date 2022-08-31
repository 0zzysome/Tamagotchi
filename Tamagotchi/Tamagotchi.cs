

public class Tamagotchi
{
    int Hunger = 0;
    int Boredom =0;
    List<string> Words = new List<string>();
    bool isAlive = true;
    Random generator;
    public string Name;
    public void Feed()
    {
        Hunger--;
    }
    private void ReduceBoredom()
    {
        Boredom--;
    }
    public void Teach(string Word)
    {
        Words.Add(Word);
    }

    public void hi()
    {
        int i = generator.Next(Words.Count);
        Console.WriteLine(Words[i]);
    }
    public void PrintStats()
    {
        Console.WriteLine("Boredom: "+Boredom);
        Console.WriteLine("Hunger: "+Hunger);
        if(isAlive==true)
        {
            Console.WriteLine("Tamagotchi is alive!");
        }
        else
        {
            Console.WriteLine("Tamagotchi is dead!");
        }
    }
    public void tick()
    {
        Hunger++;
        Boredom++;
        if(Boredom>10)
        {
           isAlive = false; 
        }
        if(Hunger>10)
        {
            isAlive = false; 
        }
    }
    public bool GetAlive()
    {
        return isAlive;
    }
}
