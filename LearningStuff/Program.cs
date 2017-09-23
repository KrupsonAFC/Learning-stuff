using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine(Name);
            Console.Read();

            NewStringDisplayStandardIsSoAwesome();
        }

        public static void NewStringDisplayStandardIsSoAwesome()
        {
            int age = 22;
            var name = "Tomek";
            string surname = "Krupa";

            var result = $"Siema! Jest {name} {surname} i ma {age} lat.";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
