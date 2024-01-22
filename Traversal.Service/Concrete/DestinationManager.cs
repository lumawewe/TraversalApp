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
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationRepository _destinationRepository;
    
        public DestinationManager(IDestinationRepository destinationRepository) { _destinationRepository = destinationRepository; }

        public void TAdd(Destination t)
        {
            _destinationRepository.Add(t);
        }

        public void TDelete(Destination t)
        {
            _destinationRepository.Delete(t);
        }

        public Destination TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Destination> TGetList()
        {
            return _destinationRepository.GetList();
        }

        public void TUpdate(Destination t)
        {
            _destinationRepository.Update(t);
        }
    }
}
