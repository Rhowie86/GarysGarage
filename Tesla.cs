using System;

namespace GarysGarage
{
    public class Tesla : Vehicle // Electric car
    {
        public double BatteryKWh { get; set; }


        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives by. Oink! Oink!");

        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle violently turns to the {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("The vehicle's battery has died...");
        }
    }
}