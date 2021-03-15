using System;
using System.Collections.Generic;

namespace GarysGarage
{

    public interface IElectric
    {
        string Name { get; }
        List<string> Electric { get; }

        string MainColor { get; set; }

        int CurrentChargePercentage { get; }

        void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives by. Oink! Oink!");

        }
        void ChargeBattery()
        {

            Console.WriteLine("The battery is charging");

        }


        void Turn(string direction)
        {
            Console.WriteLine($"The vehicle violently turns to the {direction}");
        }

        void Stop()
        {
            Console.WriteLine("The vehicle's battery has died...");
        }

    }
}