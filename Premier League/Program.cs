
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_League
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
            MakeChoice();
            DatabaseService.SaveDatabase();       
            
        }
        
        public static void DisplayMenu()
        {
            List<string> Menu = new List<string>()
            { "1. Wyświetl tabelę",
                "2. Edytuj listę drużyn",
                "3. Dodaj rezultat spotkania",
                "4. Edytuj rezultat spotkania",
                "0. Zamknij program"};
           
            foreach(var record in Menu)
            {
                Console.WriteLine(record);
            }
        }

        public static void EditTeamList()
        {
            List<string> Table = new List<string>();
            DisplayEditionMenu();
            bool check = false; 
            ConsoleKeyInfo number; 
            do
            {
                number = Console.ReadKey();
                switch (number.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        check = true;
                        Console.WriteLine("Podaj nazwę drużyny:");
                        Team NewTeam = new Team();
                        NewTeam.GetName();
                        EditTeamList();
                        break;
                    case '2':
                        Console.Clear();
                        check = true;
                        Console.WriteLine("Edycja zespołu");
                        break;
                    case '3':
                        Console.Clear();
                        check = true;                       
                        DeleteTeam();
                        EditTeamList();
                        break;
                    case '0':
                        Console.Clear();
                        check = true;
                        DisplayMenu();
                        MakeChoice();
                        break;
                    default:
                        Console.WriteLine("\nPodaj poprawny numer kalaputniaku");
                        break;
                }
            }
            while (!check);
        }
        
        public static void DisplayEditionMenu()
        {
            List<string> Menu = new List<string>()
            { "1. Dodaj zespół",
                "2. Edytuj zespół",
                "3. Usuń zespół",
                "0. Wróc do poprzedniego menu" };

            foreach (string i in Menu)
            {
                Console.WriteLine(i);
            }
        }

        public static void MakeChoice()
        {
            bool check = false;
            ConsoleKeyInfo choice;
            do
            {
                choice = Console.ReadKey();
                switch (choice.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        check = true;
                        if (File.Exists(DatabaseService.path))
                        {
                            DisplayTable();
                            DisplayMenu();
                            MakeChoice();
                        }
                        else
                        {
                            Console.WriteLine("Nie dodano żadnych zespołów\n\n");
                            DisplayMenu();
                            MakeChoice();
                        }
                        break;
                    case '2':
                        Console.Clear();
                        check = true;
                        EditTeamList();
                        break;
                    case '3':
                        Console.Clear();
                        check = true;
                        Console.WriteLine("Tu bedziesz dodawał wyniki");
                        break;
                    case '4':
                        Console.Clear();
                        check = true;
                        Console.WriteLine("Tu bedziesz zmieniał wyniki jak cos zjebałes");
                        break;
                    case '0':
                        check = true;
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("\nPodaj poprawny numer kalaputniaku");
                        break;

                }
            }
            while (!check);

        }   
        
        public static void DisplayTable()
        {
            StreamReader sr = new StreamReader(DatabaseService.path);
            Console.WriteLine(sr.ReadToEnd() + "\n\n");
            sr.Close();
        }

        public static void DeleteTeam()
        {
            List<string> Table = ReadTable();
            Console.WriteLine("Podaj nazwę zepołu do usunięcia\n" +
                "Istniejące zespoły:\n\n");
            DisplayTable();
            string name = Console.ReadLine();
            if (Table.Contains(name))
            {
                Table.Remove(name);
                StreamWriter sw = new StreamWriter(DatabaseService.path);
                foreach (string record in Table)
                {
                    sw.WriteLine(record);
                }
                sw.Close();
                Console.Clear();
                Console.WriteLine($"Usunięto zespół {name}\n\n");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("W tabeli nie ma takiego zespołu\n\n");
            }
        }

        public static List<string> ReadTable()
        {
            List<string> Table = new List<string>();
            StreamReader sr = new StreamReader(DatabaseService.path);
            while (sr.Peek() != -1)
            {
                Table.Add(sr.ReadLine());
            }
            sr.Close();

            return Table;
        }
    }
}
