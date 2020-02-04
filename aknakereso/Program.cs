using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aknakereso
{
    class Program
    {
        
        static void Main(string[] args)
        {
            char[,] palya = new char[10, 10];
            feltoltes(palya);
            kirajzolo(palya);
            
            Console.ReadKey();
        }

        static void feltoltes(char[,] palya)
        {
            for (int i = 0; i < palya.GetLength(0); i++)
            {
                for (int j = 0; j < palya.GetLength(1); j++)
                {
                    palya[i, j] = '_';
                }
            }
            Random rnd = new Random();
            int a = 0;
            int b = 0;
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    a = rnd.Next(0, 10);
                    b = rnd.Next(0, 10);
                } while (palya[a,b]=='B');
                palya[a, b] = 'B';
            }
        }

        static void kirajzolo(char[,] palya)
        {
            for (int i = 0; i < palya.GetLength(0); i++)
            {
                for (int j = 0; j < palya.GetLength(1); j++)
                {
                    Console.Write(palya[i,j]);
                }
                Console.WriteLine();
            }
        }

        
    }
}
