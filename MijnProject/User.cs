using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MijnProject
{
    class User
    {
        public int UserId { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateTime Geboortdatum { get; set; }
        public string Telefoon { get; set; }
        public string Email { get; set; }
        public Adress adress { get; set; }
        public string Username { get; set; }
        public string Wachtwoord { get; set; }
        public RoleUser Role { get; set; }
    }
}
