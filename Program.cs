using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUD
{
    class Program
    {
        static void Main(string[] args)
        {

            //----------------Player Stats-------------

            int Health;
            Health = 100;

            int Shield;
            Shield = 50;

            int Lives;
            Lives = 3;
            
            

            Console.WriteLine("HP:" + Health); //Base Health
            Console.WriteLine("SHD:" + Shield); //Base Shield
            Console.WriteLine();
            Console.WriteLine("Remaining lives: " + Lives);



            Console.ReadKey(true);

        }
    }
}
