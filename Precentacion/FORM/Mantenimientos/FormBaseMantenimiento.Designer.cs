
namespace Precentacion.FORM.Mantenimientos
{
    partial class FormBaseMantenimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaseMantenimiento));
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnsalvar = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(628, 685);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.Controls.Add(this.btnsalvar);
            this.gunaElipsePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaElipsePanel2.Location = new System.Drawing.Point(0, 617);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Size = new System.Drawing.Size(628, 68);
            this.gunaElipsePanel2.TabIndex = 1;
            // 
            // btnsalvar
            // 
            this.btnsalvar.AnimationHoverSpeed = 0.07F;
            this.btnsalvar.AnimationSpeed = 0.03F;
            this.btnsalvar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(114)))), ((int)(((byte)(17)))));
            this.btnsalvar.BorderColor = System.Drawing.Color.Black;
            this.btnsalvar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnsalvar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsalvar.FocusedColor = System.Drawing.Color.Empty;
            this.btnsalvar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsalvar.ForeColor = System.Drawing.Color.White;
            this.btnsalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnsalvar.Image")));
            this.btnsalvar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsalvar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnsalvar.Location = new System.Drawing.Point(0, 0);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnsalvar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnsalvar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnsalvar.OnHoverImage = null;
            this.btnsalvar.OnPressedColor = System.Drawing.Color.Black;
            this.btnsalvar.Size = new System.Drawing.Size(628, 68);
            this.btnsalvar.TabIndex = 0;
            // 
            // FormBaseMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 685);
            this.Controls.Add(this.gunaElipsePanel2);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "FormBaseMantenimiento";
            this.Text = "FormBaseMantenimiento";
            this.gunaElipsePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        public Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        public Guna.UI.WinForms.GunaButton btnsalvar;
    }
}