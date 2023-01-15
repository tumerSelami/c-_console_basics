 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.siniflar
{
    internal class Visitor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public void mesaj (string p)
        {
            Console.WriteLine(p);
        }
    }
}
