using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_Lab03.Exercise
{
    public class Student
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Student(String name, String phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }

    public class ExampleDictionary
    {
        public String example()
        {
            Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();
            Student s1 = new Student("Ning", "29469740.");
            Student s2 = new Student("Kim", "0431170992");

            studentDictionary.Add(1, s1);
            studentDictionary.Add(2, s2);

            Student result = new Student("", "");

            studentDictionary.TryGetValue(1, out result);

            return "I am " + result.Name + ", and my student id is " + result.PhoneNumber;


     
        }
    }
}