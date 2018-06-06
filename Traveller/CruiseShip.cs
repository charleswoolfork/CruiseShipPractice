using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CruiseShip : Travler
    {
        public string Cruise { get; set; }
        public string Activity { get; set; }
        public CruiseShip(int age)
        {
            this.Age = (age / 10);
        }

        public void GetCruise()
        {
            switch (Age)
            {
                case (1):
                    {
                        Console.WriteLine("Welcome aboard the Disney Crusie");
                        Cruise = "Disney";
                        break;
                    }
                case (2):
                    {
                        Console.WriteLine("Welcome aboard the Carnival Crusie");
                        Cruise = "Carnival";
                        break;
                    }
                case (3):
                    {
                        Console.WriteLine("Welcome aboard the Norweigon Crusie");
                        Cruise = "Norweigon";
                        break;
                    }
                case (4):
                    {
                        Console.WriteLine("Welcome aboard the Love Boat Crusie");
                        Cruise = "Love Boat";
                        break;
                    }
                case (5):
                    {
                        Console.WriteLine("Welcome aboard the Santa Maria");
                        Cruise = "Santa Maria";
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Welcome aboard Noah's Ark");
                        Cruise = "Noah's Ark";
                        break;
                    }
            }
        }
        public void Activities()
        {
            switch (Cruise)
            {
                case ("Noah's Ark"):
                    {
                        Activity = "Scoopin Poop";

                        break;
                    }
                case ("Love Boat"):
                    {
                        Activity = "Procreation";
                        break;
                    }
                case ("Norweigon"):
                    {
                        Activity = "Sightseeing";
                        break;
                    }
                case ("Santa Maria"):
                    {
                        Activity = "Discovery Excursion";
                        break;
                    }
                case ("Carnival"):
                    {
                        Activity = "Chillaxin";
                        break;
                    }
                case ("Disney"):
                    {
                        Activity = "Diaper Doody";
                        break;
                    }

            }
        }




    }
}