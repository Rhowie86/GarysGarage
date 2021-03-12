using System;

namespace GarysGarage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
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