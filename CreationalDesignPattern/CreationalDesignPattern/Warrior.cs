using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern
{
    public class Warrior : Character
    {
        public override void Attack()
        {
            Console.WriteLine("Warrior attacks with a sword!");
        }
    }
}
