namespace Presentacion
{
    partial class LoginUsuario
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
            components = new System.ComponentModel.Container();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            txtDominio = new TextBox();
            lblNombre = new Label();
            lblTelefono = new Label();
            lblDominio = new Label();
            lblTVehi = new Label();
            lbTVehi = new ListBox();
            btnIngresar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(265, 153);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(232, 31);
            txtTelefono.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(265, 93);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 31);
            txtNombre.TabIndex = 2;
            // 
            // txtDominio
            // 
            txtDominio.Location = new Point(265, 211);
            txtDominio.Name = "txtDominio";
            txtDominio.Size = new Size(232, 31);
            txtDominio.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.ForeColor = SystemColors.ButtonHighlight;
            lblNombre.Location = new Point(34, 93);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 32);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F);
            lblTelefono.ForeColor = SystemColors.ButtonHighlight;
            lblTelefono.Location = new Point(34, 153);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(112, 32);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Telefono:";
            lblTelefono.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDominio
            // 
            lblDominio.AutoSize = true;
            lblDominio.Font = new Font("Segoe UI", 12F);
            lblDominio.ForeColor = SystemColors.ButtonHighlight;
            lblDominio.Location = new Point(34, 211);
            lblDominio.Name = "lblDominio";
            lblDominio.Size = new Size(106, 32);
            lblDominio.TabIndex = 6;
            lblDominio.Text = "Dominio";
            lblDominio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTVehi
            // 
            lblTVehi.AutoSize = true;
            lblTVehi.Font = new Font("Segoe UI", 12F);
            lblTVehi.ForeColor = SystemColors.ButtonHighlight;
            lblTVehi.Location = new Point(34, 269);
            lblTVehi.Name = "lblTVehi";
            lblTVehi.Size = new Size(192, 32);
            lblTVehi.TabIndex = 7;
            lblTVehi.Text = "Tipo de vehiculo";
            lblTVehi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTVehi
            // 
            lbTVehi.FormattingEnabled = true;
            lbTVehi.ItemHeight = 25;
            lbTVehi.Items.AddRange(new object[] { "Auto", "Camioneta", "Moto" });
            lbTVehi.Location = new Point(265, 269);
            lbTVehi.Name = "lbTVehi";
            lbTVehi.ScrollAlwaysVisible = true;
            lbTVehi.Size = new Size(232, 29);
            lbTVehi.Sorted = true;
            lbTVehi.TabIndex = 8;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(344, 353);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(112, 46);
            btnIngresar.TabIndex = 9;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkRate = 200;
            errorProvider1.ContainerControl = this;
            // 
            // LoginUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 50, 90);
            ClientSize = new Size(800, 450);
            Controls.Add(btnIngresar);
            Controls.Add(lbTVehi);
            Controls.Add(lblTVehi);
            Controls.Add(lblDominio);
            Controls.Add(lblTelefono);
            Controls.Add(lblNombre);
            Controls.Add(txtDominio);
            Controls.Add(txtNombre);
            Controls.Add(txtTelefono);
            Name = "LoginUsuario";
            Text = "LoginUsuario";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private TextBox txtDominio;
        private Label lblNombre;
        private Label lblTelefono;
        private Label lblDominio;
        private Label lblTVehi;
        private ListBox lbTVehi;
        private Button btnIngresar;
        private ErrorProvider errorProvider1;
    }
}