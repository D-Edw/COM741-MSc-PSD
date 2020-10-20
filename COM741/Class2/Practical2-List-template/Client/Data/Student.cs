using System;
using Client.Data;

namespace Client.Data {

    public class Student
    {
        // implement the Student

        public int id {get; set;}

        public string name {get; set;}

        public int age {get; set;}

        public override string ToString()
        {
            return $"id:{id} name:{name} age:{age}";
        }
        
        
    }
    
}