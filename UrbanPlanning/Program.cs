using System;
using UrbanPlanning;
using System.Collections.Generic;

namespace UrbanPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instance 1
            Building FiveOneEight = new Building("512 8th Avenue");
            FiveOneEight.Width = 1000;
            FiveOneEight.Stories = 4;
            FiveOneEight.Depth = 400;
            FiveOneEight.Design("Will Kotheimer");
            FiveOneEight.Purchase("Nathan Gonzalez");
            FiveOneEight.Construct();

            //Instance 2
            Building TwoOneFive = new Building("215 9th Avenue");
            TwoOneFive.Width = 1000;
            TwoOneFive.Stories = 4;
            TwoOneFive.Depth = 400;
            TwoOneFive.Design("Will Kotheimer");
            TwoOneFive.Purchase("Nathan Gonzalez");
            TwoOneFive.Construct();

            //Instance 3
            Building ThreeOneFour = new Building("314 Circle Road");
            ThreeOneFour.Width = 2000;
            ThreeOneFour.Stories = 2;
            ThreeOneFour.Depth = 300;
            ThreeOneFour.Design("Will Kotheimer");
            ThreeOneFour.Purchase("Nathan Gonzalez");
            ThreeOneFour.Construct();

            //Instance 1
            Building OneHundred = new Building("100 Acres Estates");
            OneHundred.Width = 6000;
            OneHundred.Stories = 1;
            OneHundred.Depth = 1000;
            OneHundred.Design("Will Kotheimer");
            OneHundred.Purchase("Nathan Gonzalez");
            OneHundred.Construct();

            //Instance 1
            Building Million = new Building("100 Million Avenue");
            Million.Width = 1000;
            Million.Stories = 24;
            Million.Depth = 1000;
            Million.Design("Will Kotheimer");
            Million.Purchase("Nathan Gonzalez");
            Million.Construct();


            // display in console:
            // FiveOneEight.Display();
            // TwoOneFive.Display();
            // ThreeOneFour.Display();
            // OneHundred.Display();
            // Million.Display();

            List<int> myListOfIntegers = new List<int>();

            City myCity = new City("Williamsburg");


            myCity.Buildings.Add(Million);
            myCity.Buildings.Add(OneHundred);
            myCity.Buildings.Add(ThreeOneFour);
            myCity.Buildings.Add(OneHundred);
            myCity.Buildings.Add(TwoOneFive);


            foreach (Building building in myCity.Buildings) {
             building.Display();
            }


        }
    }
}
