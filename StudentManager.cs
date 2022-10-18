using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203
{
    public class StudentManager
    {
        List<Student> stdList;

        public StudentManager()
        {
            stdList = new List<Student>();
        }
        
        public StudentManager(List<Student> std)
        {
            stdList = std;
        }

        public StudentManager(Student std)
        {
            stdList = new List<Student>();
            CreateStudent(std);
        }

        // Create
        public void CreateStudent(Student student)
        {
            stdList.Add(student);
        }

        // Read
        public Student ReadStudent(int id)
        {
            return stdList[id];
        }

        // Update
        public void UpdateStudent(int id, string? firstName, string? lastName)
        {
            if (firstName != null)
                stdList[id].FirstName = firstName;
            if (lastName != null)
                stdList[id].LastName = lastName;
        }

        // Delete
        public Student DeleteStudent(int id)
        {
            var std = ReadStudent(id);
            // stdList.Remove(std);
            stdList.RemoveAt(id);
            return std;
        }

        public void ReadAll()
        {
            foreach (var item in stdList)
                Console.WriteLine(item);
        }
    }
}
