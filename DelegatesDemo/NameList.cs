using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class NameList
    {

        public NameList()
        {
            List<string> names = new List<string>() { "Mike", "Peters", "Munir", "Christian" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.RemoveAll(Filter);

            Console.WriteLine("\nAfter RemoveAll\n");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


        }

        public bool Filter(string s)
        {
            return s.Contains("i");
        }

    }
}
