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
        private SystemDBEntities entities;

        public UploadRepository()
        {
            this.entities = new SystemDBEntities();
        }

        public void Delete(Uploads item)
        {
            Uploads r = (from e in this.entities.Uploads
                         where e.upload_id == item.upload_id
                         select e).First();

            this.entities.Uploads.Remove(r);
            this.entities.SaveChanges();
        }

        public IQueryable<Uploads> GetAll()
        {
            return this.entities.Uploads;
        }

        public void Insert(Uploads item)
        {
            this.entities.Uploads.Add(item);
            this.entities.SaveChanges();
        }

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
