// <copyright file="IRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace VideoSharing.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IRepository<T>
    {
        /// <summary>
        /// Get all item from table
        /// </summary>
        /// <returns>Return an IQueryable variable what we can use for the query.</returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Insert the selected item.
        /// </summary>
        /// <param name="item">This will be the new item.</param>
        void Insert(T item);

        /// <summary>
        /// Delete the selected item.
        /// </summary>
        /// <param name="item">The item, what will be delete.</param>
        void Delete(T item);

        /// <summary>
        /// Modify the selected item.
        /// </summary>
        /// <param name="item">The item, what will be modify.</param>
        void Modify(T item);
    }
}
