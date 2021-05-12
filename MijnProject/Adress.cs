﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MijnProject
{
   public class Adress
    {
        public int AdressId { get; set; }
        public string Straat { get; set; }
        public int Huisnummer { get; set; }
        public string Gemeente { get; set; }
        public string Postcode { get; set; }
        public string Land { get; set; }
        public override string ToString()
        {
            return Straat+" "+Huisnummer+" "+Gemeente + " " +Postcode + " " +Land;
        }
    }
}
