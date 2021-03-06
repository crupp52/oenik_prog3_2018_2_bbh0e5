﻿// <copyright file="Tools.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace VideoSharing.Program
{
    using System;
    using VideoSharing.Data;

    /// <summary>
    /// Containts types of Entity Classes what object can happen.
    /// </summary>
    public enum Tables
    {
        /// <summary>
        /// Videos type
        /// </summary>
        Videos,

        /// <summary>
        /// Categories type
        /// </summary>
        Categories,

        /// <summary>
        /// Creators type
        /// </summary>
        Creators
    }

    /// <summary>
    /// Contains the ToStringArray and the CallQruery functions.
    /// </summary>
    public static class Tools
    {
        /// <summary>
        /// Collect parameters from console and create an object.
        /// </summary>
        /// <param name="types">Includes the type of output.</param>
        /// <returns>Returns to a t type object.</returns>
        public static object CollectParameters(Tables types)
        {
            Console.WriteLine("Add meg a bemeneti paramétereket SZÓKÖZZEL elválasztva!");
            Console.WriteLine("A művelet megszakításáshoz hagy üresen a beviteli mezőt és üss egy ENTER-t!");

            switch (types)
            {
                case Tables.Videos:
                    Console.WriteLine("Sorrend: video_id(int) video_title(string) video_description(string) video_views(int) category_id(int)");
                    break;
                case Tables.Categories:
                    Console.WriteLine("Sorrend: category_id(int) category_name(string) category_adult(int, 0 vagy 1)");
                    break;
                case Tables.Creators:
                    Console.WriteLine("Sorrend: creator_id(int) creator_name(string) creator_email(string) creator_birth_date(string) creator_premium(int, 0 vagy 1)");
                    break;
                default:
                    break;
            }

            Console.Write("Paraméterek: ");
            string input = Console.ReadLine();

            if (input != string.Empty)
            {
                string[] parameters = input.Split(' ');

                try
                {
                    switch (types)
                    {
                        case Tables.Videos:
                            return new Videos() { video_id = int.Parse(parameters[0]), video_title = parameters[1], video_description = parameters[2], video_views = int.Parse(parameters[3]), category_id = int.Parse(parameters[4]) };
                        case Tables.Categories:
                            return new Categories() { category_id = int.Parse(parameters[0]), category_name = parameters[1], category_adult = int.Parse(parameters[2]) };
                        case Tables.Creators:
                            return new Creators() { creator_id = int.Parse(parameters[0]), creator_name = parameters[1], creator_email = parameters[2], creator_birth_date = DateTime.Parse(parameters[3]), creator_premium = int.Parse(parameters[4]) };
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hibás a bemenet formátuma! {0}", e.Message);
                }
            }

            return null;
        }

        /// <summary>
        /// Collect an ID from console.
        /// </summary>
        /// <returns>Returns an integer ID.</returns>
        public static int CollectId()
        {
            Console.Write("Add meg az ID-t: ");
            string id = Console.ReadLine();

            return int.Parse(id);
        }
    }
}
