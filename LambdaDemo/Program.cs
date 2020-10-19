using System;
using System.Collections.Generic;

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

        }

        private static void AddRecords(List<Person> personList)
        {
            Person person1 = new Person(100, "ktr", "palasa", 22);
            personList.Add(person1);

            Person person2 = new Person(101, "tkr", "palas", 21);
            personList.Add(person2);

            Person person3 = new Person(102, "krt", "plasa", 20);
            personList.Add(person3);

            Person person4 = new Person(103, "rkt", "pasa", 19);
            personList.Add(person4);
        }
    }
}
