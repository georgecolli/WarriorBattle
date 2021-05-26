using System;
using static System.Console;

namespace WarriorBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();

            Console.WriteLine("Player 1, what is your name?");
            string player1Name = ReadLine().Trim();

            Console.WriteLine("Player 2, what is your name?");
            string player2Name = ReadLine().Trim();

            Warrior player1 = new Warrior(player1Name, 1000);
            Warrior player2 = new Warrior(player2Name, 1000);
            Console.WriteLine(player1.Speak(5)); //low enough that it will return a particular phrase
            Console.WriteLine(player2.Speak(1)); //low enough that it will return a particular phrase
            Console.WriteLine(player1.Speak(10)); //high enough to return a random phrase
            Console.WriteLine(player2.Speak(8)); //high enough to return a random phrase
            Battle.Play(player2, player1);
        }
    }
}
