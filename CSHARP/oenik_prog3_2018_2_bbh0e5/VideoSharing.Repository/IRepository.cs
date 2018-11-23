// <copyright file="IRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace VideoSharing.Repository
{
    using System.Linq;

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
        IQueryable<T> GetAll();

        /// <summary>
        /// Add an new item, to T Entity.
        /// </summary>
        /// <param name="item">T type will be Videos, Categories or Creators object</param>
        void Insert(T item);

        /// <summary>
        /// Update an exsisting item from T Entity.
        /// </summary>
        /// <param name="item">T type will be Videos, Categories or Creators object</param>
        void Update(T item);

        /// <summary>
        /// Delete an exsisting item from T Entity.
        /// </summary>
        /// <param name="item">T type will be Videos, Categories or Creators object</param>
        void Delete(T item);
    }
}
