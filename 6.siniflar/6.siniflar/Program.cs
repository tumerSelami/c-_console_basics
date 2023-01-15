using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.siniflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SINIFLAR
            //Sınıf_Adi Nesne_Adi = new Sinif_Adi();

            //Country c = new Country();

            //void countryDetails()
            //{
            //    Console.WriteLine(c.CountryID);
            //    Console.WriteLine(c.Name);
            //    Console.WriteLine(c.Capital);
            //    Console.WriteLine("***");
            //}

            //c.CountryID = 1;
            //c.Name = "Ukrayna";
            //c.Capital = "Kiev";

            //countryDetails();

            //c.CountryID = 2;
            //c.Name = "Almanya";
            //c.Capital = "Berlin";

            //countryDetails();

            //c.CountryID = 3;
            //c.Name = "Fransa";
            //c.Capital = "Paris";

            //countryDetails();

            Visitor v = new Visitor();

            void bilgiler()
            {
                Console.WriteLine(v.Id);
                Console.WriteLine(v.Name);
                Console.WriteLine(v.City);
            }

            v.Id = 1;
            v.Name = "Celal";
            v.City = "İstanbul";

            bilgiler();         
            v.mesaj("Merhaba!");
            Console.WriteLine();

            v.Id = 2;
            v.Name = "James";
            v.City = "Phoneix";
            bilgiler();
            v.mesaj("Hi!");


            Console.ReadLine();
        }
    }
}
