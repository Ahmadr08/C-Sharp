using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_abstraction.Interface
{
    public class Otter : IAnimal
    {
        public void karakteristik()
        {
            Console.WriteLine("Namanya Berang-Berang");
            Console.WriteLine("Hewan ini memiliki beberapa jenis");
            Console.WriteLine("Berwajah lucu dan menggemaskan");
            Console.WriteLine("Pandai berenang");
        }
    }
}
