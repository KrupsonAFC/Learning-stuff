using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_League
{
    public class Team 
    {
        public string Name { get; set; }
        public int Position { get; set; } //zasada: property z wielkiej litery znaczynamy
        public int Points { get; set; } //zasada: property z wielkiej litery znaczynamy

        public void GetName()
        {
            Name = Console.ReadLine();
            StreamWriter sw = new StreamWriter(DatabaseService.path, true);
            sw.WriteLine(Name);
            sw.Close();
            Console.Clear();
            Console.WriteLine($"Dodano zespół {Name}\n\n");            
        }
    }
}
