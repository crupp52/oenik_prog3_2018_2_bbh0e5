using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSharing.Data
{
    public class TestQueries
    {
        public void ListAllVideo()
        {
            SystemDBEntities entities = new SystemDBEntities();
            var q = from e in entities.Categories
                    select e;
        }
    }
}
