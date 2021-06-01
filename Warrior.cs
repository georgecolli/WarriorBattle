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
        public Warrior(string name, int health, string special, int maxAttack = 50, int maxBlock = 25)
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

        public void GetSpecial(Warrior warrior)
        {
            string[] special = { "Elixir of Health", "Sword of Xennereinth", "Sheild of Fortitude" };
            System.Console.WriteLine($"{warrior.Name}, choose your special!");
            System.Console.WriteLine("\t 1 - Elixir of Health\t2 - Sword of Xennereinth\t3 - Sheild of Fortitude");
            System.Console.WriteLine("\t === Choose either 1, 2 or 3 ===");

            string playResponse = ReadLine().Trim();

            if (playResponse == "1")
            {
                warrior.Special = "Elixir of Health";
                warrior.Health += 20;
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