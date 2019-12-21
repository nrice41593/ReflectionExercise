using System;
using System.Reflection;
using System.Security;

namespace ReflectionExercise
{
    public class Program
    {
        public static void Main()
        {

            //Exercise 1
            /*1) Get executing assembly.
              2) Get all types in executing assembly.
              3) In loop: for types where namespace starts with "University" - output type`s names, one per line.
              HINT: Watch out, namespace can be null.
             */






            //Exercise 2
            //1) Create new instance of StudentExercise2
            //2) Get instance type
            //3) Get property FullName by name from type
            //4) Set property value to "John Smith" using reflection






            //Exercise 3
            //1) Find GetCharacteristics method by name in type of StudentExercise3
            //2) Invoke GetCharacteristics method using reflection, also pass a parameter "false"
        }
    }


    namespace University
    {

        public class Student
        {
            public string FullName { get; set; }

            public int Class { get; set; }

            public DateTime DateOfBirth { get; set; }

            public string GetCharacteristics()
            {
                return "";
            }
        }

        namespace Department
        {

            public class Professor
            {

                public string FullName { get; set; }

            }
        }
    }

    public class StudentExercise2
    {
        public string FullName { get; set; }

        public int Class { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string GetCharacteristics()
        {
            return "";
        }
    }

    public class StudentExercise3
    {
        public string FullName { get; set; }

        public int Class { get; set; }

        public DateTime DateOfBirth { get; set; }

        public void GetCharacteristics(bool outputSomething)
        {
            Console.WriteLine(String.Format("[Characteristics:{0}]", outputSomething));
        }
    }
}
