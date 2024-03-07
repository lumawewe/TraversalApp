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
    public class ReservationManager : IReservationService
    {
        IReservationRepository _reservationsRepository;

        public ReservationManager(IReservationRepository reservationsRepository)
        {
            _reservationsRepository = reservationsRepository;
        }

        public List<Reservation> GetListApprovalReservation(int id)
        {
            return _reservationsRepository.GetListByFilter(x => x.AppUserId == id);
        }

        public void TAdd(Reservation t)
        {
            _reservationsRepository.Add(t);
        }

        public void TDelete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public Reservation TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation t)
        {
            throw new NotImplementedException();
        }
    }
}
