using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using tugas_abstraction.AbstractClass;
using tugas_abstraction.Interface;

namespace tugas_abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstract
            /*Animal animal;

            animal = new Kucing();
            animal.karakteristik();

            Console.WriteLine();
            animal = new Otter();
            animal.karakteristik();*/

            //interface
            IAnimal animal;

            animal = new Kucing();
            animal.karakteristik();

            Console.WriteLine();
            animal = new Otter();
            animal.karakteristik();

            Console.ReadKey();
        }
    }
}
