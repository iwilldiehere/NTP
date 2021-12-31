using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
     
        {
            
            int tanim,kullanici = Console.WriteLine("bir sayı giriniz 1-2-3");
           tanim= Convert.ToInt32(kullanici);
           Console.ReadLine();
            int sayı = 0;
            try
            {
                if(sayı==5)
                {
                    goto method1;
                }
            }
            catch
            {

            }
            finally
            {

            }
            #region su surda kalsin
            
           method1:
            int[] sayilar = new int[5];
            {
          //      #region bos bos uygulamalar
          //      int topla,topla2=0;
          //      sayilar[0] = 1;
          //      sayilar[1] = 2;
          //      sayilar[2] = 3;
          //      sayilar[3] = 4;
          //      sayilar[4] = 5;
          //      topla = sayilar[0] + sayilar[1] + sayilar[2] + sayilar[3] + sayilar[4];
          //      Console.WriteLine("sayi 0 = 1");
          //      Console.WriteLine("sayi 1 = 2");
          //      Console.WriteLine("sayi 2 = 3");
          //      Console.WriteLine("sayi 3 = 4");
          //      Console.WriteLine("sayi 4 = 5");
          //      for (int i = 0; i < 4; i++)
          //      {
                    
          //          Console.WriteLine("sayilardan 0,1,2,3,4'un toplamlari = "  +topla);
          //      }
          //      Console.WriteLine("  ");
            
          //  Console.WriteLine("sayi 0'ı 7 olarak degistiriyorum = 7");
            
          //  Console.WriteLine("sayi 0 = 7");
          //  Console.WriteLine("sayi 1 = 2");
          //  Console.WriteLine("sayi 2 = 3");
          //  Console.WriteLine("sayi 3 = 4");
          //  Console.WriteLine("sayi 4 = 5");
          //  sayilar[0] = 7;
          //  topla2 = sayilar[0] + sayilar[1] + sayilar[2] + sayilar[3] + sayilar[4];
          //  Console.WriteLine("  ");
          //      for (int i = 0; i < 4; i++)
          //  {
                
          //      Console.WriteLine("sayilardan 0,1,2,3,4'un toplamlari = "  +topla2);
          //  }
          // for (int i = 0; i < topla2; i++)
          //  {
          //   if(topla %2==0)
          //   {
          //       Console.WriteLine("tektir");
          //   if(topla2%2==0)
          //{
          //    Console.WriteLine("tektir");
          //}
          //   else
          //   {
          //       Console.WriteLine("tek değildir");

          //   }
          //   }
          
          //else
          //       {
          //           Console.WriteLine("tek değildir");
          //       }
          // }
          
            
            
          //   }
          //  Console.ReadKey();
           #endregion
            #region bu da burda kalsin 
            method2: //string[] isimler = { "can", "ahmet","mehmet","kursad"};
            //foreach (string item in isimler)
            //{
               
            //    Console.WriteLine(item);
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //Console.ReadKey();
            #endregion
                #region e bu da burda kalsin
            method3:       string[] item = new string[5];
                {
                  
                    item[0] = sayı.ToString();
                    item[1] = sayı.ToString();        
                    item[2] = "67";
                    item[3] = "21";
                    item[4] = "55";

                    Console.WriteLine("---------------");
                    foreach (var x in item) // sonsuz döngü
                    {
                        Console.WriteLine(x);
                        for (int i = 0; i < 5; i++)
                        {
                            sayı++;
                        }
                        for (int i = 0; i < sayı; i++)
                        {
                              Console.WriteLine(x);
                        }
                    }
                
                }
                Console.ReadKey();
                #endregion

        
            
            
            }
    }
}
}