﻿using System;
using System.Collections.Generic;

namespace ActionAndFuncDelegatesInCSharp
{
    public class Program
    {

        public static void FuncDelegate(List<Person> threePersons) { }
        public static void ActionDelegate(List<Person> threePersons)
        {
            // Using Action delegate to introduce a person
            Action<string, string> introduction = (name, gender) =>
            {
                Console.WriteLine($"{name} is a {gender}");
            };


            // Iterate through the list of persons and introduce them
            foreach (Person person in threePersons)
            {
                introduction(person.Name, person.Gender);
            }

        }

        public static void Main(string[] args)
        {
            List<Person> threePersons = new List<Person>
            {
                new Person {Name = "Jane", Gender = "Female", Country = "Australia"},
                new Person {Name = "Mark", Gender = "Male", Country = "Germany"},
                new Person {Name = "John", Gender = "Male", Country = "Mexico"},
            };


            // Using Func delegate to fully introduce a person
            Func<Person, string> fullIntroduction = (person) => person.Name + " is a " + person.Gender + " from " + person.Country;

            foreach (Person person in threePersons)
            {
                Console.WriteLine(fullIntroduction(person));
            }

            Console.ReadKey();
        }
    }

}
