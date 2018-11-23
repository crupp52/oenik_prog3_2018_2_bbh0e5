// <copyright file="CreatorRepository.cs" company="PlaceholderCompany">
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

    /// <summary>
    /// Includes Creator Entity calls.
    /// </summary>
    public class CreatorRepository : IRepository<Creators>
    {
        private SystemDBEntities entities;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatorRepository"/> class.
        /// </summary>
        public CreatorRepository()
        {
            this.entities = new SystemDBEntities();
        }

        /// <summary>
        /// Delete an exsisting item from Creators Entity.
        /// </summary>
        /// <param name="item">An instance.</param>
        public void Delete(Creators item)
        {
            Creators r = (from e in this.entities.Creators
                         where e.creator_id == item.creator_id
                          select e).First();

            this.entities.Creators.Remove(r);
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Returns all items from the table.
        /// </summary>
        /// <returns>List of elements.</returns>
        public IQueryable<Creators> GetAll()
        {
            return this.entities.Creators;
        }

        /// <summary>
        /// Adds a new item to Creators Entity.
        /// </summary>
        /// <param name="item">An instance.</param>
        public void Insert(Creators item)
        {
            this.entities.Creators.Add(item);
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Updates an exsisting item from Creators Entity.
        /// </summary>
        /// <param name="item">An instance.</param>
        public void Update(Creators item)
        {
            Creators update = (from e in this.entities.Creators
                              where e.creator_id == item.creator_id
                               select e).First();

            update = item;

            this.entities.SaveChanges();
        }
    }
}
