using System;
using System.Collections.Generic;

namespace GarysGarage
{
    public class Zero : Vehicle, IElectric  // Electric motorcycle
    {


        public string Name { get; } = "Zero";
        public List<string> Electric { get; }
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; } = 60;

        public void ChargeBattery()
        {
            Console.WriteLine($"The {Name} is charging!");
            int CurrentTankPercentage = 100;
            Console.WriteLine($"The {Name}'s fuel tank is now at {CurrentTankPercentage} percent.");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero drives by. Shhhhhhhhhh!");

        }

        // public List<string> electricVehicles { get; } = new List<string>();
        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle violently turns to the {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("The vehicle vanished into thin air!");
        }
    }
}