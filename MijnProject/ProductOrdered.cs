using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MijnProject
{
    public class ProductOrdered
    {
        public int ProductId { get; set; }
        public string ProductNaam { get; set; }
        public Levrancier levrancier { get; set; }
        public double UnitPrice { get; set; }
        public string Omschrijving { get; set; }
        public int aantal { get; set; }
    }
}
