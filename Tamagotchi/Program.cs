using System.Diagnostics;
using System.Globalization;

Console.WriteLine("Name your Tamagotchi");
string resp=Console.ReadLine();

List<string> words1=new();
words1.Add("hi");
bool alive1=true;

Tamagotchi tama1=new(resp,5,5,words1,alive1);

while(tama1.IsAlive==true){
    Console.WriteLine();
    tama1.PrintStats();
    Console.WriteLine();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("a) Say hi to "+tama1.Name);
    Console.WriteLine("b)Teach "+tama1.Name+" a new word");
    Console.WriteLine("c) Feed "+tama1.Name);
    Console.WriteLine("d) Do nothing");
    resp=Console.ReadLine().ToLower();
    Console.WriteLine();

    switch(resp){
        case"a":
        tama1.Hi();
        tama1.Tick();
        break;

        case"b":
        tama1.Teach();
        tama1.Tick();
        break;

        case"c":
        tama1.Feed();
        tama1.Tick();
        break;

        case"d":
        tama1.Tick();
        break;
    }
    if(tama1.Boredom==10||tama1.Hunger==10){
        tama1.IsAlive=false;
    }
}
Console.WriteLine(tama1.Name+" has died");
Console.ReadLine();
