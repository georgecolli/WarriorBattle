using System;

namespace WarriorBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior hercules = new Warrior("Hercules", 1000);
            Warrior ben = new Warrior("Ben", 1000);
            Console.WriteLine(hercules.Speak(5)); //low enough that it will return a particular phrase
            Console.WriteLine(ben.Speak(1)); //low enough that it will return a particular phrase
            Console.WriteLine(hercules.Speak(10)); //high enough to return a random phrase
            Console.WriteLine(ben.Speak(8)); //high enough to return a random phrase
            Battle.Play(ben, hercules);
        }
    }
}
