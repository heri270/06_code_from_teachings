using System;

namespace ConsoleApplication.Models 
{
    public class Student
    {
        // POCO Classes
        // Plain Old CLR Object
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmenDate { get; set; }

    }
}