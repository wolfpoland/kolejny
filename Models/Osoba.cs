﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kolejny.Models
{
    public class Osoba
    {
        public Osoba(int id, string imie,string nazwisko)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;

        }
        public int id { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
    }
}