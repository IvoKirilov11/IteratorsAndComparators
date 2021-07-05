using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string commandInpud = Console.ReadLine();

            while (commandInpud != "END")
            {
                string[] tokens = commandInpud.Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                people.Add(new Person(name, age, town));

                commandInpud = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());

            Person person = people[n - 1];
            int notEqual = 0;
            int countMaches = 0;

            foreach (Person currPerson in people)
            {
                int result = person.CompareTo(currPerson);

                if(result < 0)
                {
                    notEqual++;
                }
                else if(result > 0)
                {
                    notEqual++;
                }
                else
                {
                    countMaches++;
                }
            }

            if(countMaches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
              Console.WriteLine($"{countMaches} {notEqual} {people.Count}");
            }

            
        }
    }
}
