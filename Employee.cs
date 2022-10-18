using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203
{
    public class Employee
    {
        public Employee() : this(" ", " ", 0)
        {

        }


        public Employee(string firstName, string lastName = "", int age = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }


        /*
        // Property
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        // Expression-bodied Property
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }
        */
        // Auto-implemented Property
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
