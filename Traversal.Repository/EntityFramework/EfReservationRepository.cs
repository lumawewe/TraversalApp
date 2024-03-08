using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Concrete;
using Traversal.Repository.Abstract;
using Traversal.Repository.Concrete;
using Traversal.Repository.Repository;

namespace Traversal.Repository.EntityFramework
{
    public class EfReservationRepository : GenericRepository<Reservation>, IReservationRepository
    {
        private readonly Context _context;

        public EfReservationRepository(Context context)
        {
            _context = context;
        }

        public List<Reservation> GetListWithReservationByAccepted(int id)
        {     
             return _context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onaylanan Rezervasyon" && x.AppUserId == id).ToList();
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            return _context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Geçmiş Rezervasyon" && x.AppUserId == id).ToList();
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            return _context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onay Bekleyen Rezervasyon" && x.AppUserId == id).ToList();
        }
    }
}
