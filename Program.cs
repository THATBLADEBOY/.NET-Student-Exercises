using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
// Exercises
            Exercise Gitstuff = new Exercise("Git Stuff", "git");
            Exercise DomPractice = new Exercise("DOM Practice", "JavaScript");
            Exercise Components = new Exercise("Working with Components", "React");
            Exercise Handshakes = new Exercise("Proper Squeeze for Shaking Hands", "Soft Skills");

// Cohorts
            Cohort Cohort29 = new Cohort("29");
            Cohort Cohort30 = new Cohort("30");
            Cohort Cohort31 = new Cohort("31");

// Students
            Student Hank = new Student("Hank", "Hill", "@Propain", Cohort29);
            Cohort29.Students.Add(Hank);
            Student Finn = new Student("Finn", "Human", "@MATH", Cohort30);
            Cohort30.Students.Add(Finn);
            Student Larry = new Student("Larry", "David", "@PrettyGood", Cohort31);
            Cohort31.Students.Add(Larry);

// Instructors
            Instructor Andy = new Instructor("Andy", "Dude", "@Andy", Cohort29);
            Cohort29.Instructors.Add(Andy);
            Instructor Jissie = new Instructor("Jissie", "David", "@Jissie", Cohort30);
            Cohort30.Instructors.Add(Jissie);
            Instructor Leah = new Instructor("Leah", "Dudette", "@Leah", Cohort31);
            Cohort31.Instructors.Add(Leah);

// Using method from Instructor class to assign exercises to students
            Andy.AssignExercise(Hank, Gitstuff);
            Andy.AssignExercise(Hank, DomPractice);
            Jissie.AssignExercise(Finn, Gitstuff);
            Jissie.AssignExercise(Finn, Handshakes);
            Leah.AssignExercise(Larry, Components);
            Leah.AssignExercise(Larry, Handshakes);

// List of all students
            List<Student> students = new List<Student>();
            students.Add(Hank);
            students.Add(Finn);
            students.Add(Larry);
// List of all exercises
            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(Gitstuff);
            exercises.Add(DomPractice);
            exercises.Add(Components);
            exercises.Add(Handshakes);

            Console.WriteLine($"Cohort {Cohort29.Name}");
            foreach(Student stu in Cohort29.Students){
                Console.WriteLine($"{stu.FirstName} {stu.LastName}: | Slack Handle: {stu.Slack}");
            }

// Creating a list of all exercises with which students are assigned to said exercise
            Console.WriteLine();
            Console.WriteLine("Students Assigned to Exercises");
            Console.WriteLine();

            foreach(Exercise task in exercises){
                List<string> studentsAssigned = new List<string>();
                foreach(Student guy in students){
                    foreach(Exercise name in guy.Exercises){
                        if(name.Name == task.Name){
                            studentsAssigned.Add(guy.FirstName);
                        }
                    }
                }
                Console.WriteLine($"{task.Name}: {String.Join(", ", studentsAssigned)}");
            }

        }
    }
}
