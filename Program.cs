using System;
using System.Collections.Generic;

namespace GarysGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectric> electricVehicles = new List<IElectric>() {
                fx, fxs, modelS
              };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"The {ev.Name}'s battery is currently {ev.CurrentChargePercentage} charged.");
            }

            foreach (IElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }



            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGasoline> gasVehicles = new List<IGasoline>() {
                ram, cessna150
              };

            Console.WriteLine("Gas Vehicles");
            foreach (IGasoline gv in gasVehicles)
            {
                Console.WriteLine($"The {gv.Name}'s fuel tank is at {gv.CurrentTankPercentage} Percent.");
            }

            foreach (IGasoline gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }


        }
    }
}