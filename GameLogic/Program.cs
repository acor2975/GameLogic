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

            Human.Buff(Attributes.Strenght, 10);
            Human.Debuff(Dolly, Attributes.Health, 100);
            Console.WriteLine(Dolly);
            Console.WriteLine(Human);

            if(Dolly.IsAlive == false)
            {
                Console.WriteLine("omae wa mou shindeiru");
            }
            Console.ReadKey();
        }
    }
}
