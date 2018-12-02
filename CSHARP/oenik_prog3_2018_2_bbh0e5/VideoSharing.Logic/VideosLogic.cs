// <copyright file="VideosLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace VideoSharing.Logic
{
    using System;
    using System.Linq;
    using VideoSharing.Data;
    using VideoSharing.Repository;

    /// <summary>
    /// Handles repository queries and forward requests.
    /// </summary>
    public class VideosLogic : ILogic<Videos>
    {
        private IRepository<Videos> repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="VideosLogic"/> class.
        /// </summary>
        /// <param name="repository">External repository for test.</param>
        public VideosLogic(IRepository<Videos> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideosLogic"/> class.
        /// </summary>
        public VideosLogic()
        {
            this.repository = new VideoRepository();
        }

        /// <summary>
        /// Returns the contents of the list.
        /// </summary>
        /// <returns>List of the elements.</returns>
        public IQueryable<Videos> GetAll()
        {
            return from e in this.repository.GetAll()
                   select e;
        }

        /// <summary>
        /// Returns the contents of the list where the element id is equals with parameter id.
        /// </summary>
        /// <param name="id">Integer ID parameter.</param>
        /// <returns>List of the elements.</returns>
        public IQueryable<Videos> GetElementById(int id)
        {
            return from e in this.repository.GetAll()
                   where e.video_id == id
                   select e;
        }

        /// <summary>
        /// Returns the contents of the list where the element name is equals with parameter name.
        /// </summary>
        /// <param name="name">String name parameter.</param>
        /// <returns>List of the elements.</returns>
        public IQueryable<Videos> GetElementByName(string name)
        {
            return from e in this.repository.GetAll()
                   where e.video_title.Contains(name)
                   select e;
        }

        /// <summary>
        /// Add a new element to Entity Model.
        /// </summary>
        /// <param name="item">An instance.</param>
        public void Insert(Videos item)
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
        public void Update(Videos item)
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
        public void Delete(Videos item)
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
