namespace VideoSharing.Logic
{
    using System.Linq;
    using VideoSharing.Data;
    using VideoSharing.Repository;

    public class VideosLogic : ILogic<Videos>
    {
        private IRepository<Videos> repository;

        public VideosLogic(IRepository<Videos> repository)
        {
            this.repository = repository;
        }

        public Videos MakeObject(string[] parameters)
        {
            return new Videos()
            {
                video_id = int.Parse(parameters[0]),
                video_title = parameters[1],
                video_description = parameters[2],
                video_views = int.Parse(parameters[3]),
                category_id = int.Parse(parameters[4])
            };
        }

        public IQueryable<Videos> GetAll()
        {
            return from e in this.repository.GetAll()
                   select e;
        }

        public IQueryable<Videos> GetElementById(int id)
        {
            return from e in this.repository.GetAll()
                   where e.video_id == id
                   select e;
        }

        public IQueryable<Videos> GetElementByName(string name)
        {
            return from e in this.repository.GetAll()
                   where e.video_title.Contains(name)
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
