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

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadRepository"/> class.
        /// Set value for vs variable.
        /// </summary>
        public UploadRepository()
        {
            this.entities = new SystemDBEntities();
        }

        /// <summary>
        /// Get all rows from Uploads table.
        /// </summary>
        /// <returns>IEnumerable collection what containts all rows from Upload table-</returns>
        public List<string> GetAll()
        {
            var q = from e in this.entities.Uploads
                   select e.upload_id;

            List<string> temp = new List<string>();

            foreach (var item in q)
            {
                temp.Add(item.ToString());
            }

            return temp;
        }

        /// <summary>
        /// Create an upload object from string parameters.
        /// </summary>
        /// <param name="parameters">Containts the object parameters.</param>
        /// <returns>Get an Upload object.</returns>
        public Uploads MakeObject(string[] parameters)
        {
            return new Uploads()
            {
                upload_id = int.Parse(parameters[0]),
                upload_date = DateTime.Parse(parameters[1]),
                video_id = int.Parse(parameters[2]),
                creator_id = int.Parse(parameters[3])
            };
        }

        /// <summary>
        /// Add a new row to Uploads table.
        /// </summary>
        /// <param name="parameters">This is the new item.</param>
        public void Insert(string[] parameters)
        {
            this.entities.Uploads.Add(this.MakeObject(parameters));
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Update a row in Uploads table.
        /// </summary>
        /// <param name="parameters">This is the modified row.</param>
        public void Update(string[] parameters)
        {
            Uploads update = this.MakeObject(parameters);

            Uploads item = (from e in this.entities.Uploads
                           where e.upload_id == update.upload_id
                           select e).First();

            item = update;

            this.entities.SaveChanges();
        }

        /// <summary>
        /// Delete from Uploads table.
        /// </summary>
        /// <param name="id">Upload id what will delete.</param>
        public void Delete(int id)
        {
            Uploads item = (from e in this.entities.Uploads
                            where e.upload_id == id
                            select e).FirstOrDefault();

            this.entities.Uploads.Remove(item);
            this.entities.SaveChanges();
        }
    }
}
