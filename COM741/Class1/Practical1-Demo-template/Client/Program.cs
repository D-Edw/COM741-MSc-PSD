using System;
using Client.Data;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            Question1();
            Question3();
            Question5();
           // Question6();
        }

        static void Question1()
        {
         int studentID = 0076520;
         string name = "Daniel";
         string course = "MSc PSD";
         DateTime dob = new DateTime (1992,06,30);
         int age = (DateTime.Now - dob).Days/365;

         Console.WriteLine($"Student ID: {studentID}, Name: {name}, Course: {course}, DOB: {dob}, Age: {age}");
        }

        static void Question3()
        {
            var s1 = new Student();
            s1.name = "Homer";
            s1.id = 100;
            s1.dob = new DateTime(1950,1,1);
            s1.course = "English";
            
            var s2 = new Student();
            s2.name = "Marge";
            s2.id = 101;
            s2.dob = new DateTime(1951,1,1);
            s2.course = "Maths";

            Console.WriteLine(s1);
            Console.WriteLine(s2);


        }

        static void Question5()
        {
            // here we prompt the user to input values to construct a student
            // we use to custom methods to read an integer and read a string defined below
            // both print a prompt which is passed as a parameter

            var s = new Student();
            s.id = ReadInteger("Enter ID: ");
            s.name = ReadString("Enter Name: ");
            s.course = ReadString("Enter Course: ");
            
            var year = ReadInteger("Enter Year: ");
            var month = ReadInteger("Enter Month: ");
            var day = ReadInteger("Enter Day: ");
            s.dob=new DateTime (year,month,day);

            Console.WriteLine(s);

        }

        static void Question6()
        {
            
       
        }


        static int ReadInteger(string prompt)
        {
            do {
                Console.Write(prompt);
                var str = Console.ReadLine();
                try {
                    return Convert.ToInt32(str);
                } catch (FormatException) {
                    Console.WriteLine($"Invalid: {str}");
                }
            } while(true);
        }   

        static string ReadString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        } 

    }
}
