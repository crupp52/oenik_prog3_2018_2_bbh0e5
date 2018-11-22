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
        private CategoryRepository repository;

        public CategoriesLogic(IRepository<Categories> repository)
        {
            this.repository = (CategoryRepository)repository;
        }

        public void Delete(string[] parameters)
        {
            this.repository.Delete(MakeObject(parameters));
        }

        public IQueryable<Categories> GetAll()
        {
            var q = from e in this.repository.GetAll()
                    select e;

            return q;
        }

        public void Insert(string[] parameters)
        {
            this.repository.Insert(MakeObject(parameters));
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

        public void Update(string[] parameters)
        {
            this.repository.Update(MakeObject(parameters));
        }
    }
}
