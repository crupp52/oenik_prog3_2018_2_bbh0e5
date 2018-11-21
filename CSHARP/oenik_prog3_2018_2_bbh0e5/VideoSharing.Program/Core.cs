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
        private CategoriesLogic categoriesLogic;
        private VideosLogic videosLogic;
        private CreatorsLogic creatorsLogic;

        private Menu m;

        /// <summary>
        /// Initializes a new instance of the <see cref="Core"/> class.
        /// Set the menu object and draw menu.
        /// </summary>
        public Core()
        {
            this.m = new Menu();

            this.categoriesLogic = new CategoriesLogic();
            this.videosLogic = new VideosLogic();
            this.creatorsLogic = new CreatorsLogic();

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
                    this.WriteOut(this.categoriesLogic.GetAll());
                    break;
                case 1:
                    this.categoriesLogic.Insert(Tools.CollectParameters());
                    break;
                case 2:
                    this.categoriesLogic.Update(Tools.CollectParameters());
                    break;
                case 3:
                    this.categoriesLogic.Delete(Tools.CollectParameters());
                    break;
                case 4:
                    this.WriteOut(this.videosLogic.GetAll());
                    break;
                case 5:
                    this.videosLogic.Insert(Tools.CollectParameters());
                    break;
                case 6:
                    this.videosLogic.Update(Tools.CollectParameters());
                    break;
                case 7:
                    this.videosLogic.Delete(Tools.CollectParameters());
                    break;
                case 8:
                    this.WriteOut(this.creatorsLogic.GetAll());
                    break;
                case 9:
                    this.creatorsLogic.Insert(Tools.CollectParameters());
                    break;
                case 10:
                    this.creatorsLogic.Update(Tools.CollectParameters());
                    break;
                case 11:
                    this.creatorsLogic.Delete(Tools.CollectParameters());
                    break;
                default:
                    break;
            }
        }
    }
}
