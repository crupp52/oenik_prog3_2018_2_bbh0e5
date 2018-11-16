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
    public class Menu
    {
        /// <summary>
        /// Gets menu option.
        /// </summary>
        public List<string> MenuItems { get; }

        /// <summary>
        /// Gets the selected menu option.
        /// </summary>
        public int SelectedMenuItemIndex { get; }

        private int Index { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Menu"/> class.
        /// Here set the list of menu items, draw menu and store the selected menu option.
        /// </summary>
        public Menu()
        {
            this.SelectedMenuItemIndex = -1;

            this.MenuItems = new List<string>()
            {
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
            while (this.SelectedMenuItemIndex == -1)
            {
                this.SelectedMenuItemIndex = this.GetSelectedIndex(this.MenuItems);
            }
        }

        private int GetSelectedIndex(List<string> items)
        {
            this.DrawMenu(items);

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (this.Index != items.Count - 1)
                {
                    this.Index++;
                }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (this.Index > 0)
                {
                    this.Index--;
                }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                return this.Index;
            }

            Console.Clear();
            return -1;
        }

        private void DrawMenu(List<string> items)
        {
            Console.WriteLine("Válassz az alábbi lehetőségek közül:");

            for (int i = 0; i < items.Count; i++)
            {
                if (i == this.Index)
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
