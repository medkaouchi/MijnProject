using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MijnProject
{
    public class OrderLine
    {
        public int orderid { get; set; }
        public Klant klant { get; set; }
        public User user { get; set; }
        public DateTime orderdate { get; set; }
        public OrderStatus status { get; set; }
        public Bezorger bezorgddoor { get; set; }
        public Adress adress { get; set; }
        public int orderdetailid { get; set; }
        public Product product { get; set; }
        public int aantal { get; set; }
    }
}
