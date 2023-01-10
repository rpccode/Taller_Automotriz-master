using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DataAccess
{
    public class ConsBD
    {
        private conectionSQL Conexion = new conectionSQL();

        public  DataSet ejecutar(string cmd)
        {
            DataSet dsPubs = new DataSet();
            try
            {

                SqlDataAdapter daAuthors = new SqlDataAdapter(cmd, Conexion.AbrirConexion());
                dsPubs = new DataSet("Pubs");
                daAuthors.FillSchema(dsPubs, SchemaType.Source, "Authors");
                daAuthors.Fill(dsPubs, "Authors");
            }
            catch (Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show("Error =" + ex.ToString());

            }
            Conexion.CerrarConexion();
            return dsPubs;
        }
    }
}
