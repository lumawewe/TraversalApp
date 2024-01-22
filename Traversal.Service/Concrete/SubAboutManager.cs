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
    public class SubAboutManager : ISubAboutService
    {
        private readonly ISubAboutRepository _subAboutRepository;

        public SubAboutManager(ISubAboutRepository subAboutRepository) { _subAboutRepository = subAboutRepository; }

        public void TAdd(SubAbout t)
        {
            _subAboutRepository.Add(t);
        }

        public void TDelete(SubAbout t)
        {
            _subAboutRepository.Delete(t);
        }

        public SubAbout TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetList()
        {
            return _subAboutRepository.GetList();
        }

        public void TUpdate(SubAbout t)
        {
            _subAboutRepository.Update(t);
        }
    }
}
