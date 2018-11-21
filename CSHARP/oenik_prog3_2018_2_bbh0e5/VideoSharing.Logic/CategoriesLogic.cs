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

        public CategoriesLogic()
        {
            this.repository = new CategoryRepository();
        }

        public void Delete(string[] parameters)
        {
            this.repository.Delete(MakeObject(parameters));
        }

        public List<string> GetAll()
        {
            var q = from e in this.repository.GetAll()
                    select e;

            List<string> result = new List<string>();

            foreach (var item in q)
            {
                result.Add(item.category_name);
            }

            return result;
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
