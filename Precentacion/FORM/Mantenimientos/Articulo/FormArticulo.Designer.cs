
namespace Precentacion.FORM.Mantenimientos.Articulo
{
    partial class FormArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArticulo));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtcodigo = new Guna.UI.WinForms.GunaTextBox();
            this.txtNombre = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtStock = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtMax = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtMin = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.comboGrupo = new Guna.UI.WinForms.GunaComboBox();
            this.txtCosto = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtPrecio = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel1.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.Controls.Add(this.gunaButton2);
            this.gunaElipsePanel1.Controls.Add(this.txtPrecio);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel9);
            this.gunaElipsePanel1.Controls.Add(this.txtCosto);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel8);
            this.gunaElipsePanel1.Controls.Add(this.comboGrupo);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel7);
            this.gunaElipsePanel1.Controls.Add(this.txtMin);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel6);
            this.gunaElipsePanel1.Controls.Add(this.txtMax);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel5);
            this.gunaElipsePanel1.Controls.Add(this.txtStock);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel4);
            this.gunaElipsePanel1.Controls.Add(this.txtNombre);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel3);
            this.gunaElipsePanel1.Controls.Add(this.txtcodigo);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel2);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel1);
            this.gunaElipsePanel1.Size = new System.Drawing.Size(588, 658);
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.Location = new System.Drawing.Point(0, 590);
            this.gunaElipsePanel2.Size = new System.Drawing.Size(588, 68);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Size = new System.Drawing.Size(588, 68);
            this.btnsalvar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnsalvar.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(38, 30);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(190, 32);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Nuevo Articulo";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(114, 113);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(75, 25);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Codigo:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtcodigo.BaseColor = System.Drawing.Color.White;
            this.txtcodigo.BorderColor = System.Drawing.Color.Silver;
            this.txtcodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcodigo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtcodigo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtcodigo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcodigo.Location = new System.Drawing.Point(195, 113);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.PasswordChar = '\0';
            this.txtcodigo.Radius = 6;
            this.txtcodigo.Size = new System.Drawing.Size(187, 36);
            this.txtcodigo.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BaseColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.Silver;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(195, 174);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.Radius = 6;
            this.txtNombre.Size = new System.Drawing.Size(370, 36);
            this.txtNombre.TabIndex = 4;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(107, 174);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(82, 25);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Nombre:";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.Transparent;
            this.txtStock.BaseColor = System.Drawing.Color.White;
            this.txtStock.BorderColor = System.Drawing.Color.Silver;
            this.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock.FocusedBaseColor = System.Drawing.Color.White;
            this.txtStock.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtStock.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStock.Location = new System.Drawing.Point(195, 234);
            this.txtStock.Name = "txtStock";
            this.txtStock.PasswordChar = '\0';
            this.txtStock.Radius = 6;
            this.txtStock.Size = new System.Drawing.Size(187, 36);
            this.txtStock.TabIndex = 6;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(130, 234);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(59, 25);
            this.gunaLabel4.TabIndex = 5;
            this.gunaLabel4.Text = "Stock:";
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.Color.Transparent;
            this.txtMax.BaseColor = System.Drawing.Color.White;
            this.txtMax.BorderColor = System.Drawing.Color.Silver;
            this.txtMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMax.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMax.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMax.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMax.Location = new System.Drawing.Point(195, 292);
            this.txtMax.Name = "txtMax";
            this.txtMax.PasswordChar = '\0';
            this.txtMax.Radius = 6;
            this.txtMax.Size = new System.Drawing.Size(187, 36);
            this.txtMax.TabIndex = 8;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(110, 292);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(80, 25);
            this.gunaLabel5.TabIndex = 7;
            this.gunaLabel5.Text = "Maximo:";
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.Color.Transparent;
            this.txtMin.BaseColor = System.Drawing.Color.White;
            this.txtMin.BorderColor = System.Drawing.Color.Silver;
            this.txtMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMin.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMin.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMin.Location = new System.Drawing.Point(195, 344);
            this.txtMin.Name = "txtMin";
            this.txtMin.PasswordChar = '\0';
            this.txtMin.Radius = 6;
            this.txtMin.Size = new System.Drawing.Size(187, 36);
            this.txtMin.TabIndex = 10;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(110, 344);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(77, 25);
            this.gunaLabel6.TabIndex = 9;
            this.gunaLabel6.Text = "Minimo:";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(121, 405);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(66, 25);
            this.gunaLabel7.TabIndex = 11;
            this.gunaLabel7.Text = "Grupo:";
            // 
            // comboGrupo
            // 
            this.comboGrupo.BackColor = System.Drawing.Color.Transparent;
            this.comboGrupo.BaseColor = System.Drawing.Color.White;
            this.comboGrupo.BorderColor = System.Drawing.Color.Silver;
            this.comboGrupo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGrupo.FocusedColor = System.Drawing.Color.Empty;
            this.comboGrupo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboGrupo.ForeColor = System.Drawing.Color.Black;
            this.comboGrupo.FormattingEnabled = true;
            this.comboGrupo.Location = new System.Drawing.Point(195, 405);
            this.comboGrupo.Name = "comboGrupo";
            this.comboGrupo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboGrupo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboGrupo.Radius = 6;
            this.comboGrupo.Size = new System.Drawing.Size(291, 35);
            this.comboGrupo.TabIndex = 12;
            // 
            // txtCosto
            // 
            this.txtCosto.BackColor = System.Drawing.Color.Transparent;
            this.txtCosto.BaseColor = System.Drawing.Color.White;
            this.txtCosto.BorderColor = System.Drawing.Color.Silver;
            this.txtCosto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCosto.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCosto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCosto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCosto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCosto.Location = new System.Drawing.Point(195, 462);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.PasswordChar = '\0';
            this.txtCosto.Radius = 6;
            this.txtCosto.Size = new System.Drawing.Size(187, 36);
            this.txtCosto.TabIndex = 14;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(127, 462);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(63, 25);
            this.gunaLabel8.TabIndex = 13;
            this.gunaLabel8.Text = "Costo:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Transparent;
            this.txtPrecio.BaseColor = System.Drawing.Color.White;
            this.txtPrecio.BorderColor = System.Drawing.Color.Silver;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrecio.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPrecio.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecio.Location = new System.Drawing.Point(195, 519);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.Radius = 6;
            this.txtPrecio.Size = new System.Drawing.Size(187, 36);
            this.txtPrecio.TabIndex = 16;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel9.Location = new System.Drawing.Point(86, 519);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(104, 25);
            this.gunaLabel9.TabIndex = 15;
            this.gunaLabel9.Text = "Precio Vent:";
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(388, 113);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 6;
            this.gunaButton2.Size = new System.Drawing.Size(114, 42);
            this.gunaButton2.TabIndex = 17;
            this.gunaButton2.Text = "Generar";
            // 
            // FormArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 658);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FormArticulo";
            this.Text = "FormArticulo";
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.gunaElipsePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaTextBox txtPrecio;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaTextBox txtCosto;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaComboBox comboGrupo;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox txtMin;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox txtMax;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtStock;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtNombre;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtcodigo;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}