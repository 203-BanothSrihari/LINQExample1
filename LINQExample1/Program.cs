using System;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;

namespace LINQExample1
{
    class Program
    {
        private static object s;

        static void Main(string[] args)
        {
            string[] names = {"Srihari", "Srikanth", "Naveen", "Srinu", "Venkatesh",
            "Rajiv", "Quresh", "Ashif", "Nagaraju", "Prasad"};

            //using linq queries
           // UsingLINQ(names);

            UsingLINQFunctions(names);
        }


        private static void UsingLINQ(string[] names)
        {
            IEnumerable<string> query = from s in names
                                        where (s.Length > 5 && s.Contains("a"))
                                        select s;

            foreach (var item in query)
                Console.WriteLine(item);

            Console.Read();
        }

        private static void UsingLINQFunctions(string[] names)
        {
            IEnumerable<string> result = names
                                        .Where(s => s.Length > 5 && s.Contains("a"))
                                        .Select(s=>s.ToUpper());
            foreach (var item in result)
                Console.WriteLine(item);

            Console.Read();
        }
    }
}

