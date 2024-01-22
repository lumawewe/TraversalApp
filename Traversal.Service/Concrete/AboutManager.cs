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
    public class AboutManager : IAboutService
    {
        private readonly IAboutRepository _aboutRepository;

        public AboutManager(IAboutRepository aboutRepository) { _aboutRepository = aboutRepository; }

        public void TAdd(About t)
        {
            _aboutRepository.Add(t);
        }

        public void TDelete(About t)
        {
            _aboutRepository.Delete(t);
        }

        public About TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
            return _aboutRepository.GetList();
        }

        public void TUpdate(About t)
        {
            _aboutRepository.Update(t);
        }
    }
}
