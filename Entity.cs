using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Entity : GameObject
    {
        public Health healthSystem;

        public Entity() 
        {
            Console.WriteLine("Entity class line test");
            healthSystem = new Health();
        }

    }
}
