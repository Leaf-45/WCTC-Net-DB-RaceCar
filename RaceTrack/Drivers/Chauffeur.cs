using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    internal class Chauffeur : Driver
    {
        public Chauffeur(RaceCar car) : base(car)
        {
            Name = "Chauffeur";
            SkillLevel = 12;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

        internal override void StopEngine()
        {
            Console.WriteLine($"{Name} has stopped their engine!");
        }
    }
}
