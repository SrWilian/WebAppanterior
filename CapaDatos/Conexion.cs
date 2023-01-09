using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion

    {
        private static readonly Conexion _instancia = new Conexion();

        public static Conexion Instancia
        {
            get { return _instancia; }
        }

        public SqlConnection Conectar()
        {
           
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-I5OBAPS;initial Catalog=BD_MADERERA;" + "Integrated Security=true";
            return cn;
           
        }
    }
}
