using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Reptiles david = new Reptiles("david", "NYC", 156.42, 146.66, true);
            //david.GetInfo();
            //Mammals timbo = new Mammals("timbo", "jimbo", 9999.999, 999999, true);
            //timbo.GetInfo();

            //Console.WriteLine(timbo.Sum()); // calls the sum method in the mammlas class that gets inheritied from the species class
            //Console.WriteLine(david.Sum());
            //Console.WriteLine(timbo.GetWeight(50)); // gets added 50 since the mammal class has an override
            //Console.WriteLine(david.GetWeight(50));


            Console.WriteLine("Whats ya Age?");

            CruiseShip jimbo = new CruiseShip(int.Parse(Console.ReadLine()));
            jimbo.GetCruise();
            Console.WriteLine("Welcome Aboard the {0} cruise!", jimbo.Cruise);
            jimbo.Level();
            jimbo.Activities();
            Console.WriteLine("Your activity will be " + jimbo.Activity);
        }
    }
}