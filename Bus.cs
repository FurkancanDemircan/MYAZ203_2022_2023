using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203
{
    public class Bus : Vehicle
    {
        public Bus() { }

        public Bus(double engine, string model, int numberOfWheel, int price, string transmission)
        {
            Engine = engine;
            Model = model;
            NumberOfWheel = numberOfWheel;
            Price = price;
            Transmission = transmission;
        }
    }
}
