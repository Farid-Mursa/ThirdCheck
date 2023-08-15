using System.Xml.Linq;

namespace ConsoleApp3
{
    public class Program
    {     
        public static void Main(string[] args)
        {
            Student student = new Student("Ferid", "Mursagulov", 20);

            Console.WriteLine(student.Name);
            Console.WriteLine(student.Surname);
            Console.WriteLine(student.Age);
            student.Learn();

            Teacher teacher = new Teacher("Ferid", "Mursagulov", 20);
            Console.WriteLine(teacher.Name);
            Console.WriteLine(teacher.Surname);
            Console.WriteLine(teacher.Age);
            teacher.Explain();
        }
        
    }
}