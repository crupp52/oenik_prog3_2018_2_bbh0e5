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
    using VideoSharing.Data;
    using VideoSharing.Repository;

    /// <summary>
    /// Containt all must have datebase queries list.
    /// </summary>
    public interface ILogic
    {
        /// <summary>
        /// Get all rows from Uploads table
        /// </summary>
        /// <returns>List of all record from Uploads table</returns>
        IEnumerable<Uploads> UploadsGetAll();

        /// <summary>
        /// Insert a new row to Uploads table.
        /// </summary>
        /// <param name="item">This item will be added.</param>
        void UploadsInsert(Uploads item);

        /// <summary>
        /// Update the selected row in Uploads table.
        /// </summary>
        /// <param name="item">This item will be update.</param>
        void UploadsUpdate(Uploads item);

        /// <summary>
        /// Delete the selected row in Uploads table.
        /// </summary>
        /// <param name="item">This item will be delete.</param>
        void UploadsDelete(Uploads item);

        /// <summary>
        /// Get all rows from Videos table
        /// </summary>
        /// <returns>List of all record from Videos table</returns>
        IEnumerable<Videos> VideosGetAll();

        /// <summary>
        /// Insert a new row to Videos table.
        /// </summary>
        /// <param name="item">This item will be added.</param>
        void VideosInsert(Videos item);

        /// <summary>
        /// Update the selected row in Videos table.
        /// </summary>
        /// <param name="item">This item will be update.</param>
        void VideosUpdate(Videos item);

        /// <summary>
        /// Delete the selected row in Videos table.
        /// </summary>
        /// <param name="item">This item will be delete.</param>
        void VideosDelete(Videos item);

        /// <summary>
        /// Get all rows from Creators table
        /// </summary>
        /// <returns>List of all record from Creators table</returns>
        IEnumerable<Creators> creatorsGetAll();

        /// <summary>
        /// Insert a new row to Creators table.
        /// </summary>
        /// <param name="item">This item will be added.</param>
        void CreatorsInsert(Creators item);

        /// <summary>
        /// Update the selected row in Creators table.
        /// </summary>
        /// <param name="item">This item will be update.</param>
        void CreatorsUpdate(Creators item);

        /// <summary>
        /// Delete the selected row in Creators table.
        /// </summary>
        /// <param name="item">This item will be delete.</param>
        void CreatorsDelete(Creators item);

        /// <summary>
        /// Get all rows from Categories table
        /// </summary>
        /// <returns>List of all record from Categories table</returns>
        IEnumerable<Categories> CategoriesGetAll();

        /// <summary>
        /// Insert a new row to Categories table.
        /// </summary>
        /// <param name="item">This item will be added.</param>
        void CategoriesInsert(Categories item);

        /// <summary>
        /// Update the selected row in Categories table.
        /// </summary>
        /// <param name="item">This item will be update.</param>
        void CategoriesUpdate(Categories item);

        /// <summary>
        /// Delete the selected row in Categories table.
        /// </summary>
        /// <param name="item">This item will be delete.</param>
        void CategoriesDelete(Categories item);
    }
}
