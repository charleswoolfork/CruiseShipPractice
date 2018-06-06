using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Travler
    {
        public int Age { get; set; }

        public Travler()
        {
        }

        public void Level()
        {
            Console.WriteLine("Youll be on the " + (Age / 2) + "st level");
        }

    }
}