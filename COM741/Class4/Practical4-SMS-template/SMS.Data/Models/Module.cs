using System;
using System.Collections.Generic;

namespace SMS.Data.Models
{
    public class Module
    {
        public int Id { get; set; }
        public string Title { get; set; }
            
        // Navigation property
        ICollection<StudentModule> StudentModules { get; set; }
    }
}
