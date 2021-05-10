using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MijnProject
{
    class OrderDetail
    {
        public int ID { get; set; }
        public Order order { get; set; }
        public Product product { get; set; }
        public int Aantal { get; set; }
    }
}
