using System;
using System.Collections.Generic;

namespace GarysGarage
{
    public class Cessna : Vehicle, IGasoline
    {
        public string Name { get; } = "Cessna";
        public double FuelCapacity { get; set; }

        public List<string> Gasoline { get; }

        public int CurrentTankPercentage { get; } = 20;

        public void RefuelTank()
        {
            Console.WriteLine("Filling up the tank!");
            int CurrentTankPercentage = 100;
            Console.WriteLine($"The {Name}'s fuel tank is now at {CurrentTankPercentage} percent.");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies by. Bang! Boom!");

        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle violently turns to the {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("The plane transfomed into a giant robot, it began to yell something as it landed feet first on the ground.");
        }
    }
}