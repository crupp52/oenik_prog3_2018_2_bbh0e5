// <copyright file="UploadRepository.cs" company="PlaceholderCompany">
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
    public class UploadRepository : IRepository<Uploads>
    {
        private SystemDBEntities entities;

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadRepository"/> class.
        /// </summary>
        public UploadRepository()
        {
            this.entities = new SystemDBEntities();
        }

        /// <summary>
        /// Delete an exsisting item from Uploads Entity.
        /// </summary>
        /// <param name="item">An instance.</param>
        public void Delete(Uploads item)
        {
            Uploads r = (from e in this.entities.Uploads
                         where e.upload_id == item.upload_id
                         select e).First();

            this.entities.Uploads.Remove(r);
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Returns all items from the table.
        /// </summary>
        /// <returns>List of elements.</returns>
        public IQueryable<Uploads> GetAll()
        {
            return this.entities.Uploads;
        }

        /// <summary>
        /// Adds a new item to Uploads Entity.
        /// </summary>
        /// <param name="item">An Instance.</param>
        public void Insert(Uploads item)
        {
            this.entities.Uploads.Add(item);
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Updates an exsisting item from Uploads Entity.
        /// </summary>
        /// <param name="item">An Instance.</param>
        public void Update(Uploads item)
        {
            Uploads update = (from e in this.entities.Uploads
                             where e.upload_id == item.upload_id
                             select e).First();

            update = item;

            this.entities.SaveChanges();
        }
    }
}
