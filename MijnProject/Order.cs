using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MijnProject
{
   public class Order
    {
        public int OrderId { get; set; }
        public Klant klant { get; set; }
        public User user { get; set; }
        public DateTime OrderDatum { get; set; }
        public Status status { get; set; }
        public Bezorger BezorgdDoor { get; set; }
    }
}
