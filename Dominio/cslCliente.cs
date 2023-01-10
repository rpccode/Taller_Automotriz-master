using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
     
     public class cslCliente
    {
        ConsBD Cons = new ConsBD();
        public DataSet ds = new DataSet();

        public DataSet ConsultarCliente()
        {
            String cmd = string.Format("exec ReadTodosCliente");

            ds = Cons.ejecutar(cmd);

            return ds;
        }











    }
}
