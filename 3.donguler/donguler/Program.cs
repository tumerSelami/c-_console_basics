using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LOOPS - DÖNGÜLER (For / While / Do-While / ForEach)
            //Parametreleri: Başlangıç, Bitiş, Artış/Azalış Miktarı

            //FOR

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Helloo");
            //}

            /*for (int i = 1; i < 6; i++)
            {
              Console.WriteLine(i);
            }*/

            /*for(int i = 1; i < 24; i += 7)
            {
              Console.WriteLine(i);
            }*/

            /*for(int i = 1; i <= 20; i++)
            {
              if (i % 2 == 0)
              {
                Console.WriteLine(i);
              }
            }*/

            /*for (int i = 1; i <= 100; i++)
            {
              if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine(i);
            }*/

            //Faktöriyel Örneği

            /*int sonuc = 1;
            for (int i = 1; i <= 5; i++)
            {
              sonuc = sonuc * i;
            }
            Console.WriteLine(sonuc);*/

            /*int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
              Console.WriteLine(toplam = toplam + i);
            }*/

            /*int toplam = 0;
            for (int i = 1; i <= 100; i++)
            {
              if (i % 7 == 0)
              {
                Console.WriteLine(toplam = toplam + i);
              }
            }*/


            //WHILE

            /*int sayac = 1;
            while (sayac <= 5)
            {
              Console.WriteLine(sayac + ". Merhabaa");
              sayac++;
            }*/

            /*int sayi = 1;
            while (sayi <= 50)
            {
              if (sayi % 8 == 0)
              {
                Console.WriteLine(sayi);
              }
              sayi++;
            }*/

            Console.ReadLine();
        }
    }
}
