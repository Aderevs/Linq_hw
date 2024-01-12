using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_hw
{
    internal class Car
    {
        public Car(string brand, string model, int maufactureYear) 
        {
            Colour = CarColour.White; //Let's assume that most of the cars at bus stations are white
            Brand = brand;
            Model = model;
            if(maufactureYear >= 1894)
            {
                ManufactureYear = maufactureYear;
            }
            else
            {
                throw new ArgumentException("Attempting to assign value of manufacfture year of the car that doesn't match time range of available cars");
            }
        }
        public string Brand{get;}
        public string Model { get;}
        public int ManufactureYear { get;}
        public CarColour Colour { get; set; }

        internal enum CarColour
        {
            White,
            Black,
            Red,
            Blue,
            Green,
            Yellow,
            Silver,
            Gray,
            Orange,
            Purple,
            Brown,
            Other
        }
    }
}
