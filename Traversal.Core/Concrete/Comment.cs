using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.Core.Concrete
{
    public class Comment
    {
        public int Id { get; set; }
        public string User {  get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public bool State { get; set; }
        //destination ile bağlantısını yapalım çünkü rotalarda seçtiğimiz rotanın yazar yorumlarına giderken
        //bu bağlantıları kullanacağız
        public int DestinationId { get; set; }
        public Destination Destination { get; set; }


    }
}
