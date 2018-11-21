// <copyright file="CreatorRepository.cs" company="PlaceholderCompany">
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

    public class CreatorRepository : IRepository<Creators>
    {
        private SystemDBEntities entities;

        public CreatorRepository()
        {
            this.entities = new SystemDBEntities();
        }

        public void Delete(Creators item)
        {
            Creators r = (from e in this.entities.Creators
                         where e.creator_id == item.creator_id
                          select e).First();

            this.entities.Creators.Remove(r);
            this.entities.SaveChanges();
        }

        public IQueryable<Creators> GetAll()
        {
            return this.entities.Creators;
        }

        public void Insert(Creators item)
        {
            this.entities.Creators.Add(item);
            this.entities.SaveChanges();
        }

        public void Update(Creators item)
        {
            Creators update = (from e in this.entities.Creators
                              where e.creator_id == item.creator_id
                               select e).First();

            update = item;

            this.entities.SaveChanges();
        }
    }
}
