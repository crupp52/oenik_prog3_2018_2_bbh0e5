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
    class UploadRepository : IRepository<Uploads>
    {
        private SystemDBEntities vs;

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadRepository"/> class.
        /// Set value for vs variable.
        /// </summary>
        public UploadRepository()
        {
            throw new NotImplementedException();
        }

        public void Delete(Uploads item)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Uploads> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Uploads item)
        {
        }

        public void Modify(Uploads item)
        {
            throw new NotImplementedException();
        }
    }
}
