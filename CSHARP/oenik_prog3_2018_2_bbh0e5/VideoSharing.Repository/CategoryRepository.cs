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
        private SystemDBEntities entities;

        public CategoryRepository()
        {
            this.entities = new SystemDBEntities();
        }

        public void Delete(Categories item)
        {
            Categories r = (from e in this.entities.Categories
                          where e.category_id == item.category_id
                            select e).First();

            this.entities.Categories.Remove(r);
            this.entities.SaveChanges();
        }

        public IQueryable<Categories> GetAll()
        {
            return this.entities.Categories;
        }

        public void Insert(Categories item)
        {
            this.entities.Categories.Add(item);
            this.entities.SaveChanges();
        }

        public void Update(Categories item)
        {
            Categories update = (from e in this.entities.Categories
                               where e.category_id == item.category_id
                                 select e).First();

            update = item;

            this.entities.SaveChanges();
        }
    }
}
