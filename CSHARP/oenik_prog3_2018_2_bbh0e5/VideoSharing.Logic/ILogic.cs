// <copyright file="ILogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace VideoSharing.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VideoSharing.Repository;

    /// <summary>
    /// asd
    /// </summary>
    /// <typeparam name="T">asd1</typeparam>
    public interface ILogic<T>
    {
        /// <summary>
        /// Returns the contents of the list.
        /// </summary>
        /// <returns>List of the elements.</returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Add a new element to Entity Model.
        /// </summary>
        /// <param name="item">An instance.</param>
        void Insert(T item);

        /// <summary>
        /// Update an exsisting element from the Entity Model.
        /// </summary>
        /// <param name="item">An instance.</param>
        void Update(T item);

        /// <summary>
        /// Delete an exsisting element from the Entity Model.
        /// </summary>
        /// <param name="item">An instance.</param>
        void Delete(T item);
    }
}
