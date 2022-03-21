using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Blackhole : Interface, IDetails
    {
        //public string SolarMass { get; set; }
        //public string Name { get; set; }
        //public string Location { get; set; }

        //public override string GetDetails() => $"Name: {Name} Location: {Location}, has {SolarMass} solar masses";
        public string SolarMass { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        
        public string GetDetails() => $"Name: {Name} Location: {Location}, has {SolarMass} solar masses";
        public void Details()
        {
            throw new NotImplementedException();
        }
    }
}
