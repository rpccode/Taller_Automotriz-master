using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Precentacion.FORM.Ordenes
{
    public partial class FormOrdenes : Form

    {
        public FormOrdenes()
        {
            InitializeComponent();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panelSeguro.Visible = true;
           
        }

        private void gunaRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panelSeguro.Visible = false;
            
        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
