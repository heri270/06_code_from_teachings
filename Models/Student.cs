namespace ConsoleApplication.Models 
{
    public class Student
    {
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

    }
}