using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoSharing.Data;
using VideoSharing.Repository;

namespace VideoSharing.Logic
{
    public class CategoriesLogic : ILogic<Categories>
    {
        private IRepository<Categories> repository;

        public CategoriesLogic(IRepository<Categories> repository)
        {
            this.repository = repository;
        }

        public Categories MakeObject(string[] parameters)
        {
            return new Categories()
            {
                category_id = int.Parse(parameters[0]),
                category_name = parameters[1],
                category_adult = int.Parse(parameters[2])
            };
        }

        public IQueryable<Categories> GetAll()
        {
            var q = from e in this.repository.GetAll()
                    select e;

            return q;
        }

        public IQueryable<Categories> GetElementById(int id)
        {
            return from e in this.repository.GetAll()
                   where e.category_id == id
                   select e;
        }

        public IQueryable<Categories> GetElementByName(string name)
        {
            return from e in this.repository.GetAll()
                   where e.category_name.Contains(name)
                   select e;
        }

        public void Insert(string[] parameters)
        {
            this.repository.Insert(MakeObject(parameters));
        }

        public void Update(string[] parameters)
        {
            this.repository.Update(MakeObject(parameters));
        }

        public void Delete(string[] parameters)
        {
            this.repository.Delete(MakeObject(parameters));
        }
    }
}
