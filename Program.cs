using System;
using System.Collections.Generic;
using System.Linq;

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
            Student Dude = new Student("Dude", "Guy", "@Man", Cohort31);
            Cohort31.Students.Add(Dude);

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
            Jissie.AssignExercise(Finn, Gitstuff);
            Leah.AssignExercise(Larry, Components);
            Leah.AssignExercise(Larry, Handshakes);

// List of all students
            List<Student> students = new List<Student>();
            students.Add(Hank);
            students.Add(Finn);
            students.Add(Larry);
            students.Add(Dude);
// List of all instructors
            List<Instructor> instructors = new List<Instructor>();
            instructors.Add(Andy);
            instructors.Add(Jissie);
            instructors.Add(Leah);
// List of all cohorts
            List<Cohort> cohorts = new List<Cohort>();
            cohorts.Add(Cohort29);
            cohorts.Add(Cohort30);
            cohorts.Add(Cohort31);
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

            Console.WriteLine();
// List exercises for the JavaScript language by using the Where() LINQ method.
            IEnumerable<Exercise> JSExercises = from exercise in exercises
            where exercise.Language == "JavaScript"
            select exercise;

            Console.WriteLine("-----JS Exercises-----");

            foreach(Exercise exercise in JSExercises){
                Console.WriteLine($"{exercise.Name}");
            }

            Console.WriteLine();
// List students in a particular cohort by using the Where() LINQ method.
            IEnumerable<Student> Cohort29Students = from student in students
            where student.Cohort == Cohort29
            select student;

            Console.WriteLine("-----Cohort29 Students-----");

            foreach(Student student in Cohort29Students){
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            Console.WriteLine();
// List instructors in a particular cohort by using the Where() LINQ method.
            IEnumerable<Instructor> Cohort29Instructors = from instructor in instructors
            where instructor.Cohort == Cohort29
            select instructor;

            Console.WriteLine("-----Cohort29 Instructors-----");

            foreach(Instructor instructor in Cohort29Instructors){
                Console.WriteLine($"{instructor.FirstName} {instructor.LastName}");
            }
            Console.WriteLine();
// Sort the students by their last name.
            IEnumerable<Student> AlphabetizedStudents = from student in students
            orderby student.LastName ascending
            select student;

             Console.WriteLine("-----Alphabetized Students-----");

            foreach(Student student in AlphabetizedStudents){
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            Console.WriteLine();
// Display any students that aren't working on any exercises (Make sure one of your student instances doesn't have any exercises. Create a new student if you need to.)
            IEnumerable<Student> StudentsWithoutExercises = from student in students
            where student.Exercises.Count() == 0
            select student;

             Console.WriteLine("-----Students Without Exercises-----");

            foreach(Student student in StudentsWithoutExercises){
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            Console.WriteLine();
// Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
            IEnumerable<Student> StudentWithMostExercise = from student in students
            orderby student.Exercises.Count()
            select student;

            Console.WriteLine("-----Student With Most Exercises-----");

            Student MostExerciseStudent = StudentWithMostExercise.Last();

            Console.WriteLine($"{MostExerciseStudent.FirstName} {MostExerciseStudent.LastName}");

            Console.WriteLine();
// How many students in each cohort?
            Console.WriteLine("-----Cohort Student Count-----");

            foreach(Cohort cohort in cohorts){
                Console.WriteLine($"{cohort.Name} {cohort.Students.Count()}");
            }
            
        }
    }
}
