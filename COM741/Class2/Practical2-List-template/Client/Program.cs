using System;
using System.Linq;  // provides Linq Collection extension methods
using System.Collections.Generic;

using Client.Data; // where our student classe is defined
using Client.Misc; // where our List ToPrettyString extension method is defined 

namespace Client  {
    public class Program
    {
        public static void Main (string[] args)
        {
            // call relevant methods here to test

            var nums = BuildList();
            Console.WriteLine(nums.ToPrettyString());

            Question2();
            BuildStudentList();
            Question5();
            Question6();

        }//main

        // Construct and return an int List
        public static List<int> BuildList()
        {
            // create initial list using list initialisation syntax 
            // and return replacing return statement below
            var nums = new List<int>{23, 4, 7, 12, 45};

            // add 7 to position 0 (beginning of list)
            nums.Insert(0, 7);
           

            // add 19 to end of list
            nums.Add(19);
           

            // add element 1 at position 4
            nums.Insert(4, 1);
           

            // finally return the new list you created rather than null
        
            return nums;
        }//BuildList

        // construct an return a Student List
        public static List<Student> BuildStudentList()
        {
            // create initial list using list initialisation syntax and return replacing return statement below
         var StudentList = new List<Student>{
             new Student{id = 23, name = "Homer", age = 44},
             new Student{id = 12, name = "Marge", age = 39},
             new Student{id = 31, name = "Bart", age = 12},
             new Student{id = 16, name = "Lisa", age = 10},
         };

            Console.WriteLine(StudentList.ToPrettyString());

            return StudentList; // return the list you created rather than null
        }//BuildStudentList

        public static void Question2()
        {
            Console.WriteLine("\nQuestion 2");
            
            // call buildlist to construct and return a sample list
           
            // q2 a
            var nums = BuildList();
            Console.WriteLine(nums.ToPrettyString());

            // q2 b
           var result = nums.Where(e => e > 15);
           Console.WriteLine(result.ToPrettyString());

            // q2 c
           var result2 = nums.Where(e => e > 5 && e < 15);
           Console.WriteLine(result2.ToPrettyString());

            // q2 d
           var result3 = nums.Where(e => e > 5 && e < 15);
           Console.WriteLine(result3.Distinct().ToPrettyString());

            // q2 e       
           Console.WriteLine(nums.OrderBy(e => e).ToPrettyString());  

        }//Question2

        public static void Question5()
        {
            Console.WriteLine("\nQuestion 5");

            // call the BuildStudentList method which constructs and returns our
            // test list of students and assign to data variable

            var StudentList = BuildStudentList();
           
            // q5 a - print the List using our ToPrettyString extension method
            Console.WriteLine(StudentList.ToPrettyString());

            // q5 b - print students over 20
            var over20 = StudentList.Where(s => s.age > 20);
            Console.WriteLine("Over 20: " + over20.ToPrettyString());
           
            // q5 c print the names of students over 20 using select projection
            var over20Name = StudentList.Where(s => s.age > 20).Select(s => s.name);
            Console.WriteLine("Students over 20: " + over20Name.ToPrettyString());
            
            // q5 d - print just the Age of Homer - the one student returned
            var homer = StudentList.FirstOrDefault(s => s.name == "Homer");
            Console.WriteLine("Homer's age: " + homer.age);
           
            // alternatively we could use projection to only return an Age (int)
            // rather than a Student 
            var homerAge = StudentList.Where(s => s.name == "Homer").Select(s => homer.age);
            Console.WriteLine("Homer's Age: " + homerAge);
            
            //q5 e - select the name age and Data of students under 20 (custom projection)
            var under20 = StudentList.Where(s => s.age < 20).Select(s => new {s.name, s.age});
            Console.WriteLine("Students under 20: " + under20);
            
            // q5 f - remove students over 20 from data list 
            StudentList.RemoveAll(s => s.age > 20);
            Console.WriteLine("Removed students over 20: " + StudentList.ToPrettyString());
                
        }//Question5


        public static void Question6()
        {
            Console.WriteLine("\nQuestion 6");

            // 6a. initialise variable named 'data' using BuildStudentList()
            var data = BuildStudentList();
            
            // 6b. add a new student Id: 5 Name: "Mr Burns", Age: 71 to end of list
            data.Insert(data.Count, new Student { id=5, name="Burns", age=71});

            // 6c. order the students by age descending
            var ageOrder = data.OrderByDescending(s => s.age).ToList();

            // 6d. Print Name and Age of ordered results
            foreach(var s in ageOrder)
            {
                Console.WriteLine($"Name: {s.name} Age: {s.age}");
            }//foreach

            // 6e.  Print count of number of students who are over 18
            var over18 = data.Count(s => s.age > 18);
            Console.WriteLine($"Number of students over 18: {over18}");

            // 6f. Print Age of oldest Student
            var oldest = data.Max(s => s.age);
            Console.WriteLine($"Oldest student: {oldest}");

        }

    }
}