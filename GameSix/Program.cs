using System;

namespace GameSix
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number of enemies");
            int N_enemy = Convert.ToInt32(Console.ReadLine());
            Foe[] enemies = new Foe[N_enemy];
            for (int i = 0; i < N_enemy; i++)
            {
                Console.WriteLine("Write the enemy's name please");
                string enemyName =  Console.ReadLine();
                enemies[i] = new Foe(enemyName);
            }


        }
    }   
}
