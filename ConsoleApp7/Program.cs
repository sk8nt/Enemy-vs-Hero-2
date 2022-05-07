using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Enemy
    {
        public int hp = 100;
        public int damage = 15;
        public void OstHP()
        {
            hp = hp - 15;
        }
    }

    class Hero
    {
        public int hp = 80;
        public int damage = 15;
        public void OstHP()
        {
            hp = hp - 15;
        }

        public void Def()
        {
            hp = hp + 20;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Enemy enemy = new Enemy();
            Hero hero = new Hero();

            while (enemy.hp > 0 && hero.hp > 0)
            {
                Console.WriteLine($"\t\tINFO\nENEMY\nDamage: {enemy.damage}\nHP: {enemy.hp}\n");
                Console.WriteLine($"HERO\nDamage: {hero.damage}\nHP: {hero.hp}\n");
                Console.WriteLine("Что сделать?\n1 - атаковать\n2 - защищаться\n");
                string k = Console.ReadLine();
                int k1= Convert.ToInt32(k);

                if (k1 == 1)
                {
                    enemy.OstHP();
                    Console.WriteLine($"ENEMY\nDamage получено: {hero.damage}\nHP: {enemy.hp}\n");
                    hero.OstHP();
                    Console.WriteLine($"HERO\nDamage получено: {enemy.damage}\nHP: {hero.hp}\n");
                }

                if (k1 == 2)
                {
                    hero.Def();
                    hero.OstHP();
                    Console.WriteLine($"ENEMY\nDamage получено: 0\nHP: {enemy.hp}\n");
                    Console.WriteLine($"HERO\nDamage получено: {enemy.damage}\nHP: {hero.hp}\n");
                }
            }

            if (enemy.hp <= 0)
            {
                Console.WriteLine("\nHero wins!!!");
            }
            else
            {
                Console.WriteLine("\nEnemy wins!!!");
            }
        }
        
    }
}
