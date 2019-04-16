using System;
using System.Collections.Generic;

namespace uts
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> menuItem = new List<string>() {
                "Agregasi",
                "Komposisi",
                "Dependensi",
                "exit"
            };

            Console.CursorVisible = false;
            while (true)
            {
                int menu = dropDownMenu.MenuList(menuItem);
                Console.Clear();
                if (menu.Equals(0))
                {
                    Console.WriteLine("Agregasi");

                    Dishes dishes = new Dishes();
                    Transaction transaction = new Transaction(dishes);
                    transaction.PreSales();

                    Console.ReadKey();
                    break;
                }
                else if (menu.Equals(1))
                {
                    Console.WriteLine("Komposisi");

                    Transaction2 transaction2 = new Transaction2();
                    transaction2.PreSales();
                    transaction2.ListDish();

                    Console.ReadKey();
                    break;
                }
                else if (menu.Equals(2))
                {
                    Console.WriteLine("Dependensi");

                    Dishes dishes = new Dishes();
                    Transaction3 transaction3 = new Transaction3();
                    transaction3.PreSales(dishes);

                    Console.ReadKey();
                    break;
                }
                else if (menu.Equals(3))
                {
                    Console.WriteLine("Terima Kasih...");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
    }
}
