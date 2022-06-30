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
            try
            {
                return PersonaDA.ListarPersonas();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static Persona ObtenerPersona(int id)
        {            
            try
            {
                return PersonaDA.ObtenerPersona(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static void CrearPersona(Persona persona)
        {
            try
            {
                PersonaDA.CrearPersona(persona);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }

        public static void EditarPersona(Persona persona)
        {            
            try
            {
                PersonaDA.EditarPersona(persona);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void EliminarPersona(int id)
        {            
            try
            {
                PersonaDA.EliminarPersona(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}