using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FakeTaxi baru = new FakeTaxi();

            baru.DriverName = "Aoi";
            baru.OnDuty = true;
            baru.NumPassenger = 10;

            baru.FakeTaxiInfo();
            baru.PickUpPassenger();
            baru.DropOffPassenger();
            Console.ReadKey();
        }
    }
}
