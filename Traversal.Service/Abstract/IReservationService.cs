using Traversal.Core.Concrete;

namespace Traversal.Service.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> GetListApprovalReservation(int id);
    }
}
