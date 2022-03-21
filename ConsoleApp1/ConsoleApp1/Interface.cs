using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface Interface
    {
        string Name { get; set; }
        string Location { get; set; }

        string GetDetails();
    }
    public interface IDetails
    {
        void Details();
    }
}
