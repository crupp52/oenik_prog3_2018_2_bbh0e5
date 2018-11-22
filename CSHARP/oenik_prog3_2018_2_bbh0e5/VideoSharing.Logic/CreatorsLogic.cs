namespace VideoSharing.Logic
{
    using System;
    using System.Linq;
    using VideoSharing.Data;
    using VideoSharing.Repository;

    public class CreatorsLogic : ILogic<Creators>
    {
        private IRepository<Creators> repository;

        public CreatorsLogic(IRepository<Creators> repository)
        {
            this.repository = repository;
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

        public IQueryable<Creators> GetAll()
        {
            var q = from e in this.repository.GetAll()
                    select e;

            return q;
        }

        public IQueryable<Creators> GetElementById(int id)
        {
            return from e in this.repository.GetAll()
                   where e.creator_id == id
                   select e;
        }

        public IQueryable<Creators> GetElementByName(string name)
        {
            return from e in this.repository.GetAll()
                   where e.creator_name.Contains(name)
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
