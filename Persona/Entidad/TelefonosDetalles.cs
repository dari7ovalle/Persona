using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Entidad
{
    public class TelefonosDetalles
    {
        [Key]
        public int Id { get; set; }
        public string TipoTelefono { get; set; }
        public string NumeroTelefono { get; set; }
        public int PersonaId { get; set; }


        public TelefonosDetalles()
        {
            this.Id = 0;
            this.TipoTelefono = "";
            this.NumeroTelefono = " ";
            this.PersonaId = 1;
        }

        public TelefonosDetalles(int Id, int TelefonoId, string TipoTelefono, string NumeroTelefono, int PersonaId)
        {
            this.Id = Id;
            this.TipoTelefono = TipoTelefono;
            this.NumeroTelefono= NumeroTelefono;
            this.PersonaId = PersonaId;
            
        }

        public TelefonosDetalles(string TipoTelefono, string NumeroTelefono)
        {
            this.TipoTelefono = TipoTelefono;
            this.NumeroTelefono = NumeroTelefono;
        }

    }
}
