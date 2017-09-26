using System;
using System.Collections.Generic;
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
            bool done = false;
            do
            {
                ConsoleKeyInfo number = Console.ReadKey();
                switch (number.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        done = true;
                        Console.WriteLine("Tu bedzie tabela");
                        break;
                    case '2':
                        Console.Clear();
                        done = true;
                        Console.WriteLine("Tu se bedziesz edytował liste teamow");
                        break;
                    case '3':
                        Console.Clear();
                        done = true;
                        Console.WriteLine("Tu bedziesz dodawał wyniki");
                        break;
                    case '4':
                        Console.Clear();
                        done = true;
                        Console.WriteLine("Tu bedziesz zmieniał wyniki jak cos zjebałes");
                        break;
                    default:
                        Console.WriteLine("\nPodaj poprawny numer kalaputniaku");
                        break;

                }
            }
            while (!done);
            Console.ReadLine();
        }

        
        public static void DisplayMenu()
        {
            Console.WriteLine("1. Wyświetl tabelę\n" +
                "2. Edytuj listę drużyn\n" +
                "3. Dodaj rezultat spotkania\n" +
                "4. Edytuj rezultat spotkania\n");
        }
    }
}
