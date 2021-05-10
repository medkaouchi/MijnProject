using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MijnProject
{
    class Klant
    {
        public int KlantId { get; set; }
        public string Voornaam { get; set; }
        public string achternaam { get; set; }
        public DateTime Geboortdatum { get; set; }
        public string Telefoon1 { get; set; }
        public string Telefoon2 { get; set; }
        public string Email { get; set; }
        public Adress adress { get; set; }
        public User IngevoegdDoor { get; set; }
        public DateTime IngevoegdDatum { get; set; }
        public bool IsBedrijf { get; set; }
        public string BTWNummer { get; set; }
        public string Commentaar { get; set; }
    }
}
