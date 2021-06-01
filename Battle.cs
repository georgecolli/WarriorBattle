using System;

namespace WarriorBattle
{
    class Battle
    {
        public static void Play(Warrior warrior1, Warrior warrior2)
        {

            while (true)
            {
                HandleAttack(warrior1, warrior2);
                if (warrior2.Health < 0)
                {
                    Console.WriteLine($"{0} has died", warrior2.Name);
                    break;
                };

                HandleAttack(warrior2, warrior1);
                if (warrior1.Health < 0)
                {
                    Console.WriteLine($"{0} has died", warrior1.Name);
                    break;
                };
            };

        }
        static void HandleAttack(Warrior warriorA, Warrior warriorB)
        {
            int attack = warriorA.GetAttack();
            int block = warriorB.GetBlock();
            int damage = attack - block;

            Console.WriteLine("{0} attacks with {1}",
                warriorA.Name,
                attack,
                warriorB.Health);

            if (damage > 0)
            {
                warriorB.Health -= damage;
                Console.WriteLine("{0} received {1} damage and now has {2} health\n",
                    warriorB.Name,
                    damage,
                    warriorB.Health);
            }
            else
            {
                Console.WriteLine("{0} received no damage\n", warriorB.Name);
            }
        }

        static void HandleSpecial(Warrior warriorA, Warrior warriorB)
        {

        }
    }
}