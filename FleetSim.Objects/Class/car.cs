using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Enum;
using FleetSim.Objects.Interface;

namespace FleetSim.Objects.Class
{
    // public class car that takes on vehicle and the interface Icar

   public class car : vehicle, Icar

        // vars needed in this class
        {
            public int year;
            public string make;
            public string model;
            public colors CarColors;


        // default constructor
        public car()
        {
            carMiles = 0;
            carServiceMiles = 0;
        }

        // 1st overload constructor that allows you to set Year Make and Model
        public car(int theYear, string theMake, string theModel)
            {
               this.year = theYear;
                this.make = theMake;
                this.model = theModel;
            }

            // 2nd overload constructor that allows you to set Year Make Model and Color
            public car(int otherYear, string otherMake, string otherModel, colors C)
            {
                this.year = otherYear;
                this.make = otherMake;
                this.model = otherModel;
                this.CarColors = C;
            }
   }
}
