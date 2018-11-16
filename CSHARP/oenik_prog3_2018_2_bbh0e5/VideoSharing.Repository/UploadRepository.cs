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
    /// Upload table CRUD commands.
    /// </summary>
    public class UploadRepository : IRepository<Uploads>
    {
        private SystemDBEntities vs;

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadRepository"/> class.
        /// Set value for vs variable.
        /// </summary>
        public UploadRepository()
        {
            this.vs = new SystemDBEntities();
        }

        /// <summary>
        /// Delete from Uploads table.
        /// </summary>
        /// <param name="id">Upload id what will delete.</param>
        public void Delete(int id)
        {
            Uploads item = (from e in this.vs.Uploads
                            where e.upload_id == id
                            select e).FirstOrDefault();

            this.vs.Uploads.Remove(item);
        }

        /// <summary>
        /// Get all rows from Uploads table.
        /// </summary>
        /// <returns>IEnumerable collection what containts all rows from Upload table-</returns>
        public IEnumerable<Uploads> GetAll()
        {
            return from e in this.vs.Uploads
                   select e;
        }

        /// <summary>
        /// Add a new row to Uploads table.
        /// </summary>
        /// <param name="item">This is the new item.</param>
        public void Insert(Uploads item)
        {
            this.vs.Uploads.Add(item);
        }

        /// <summary>
        /// Update a row in Uploads table.
        /// </summary>
        /// <param name="item">This is the modified row.</param>
        public void Update(Uploads item)
        {
            throw new NotImplementedException();
        }
    }
}
