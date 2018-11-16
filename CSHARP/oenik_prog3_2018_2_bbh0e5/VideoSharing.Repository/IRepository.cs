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

    /// <summary>
    /// Repository schema, what must be declarate.
    /// </summary>
    /// <typeparam name="T">T type what will be Uploads, Videos, Creators, Categories</typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Get all item from table
        /// </summary>
        /// <returns>Return an IQueryable variable what we can use for the query.</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Insert the selected item.
        /// </summary>
        /// <param name="item">This will be the new item.</param>
        void Insert(T item);

        /// <summary>
        /// Update the selected item.
        /// </summary>
        /// <param name="item">The item, what will Update.</param>
        void Update(T item);

        /// <summary>
        /// Delete the selected item.
        /// </summary>
        /// <param name="id">The item, what will delete.</param>
        void Delete(int id);
    }
}
