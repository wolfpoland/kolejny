using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kolejny.Models
{
    public interface  IManagment
    {
        void AddOsoba(Osoba o);
        void RemoveOsoba(Osoba o);
        Osoba getOsobaByID(int id);
        Osoba[] getAllPerson();
    }
}