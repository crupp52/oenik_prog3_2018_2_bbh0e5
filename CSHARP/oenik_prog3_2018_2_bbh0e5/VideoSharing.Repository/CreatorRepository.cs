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

        private Creators MakeObject(string[] parameters)
        {
            return new Creators()
            {
                creator_id = int.Parse(parameters[0]),
                creator_name = parameters[1],
                creator_email = parameters[2],
                creator_birth_date = DateTime.Parse(parameters[3]),
                creator_premium = int.Parse(parameters[4])
            };
        }

        public void Delete(int id)
        {
            Creators item = (from e in this.entities.Creators
                             where e.creator_id == id
                             select e).FirstOrDefault();

            this.entities.Creators.Remove(item);
            this.entities.SaveChanges();
        }

        public List<string> GetAll()
        {
            var q = from e in this.entities.Creators
                    select e.creator_name;

            List<string> temp = new List<string>();

            foreach (var item in q)
            {
                temp.Add(item);
            }

            return temp;
        }

        public void Insert(string[] parameters)
        {
            this.entities.Creators.Add(MakeObject(parameters));
            this.entities.SaveChanges();
        }

        public void Update(string[] parameters)
        {
            Creators update = MakeObject(parameters);

            Creators item = (from e in entities.Creators
                             where e.creator_id == update.creator_id
                             select e).FirstOrDefault();

            item = update;

            this.entities.SaveChanges();
        }
    }
}
