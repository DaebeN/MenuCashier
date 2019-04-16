using System;
using System.Collections.Generic;

namespace responsi
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
                    Makanan makanan = new Makanan(dishes);
                    makanan.PreSales();

                    Console.ReadKey();
                    break;
                }
                else if (menu.Equals(1))
                {
                    Console.WriteLine("Komposisi");

                    Minuman minuman = new Minuman();
                    minuman.PreSales();
                    minuman.ListDish();

                    Console.ReadKey();
                    break;
                }
                else if (menu.Equals(2))
                {
                    Console.WriteLine("Dependensi");

                    Dishes dishes = new Dishes();
                    Lain lain = new Lain();
                    lain.PreSales(dishes);

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
