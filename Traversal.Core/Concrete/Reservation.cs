using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.Core.Concrete
{
    public class Reservation
    {
        public int Id { get; set; }

        //AppUser.cs ilişki kuralım
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public string PersonCount { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public int DestinationId { get; set; }
        public Destination Destination { get; set; }

    }
}
