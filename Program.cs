﻿using System;
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

            int Score;
            Score = 0;

            //---------HUD------------

            Console.WriteLine("Knights"); //game title
            Console.WriteLine("by Lucas-arts"); //HAHA
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("HP:" + Health); //Base Health
            Console.WriteLine("SHD:" + Shield); //Base Shield
            Console.WriteLine();
            Console.WriteLine("Remaining lives: " + Lives); //Base Lives
            Console.WriteLine();
            Console.WriteLine("--Score--");
            Console.WriteLine("Combo multiplier: " + Combo);
            Console.WriteLine("Score: " + Score);
            Console.WriteLine();
            Console.WriteLine("---Event Log---");

            //----------------Event Log---------------------


            Console.WriteLine("Player loaded in");

            Console.ReadKey(true);

            Health = Health - 5;
            Console.WriteLine("Player was hit for 5HP");
            Console.WriteLine("HP " + Health);
            Combo = Combo + 0.5f;
            Console.WriteLine("Reached hit streak of 10");
            Console.WriteLine("Score multiplier is now " + Combo);

            Console.WriteLine("Knights"); //game title
            Console.WriteLine("by Lucas-arts"); //HAHA
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("HP:" + Health); //Base Health
            Console.WriteLine("SHD:" + Shield); //Base Shield
            Console.WriteLine();
            Console.WriteLine("Remaining lives: " + Lives); //Base Lives
            Console.WriteLine();
            Console.WriteLine("--Score--");
            Console.WriteLine("Combo multiplier: " + Combo);
            Console.WriteLine("Score: " + Score);
            Console.WriteLine();
            Console.WriteLine("---Event Log---");

            Console.ReadKey(true);

            Console.WriteLine("Player Died");
            Console.WriteLine("Reson: Jumping into magma");
            Lives = Lives - 1;
            Console.WriteLine("Remaining lives: " + Lives);

            Console.WriteLine("Knights"); //game title
            Console.WriteLine("by Lucas-arts"); //HAHA
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("HP:" + Health); //Base Health
            Console.WriteLine("SHD:" + Shield); //Base Shield
            Console.WriteLine();
            Console.WriteLine("Remaining lives: " + Lives); //Base Lives
            Console.WriteLine();
            Console.WriteLine("--Score--");
            Console.WriteLine("Combo multiplier: " + Combo);
            Console.WriteLine("Score: " + Score);
            Console.WriteLine();
            Console.WriteLine("---Event Log---");

            Console.ReadKey(true);

            Console.WriteLine("Player danced for the amusment of the gods!"); //Score from the gods!
            Score = Score + 1000; 
            Console.WriteLine("new score: " + (Score * Combo));

            Console.WriteLine("Knights"); //game title
            Console.WriteLine("by Lucas-arts"); //HAHA
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("HP:" + Health); //Base Health
            Console.WriteLine("SHD:" + Shield); //Base Shield
            Console.WriteLine();
            Console.WriteLine("Remaining lives: " + Lives); //Base Lives
            Console.WriteLine();
            Console.WriteLine("--Score--");
            Console.WriteLine("Combo multiplier: " + Combo);
            Console.WriteLine("Score: " + Score);
            Console.WriteLine();
            Console.WriteLine("---Event Log---");

            Console.ReadKey(true);





        }   
    }
}
