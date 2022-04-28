using Exercise.Lists.Models;
using Exercise.Lists.Utils;
using System;
using System.Collections.Generic;

namespace Exercise.Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<LogEntry> logs = new List<LogEntry>();

            string peopleFile = @"C:\Temp\students.csv";
            string logFile = @"C:\Temp\logs.csv";

            PopulateLists(people);
            OriginalTextFileProcessor.SavePeople(people, peopleFile);

            var newPeople = OriginalTextFileProcessor.LoadPeople(peopleFile);

            foreach (var p in newPeople)
            {
                Console.WriteLine($"{ p.FirstName } { p.LastName } )");
            }
        }
        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }

            var myPersonObjects = new List<Person>() 
            {
                new Person { Id = 1,  Name = "Aldo" },
                new Person { Id = 2,  Name = "Giovanni" },
                new Person { Id = 3,  Name = "Giacomo" }
            };
            
        }

    }
}