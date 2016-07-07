using kolejny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace kolejny.Controllers
{
    public class GrandaController : ApiController
    {
        private readonly IManagment mag;
        public GrandaController()
        {

        }
        public GrandaController(IManagment mag)
        {
            this.mag = mag;
        }
        public void PostOsoba(Osoba o)
        {
            mag.AddOsoba(o);
        }
        public void DeletePerson(Osoba o)
        {
            mag.RemoveOsoba(o);
        }
        public Osoba getOsobaById(int id)
        {
            return mag.getOsobaByID(id);
        }
        public Osoba[] getOosoby()
        {
            return mag.getAllPerson();
        }
    }
}
