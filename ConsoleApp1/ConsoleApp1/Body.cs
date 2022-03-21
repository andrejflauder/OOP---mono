using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Body : Interface
    {
        //public string Name { get; set; }
        //public string Location { get; set; }

        //public virtual string GetDetails() => $"Name: {Name} Location: {Location}";
        public string Name { get; set; }
        public string Location { get; set; }

        public string GetDetails() => $"Name: {Name} Location: {Location}";
    }
}
