using System;

namespace SMS.Data
{
    class Program
    {     
        static void Main(string[] args)
        {
            // P4
            var sm = new PracticalQueries();

            sm.Seed();

            // // Q1
            sm.StudentsWithProfile();

            // // Q2
            sm.StudentsFailing(); 

            // // Q3
            sm.AdultStudentsPassing(); 
            sm.AdultStudentsPassingProjection(); 

            // // Q4
            sm.TicketsWithStudent(); // 3 tickets

            // // Q5
            sm.ActiveTicketsWithStudent(); 
            sm.ActiveTicketsWithStudentProjection(); 

            // // Q6
            sm.ActiveTicketsBeforeDate( new DateTime(2020,2,23) ); 

            // Q7
            sm.AllStudentModulesOrderedByStudent();

            // Q8
            sm.ModulesTakenByStudent("Lisa"); 

            // Q9
            sm.StudentsTakingModule("Programming");

        }

    }
}
