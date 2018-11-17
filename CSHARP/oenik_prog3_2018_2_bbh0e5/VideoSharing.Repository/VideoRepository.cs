// <copyright file="VideoRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace VideoSharing.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VideoSharing.Data;

    public class VideoRepository : IRepository<Creators>
    {
        private SystemDBEntities entities;

        public VideoRepository()
        {
            this.entities = new SystemDBEntities();
        }

        public Videos MakeObject(string[] parameters)
        {
            return new Videos()
            {
                video_id = int.Parse(parameters[0]),
                video_title = parameters[1],
                video_description = parameters[2],
                video_views = int.Parse(parameters[3]),
                category_id = int.Parse(parameters[4])
            };
        }

        public void Delete(int id)
        {
            Videos item = (from e in this.entities.Videos
                           where e.video_id == id
                           select e).FirstOrDefault();

            this.entities.Videos.Remove(item);
            this.entities.SaveChanges();
        }

        public List<string> GetAll()
        {
            var q = from e in this.entities.Videos
                    select e.video_title;

            List<string> temp = new List<string>();

            foreach (var item in q)
            {
                temp.Add(item);
            }

            return temp;
        }

        public void Insert(string[] parameters)
        {
            this.entities.Videos.Add(this.MakeObject(parameters));
            this.entities.SaveChanges();
        }

        public void Update(string[] parameters)
        {
            Videos update = this.MakeObject(parameters);

            Videos item = (from e in this.entities.Videos
                            where e.video_id == update.video_id
                            select e).First();

            item = update;

            this.entities.SaveChanges();
        }
    }
}
