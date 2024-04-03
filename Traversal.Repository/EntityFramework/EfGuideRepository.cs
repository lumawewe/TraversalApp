using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Concrete;
using Traversal.Repository.Abstract;
using Traversal.Repository.Concrete;
using Traversal.Repository.Repository;

namespace Traversal.Repository.EntityFramework
{
    public class EfGuideRepository : GenericRepository<Guide>, IGuideRepository
    {
        Context c = new Context();

        public void ChangeToFalseByGuide(int id)
        {
            var values = c.Guides.Find(id);
            values.Status = false;
            c.Update(values);
            c.SaveChanges();
        }

        public void ChangeToTrueByGuide(int id)
        {
            var values = c.Guides.Find(id);
            values.Status = true;
            c.Update(values);
            c.SaveChanges();
        }
    }
}
