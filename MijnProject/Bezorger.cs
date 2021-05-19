using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MijnProject
{
   public class Bezorger
    {
        public int BezorgerId { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }
        public string Telefoon1 { get; set; }
        public string Telefoon2 { get; set; }
        public string Email { get; set; }
        public Adress adress { get; set; }
        public override string ToString()
        {
            return Naam;
        }
    }
}
