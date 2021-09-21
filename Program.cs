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

            Console.WriteLine("Knights"); //game title
            Console.WriteLine("by Lucas-arts");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("HP:" + Health); //Base Health
            Console.WriteLine("SHD:" + Shield); //Base Shield
            Console.WriteLine();
            Console.WriteLine("Remaining lives: " + Lives); //Base Lives

            //-------Score----------

            float Combo;
            Combo = 1.0f;

            int Score;
            Score = 0;
            Console.WriteLine();
            Console.WriteLine("--Score--");
            Console.WriteLine("Combo multiplier: " + Combo);
            Console.WriteLine("Score: " + Score);

            Console.ReadKey(true);

        }
    }
}
