using System;
using System.Collections.Generic;

namespace GarysGarage
{

    public interface IGasoline
    {
        string Name { get; }
        List<string> Gasoline { get; }

        string MainColor { get; set; }

        int CurrentTankPercentage { get; }


        void RefuelTank()
        {
            Console.WriteLine("Filling up the tank!");

        }
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