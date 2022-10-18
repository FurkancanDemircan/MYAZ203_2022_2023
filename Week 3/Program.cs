namespace MYAZ203.Week3
{
    public class Program
    {
        public static void Main()
        {
            Student std = new Student(5, "Mert", "Tepe");

            List<Student> students = new List<Student>()
            {
                new Student(0, "Ali", "Dag"),
                new Student(1, "Veli", "Dag"),
                new Student(2, "Ahmet", "Dag"),
                new Student(3, "Mehmet", "Dag"),
                new Student(4, "Melih", "Dag"),
            };
            StudentManager studentManager = new StudentManager(students);
            studentManager.ReadAll();
            studentManager.CreateStudent(std);
            Console.WriteLine("------------------\n"+studentManager.ReadStudent(5));
            studentManager.DeleteStudent(4);
            studentManager.UpdateStudent(1, null, "Veli");
            Console.WriteLine("------------------");
            studentManager.ReadAll();
        }
    }
}
