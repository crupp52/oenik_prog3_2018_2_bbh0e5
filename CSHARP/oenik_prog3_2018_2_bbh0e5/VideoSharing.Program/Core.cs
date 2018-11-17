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
    using VideoSharing.Logic;

    /// <summary>
    /// This class will call Menu, and Logic functions.
    /// </summary>
    public class Core
    {
        private Logic logic;

        private Menu m;

        /// <summary>
        /// Initializes a new instance of the <see cref="Core"/> class.
        /// Set the menu object and draw menu.
        /// </summary>
        public Core()
        {
            this.m = new Menu();
            this.logic = new Logic();

            while (this.m.SelectedMenuItemIndex != this.m.MenuItems.Count - 1)
            {
                this.m.PrintMenu();

                Console.WriteLine(this.m.MenuItems[this.m.SelectedMenuItemIndex]);

                this.CallQruery(this.m.SelectedMenuItemIndex);

                Console.ReadKey();
            }
        }

        private void WriteOut(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void CallQruery(int select)
        {
            switch (select)
            {
                case 0:
                    this.WriteOut(this.logic.CategoriesGetAll());
                    break;
                case 1:
                    this.logic.CategoriesInsert(Tools.CollectParameters());
                    this.WriteOut(this.logic.CategoriesGetAll());
                    break;
                case 2:
                    this.logic.CategoriesUpdate(Tools.CollectParameters());
                    break;
                case 3:
                    this.logic.CategoriesDelete(Tools.CollectId());
                    break;
                case 4:
                    this.WriteOut(this.logic.VideosGetAll());
                    break;
                case 5:
                    this.logic.VideosInsert(Tools.CollectParameters());
                    break;
                case 6:
                    this.logic.VideosUpdate(Tools.CollectParameters());
                    break;
                case 7:
                    this.logic.VideosDelete(Tools.CollectId());
                    break;
                case 8:
                    this.WriteOut(this.logic.CreatorsGetAll());
                    break;
                case 9:
                    this.logic.CreatorsInsert(Tools.CollectParameters());
                    break;
                case 10:
                    this.logic.CreatorsUpdate(Tools.CollectParameters());
                    break;
                case 11:
                    this.logic.CreatorsDelete
                        (Tools.CollectId());
                    break;
                case 12:
                    this.WriteOut(this.logic.UploadsGetAll());
                    break;
                case 13:
                    this.logic.UploadsInsert(Tools.CollectParameters());
                    break;
                case 14:
                    this.logic.UploadsUpdate(Tools.CollectParameters());
                    break;
                case 15:
                    this.logic.UploadsDelete(Tools.CollectId());
                    break;
                default:
                    break;
            }
        }
    }
}
