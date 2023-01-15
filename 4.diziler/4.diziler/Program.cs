using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DİZİLER[]
            //Birbiriyle ilişkili olan değerleri bir arada tutmamıza olanak sağlar
            //Index--> Dizinin içindeki değerin sırası, 0'dan başlar

            //string[] sehirler = { "Londra", "Madrid", "Milan", "Roma", "Antalya" };

            /*Dizinin adı sehirler
             *eleman sayısı 5
             *0.index Londra
             *son yani 4.index Antalya
             */

            //Console.Write(sehirler[3]);

            //int[] notlar = { 67, 85, 92, 74, 57 };
            //Console.Write(notlar[4]);


            //FOREACH
            //Bir dizinin istenilen elemanlarını listelemeye yarar

            //string[] sehirler = { "Londra", "Madrid", "Milan", "Roma", "Antalya" };
            //foreach(string s in sehirler)
            //{
            //    Console.WriteLine(s);
            //}

            //int[] notlar = { 67, 85, 92, 74, 56 };
            //foreach(int n in notlar)
            //{
            //    if(n % 4 == 0)
            //    {
            //        Console.WriteLine(n);
            //    }
            //}

            //int sayi, b1, b2, b3, b4, toplam;
            //toplam = 0;

            //Console.Write("Sayıyı Giriniz :");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 1000 && sayi < 10000)
            //{
            //    b1 = sayi / 1000;
            //    b2 = (sayi - (b1 * 1000)) / 100;
            //    b3 = (sayi - ((b1 * 1000) + (b2 * 100))) / 10;
            //    b4 = (sayi - ((b1 * 1000) + (b2 * 100) + (b3 * 10))) / 1;
            //    int[] basamaklar = { b1, b2, b3, b4 };

            //    foreach (int b in basamaklar)
            //    {
            //        toplam = toplam + b;
            //    }
            //    Console.WriteLine(b1 + "+" + b2 + "+" + b3 + "+" + b4 + "+" + "=" + toplam);
            //}

            //else
            //{
            //    Console.WriteLine("Lütfen 4 Basamaklı Bir Tamsayı Giriniz!!");
            //}

            /*
             * Sıradaki Konular:
             * Metotlar
             * Kalıtım, kapsülleme
             * ---
             * SQL
             * Adonet
             * Entity FrameWork
             * N Tier Arc.
             */

            Console.ReadLine();
        }
    }
}
