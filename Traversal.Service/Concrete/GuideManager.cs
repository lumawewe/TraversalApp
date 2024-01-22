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
    public class GuideManager : IGuideService
    {
        private readonly IGuideRepository _guideRepository;

        public GuideManager(IGuideRepository guideRepository)
        {
            _guideRepository = guideRepository;
        }

        public void TAdd(Guide t)
        {
            _guideRepository.Add(t);
        }

        public void TDelete(Guide t)
        {
            _guideRepository.Delete(t);
        }

        public Guide TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Guide> TGetList()
        {
            return _guideRepository.GetList();
        }

        public void TUpdate(Guide t)
        {
            _guideRepository.Update(t);
        }
    }
}
