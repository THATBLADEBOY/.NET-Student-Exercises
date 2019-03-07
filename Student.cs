using System;
using System.Collections.Generic;

namespace StudentExercises 
{
public class Student
    {
        public Student(string firstName, string lastName,string slack, Cohort cohort){
            FirstName = firstName;
            LastName = lastName;
            Slack = slack;
            Cohort = cohort;
        }
        
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Slack {get; set;}
        public Cohort Cohort {get; set;}
        public List<Exercise> Exercises {get; set;} = new List<Exercise>();
        
        }
}