using System;
using System.Linq;
using System.Collections.Generic;

using SMS.Data.Models;
using SMS.Data.Repositories;

namespace SMS.Data
{
    class PracticalExercises
    {
        // the context which connects us via entityframework to the underlying database
        private DatabaseContext ctx = new DatabaseContext();
        

        // Q1 - Each time we Initialise the database all data is lost. This convenience method adds some 
        //      sample data to the database during development process.
        public void Seed()
        {
            // initialise the database
           ctx.Initialise();

            // create the students
           var s1 = new Student {Age = 45, Name = "Homer", Course = "Computing"};
           var s2 = new Student {Age = 40, Name = "Marge", Course = "Engineering"};
           var s3 = new Student {Age = 16, Name = "Bart", Course = "Philosophy"};
           var s4 = new Student {Age = 14, Name = "Lisa", Course = "Computing"};
           



            // add the students
           ctx.Students.Add(s1);
           ctx.Students.Add(s2);
           ctx.Students.Add(s3);
           ctx.Students.Add(s4);

            // save the changes
           ctx.SaveChanges(); 
        }
 
        // Q2 print student details in format Id - Name - Course - Age 
        public void PrintStudents()
        {
            var students = ctx.Students.ToList();
            foreach(var s in students)
            {
                Console.WriteLine($"Id:{s.Id} Name:{s.Name} Course:{s.Course} Age:{s.Age}");
            }
        }


        // Q3 - print student with specified id if found, otherwise print Not found 
        public void  PrintStudentById(int id)
        {
           
            var s = ctx.Students.FirstOrDefault(s => s.Id == id);
            if (s != null)
            {
               Console.WriteLine($"Id:{s.Id} Name:{s.Name} Course:{s.Course} Age:{s.Age}"); 
            }
            else
            {
            Console.WriteLine("No student at: " + id);
            }
           
            
        }


        // Q4 - return all students taking specific course - 2 Computing 
        public void PrintStudentsTakingCourse(string course)
        {
            var students = ctx.Students.Where(s => s.Course == course).ToList();
             foreach(var s in students)
            {
                Console.WriteLine($"Id:{s.Id} Name:{s.Name} Course:{s.Course} Age:{s.Age}");
            }          
        }

        // Q5 - print all adults (>=18) taking course - 1 computing
        public void PrintAdultStudentsTakingCourse(string course)
        {
            var students = ctx.Students.Where(s => s.Course == course && s.Age >= 18).ToList();
             foreach(var s in students)
            {
                Console.WriteLine($"Id:{s.Id} Name:{s.Name} Course:{s.Course} Age:{s.Age}");
            }
            
        }

        // Q6 - update the student details (not the id)
        public Student UpdateStudent(int id, string name, string course, int age)
        {
            // verify student with id exists
            var student = ctx.Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return null;
            }

            // update student that has been loaded
            student.Name = name;
            student.Course = course;
            student.Age = age;

            // save changes and return updated student
            ctx.SaveChanges();
            
            return student; // replace with updated student
        }
    
        // Q6 - Test method to verify operation of Updating a student
        public void TestUpdateStudent()
        {
            // retrieve student 1 “Homer” 
            // update homer - adding 1 to his age and set his course to Physics
            // save updated homer by calling the UpdateStudent method passing parameters from homer
            // then print to ensure updates were saved

            var homer = ctx.Students.FirstOrDefault(s => s.Id == 1);
             Console.WriteLine(homer);


            homer.Age = homer.Age + 1;
            homer.Course = "Physics";

            homer = UpdateStudent(homer.Id, homer.Name, homer.Course, homer.Age);

            var updatedHomer = ctx.Students.FirstOrDefault(s => s.Id == 1);
            Console.WriteLine(updatedHomer);
           
            
        }

        // Q7  - delete the student identified by id
        //       load the student and if not found then return false
        //       otherwise remove the student, save the changes and return true 
        public bool DeleteStudent(int id)
        {
            // verify student exists and if not return false
            var student = ctx.Students.FirstOrDefault(s => s.Id == id);
            if(student == null)
            {
                return false;
            }


            // remove student
            ctx.Students.Remove(student);

            // save changes
            ctx.SaveChanges();

            return true; 
        }

        // Q7 - Test method to verify operation of deleting a student
        public void TestDeleteStudent()
        {
            // delete student 1 ("Homer')
            // verify deleteStudent returned true and print appropriate message

            if (DeleteStudent(1))
            {
                Console.WriteLine("Student deleted");
            }
            else{
                Console.WriteLine("Student not deleted");
            }
        }

        // Q8 - optional
        public void PrintListOfStudents(IList<Student> students)
        {
            Console.WriteLine("ID\t" + "Name\t" + "Course\t\t" + "Age\t");
            Console.WriteLine("=======================================");
            foreach(var s in students)
            {
                Console.WriteLine(s);
            }        
        }
        
    }
}
