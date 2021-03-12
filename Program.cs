using System;

namespace GarysGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "White",
                MaximumOccupancy = "4"
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "Black",
                MaximumOccupancy = "4"
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "Red",
                MaximumOccupancy = "2"
            };
            Ram truck = new Ram()
            {
                MainColor = "Hot Pink",
                MaximumOccupancy = "2"
            };

            fxs.Drive();
            fxs.Turn("Left");
            fxs.Stop();
            modelS.Drive();
            modelS.Turn("Right");
            modelS.Stop();
            mx410.Drive();
            mx410.Turn("up?");
            mx410.Stop();
            truck.Drive();
            truck.Turn("Donut style!");
            truck.Stop();
        }
    }
}
