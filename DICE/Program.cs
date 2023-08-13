using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine(dice);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Green;
            if (dice == 1)
            {
                Console.WriteLine("du slog en ener");
            }
            else if (dice == 2)
            {
                Console.WriteLine("du slog en torer");
               
            }
            else if (dice == 3)
            {
                Console.WriteLine("du har slåget en trer");
                

            }
            else if (dice == 4)
            {
                Console.WriteLine("du har slåget en fire");
               
            }
            else if (dice == 5)
            {
                Console.WriteLine("du har sloget en femmer");
               
            }
            else if (dice == 6)
            {
                Console.WriteLine("du har slåget en sekser");
               
            }
            else
            {
                Console.WriteLine("ugyldigt terningkast");
            }
            Console.ReadLine();
           
        } 
    } 
}

