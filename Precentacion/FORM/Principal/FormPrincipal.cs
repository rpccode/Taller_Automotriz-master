using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Precentacion.FORM.Mantenimientos.Cliente;
using Precentacion.FORM.Mantenimientos.Cotizacion;
using Precentacion.FORM.Mantenimientos.InformeTecnico;
using Precentacion.FORM.Ordenes;

namespace Precentacion.FORM.Principal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            pantallaConf();
        }
        #region
        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.Sizable;
              //formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.StartPosition = FormStartPosition.CenterScreen;
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }


        #endregion

        private void gunaButton4_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pantallaConf()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(panelMenu.Width == 39)
            {
                panelMenu.Width = 300;
                panel1.Visible = true;
            }
            else
            {
                panelMenu.Width = 39;
                panel1.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCotizar>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblfecha.Text = DateTime.Now.ToString("dddd MMMM yyyy");
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormOrdenes>();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormInfTecnico>();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCliente>();
        }
    }
}
