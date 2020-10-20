using System;

namespace SMS.Data
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Practical 2 Solutions");
            Console.WriteLine("=====================");

            // create student practical exercise           
            var p = new PracticalExercises();

            p.Seed(); // re-initialise the database and add sample data;

            // Now call 'p' (PracticalExercises) methods to test question solutions
            
            // q2 call p.PrintStudents method to print contents of students table
            Console.WriteLine("\nQuestion 2");
            p.PrintStudents();

            
            // q3 call p.PrintStudentById so that it prints student 0  (doesnt exist) and student 1
            Console.WriteLine("\nQuestion 3");
            p.PrintStudentById(0);
            p.PrintStudentById(1);

            

            // q4 call p.PrintStudentsTakingCourse 'Computing"'
            Console.WriteLine("\nQuestion 4");
            p.PrintStudentsTakingCourse("Computing");


            
            
            // q5 call p.PrintAdultStudentsTakingCourse 'Computing'
            Console.WriteLine("\nQuestion 5");
            p.PrintAdultStudentsTakingCourse("Computing");
           

            // q6 test p.UpdateStudent
            Console.WriteLine("\nQuestion 6");
            p.TestUpdateStudent();
           

            // q7 test p.DeleteStudent
            Console.WriteLine("\nQuestion 7");
            p.TestDeleteStudent();
           
            
            
        }

        

    }
}
