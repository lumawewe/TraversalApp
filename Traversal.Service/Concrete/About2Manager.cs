using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Concrete;
using Traversal.Repository.Abstract;
using Traversal.Service.Abstract;

namespace Traversal.Service.Concrete
{
    public class About2Manager : IAbout2Service
    {
        private readonly IAbout2Repository _about2Repository;

        public About2Manager(IAbout2Repository about2Repository)
        {
            _about2Repository = about2Repository;
        }

        public void TAdd(About2 t)
        {
            _about2Repository.Add(t);
        }

        public void TDelete(About2 t)
        {
            _about2Repository.Delete(t);
        }

        public About2 TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About2> TGetList()
        {
            return _about2Repository.GetList();
        }

        public void TUpdate(About2 t)
        {
            _about2Repository.Update(t);
        }
    }
}
