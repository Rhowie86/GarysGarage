using System;

namespace GarysGarage
{
    public class Ram : Vehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }


        public void RefuelTank()
        {
            // method definition omitted
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