using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoSharing.Data;
using VideoSharing.Repository;

namespace VideoSharing.Logic
{
    public class CreatorsLogic : ILogic<Creators>
    {
        private CreatorRepository repository;

        public CreatorsLogic(IRepository<Creators> repository)
        {
            this.repository = (CreatorRepository)repository;
        }

        public void Delete(string[] parameters)
        {
            this.repository.Delete(MakeObject(parameters));
        }

        public IQueryable<Creators> GetAll()
        {
            var q = from e in this.repository.GetAll()
                    select e;

            return q;
        }

        public void Insert(string[] parameters)
        {
            this.repository.Insert(MakeObject(parameters));
        }

        public Creators MakeObject(string[] parameters)
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

        public void Update(string[] parameters)
        {
            this.repository.Update(MakeObject(parameters));
        }
    }
}
