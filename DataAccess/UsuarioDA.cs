using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;
using System.Data;

namespace DataAccess
{
    public class UsuarioDA : Conexion
    {
        public static int InsertarUsuario(Usuario usuario)
        {
            int resultado = 0;
            SqlConnection cn = Conexion.Conectar();
            SqlCommand cmd = new SqlCommand("InsertarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            cmd.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
            cmd.Parameters.AddWithValue("@PersonaId", usuario.Persona.Id);
            cn.Open();
            resultado = cmd.ExecuteNonQuery();
            cn.Close();
            return resultado;
        }
        public static int ActualizarUsuario(Usuario usuario)
        {
            int resultado = 0;
            SqlConnection cn = Conexion.Conectar();
            SqlCommand cmd = new SqlCommand("ActualizarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", usuario.Id);
            cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            cmd.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
            cmd.Parameters.AddWithValue("@PersonaId", usuario.Persona.Id);
            cn.Open();
            resultado = cmd.ExecuteNonQuery();
            cn.Close();
            return resultado;
        }
        public static int EliminarUsuario(int id)
        {
            int resultado = 0;
            SqlConnection cn = Conexion.Conectar();
            SqlCommand cmd = new SqlCommand("EliminarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            cn.Open();
            resultado = cmd.ExecuteNonQuery();
            cn.Close();
            return resultado;
        }
        public static Usuario ObtenerUsuario(int id)
        {
            Usuario usuario = null;
            SqlConnection cn = Conexion.Conectar();
            SqlCommand cmd = new SqlCommand("ObtenerUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new Usuario();
                usuario.Id = Convert.ToInt32(dr["Id"]);
                usuario.Nombre = dr["Nombre"].ToString();
                usuario.Contrasena = dr["Contrasena"].ToString();
                usuario.Persona = PersonaDA.ObtenerPersona(Convert.ToInt32(dr["PersonaId"]));
            }
            cn.Close();
            return usuario;
        }
        public static List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            SqlConnection cn = Conexion.Conectar();
            SqlCommand cmd = new SqlCommand("ObtenerUsuarios", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Usuario usuario = new Usuario();
                usuario.Id = Convert.ToInt32(dr["Id"]);
                usuario.Nombre = dr["Nombre"].ToString();
                usuario.Contrasena = dr["Contrasena"].ToString();
                usuario.Persona = PersonaDA.ObtenerPersona(Convert.ToInt32(dr["PersonaId"]));
                lista.Add(usuario);
            }
            cn.Close();
            return lista;
        }
        public static Usuario Login(string user, string password)
        {
            Usuario usuario = null;
            SqlConnection cn = Conexion.Conectar();
            SqlCommand cmd = new SqlCommand("usp_Login", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@password", password);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new Usuario();
                usuario.Id = Convert.ToInt32(dr["Id"]);
                usuario.Nombre = dr["Nombre"].ToString();
                usuario.Contrasena = dr["Contrasena"].ToString();
                usuario.Persona = PersonaDA.ObtenerPersona(Convert.ToInt32(dr["PersonaId"]));
            }
            cn.Close();
            return usuario;
        }
    }
}