using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MijnProject
{
   public class Product
    {
        public int ProductId { get; set; }

        public string ProductNaam { get; set; }
        public Levrancier levrancier { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsOnStock { get; set; }
        public Categorie categorie { get; set; }
        public string ProductNummer { get; set; }
        public string BarCode { get; set; }
        public double Gewicht { get; set; }
        public double Breedte { get; set; }
        public double Lengte { get; set; }
        public double Hoogte { get; set; }
        public DateTime BBD { get; set; }
        public string Omschrijving { get; set; }
    }
}
