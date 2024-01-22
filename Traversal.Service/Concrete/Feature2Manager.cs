using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Concrete;
using Traversal.Repository.Abstract;
using Traversal.Service.Abstract;

namespace Traversal.Service.Concrete
{
    public class Feature2Manager : IFeature2Service
    {
        private readonly IFeature2Repository _feature2Repository;

        public Feature2Manager(IFeature2Repository feature2Repository) { _feature2Repository = feature2Repository; }

        public void TAdd(Feature2 t)
        {
           _feature2Repository.Add(t);
        }

        public void TDelete(Feature2 t)
        {
            _feature2Repository.Delete(t);
        }

        public Feature2 TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature2> TGetList()
        {
            return _feature2Repository.GetList();
        }

        public void TUpdate(Feature2 t)
        {
            _feature2Repository.Update(t);
        }
    }
}
