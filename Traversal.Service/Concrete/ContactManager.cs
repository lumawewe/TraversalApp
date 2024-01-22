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
    public class ContactManager : IContactService
    {
        private readonly IContactRepository _contactRepository;
        
        public ContactManager(IContactRepository contactRepository) { _contactRepository = contactRepository; }

        public void TAdd(Contact t)
        {
            _contactRepository.Add(t);
        }

        public void TDelete(Contact t)
        {
            _contactRepository.Delete(t);
        }

        public Contact TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> TGetList()
        {
            return _contactRepository.GetList();
        }

        public void TUpdate(Contact t)
        {
           _contactRepository.Update(t);
        }
    }
}
