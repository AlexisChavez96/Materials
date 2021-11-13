using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materials.Datos
{
    public class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=localhost; DATABASE=Materials;integrated security=true;");
            cn.Open();
            return cn;
        }
    }
}
