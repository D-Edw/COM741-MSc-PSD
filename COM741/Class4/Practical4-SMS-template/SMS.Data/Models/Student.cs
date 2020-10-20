
using System;
using System.Collections.Generic;

namespace SMS.Data.Models
{
    // Class representing a table in our database
    public class Student
    {
        public Student()
        {
            // initialise the Lists
            Tickets = new List<Ticket>();
            StudentModules = new List<StudentModule>();
        }

        // An int field named Id will by convention be used as primary key
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public int Age { get; set; }

         // Navigation property to allow navigation to the related Profile (1:1)
        public Profile Profile { get; set; } 

        // navigation property to access students list of support tickets (1:N)
        public ICollection<Ticket> Tickets {get; set;}
        // navigation property to access students list of modules (M:N)
        public ICollection<StudentModule> StudentModules {get; set;}

        // Used for printing Students to the console during testing
        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Course:{Course} Age:{Age} Grade: {Profile?.Grade}";
        }
    }
}