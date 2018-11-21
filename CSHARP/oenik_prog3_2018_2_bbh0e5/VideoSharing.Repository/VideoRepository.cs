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

    public class VideoRepository : IRepository<Videos>
    {
        private SystemDBEntities entities;

        public VideoRepository()
        {
            this.entities = new SystemDBEntities();
        }

        public void Delete(Videos item)
        {

            Videos r = (from e in this.entities.Videos
                        where e.video_id == item.video_id
                        select e).First();

            this.entities.Videos.Remove(r);
            this.entities.SaveChanges();
        }

        public IQueryable<Videos> GetAll()
        {
            return this.entities.Videos;
        }

        public void Insert(Videos item)
        {
            this.entities.Videos.Add(item);
            this.entities.SaveChanges();
        }

        public void Update(Videos item)
        {
            Videos update = (from e in this.entities.Videos
                            where e.video_id == item.video_id
                            select e).First();

            update = item;

            this.entities.SaveChanges();
        }
    }
}
