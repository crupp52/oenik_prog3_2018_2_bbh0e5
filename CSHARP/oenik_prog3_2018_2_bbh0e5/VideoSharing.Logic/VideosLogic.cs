using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoSharing.Data;
using VideoSharing.Repository;

namespace VideoSharing.Logic
{
    public class VideosLogic : ILogic<Videos>
    {
        private IRepository<Videos> repository;

        public VideosLogic(IRepository<Videos> repository)
        {
            this.repository = repository;
        }

        public void Delete(string[] parameters)
        {
            this.repository.Delete(MakeObject(parameters));
        }

        public IQueryable<Videos> GetAll()
        {
            var q = from e in this.repository.GetAll()
                   select e;

            return q;
        }

        public void Insert(string[] parameters)
        {
            this.repository.Insert(MakeObject(parameters));
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

        public void Update(string[] parameters)
        {
            this.repository.Update(MakeObject(parameters));
        }
    }
}
