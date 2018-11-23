// <copyright file="CreatorsLogic.cs" company="PlaceholderCompany">
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
    public class CreatorsLogic : ILogic<Creators>
    {
        private IRepository<Creators> repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatorsLogic"/> class.
        /// </summary>
        /// <param name="repository">External repository for test.</param>
        public CreatorsLogic(IRepository<Creators> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatorsLogic"/> class.
        /// </summary>
        public CreatorsLogic()
        {
            this.repository = new CreatorRepository();
        }

        /// <summary>
        /// Returns the contents of the list.
        /// </summary>
        /// <returns>List of the elements.</returns>
        public IQueryable<Creators> GetAll()
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
        public IQueryable<Creators> GetElementById(int id)
        {
            return from e in this.repository.GetAll()
                   where e.creator_id == id
                   select e;
        }

        /// <summary>
        /// Returns the contents of the list where the element name is equals with parameter name.
        /// </summary>
        /// <param name="name">String name parameter.</param>
        /// <returns>List of the elements.</returns>
        public IQueryable<Creators> GetElementByName(string name)
        {
            return from e in this.repository.GetAll()
                   where e.creator_name.Contains(name)
                   select e;
        }

        /// <summary>
        /// Add a new element to Entity Model.
        /// </summary>
        /// <param name="item">An instance.</param>
        public void Insert(Creators item)
        {
            this.repository.Insert(item);
        }

        /// <summary>
        /// Update an exsisting element from the Entity Model.
        /// </summary>
        /// <param name="item">An instance.</param>
        public void Update(Creators item)
        {
            this.repository.Update(item);
        }

        /// <summary>
        /// Delete an exsisting element from the Entity Model.
        /// </summary>
        /// <param name="item">An instance.</param>
        public void Delete(Creators item)
        {
            this.repository.Delete(item);
        }
    }
}
