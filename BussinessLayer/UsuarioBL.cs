using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities;

namespace BusinessLayer
{
    public class UsuarioBL
    {
        public static int InsertarUsuario(Usuario usuario)
        {            
            try
            {
                return UsuarioDA.InsertarUsuario(usuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public static int ActualizarUsuario(Usuario usuario)
        {            
            try
            {
                return UsuarioDA.ActualizarUsuario(usuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public static int EliminarUsuario(int id)
        {
            try
            {
                return UsuarioDA.EliminarUsuario(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }            
        }

        public static Usuario ObtenerUsuario(int id)
        {
            try
            {
                return UsuarioDA.ObtenerUsuario(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }            
        }

        public static List<Usuario> ObtenerUsuarios()
        {
            try
            {
                return UsuarioDA.ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }            
        }

        public static Usuario Login(string user, string password)
        {
            try
            {
                return UsuarioDA.Login(user, password);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}