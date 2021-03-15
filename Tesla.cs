using System;
using System.Collections.Generic;

namespace GarysGarage
{
    public class Tesla : Vehicle, IElectric // Electric car
    {

        public string Name { get; } = "Tesla";
        public List<string> Electric { get; }

        public double BatteryKWh { get; set; }




        public int CurrentChargePercentage { get; } = 15;

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives by. Oink! Oink!");

        }

        public void ChargeBattery()
        {
            Console.WriteLine($"The {Name} is charging!");
            int CurrentTankPercentage = 100;
            Console.WriteLine($"The {Name}'s fuel tank is now at {CurrentTankPercentage} percent.");
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

