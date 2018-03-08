using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Entidad
{
    public class TelefonosDetalles
    {
        public int Id { get; set; }
        public int TelefonoId { get; set; }
        public int TipoTelefono { get; set; }
        public string NumeroTelefono { get; set; }
        public int PersonaId { get; set; }


        public TelefonosDetalles()
        {
            this.Id = 0;
            this.TelefonoId = 0;
            this.TipoTelefono = 0;
            this.NumeroTelefono = " ";
            this.PersonaId = 0;
        }
        public TelefonosDetalles(int Id, int TelefonoId, int TipoTelefono, string NumeroTelefono, int PersonaId)
        {
            this.Id = Id;
            this.TelefonoId = TelefonoId;
            this.TipoTelefono = TipoTelefono;
            this.NumeroTelefono= NumeroTelefono;
            this.PersonaId = PersonaId;
            
        }

        public TelefonosDetalles(int TipoTelefono, string NumeroTelefono)
        {
            this.TipoTelefono = TipoTelefono;
            this.NumeroTelefono = NumeroTelefono;
        }

    }
}
