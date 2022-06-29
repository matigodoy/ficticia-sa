using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-QQQQQQQ\\SQLEXPRESS;Initial Catalog=Seguros;Integrated Security=True");
            return cn;
        }
    }
}
