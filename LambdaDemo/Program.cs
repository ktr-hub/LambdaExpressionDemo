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

            //UC 3: Accessing records whose Age between 13-18
            AccessRecordsForAgesInBetween(personList, 13, 18);


            //UC 4: Accessing average Age of the list
            AverageOfAges(personList);
            
        }


        //UC 4: Accessing average Age of the list
        private static void AverageOfAges(List<Person> personList)
        {
            Console.WriteLine("\nAverage of the ages is : " +personList.Average(e=>e.age));
        }

        //UC 3: Accessing records whose Age between 13-18
        private static void AccessRecordsForAgesInBetween(List<Person> personList, int startAge, int endAge)
        {
            if (personList.Any(e => (e.age>13 && e.age<18))) 
            {
                Console.WriteLine("\nPersons with age between 13-18");
                foreach (Person person in personList.FindAll(e => (e.age > startAge && e.age < endAge)))
                {
                    Console.WriteLine("Name : " + person.name + "\t\tAge: " + person.age);
                }
            }
            else
            {
                Console.WriteLine("No data for specified Range");
            }
        }

        //UC 2: Accessing top 2 records whose Age below 60
        private static void AccessRecordsAgeWise(List<Person> personList,int records,int belowAge)
        {
            Console.WriteLine("\nTop 2 Persons with age below 60");
            foreach (Person person in personList.FindAll(e => (e.age < belowAge)).Take(records).ToList())
            {
                Console.WriteLine("Name : " + person.name + "\t\tAge: " + person.age);
            }
        }

        //UC 1: Creating list and insert records
        private static void AddRecords(List<Person> personList)
        {
            personList.Add(new Person(100, "ktr", "palasa", 22));

            personList.Add(new Person(101, "tkr", "palas", 21));

            personList.Add(new Person(101, "tkr", "palas", 58));

            personList.Add(new Person(102, "krt", "plasa", 65));

            personList.Add(new Person(103, "rkt", "pasa", 19));

            personList.Add(new Person(104, "rikit", "pasa", 14));

            personList.Add(new Person(105, "krit", "pasa", 10));

            personList.Add(new Person(106, "rkit", "pasa", 15));

            personList.Add(new Person(107, "rikita", "pasa", 16));

        }
    }
}
