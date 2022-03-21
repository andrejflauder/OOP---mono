using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Star : Interface
    {
        //public int NumPlanets { get; set; }
        //public string Name { get; set; }
        //public string Location { get; set ; }

        //public override string GetDetails() => $"Name: {Name} Location: {Location}, Has {NumPlanets} planets";
        public int NumPlanets { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public string GetDetails() => $"Name: {Name} Location: {Location}, Has {NumPlanets} planets";
    }
}
