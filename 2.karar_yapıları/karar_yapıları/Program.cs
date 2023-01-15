using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karar_yapıları
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*IF and ELSE*/

            //string sifre;
            //Console.Write("Lütfen şifreyi giriniz: ");
            //sifre = Console.ReadLine();
            //if (sifre == "qwerty")
            //{
            //    Console.Write("Şifre doğru, hoşgeldiniz!");
            //}
            //else
            //{
            //    Console.Write("Şifre hatalı, tekrar deneyiniz.");
            //}

            //int s1, s2, ort;
            //string durum;

            //Console.Write("1.sınav notunu giriniz: ");
            //s1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.sınav notunu giriniz: ");
            //s2 = Convert.ToInt32(Console.ReadLine());
            //ort = (s1 + s2) / 2;

            //if (ort >= 50)
            //{
            //    durum = "geçti";
            //}
            //else
            //{
            //    durum = "kaldı";
            //}
            //Console.WriteLine("Öğrenci ortalaması: " + ort);
            //Console.Write("Öğrenci durumu: " + durum);


            //OPERATÖRLER

            /*
            = atama
            +, -, *, / aritmetik işleçler
            % mod işleci
            == eşitse
            != eşit değilse
            >= büyük veya eşit mi
            <= küçük veya eşit mi
            && ve
            || veya             
            */

            //string usr, pass;
            //Console.Write("Enter the username: ");
            //usr = Console.ReadLine();
            //Console.Write("Enter the password: ");
            //pass = Console.ReadLine();
            //if (usr == "admin" && pass == "1234")
            //{
            //    Console.Write("Login Successful");
            //}
            //else
            //{
            //    Console.Write("Login Unsuccessful");
            //}

            //Hatalı or kullanımı//
            //string anahtar;
            //Console.Write("Anahtar kelimeyi giriniz: ");
            //anahtar = Console.ReadLine();
            //if (anahtar != "Adana" || anahtar != "Hatay")
            //{
            //    Console.Write("Anahtar doğru");
            //}
            //else
            //{
            //    Console.Write("Anahtar yanlış");
            //}

            //int sonuc;
            //sonuc = 25 % 4;
            //Console.WriteLine(sonuc);

            //int s1, s2, s3, ort;
            //string durum;

            //Console.Write("1.sınav notunu giriniz: ");
            //s1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.sınav notunu giriniz: ");
            //s2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("3.sınav notunu giriniz: ");
            //s3 = Convert.ToInt32(Console.ReadLine());
            //ort = (s1 + s2 + s3) / 3;

            /*Noktalı virgüllere DİKKAT*/
            //if (ort <= 49)
            //{
            //    durum = "vasat";
            //    Console.Write(durum);
            //}
            //if (ort > 49 && ort <= 70)
            //{
            //    durum = "orta";
            //    Console.Write(durum);
            //}
            //if (ort > 70)
            //{
            //    durum = "başarılı";
            //    Console.Write(durum);
            //}

            //Console.Write("Bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi % 2 == 0)
            //{
            //    Console.Write("Sayınız çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayınız tektir");
            //}

            /*SWITCH CASE*/

            //string fruit;
            //Console.Write("Enter a fruit name and see its Turkish translation: ");
            //fruit = Console.ReadLine();

            //switch (fruit)
            //{
            //    case "strawberry": Console.Write("Çilek"); break;
            //    case "banana": Console.Write("Muz"); break;
            //    case "peach": Console.Write("Şeftali"); break;
            //    default: Console.Write("Karşılık bulunamadı!"); break;
            //}

            //Console.Write("5 üzerinden puanlamanızı giriniz: ");
            //int puan = Convert.ToInt32(Console.ReadLine());

            //switch (puan)
            //{
            //    default: Console.Write("Yanlış bir değer girdiniz!");
            //        break;
            //    case 1:
            //        Console.Write("Çok Kötü");
            //        break;
            //    case 2:
            //        Console.Write("Kötü");
            //        break;
            //    case 3:
            //        Console.Write("Ortalama");
            //        break;
            //    case 4:
            //        Console.Write("İyi");
            //        break;
            //    case 5:
            //        Console.Write("Çok İyi");
            //        break;
            //}

            Console.ReadLine();
        }
    }
}
