using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_abstraction.AbstractClass
{
    public class Kucing : Animal
    {
        public override void karakteristik()
        {
            Console.WriteLine("Namanya Kucing");
            Console.WriteLine("Hewan ini memiliki banyak jenis");
            Console.WriteLine("Sifat sangat manja");
            Console.WriteLine("Bersuara meow");

        }
    }
}
