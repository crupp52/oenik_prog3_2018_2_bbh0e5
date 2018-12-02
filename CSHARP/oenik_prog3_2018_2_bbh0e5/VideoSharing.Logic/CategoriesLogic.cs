// <copyright file="CategoriesLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace VideoSharing.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VideoSharing.Data;
    using VideoSharing.Repository;

    /// <summary>
    /// Handles repository queries and forward requests.
    /// </summary>
    public class CategoriesLogic : ILogic<Categories>
    {
        private IRepository<Categories> repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesLogic"/> class.
        /// </summary>
        /// <param name="repository">External repository for test.</param>
        public CategoriesLogic(IRepository<Categories> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesLogic"/> class.
        /// </summary>
        public CategoriesLogic()
        {
            this.repository = new CategoryRepository();
        }

        /// <summary>
        /// Returns the contents of the list.
        /// </summary>
        /// <returns>List of the elements.</returns>
        public IQueryable<Categories> GetAll()
        {
            var q = from e in this.repository.GetAll()
                    select e;

            return q;
        }

        /// <summary>
        /// Returns the contents of the list where the element id is equals with parameter id.
        /// </summary>
        /// <param name="id">Integer ID parameter.</param>
        /// <returns>List of the elements.</returns>
        public IQueryable<Categories> GetElementById(int id)
        {
            return from e in this.repository.GetAll()
                   where e.category_id == id
                   select e;
        }

        /// <summary>
        /// Returns the contents of the list where the element name is equals with parameter name.
        /// </summary>
        /// <param name="name">String name parameter.</param>
        /// <returns>List of the elements.</returns>
        public IQueryable<Categories> GetElementByName(string name)
        {
            return from e in this.repository.GetAll()
                   where e.category_name.Contains(name)
                   select e;
        }

        /// <summary>
        /// Add a new element to Entity Model.
        /// </summary>
        /// <param name="item">An instance.</param>
        public void Insert(Categories item)
        {
            try
            {
                this.repository.Insert(item);
            }
            catch (Exception)
            {
                Console.WriteLine("Nem sikerült a hozzáadás.");
            }
        }

        /// <summary>
        /// Update an exsisting element from the Entity Model.
        /// </summary>
        /// <param name="item">An instance.</param>
        public void Update(Categories item)
        {
            try
            {
                this.repository.Update(item);
            }
            catch (Exception)
            {
                Console.WriteLine("Nem sikerült a módosítás.");
            }
        }

        /// <summary>
        /// Delete an exsisting element from the Entity Model.
        /// </summary>
        /// <param name="item">An instance.</param>
        public void Delete(Categories item)
        {
            try
            {
                this.repository.Delete(item);
            }
            catch (Exception)
            {
                Console.WriteLine("Nem sikerült a törlés.");
            }
        }
    }
}
