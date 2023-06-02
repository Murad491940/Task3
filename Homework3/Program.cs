namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var teacher = new Teacher("Qabil", "Aliyev", 45);
            Console.WriteLine(teacher.Name);
            Console.WriteLine(teacher.SurName);
            Console.WriteLine(teacher.Age);
            teacher.Explain();

            var student=new Student("Zaur","Miraleyiv",30);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.SurName);
            Console.WriteLine(student.Age);
            student.Learn();

            
            
            
        }
    }
}