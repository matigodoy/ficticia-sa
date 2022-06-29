using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;

namespace DataAccess
{
    public class PersonaDA : Conexion
    {
        public static List<Persona> ListarPersonas()
        {
            List<Persona> lista = new List<Persona>();
            using (SqlConnection cn = Conexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand("usp_ListarPersonas", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Persona p = new Persona();
                    p.Id = Convert.ToInt32(dr["Id"]);
                    p.Nombre = dr["Nombre"].ToString();
                    p.Identificacion = dr["Identificacion"].ToString();
                    p.Edad = Convert.ToInt32(dr["Edad"]);
                    p.Genero = dr["Genero"].ToString();
                    p.Estado = dr["Estado"].ToString();
                    p.Maneja = dr["Maneja"].ToString();
                    p.UsaLentes = dr["UsaLentes"].ToString();
                    p.Diabetico = dr["Diabetico"].ToString();
                    p.Enfermedad = dr["Enfermedad"].ToString();
                    lista.Add(p);
                }
            }
            return lista;
        }

        public static Persona ObtenerPersona(int id)
        {
            Persona p = new Persona();
            using (SqlConnection cn = Conexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand("usp_ObtenerPersona", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    p.Id = Convert.ToInt32(dr["Id"]);
                    p.Nombre = dr["Nombre"].ToString();
                    p.Identificacion = dr["Identificacion"].ToString();
                    p.Edad = Convert.ToInt32(dr["Edad"]);
                    p.Genero = dr["Genero"].ToString();
                    p.Estado = dr["Estado"].ToString();
                    p.Maneja = dr["Maneja"].ToString();
                    p.UsaLentes = dr["UsaLentes"].ToString();
                    p.Diabetico = dr["Diabetico"].ToString();
                    p.Enfermedad = dr["Enfermedad"].ToString();
                }
            }
            return p;
        }

        public static void CrearPersona(Persona persona)
        {
            using (SqlConnection cn = Conexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand("usp_CrearPersona", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", persona.Nombre);
                cmd.Parameters.AddWithValue("@Identificacion", persona.Identificacion);
                cmd.Parameters.AddWithValue("@Edad", persona.Edad);
                cmd.Parameters.AddWithValue("@Genero", persona.Genero);
                cmd.Parameters.AddWithValue("@Estado", persona.Estado);
                cmd.Parameters.AddWithValue("@Maneja", persona.Maneja);
                cmd.Parameters.AddWithValue("@UsaLentes", persona.UsaLentes);
                cmd.Parameters.AddWithValue("@Diabetico", persona.Diabetico);
                cmd.Parameters.AddWithValue("@Enfermedad", persona.Enfermedad);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarPersona(Persona persona)
        {
            using (SqlConnection cn = Conexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand("usp_EditarPersona", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", persona.Id);
                cmd.Parameters.AddWithValue("@Nombre", persona.Nombre);
                cmd.Parameters.AddWithValue("@Identificacion", persona.Identificacion);
                cmd.Parameters.AddWithValue("@Edad", persona.Edad);
                cmd.Parameters.AddWithValue("@Genero", persona.Genero);
                cmd.Parameters.AddWithValue("@Estado", persona.Estado);
                cmd.Parameters.AddWithValue("@Maneja", persona.Maneja);
                cmd.Parameters.AddWithValue("@UsaLentes", persona.UsaLentes);
                cmd.Parameters.AddWithValue("@Diabetico", persona.Diabetico);
                cmd.Parameters.AddWithValue("@Enfermedad", persona.Enfermedad);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void EliminarPersona(int id)
        {
            using (SqlConnection cn = Conexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand("usp_EliminarPersona", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}