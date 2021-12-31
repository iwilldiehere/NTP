using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
           
          
            int[] sayilar = new int[20];
            {
                for (int i = 0; i < 20; i++)
                {
                    int a = rnd.Next(1, 100);
                    sayilar[0] = a;
                    Console.WriteLine(a);
               
            
                }

                Console.WriteLine("*********************");

                for (int i = 0; i <= 1; i++)
                {
                    int b = (int)sayilar.Count();
                    if (b % 2 == 0)
                    {

                        Console.WriteLine(b + " tek sayı");
                        b++;
                        Console.WriteLine(b + " Arttırılmışı");
                       
                    }
              
                }
                
                Console.ReadKey();
              


            }
        }
    }
}
