using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Precentacion.FORM.FormBase;
using Dominio;


namespace Precentacion.FORM.Mantenimientos.Cliente
{
    public partial class FormCliente : Form
    {
        cslCliente Clie = new cslCliente();
        public DataSet ds = new DataSet();
        public FormCliente()
        {
            InitializeComponent();
           gunaDataGridView1.AutoGenerateColumns = false;
        }

        private void gunaElipsePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            ds = Clie.ConsultarCliente();
            gunaDataGridView1.DataSource = ds.Tables[0];
        }
    }
}
