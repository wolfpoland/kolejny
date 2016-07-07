using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kolejny.Models
{
    public class Calosc : IManagment
    {
        private List<Osoba> lista = new List<Osoba>();
        public Calosc()
        {
            lista.Add(new Osoba(1,"Patriko","Fantastico"));
        }
        public void AddOsoba(Osoba o)
        {
            lista.Add(o);

        }

        public Osoba[] getAllPerson()
        {
            Osoba[] osoby = lista.ToArray();
            return osoby;
        }

        public Osoba getOsobaByID(int id)
        {
           Osoba o= lista.Single(k => k.id == id);
            return o;
        }

        public void RemoveOsoba(Osoba o)
        {
            lista.Remove(o);
        }
    }
}