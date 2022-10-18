using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203
{
    public class Truck : Vehicle
    {
        private int _numberOfWheel;
        public override int NumberOfWheel
        {
            get => _numberOfWheel;
            set
            {
                if (value <= 12)
                    _numberOfWheel = value;
                else
                    throw new Exception("Invalid Value");
            }
        }

        public Truck() { }

        public Truck(double engine, string model, int numberOfWheel, int price, string transmission)
        {
            Engine = engine;
            Model = model;
            NumberOfWheel = numberOfWheel;
            Price = price;
            Transmission = transmission;
        }
    }
}
