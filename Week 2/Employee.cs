namespace MYAZ203.Week_2
{
    public class Employee : IComparable<Employee>
    {
        private List<Employee> _employees;

        public Employee()
        {
            _employees = new List<Employee>();
        }

        // Property
        public int Id { get; set; }
        public string Employees { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void Add(Employee emp)
        {
            _employees.Add(emp);
        }

        public int CompareTo(Employee? other)
        {
            // Sıralama
            return Age.CompareTo(other.Age);
            // Ters Sıralama
            // return other.Age.CompareTo(Age);
        }

        public void ShowAll()
        {
            _employees.Sort();
            for (int i = 0; i < _employees.Count; i++)
            {
                Console.WriteLine($"{_employees[i].Id} " +
                    $"{_employees[i].FirstName} " +
                    $"{_employees[i].LastName} " +
                    $"{_employees[i].Age}");
            }
        }
    }
}
