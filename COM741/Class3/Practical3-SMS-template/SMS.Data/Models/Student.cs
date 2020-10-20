

namespace SMS.Data.Models
{
    // Class representing a Student table in our database
    public class Student
    {
        // An int field named Id will by convention be used as primary key
        public int Id { get; set; }

        public string Name { get; set; }
        public string Course { get; set; }
        public int Age { get; set; }
       

        // Override the ToString method to return a Student in following format
        // Id: X  Name: X  Course: X  Age: X
        public override string ToString()
        {
            return $"{Id}\t {Name}\t {Course}\t {Age} ";
        }
    }
}