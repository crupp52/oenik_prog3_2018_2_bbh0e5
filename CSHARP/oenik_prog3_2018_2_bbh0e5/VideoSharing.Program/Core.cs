// <copyright file="Core.cs" company="PlaceholderCompany">
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
    /// This class will call Menu, and Logic functions.
    /// </summary>
    public class Core
    {
        private Menu m;

        /// <summary>
        /// Initializes a new instance of the <see cref="Core"/> class.
        /// Set the menu object and draw menu.
        /// </summary>
        public Core()
        {
            this.m = new Menu();

            Console.WriteLine(this.m.MenuItems[this.m.SelectedMenuItemIndex]);
            Console.ReadKey();
        }
    }
}
