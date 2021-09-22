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

            float Combo;
            Combo = 1.0f;

            float Score;
            Score = 0;

            //---------HUD------------

            Console.WriteLine("[----------------]");
            Console.WriteLine("Knights"); //game title
            Console.WriteLine("By Lucas-arts"); //HAHA
            Console.WriteLine("[----------------]");
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.WriteLine("HP:" + Health); //Base Health
            Console.WriteLine("SHD:" + Shield); //Base Shield
            Console.WriteLine("Lives: " + Lives); //Base Lives
            Console.WriteLine("Combo: " + Combo + "X");
            Console.WriteLine("Score: " + Score);
            Console.WriteLine("====================");
            Console.WriteLine("");

            Console.ReadKey(true);
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine("|-------lOADING------}");
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine();
            Console.ReadKey(true);

            //----------------Event Log---------------------


            Console.WriteLine("---Event Log---");
            Console.WriteLine("Player loaded in");
            Console.WriteLine("---------------");
            Console.WriteLine();

            Console.ReadKey(true);
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine("|-------lOADING------}");
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine("[----------------]");
            Console.WriteLine("Knights"); //game title
            Console.WriteLine("by Lucas-arts"); //HAHA
            Console.WriteLine("[----------------]");
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.WriteLine("HP:" + Health); //Base Health
            Console.WriteLine("SHD:" + Shield); //Base Shield
            Console.WriteLine("Lives: " + Lives); //Base Lives
            Console.WriteLine("Combo: " + Combo + "X");
            Console.WriteLine("Score: " + Score);
            Console.WriteLine("====================");
            Console.WriteLine();

            Console.ReadKey(true);
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine("|-------lOADING------}");
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine("---Event Log---");
            Health -= 5;
            Console.WriteLine("Player was hit for 5HP");
            Combo += 0.5f;
            Console.WriteLine("Reached hit streak of 10");
            Console.WriteLine("Score multiplier is now " + Combo + "X");
            Console.WriteLine("-------------");
            Console.WriteLine();

            Console.ReadKey(true);
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine("|-------lOADING------}");
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine("[----------------]");
            Console.WriteLine("Knights"); //game title
            Console.WriteLine("by Lucas-arts"); //HAHA
            Console.WriteLine("[----------------]");
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.WriteLine("HP:" + Health); //Base Health
            Console.WriteLine("SHD:" + Shield); //Base Shield
            Console.WriteLine("Lives: " + Lives); //Base Live
            Console.WriteLine("Combo: " + Combo + "X");
            Console.WriteLine("Score: " + Score);
            Console.WriteLine("====================");
            Console.WriteLine();


            Console.ReadKey(true);
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine("|-------lOADING------}");
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine("---Event Log---");
            Console.WriteLine("Player Died");
            Console.WriteLine("Reson: Jumping into magma");
            Console.WriteLine("----------------");
            Lives -= 1;
            Console.WriteLine();

            Console.ReadKey(true);
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine("|-------lOADING------}");
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine("[----------------]");
            Console.WriteLine("Knights"); //game title
            Console.WriteLine("by Lucas-arts"); //HAHA
            Console.WriteLine("[----------------]");
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.WriteLine("HP:" + Health); //Base Health
            Console.WriteLine("SHD:" + Shield); //Base Shield
            Console.WriteLine("Lives: " + Lives); //Base Lives
            Console.WriteLine("Combo: " + Combo);
            Console.WriteLine("Score: " + Score);
            Console.WriteLine("====================");
            Console.WriteLine();

            Console.ReadKey(true);
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine("|-------lOADING------}");
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine("---Event Log---");
            Console.WriteLine("Player danced for the amusment of the gods!"); //Score from the gods!
            Score += 1000 * Combo;

            Console.WriteLine("Player was gifted 1000 points");
            Console.WriteLine("----------------");
            Console.WriteLine();


            Console.ReadKey(true);
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine("|-------lOADING------}");
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine("[----------------]");
            Console.WriteLine("Knights"); //game title
            Console.WriteLine("by Lucas-arts"); //HAHA
            Console.WriteLine("[----------------]");
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.WriteLine("HP:" + Health); //Base Health
            Console.WriteLine("SHD:" + Shield); //Base Shield
            Console.WriteLine("Lives: " + Lives); //Base Lives
            Console.WriteLine("Combo: " + Combo);
            Console.WriteLine("Score: " + Score);
            Console.WriteLine("====================");
            Console.WriteLine();

            Console.ReadKey(true);
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine("|-------lOADING------}");
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine("---Event Log---");
            Shield = Shield - 50;
            Health = Health - 1000;
            Score += 150 * Combo;
            Console.WriteLine("Player was hit for 1000HP");
            Console.WriteLine("---------------");
            Console.WriteLine();

            Console.ReadKey(true);
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine("|-------lOADING------}");
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine("[----------------]");
            Console.WriteLine("Knights"); //game title
            Console.WriteLine("by Lucas-arts"); //HAHA
            Console.WriteLine("[----------------]");
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.WriteLine("HP:" + Health); //Base Health
            Console.WriteLine("SHD:" + Shield); //Base Shield
            Console.WriteLine("Lives: " + Lives); //Base Lives
            Console.WriteLine("Combo: " + Combo);
            Console.WriteLine("Score: " + Score);
            Console.WriteLine("====================");
            Console.WriteLine();

            Console.ReadKey(true);
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine("|-------lOADING------}");
            Console.WriteLine("{++++++++++++++++++++}");
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine("---Event Log---");
            Lives -= 1;
            Console.WriteLine("Player XDDD89 killed you");
            Console.WriteLine("(XDDD89) HaHa, No0b");
            Console.WriteLine("---------------");
            Console.WriteLine();

            Console.ReadKey(true);

            Console.WriteLine("[----------------]");
            Console.WriteLine("Knights"); //game title
            Console.WriteLine("by Lucas-arts"); //HAHA
            Console.WriteLine("[----------------]");
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.WriteLine("HP:" + Health); //Base Health
            Console.WriteLine("SHD:" + Shield); //Base Shield
            Console.WriteLine("Lives: " + Lives); //Base Lives
            Console.WriteLine("Combo: " + Combo);
            Console.WriteLine("Score: " + Score);
            Console.WriteLine("====================");
            Console.WriteLine();

            Console.ReadKey(true);

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("--XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX--");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("!YOU DIED!");
            Console.WriteLine("!Press any key to rage quit...!");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("--XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX--");
            Console.WriteLine("------------------------------------------");
            Console.ReadKey(true);





        }   
    }
}
