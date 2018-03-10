using Persona.DAL;
using Persona.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Persona.BLL
{
    public class PersonaBLL
    {
        public static bool Guardar(Personas persona)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                db.Persona.Add(persona);
               // db.SaveChanges();

                foreach (TelefonosDetalles detalle in persona.Detalles)
                {
                    db.Telefonodetalle.Add(detalle);
                   
                }
                db.SaveChanges();

                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }

        public static Personas Buscar(int id)
        {
            Personas persona = null;
            try
            {
                Contexto db = new Contexto();
                persona = db.Persona.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return persona;
        }

        public static bool eliminar(int Id)
        {
            Personas persona = null;
            bool estado = false;
            try
            {
                Contexto db = new Contexto();
             persona = db.Persona.Find(Id);
            db.Persona.Remove(persona);
                db.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {
                throw;

            }
            return estado;
        }
        public static void BorrarEstudiosPorAlumno(Personas personas)
        {
            using (Contexto Contexto = new Contexto())
            {
                personas..Clear();
                Contexto.SaveChanges();
                Contexto.Dispose();
            }
        }
}


