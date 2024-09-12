class Tamagotchi
{
    public string Name;
    public int Hunger;
    public int Boredom;
    private List<string> Words = new();
    public bool IsAlive;
    public Tamagotchi(string Name, int Hunger, int Boredom, List<string> Words, bool IsAlive)
    {
        this.Name = Name;
        this.Hunger = Hunger;
        this.Boredom = Boredom;
        this.Words = Words;
        this.IsAlive = IsAlive;
    }

    public void GetAlive()
    {
        if (IsAlive == true)
        {
            Console.WriteLine(Name + " is still alive");
        }
        else if (IsAlive == false)
        {
            Console.WriteLine(Name + " is DEAD!!");
        }
    }

    public void Hi()
    {
        Random gen = new();
        Console.WriteLine(Words[gen.Next(Words.Count)]);
        ReduceBoredom();
    }

    public void Teach()
    {
        Console.WriteLine("Enter a word you want to teach " + Name);
        string word = Console.ReadLine().ToLower();
        Words.Add(word);
        ReduceBoredom();
    }

    public void PrintStats()
    {
        Console.WriteLine("Tamagotchi: " + Name);
        if (IsAlive == true)
        {
            Console.WriteLine(Name + " is still alive");
        }
        else if (IsAlive == false)
        {
            Console.WriteLine(Name + " is DEAD!!");
        }
        Console.WriteLine("Hunger: " + Hunger);
        Console.WriteLine("Boredom: " + Boredom);
    }
    public void Tick()
    {
        Random gen = new();

        Boredom += gen.Next(1, 3);
        Hunger += gen.Next(1, 3);
    }

    public void Feed()
    {
        Random gen = new();
        Hunger -= gen.Next(1, 4);
    }
    public void ReduceBoredom()
    {
        Random gen = new();
        Boredom -= gen.Next(1, 4);
    }

    public void CreateTamagotchi()
    {

    }
}