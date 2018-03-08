using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Entidad
{
  public  class Personas
    {
        [Key]
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public virtual List<TelefonosDetalles> Detalles { get; set; }

        public Personas()
        {
            this.PersonaId = 0;
            this.Nombre = " ";
            Detalles = new List<TelefonosDetalles>();
            Fecha = DateTime.Today.ToString("d");
        }

        public Personas(int PersonaId, string Nombre, List<TelefonosDetalles> detalles)

        {
            this.Nombre = Nombre;
            this.PersonaId = PersonaId;
            this.Detalles = detalles;

        }

    }
}
