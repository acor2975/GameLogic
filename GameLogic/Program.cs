using System;
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
            Monster Dolly = new Monster("dollynho", 12, 3, 1, 10);
            Hero Human = new Hero("Saitama", 100, 40, 5, 15);
            Console.WriteLine(Human);
            Console.WriteLine(Dolly);

            Human.PhysicalAttack(Dolly);
            Human.PhysicalAttack(Dolly);
            Human.PhysicalAttack(Dolly);
            Console.WriteLine(Dolly);

            if(Dolly.IsAlive == false)
            {
                Console.WriteLine("omae wa mou shindeiru");
            }
            Console.ReadKey();
        }
    }
}
