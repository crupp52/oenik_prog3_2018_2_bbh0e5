// <copyright file="Core.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace VideoSharing.Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
        private NonCrudLogic nonCrudLogic;
        private WebRequestLogic webLogic;

        private Menu m;

        /// <summary>
        /// Initializes a new instance of the <see cref="Core"/> class.
        /// Set the menu object and draw menu.
        /// </summary>
        public Core()
        {
            List<string> items = new List<string>()
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

            this.m = new Menu(items);

            this.categoriesLogic = new CategoriesLogic(new CategoryRepository());
            this.videosLogic = new VideosLogic(new VideoRepository());
            this.creatorsLogic = new CreatorsLogic(new CreatorRepository());
            this.nonCrudLogic = new NonCrudLogic();
            this.webLogic = new WebRequestLogic();

            while (this.m.SelectedMenuItemIndex != this.m.MenuItems.Count - 1)
            {
                this.m.PrintMenu();

                Console.WriteLine(this.m.MenuItems[this.m.SelectedMenuItemIndex]);

                this.CallQruery(this.m.SelectedMenuItemIndex);

                Console.Write("Nyomj meg egy gombot a folytatáshoz...");
                Console.ReadKey();
            }
        }

        private void WriteOutVideos(IQueryable<object> list)
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

        private void WriteOutNonCrud(List<string> input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }

        private void WriteOutWebRequest()
        {
            Console.WriteLine("Kinek szeretnél nevet generálni?");

            List<string> genders = new List<string>()
            {
                "Férfi",
                "Nő"
            };

            Menu jmenu = new Menu(genders);
            string t = string.Empty;

            while (jmenu.SelectedMenuItemIndex == -1)
            {
                jmenu.PrintMenu();
                t = jmenu.SelectedMenuItemIndex.ToString();
            }

            if (t == "0")
            {
                this.webLogic.ListenWeb("man");
            }
            else if (t == "1")
            {
                this.webLogic.ListenWeb("woman");
            }

            Console.Clear();

            string[] result = this.webLogic.ResponseString.Split('\n');
            for (int i = 0; i < result.Length - 1; i++)
            {
                Console.WriteLine($"{i + 1}: {result[i]}");
            }

            Console.Write("Létreszeretnél hozni egy felhasználót? (i/n) Válasz: ");
            string choice = Console.ReadLine();

            Random rnd = new Random();

            if (choice == "i")
            {
                Console.WriteLine("Add meg a választott felhasználónév sorszámát!");
                Console.Write("Válasz: ");

                int c = -1;
                switch (Console.ReadLine())
                {
                    case "1":
                        c = 1;
                        break;
                    case "2":
                        c = 2;
                        break;
                    case "3":
                        c = 3;
                        break;
                    case "4":
                        c = 4;
                        break;
                    case "5":
                        c = 5;
                        break;
                    default:
                        Console.WriteLine("Rossz input!");
                        break;
                }

                try
                {
                    string name = result[c - 1].Substring(0, result[c - 1].Length - 1);
                    this.creatorsLogic.Insert(new Creators() { creator_id = (int)rnd.Next(900, 1000), creator_name = name, creator_email = name + "@example.com", creator_birth_date = DateTime.Now, creator_premium = 0 });
                    Console.WriteLine("{0} felhasználó létrehozva!", name);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hiba! {0}", e.Message);
                }
            }
        }

        private void CallQruery(int select)
        {
            switch (select)
            {
                case 0:
                    this.WriteOutCategories(this.categoriesLogic.GetAll());
                    break;
                case 1:
                    this.categoriesLogic.Insert((Categories)Tools.CollectParameters(Tables.Categories));
                    break;
                case 2:
                    this.categoriesLogic.Update((Categories)Tools.CollectParameters(Tables.Categories));
                    break;
                case 3:
                    this.categoriesLogic.Delete((Categories)Tools.CollectParameters(Tables.Categories));
                    break;
                case 4:
                    this.WriteOutVideos(this.videosLogic.GetAll());
                    break;
                case 5:
                    this.videosLogic.Insert((Videos)Tools.CollectParameters(Tables.Videos));
                    break;
                case 6:
                    this.videosLogic.Update((Videos)Tools.CollectParameters(Tables.Videos));
                    break;
                case 7:
                    this.videosLogic.Delete((Videos)Tools.CollectParameters(Tables.Videos));
                    break;
                case 8:
                    this.WriteOutCreators(this.creatorsLogic.GetAll());
                    break;
                case 9:
                    this.creatorsLogic.Insert((Creators)Tools.CollectParameters(Tables.Creators));
                    break;
                case 10:
                    this.creatorsLogic.Update((Creators)Tools.CollectParameters(Tables.Creators));
                    break;
                case 11:
                    this.creatorsLogic.Delete((Creators)Tools.CollectParameters(Tables.Creators));
                    break;
                case 12:
                    this.WriteOutNonCrud(this.nonCrudLogic.VideoAndCategory());
                    break;
                case 13:
                    this.WriteOutNonCrud(this.nonCrudLogic.VideoCreatorViews());
                    break;
                case 14:
                    this.WriteOutNonCrud(this.nonCrudLogic.MostViewedVideos());
                    break;
                case 15:
                    this.WriteOutWebRequest();
                    break;
                default:
                    break;
            }
        }
    }
}
