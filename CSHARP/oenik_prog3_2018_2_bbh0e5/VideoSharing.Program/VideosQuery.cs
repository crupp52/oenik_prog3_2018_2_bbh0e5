using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoSharing.Data;

namespace VideoSharing.Program
{
    class VideosQuery
    {
        SystemDBEntities db;

        public VideosQuery()
        {
            this.db = new SystemDBEntities();
        }
    }
}
