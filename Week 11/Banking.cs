using Microsoft.EntityFrameworkCore;

namespace MYAZ203.Week_11
{
    [PrimaryKey(nameof(Id))]
    public class Banking
    {
        // Customer
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
        public string Password { get; set; }
        public double Balance { get; set; }

        public Banking()
        {
            Balance = 0;
            Password = "1234";
        }
    }
}