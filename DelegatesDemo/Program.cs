using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class Program
    {
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            /* NameList class
            NameList nl = new NameList();
            */

            /* Person Class
             


            */

            Person p1 = new Person() { Name = "Mike", Age = 34 };
            Person p2 = new Person() { Name = "Munir", Age = 16 };
            Person p3 = new Person() { Name = "Matt", Age = 70 };
            Person p4 = new Person() { Name = "Jenn", Age = 28 };

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, IsMinor);
            Console.WriteLine("\n");
            DisplayPeople("Adult", people, IsAdult);
            Console.WriteLine("\n");
            DisplayPeople("Senior", people, IsSenior);


            /* Create a new variable called filter of type FilterDelegate.
             * Then we assigned an anonymours method to it instead of an already defined method
             */

            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            };

            Console.WriteLine("\n");
            DisplayPeople("Young Adult", people, filter);


            Console.WriteLine("\n");
            DisplayPeople("All: ", people, delegate (Person p) { return true; });
            
            Console.WriteLine("\n");
            Console.WriteLine("\nStatement Lambda");
            string searchKeyword = "a";
            DisplayPeople("Age > 20 with search Keyword: " + searchKeyword, people, p =>
               {
                   if(p.Name.Contains(searchKeyword) && p.Age>20)
                   {
                       return true;
                   }
                   else
                   {
                       return false;
                   }
               });

            Console.WriteLine("\n");
            Console.WriteLine("\nExpression Lambda");

            DisplayPeople("exactly 34: ", people, p => p.Age == 34);

            Console.ReadKey();
        }

        /*A method to display the list of people that passes the filter condition
         * (returns true)
         * this method will take a title to be displayed, the list of people,
         * and a filter delegate
         */

        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach(Person p in people)
            {
                if(filter(p))
                {
                    Console.WriteLine($"{p.Name}, {p.Age} years old");
                }
            }
        }

        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }
}
