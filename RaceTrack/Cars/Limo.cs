using System;

namespace RaceTrack.RaceTrack.Cars
{
    internal class Limo : RaceCar
    {
        public Limo() 
        {
            Name = "Limo";
            TopSpeed = 55;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engine starts in style");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} ends at position {Position}!");
        }
    }
}
