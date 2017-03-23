using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication.Models 
{
    public class Student
    {
        // POCO Classes
        // Plain Old CLR Object
        public int StudentID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Release Date")]
        public string LastName { get; set; }
        [DataTypeAttribute(DataType.Date)]
        public DateTime EnrollmenDate { get; set; }
        public int Age { get; set; }

    }
}