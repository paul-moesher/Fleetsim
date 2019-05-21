using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects;
using FleetSim.Objects.Class;
using FleetSim.Objects.Enum;

namespace FleetSim.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 5 car instances
                Random rnd = new Random();
                car car1 = new car();
                car car2 = new car();
                car car3 = new car();
                car car4 = new car();
                car car5 = new car();

                // 5 random car models, colors
                car[] carArray = new car[] { car1, car2, car3, car4, car5 };
                car1.model = "Benz"; car1.CarColors = colors.red;
                car2.model = "Beemer"; car2.CarColors = colors.white;
                car3.model = "Bentley"; car3.CarColors = colors.blue;
                car4.model = "Lambo"; car4.CarColors = colors.red;
                car5.model = "Buggati"; car5.CarColors = colors.white;

                // loop 10 times to generate random miles and add them to the vehicle collection

                for (int counter = 1; counter <= 10; counter++)
                {
                    System.Console.BackgroundColor = ConsoleColor.Blue;
                    System.Console.ForegroundColor = ConsoleColor.Red;

                    for (int count = 0; count <= 4; count++)
                    {
                        carArray[count].carMiles += rnd.Next(5, 15000);
                        carArray[count].TuneUp();
                        // also output other genreal info about the car
                        System.Console.WriteLine($"{carArray[count].model}\t   mileage: {carArray[count].carMiles}\t last service day {carArray[count].carService} ");
                    }
                    System.Console.WriteLine("\n");
                    System.Console.ResetColor();

                }
                System.Console.Read();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Please contact System Administrator");
            }
        }
    }
}




