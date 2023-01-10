using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace DataAccess
{
    class conectionSQL
    {
        static private string cadenaDeConexion = "server=DESKTOP-QBHLAER;DataBase=Taller_Automotriz2;integrated security=true";
        private SqlConnection Conexion = new SqlConnection(cadenaDeConexion);

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }




    }
}
