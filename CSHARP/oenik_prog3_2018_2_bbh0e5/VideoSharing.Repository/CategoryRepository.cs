// <copyright file="CategoryRepository.cs" company="PlaceholderCompany">
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

    public class CategoryRepository : IRepository<Categories>
    {
        private SystemDBEntities entities;

        public CategoryRepository()
        {
            this.entities = new SystemDBEntities();
        }

        private Categories MakeObject(string[] parameters)
        {
            return new Categories()
            {
                category_id = int.Parse(parameters[0]),
                category_name = parameters[1],
                category_adult = int.Parse(parameters[2])
            };
        }

        public void Delete(int id)
        {
            Categories item = (from e in this.entities.Categories
                               where e.category_id == id
                               select e).FirstOrDefault();

            this.entities.Categories.Remove(item);
            this.entities.SaveChanges();
        }

        public List<string> GetAll()
        {
            var q = from e in this.entities.Categories
                    select e.category_name;

            List<string> temp = new List<string>();

            foreach (var item in q)
            {
                temp.Add(item);
            }

            return temp;
        }

        public void Insert(string[] parameters)
        {
            this.entities.Categories.Add(this.MakeObject(parameters));
            this.entities.SaveChanges();
        }

        public void Update(string[] parameters)
        {
            Categories update = this.MakeObject(parameters);

            Categories item = (from e in this.entities.Categories
                               where e.category_id == update.category_id
                               select e).FirstOrDefault();

            item = update;

            this.entities.SaveChanges();
        }
    }
}
