// <copyright file="CategoryRepository.cs" company="PlaceholderCompany">
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

    public class CategoryRepository : IRepository<Categories>
    {
        public CategoryRepository()
        {
        }

        public void Delete(Categories item)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Categories> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Categories item)
        {
            throw new NotImplementedException();
        }

        public void Modify(Categories item)
        {
            throw new NotImplementedException();
        }
    }
}
