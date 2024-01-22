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
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureRepository _featureRepository;

        public FeatureManager(IFeatureRepository featureRepository)
        {
            _featureRepository = featureRepository;
        }

        public void TAdd(Feature t)
        {
            _featureRepository.Add(t);
        }

        public void TDelete(Feature t)
        {
            _featureRepository.Delete(t);
        }

        public Feature TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetList()
        {
            return _featureRepository.GetList();
        }

        public void TUpdate(Feature t)
        {
            _featureRepository.Update(t);
        }
    }
}
