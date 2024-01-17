using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance");
            Console.WriteLine("-----------");
            Console.WriteLine();

            Player player = new Player();
            Enemy slime = new Enemy();
            Item sword = new Item();

            player.healthSystem.health = 100;
            player.position.x = 0;
            player.position.y = 0;

            slime.healthSystem.health = 50;
            slime.position.x = 10;
            slime.position.y = 10;

            sword.position.x = 5;
            sword.position.y = 5;

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);

        }
    }
}
