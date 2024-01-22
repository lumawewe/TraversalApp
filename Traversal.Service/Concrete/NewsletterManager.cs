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
    public class NewsletterManager : INewsletterService
    {
        private readonly INewsletterRepository _newsletterRepository;

        public NewsletterManager(INewsletterRepository newsletterRepository) { _newsletterRepository = newsletterRepository }

        public void TAdd(Newsletter t)
        {
            _newsletterRepository.Add(t);
        }

        public void TDelete(Newsletter t)
        {
            _newsletterRepository.Delete(t);
        }

        public Newsletter TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Newsletter> TGetList()
        {
            return _newsletterRepository.GetList();
        }

        public void TUpdate(Newsletter t)
        {
           _newsletterRepository.Update(t);
        }
    }
}
