using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.Core.Concrete
{
    public class Destination
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }

        //destination detayları için eklemeler yapıyorum

        public string CoverImage { get; set; }
        public string Details1 { get; set; }
        public string Details2 { get; set; }
        public string Image2 { get; set; }

        //yorumları alacağı için Comment ile bağlantısını yapalım
        public List<Comment> Comments { get; set; }



    }
}
