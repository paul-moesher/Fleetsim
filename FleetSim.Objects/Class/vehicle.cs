using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects;
using FleetSim.Objects.Interface;
using FleetSim.Objects.Class;
using FleetSim.Objects.Enum;

namespace FleetSim.Objects.Class
{
   // public class vehicle that takes and the interface Ivehicle

        public class vehicle : Ivehicle
        {
            // Pirvate properties
            private string _vin;
            private int _miles;
            private DateTime _lastService;
            private int _lastServiceMilage;

        // constructor that does the needed work for this class
            public vehicle()
            {
                _vin = (Guid.NewGuid().ToString());

                Random num = new Random();
                _miles = num.Next(1, 200000);

                _lastService = DateTime.Now;

                Random _lastServiceMilage = new Random();
                _miles = num.Next(1, 200000);
            }

        // Below is getting and setting the public vars to access the private ones
            public string carVin
            {
                get
                {
                    return _vin;
                }

                set
                {
                    _vin = value;
                }
            }

            public int carMiles
            {
                get
                {
                    return _miles;
                }

                set
                {
                    _miles = value;
                }
            }

            public DateTime carService
            {
                get
                {
                    return _lastService;
                }

                set
                {
                    _lastService = value;
                }
            }

            public int carServiceMiles
            {
                get
                {
                    return _lastServiceMilage;
                }

                set
                {
                    _lastServiceMilage = value;
                }
            }

        // The TuneUp method if last service miles is greater than 30k update last service miles and date

            public void TuneUp()
            {
            if ((carMiles - carServiceMiles) >= 30000)
            {
                carServiceMiles = carMiles;
                carService = carService.AddMonths(2);
                Console.WriteLine($"Vehicle tuned up at {carServiceMiles}\t  on  {carService}");
            }

            // if greater than 100000k call rebuild and update miles as well as service miles to 0

            else if (carMiles >= 100000)
                    RebuildEngine();
            }

            public void RebuildEngine()
            {
                carMiles = 0;
                carServiceMiles = 0;
                Console.WriteLine($"Engine rebuilt on {carService}. ");
            }
       }
}
