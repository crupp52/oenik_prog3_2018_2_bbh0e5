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
    using VideoSharing.Data;
    using VideoSharing.Logic;
    using VideoSharing.Repository;

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

            this.categoriesLogic = new CategoriesLogic(new CategoryRepository());
            this.videosLogic = new VideosLogic(new VideoRepository());
            this.creatorsLogic = new CreatorsLogic(new CreatorRepository());

            while (this.m.SelectedMenuItemIndex != this.m.MenuItems.Count - 1)
            {
                this.m.PrintMenu();

                Console.WriteLine(this.m.MenuItems[this.m.SelectedMenuItemIndex]);

                this.CallQruery(this.m.SelectedMenuItemIndex);

                Console.ReadKey();
            }
        }

        private void WriteOutVideos(IQueryable<Videos> list)
        {
            foreach (Videos item in list)
            {
                Console.WriteLine("{0}   {1}   {2}   {3}   {4}", item.video_id, item.video_title, item.video_description, item.video_views, item.category_id);
            }
        }

        private void WriteOutCategories(IQueryable<Categories> list)
        {
            foreach (Categories item in list)
            {
                Console.WriteLine("{0}   {1}   {2}", item.category_id, item.category_name, item.category_adult);
            }
        }

        private void WriteOutCreators(IQueryable<Creators> list)
        {
            foreach (Creators item in list)
            {
                Console.WriteLine("{0}   {1}   {2}   {3}   {4}", item.creator_id, item.creator_name, item.creator_email, item.creator_birth_date, item.creator_premium);
            }
        }

        public void CallQruery(int select)
        {
            switch (select)
            {
                case 0:
                    this.WriteOutCategories(this.categoriesLogic.GetAll());
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
                    this.WriteOutVideos(this.videosLogic.GetAll());
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
                    this.WriteOutCreators(this.creatorsLogic.GetAll());
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
