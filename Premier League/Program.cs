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
           // DisplayMenu();
           // MakeChoice();
            DatabaseService.SaveDatabase();
            StreamWriter sw = new StreamWriter(DatabaseService.path);
            sw.WriteLine("I hope it works");
            sw.Close();
        }
        
        public static void DisplayMenu()
        {            
            List<string> Menu = new List<string>();
            Menu.Add("1. Wyświetl tabelę");
            Menu.Add("2. Edytuj listę drużyn");
            Menu.Add("3. Dodaj rezultat spotkania");
            Menu.Add("4. Edytuj rezultat spotkania");
            Menu.Add("0. Zamknij program");

            for (int i = 0; i < Menu.Count; i++)
            {
                Console.WriteLine(Menu[i]);
            }
        }

        public static void EditTeamList()
        {
            DisplayEditionMenu();
            bool check = false; //jak na gorze
            ConsoleKeyInfo number; // jak na gorze
            do
            {
                number = Console.ReadKey();
                switch (number.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        check = true;
                        Console.WriteLine("Dodawanie zespołu");
                        break;
                    case '2':
                        Console.Clear();
                        check = true;
                        Console.WriteLine("Edycja zespołu");
                        break;
                    case '3':
                        Console.Clear();
                        check = true;
                        Console.WriteLine("Usuwanie zespołu");
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
            List<string> Menu = new List<string>();
            Menu.Add("1. Dodaj zespół");
            Menu.Add("2. Edytuj zespół");
            Menu.Add("3. Usuń zespół");
            Menu.Add("0. Wróc do poprzedniego menu");
            for (int i = 0; i < Menu.Count; i++)
            {
                Console.WriteLine(Menu[i]);
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
                        Console.WriteLine("Tu bedzie tabela");
                        break;
                    case '2':
                        Console.Clear();
                        check = true;
                        //Console.WriteLine("Tu se bedziesz edytował liste teamow");
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
        
    }
}
