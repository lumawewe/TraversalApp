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

        public void TChangeToFalseByGuide(int id)
        {
            _guideRepository.ChangeToFalseByGuide(id);
        }

        public void TChangeToTrueByGuide(int id)
        {
            _guideRepository.ChangeToTrueByGuide(id);
        }

        public void TDelete(Guide t)
        {
            _guideRepository.Delete(t);
        }

        public Guide TGetByID(int id)
        {
            return _guideRepository.GetById(id);

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
