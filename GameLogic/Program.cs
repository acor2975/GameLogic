﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster Dolly = new Monster("dollynho", 12, 3, 1);
            Hero Human = new Hero("Saitama", 100, 40, 5);
            Console.WriteLine(Human);
            Console.WriteLine(Dolly);

            Human.PhysicalAttack(Dolly);
            Human.PhysicalAttack(Dolly);
            Human.PhysicalAttack(Dolly);
            Console.WriteLine(Dolly);
            Console.ReadKey();
        }
    }
}