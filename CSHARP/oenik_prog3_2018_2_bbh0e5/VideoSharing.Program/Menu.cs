﻿// <copyright file="Menu.cs" company="PlaceholderCompany">
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
        /// <param name="list">List of menu elements.</param>
        public Menu(List<string> list)
        {
            this.SelectedMenuItemIndex = -1;

            this.MenuItems = list;
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
            Console.Clear();
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
