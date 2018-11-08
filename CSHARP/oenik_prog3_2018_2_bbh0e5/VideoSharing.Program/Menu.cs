// <copyright file="Menu.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace VideoSharing.Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Manage and show menu options.
    /// </summary>
    internal class Menu
    {
        private static int index = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Menu"/> class.
        /// If the menu object will be instanced automatically called the PrintMenu method.
        /// </summary>
        public Menu()
        {
            List<string> menuItems = new List<string>() {
                "Videos tábla kilistázása",
                "Videos tábla módosítása",
                "Videos tábla hozzáfűzés",
                "Videos tábla módosítás",
                "Categories tábla kilistázása",
                "Categories tábla módosítása",
                "Categories tábla hozzáfűzés",
                "Categories tábla módosítás",
                "Creators tábla kilistázása",
                "Creators tábla módosítása",
                "Creators tábla hozzáfűzés",
                "Creators tábla módosítás",
                "Uploads tábla kilistázása",
                "Uploads tábla módosítása",
                "Uploads tábla hozzáfűzés",
                "Uploads tábla módosítás",
                "Program bezárása"
            };

            Console.CursorVisible = false;
            while (true)
            {
                int selectedMenuItemIndex = GetSelectedIndex(menuItems);
                if (menuItems.Count - 1 == selectedMenuItemIndex)
                {
                    Environment.Exit(0);
                }
            }
        }

        private static int GetSelectedIndex(List<string> items)
        {
            DrawMenu(items);

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index != items.Count - 1)
                {
                    index++;
                }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index > 0)
                {
                    index--;
                }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                return index;
            }

            Console.Clear();
            return -1;
        }

        public static void DrawMenu(List<string> items)
        {
            Console.WriteLine("Válassz az alábbi lehetőségek közül:");

            for (int i = 0; i < items.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine(items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
                Console.ResetColor();
            }
        }
    }
}
