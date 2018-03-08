using Persona.Entidad;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.DAL
{
   public  class Contexto : DbContext
    {
        public DbSet<Personas> Persona { get; set; }
        public DbSet<TelefonosDetalles> Telefonodetalle { get; set; }


        public Contexto() : base("ConStr")
        {

        }

    }
     
    
}
