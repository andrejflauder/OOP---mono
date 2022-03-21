using System;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            Star star = new Star() { Location = "Milky Way", Name = "Sun", NumPlanets = 9 };
            Console.WriteLine(star.GetDetails());
            Blackhole blackhole = new Blackhole() { Location = "Whirpool Galaxy", Name = "TON", SolarMass = "66 bil."};
            Console.WriteLine(blackhole.GetDetails());
        }
    }
}
