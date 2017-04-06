using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication.Models 
{
    public class Student
    {
        // POCO Classes
        // Plain Old CLR Object
        [Display(Name = "Student ID")]
        public int StudentID { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Enrollment Date")]
        [DataTypeAttribute(DataType.Date)]
        public DateTime EnrollmenDate { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

    }
}