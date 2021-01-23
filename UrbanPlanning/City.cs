using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanning
{
    class City
    {
        public string Name { get; set; }

        private string Mayor { get; set; }

        private string Year { get; set; }

        public List<Building> Buildings = new List<Building>();

        public City(string name)
        {
            Name = name;

        }

        public void addBuilding(Building building)
        {
    
            //Buildings.Add(building);
        }

        
    }
}
