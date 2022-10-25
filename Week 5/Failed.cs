namespace MYAZ203.Week_5
{
    public class Failed : Result
    {
        public Failed() : base(false, "Failed!")
        {

        }

        // Overload
        public Failed(string message) : base(false, message)
        {

        }
    }
}
