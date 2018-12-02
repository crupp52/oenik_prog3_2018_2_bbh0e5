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
        /// Initializes a new instance of the <see cref="Menu"/> class.
        /// Here set the list of menu items, draw menu and store the selected menu option.
        /// </summary>
        public Menu()
        {
            this.SelectedMenuItemIndex = -1;

            this.MenuItems = new List<string>()
             {
                "Categories tábla kilistázása",
                "Categories rekord hozzáfűzés",
                "Categories rekord módosítás",
                "Categories rekord törlés",
                "Videos tábla kilistázása",
                "Videos rekord hozzáfűzés",
                "Videos rekord módosítás",
                "Videos rekord törlés",
                "Creators tábla kilistázása",
                "Creators rekord hozzáfűzés",
                "Creators rekord módosítás",
                "Creators rekord törlés",
                "Videók és a hozzá tartozó kategóriák listázása",
                "Videók, feltöltő nevének és nézettség listázása",
                "Top 5 legnézettebb videó",
                "Java végpont figyelése",
                "Program bezárása"
             };
        }

        /// <summary>
        /// Gets menu option.
        /// </summary>
        public List<string> MenuItems { get; }

        /// <summary>
        /// Gets the selected menu option.
        /// </summary>
        public int SelectedMenuItemIndex { get; private set; }

        private int Index { get; set; }

        /// <summary>
        /// Draw out the all of menu options.
        /// </summary>
        public void PrintMenu()
        {
            this.SelectedMenuItemIndex = -1;

            while (this.SelectedMenuItemIndex == -1)
            {
                this.GetSelectedIndex(this.MenuItems);
            }
        }

        private void GetSelectedIndex(List<string> items)
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
                this.SelectedMenuItemIndex = this.Index;
                Console.CursorVisible = true;
            }
            else
            {
                this.SelectedMenuItemIndex = -1;
            }

            Console.Clear();
        }

        private void DrawMenu(List<string> items)
        {
            Console.Clear();
            Console.WriteLine("Válassz az alábbi lehetőségek közül:");
            Console.CursorVisible = false;

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
