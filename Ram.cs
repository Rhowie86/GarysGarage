using System;
using System.Collections.Generic;

namespace GarysGarage
{
    public class Ram : Vehicle, IGasoline  // Gas powered truck
    {
        public string Name { get; } = "Ram";
        public double FuelCapacity { get; set; }

        public List<string> Gasoline { get; }

        public int CurrentTankPercentage { get; } = 42;
        public void RefuelTank()
        {
            Console.WriteLine("Filling up the tank!");
            int CurrentTankPercentage = 100;
            Console.WriteLine($"The {Name}'s fuel tank is now at {CurrentTankPercentage} percent.");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives by. Weeeeee!");

        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle violently turns to the {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("The vehicle grinds to a halt!");
        }
    }
}