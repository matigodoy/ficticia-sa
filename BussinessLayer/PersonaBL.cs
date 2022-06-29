using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities;

namespace BusinessLayer
{
    public class PersonaBL
    {
        public static List<Persona> ListarPersonas()
        {
            return PersonaDA.ListarPersonas();
        }

        public static Persona ObtenerPersona(int id)
        {
            return PersonaDA.ObtenerPersona(id);
        }

        public static void CrearPersona(Persona persona)
        {
            PersonaDA.CrearPersona(persona);
        }

        public static void EditarPersona(Persona persona)
        {
            PersonaDA.EditarPersona(persona);
        }

        public static void EliminarPersona(int id)
        {
            PersonaDA.EliminarPersona(id);
        }
    }
}