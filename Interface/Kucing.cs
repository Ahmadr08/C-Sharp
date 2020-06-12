using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_abstraction.Interface
{
    public class Kucing : IAnimal
    {
        public void karakteristik()
        {
            Console.WriteLine("Namanya Kucing");
            Console.WriteLine("Hewan ini memiliki banyak jenis");
            Console.WriteLine("Sifat sangat manja");
            Console.WriteLine("Bersuara meow");

        }
    }
}
