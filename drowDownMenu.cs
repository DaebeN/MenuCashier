using System;
using System.Collections.Generic;
namespace responsi
{
    public static class dropDownMenu
    {

        static int index;
        public static int MenuList(List<string> menuItem)
        {

            for (int i = 0; i < menuItem.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(menuItem[i]);
                }
                else
                {
                    Console.WriteLine(menuItem[i]);
                }
                Console.ResetColor();
            }
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                if (index >= menuItem.Count - 1)
                {

                }
                else
                {
                    index++;
                }
            }
            else if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {

                }
                else
                {
                    index--;
                }
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                return index;
            }
            else
            {
                return -1;
            }
            Console.Clear();
            return -1;
        }
    }
}
