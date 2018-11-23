// <copyright file="VideoRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace VideoSharing.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VideoSharing.Data;

    /// <summary>
    /// Includes Videos Entity calls.
    /// </summary>
    public class VideoRepository : IRepository<Videos>
    {
        private SystemDBEntities entities;

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoRepository"/> class.
        /// </summary>
        public VideoRepository()
        {
            this.entities = new SystemDBEntities();
        }

        /// <summary>
        /// Delete an exsisting item from Videos Entity.
        /// </summary>
        /// <param name="item">An instance</param>
        public void Delete(Videos item)
        {
            Videos r = (from e in this.entities.Videos
                        where e.video_id == item.video_id
                        select e).First();

            this.entities.Videos.Remove(r);
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Returns all items from the table.
        /// </summary>
        /// <returns>List of elements.</returns>
        public IQueryable<Videos> GetAll()
        {
            return this.entities.Videos;
        }

        /// <summary>
        /// Adds a new item to Videos Entity.
        /// </summary>
        /// <param name="item">An instance.</param>
        public void Insert(Videos item)
        {
            this.entities.Videos.Add(item);
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Updates an exsisting item from Videos Entity.
        /// </summary>
        /// <param name="item">An instance</param>
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
