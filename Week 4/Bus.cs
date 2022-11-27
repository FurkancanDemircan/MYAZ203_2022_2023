namespace MYAZ203.Week_4
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
