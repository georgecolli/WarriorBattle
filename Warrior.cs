using System;
using System.Collections.Generic;
using static System.Console;

namespace WarriorBattle
{
    class Warrior
    {
        public string Name { get; set; }
        public int Health { get; set; }
        int MaxAttack { get; set; }
        int MaxBlock { get; set; }
        public string Special { get; set; }


        private Random _random;
        public Warrior(string name, int health, string special = " ", int maxAttack = 50, int maxBlock = 25)
        {
            Name = name;
            Health = health;
            MaxAttack = maxAttack;
            MaxBlock = maxBlock;
            Special = special;
            _random = new Random();
        }

        public int GetAttack()
        {
            return _random.Next(0, MaxAttack);
        }
        public int GetBlock()
        {
            return _random.Next(0, MaxBlock);
        }

        public static void GetSpecial(Warrior warrior)
        {
            Clear();

            string[] special = { "Elixir of Health", "Sword of Xennireinth", "Sheild of Fortitude" };
            System.Console.WriteLine($"{warrior.Name}, choose your special!");
            System.Console.WriteLine("\n\t 1 - Elixir of Health\t2 - Sword of Xennireinth\t3 - Sheild of Fortitude");
            System.Console.WriteLine("\n\t === Choose either 1, 2 or 3 ===");

            string playResponse = ReadLine().Trim();

            if (playResponse == "1")
            {
                warrior.Special = "Elixir of Health";
                warrior.Health += 20;
                System.Console.WriteLine("+20 hp!\nPress any key to continue.");
                ReadKey();
            }
            else if (playResponse == "2")
            {
                warrior.Special = "Sword of Xennireinth";
                warrior.MaxAttack += 20;
                System.Console.WriteLine("+20 Damage!\nPress any key to continue.");
                ReadKey();
            }
            else if (playResponse == "3")
            {
                warrior.Special = "Sheild of Fortitude";
                warrior.MaxBlock += 20;
                System.Console.WriteLine("+20 Block!\nPress any key to continue.");
                ReadKey();
            }
            else
            {
                System.Console.WriteLine("Invalid input.");
                GetSpecial(warrior);
            }

        }

        public string Speak(int index)
        {
            var phrases = new List<string>() { "Let's get ready to rumble!", "You're going down, buddy!", "Be afraid!", "Uh-oh...", "Gulp", "Eek, don't hurt me!" };
            if (index >= 6)
            {
                int randomIndex = _random.Next(0, 5);
                return $"{Name} says: {phrases[randomIndex]}";
            }
            return $"{Name} says: {phrases[index]}";
        }
    }
}