using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Lambda Expressions!");

            //UC 1: Creating list and insert records
            List<Person> personList = new List<Person>();
            AddRecords(personList);

            //UC 2: Accessing top 2 records whose Age below 60
            AccessRecordsAgeWise(personList, 2, 60);
        }

        private static void AccessRecordsAgeWise(List<Person> personList,int records,int belowAge)
        {
            foreach (Person person in personList.FindAll(e => (e.age < belowAge)).Take(records).ToList()) 
            {
                Console.WriteLine("Name : " + person.name + "\t\tAge: " + person.age);
            }
        }
        private static void AddRecords(List<Person> personList)
        {
            personList.Add(new Person(100, "ktr", "palasa", 22));

            personList.Add(new Person(101, "tkr", "palas", 21));

            personList.Add(new Person(102, "krt", "plasa", 65));

            personList.Add(new Person(103, "rkt", "pasa", 19));
        }
    }
}
