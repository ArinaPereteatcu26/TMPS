﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Domain
{
    public class Wizard : Character
    {
        public override void Attack()
        {
            Console.WriteLine("Wizard casts a spell!");
        }
    }
}
