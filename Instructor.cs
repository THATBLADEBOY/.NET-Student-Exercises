using System;

namespace StudentExercises 
{
public class Instructor
    {
        public Instructor(string firstName, string lastName,string slack, Cohort cohort){
            FirstName = firstName;
            LastName = lastName;
            Slack = slack;
            Cohort = cohort;
        }
        
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Slack {get; set;}
        public Cohort Cohort {get; set;}

        

         public void AssignExercise(Student studentname, Exercise excercisename){
             studentname.Exercises.Add(excercisename);
            
        }
        
        }



}