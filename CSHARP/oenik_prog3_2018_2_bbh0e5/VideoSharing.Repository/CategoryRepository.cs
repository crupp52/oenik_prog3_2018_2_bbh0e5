// <copyright file="CategoryRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace VideoSharing.Repository
{
    using System.Linq;
    using VideoSharing.Data;

    /// <summary>
    /// Includes Category Entity calls.
    /// </summary>
    public class CategoryRepository : IRepository<Categories>
    {
        private SystemDBEntities entities;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryRepository"/> class.
        /// </summary>
        public CategoryRepository()
        {
            this.entities = new SystemDBEntities();
        }

        /// <summary>
        /// Delete an exsisting item from Categories Entity.
        /// </summary>
        /// <param name="item">An instance.</param>
        public void Delete(Categories item)
        {
            Categories r = (from e in this.entities.Categories
                          where e.category_id == item.category_id
                            select e).First();

            this.entities.Categories.Remove(r);
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Returns all items from the table.
        /// </summary>
        /// <returns>List of elements.</returns>
        public IQueryable<Categories> GetAll()
        {
            return this.entities.Categories;
        }

        /// <summary>
        ///  Adds an new item to Categories Entity.
        /// </summary>
        /// <param name="item">An instance.</param>
        public void Insert(Categories item)
        {
            this.entities.Categories.Add(item);
            this.entities.SaveChanges();
        }

        /// <summary>
        ///  Updates an exsisting item from Categories Entity.
        /// </summary>
        /// <param name="item">An instance.</param>
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
