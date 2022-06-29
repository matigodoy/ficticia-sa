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
            return UsuarioDA.InsertarUsuario(usuario);
        }

        public static int ActualizarUsuario(Usuario usuario)
        {
            return UsuarioDA.ActualizarUsuario(usuario);
        }

        public static int EliminarUsuario(int id)
        {
            return UsuarioDA.EliminarUsuario(id);
        }

        public static Usuario ObtenerUsuario(int id)
        {
            return UsuarioDA.ObtenerUsuario(id);
        }

        public static List<Usuario> ObtenerUsuarios()
        {
            return UsuarioDA.ObtenerUsuarios();
        }
    }
}