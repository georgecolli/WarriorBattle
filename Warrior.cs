using System;
using System.Collections.Generic;

namespace WarriorBattle
{
    class Warrior
    {
        public string Name { get; set; }
        public int Health { get; set; }
        int MaxAttack { get; set; }
        int MaxBlock { get; set; }

        private Random _random;
        public Warrior(string name, int health, int maxAttack = 100, int maxBlock = 25)
        {
            Name = name;
            Health = health;
            MaxAttack = maxAttack;
            MaxBlock = maxBlock;
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