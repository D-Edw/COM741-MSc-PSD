using System;
namespace Client.Data
{
    public class Student{
     public int id {get; set;}
     public string name {get; set;}
     public string course {get; set;}
     public DateTime dob {get; set;}
     int age => (DateTime.Now - dob).Days/365;

     public override string ToString(){
         return $"Student ID: {id}, Name: {name}, Course: {course}, DOB: {dob}, Age: {age}";

        }
    }
}

