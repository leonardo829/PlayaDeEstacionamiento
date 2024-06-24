namespace Presentacion
{
    partial class Programa
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
            tabControl1 = new TabControl();
            tpBuscarLugar = new TabPage();
            lbTVehiB = new ListBox();
            lblSST = new Label();
            lblRBuscar = new Label();
            btnBuscar = new Button();
            tpReservar = new TabPage();
            lblRLD = new Label();
            lblLugarR = new Label();
            btnReservar = new Button();
            tpLiberar = new TabPage();
            lblSSL = new Label();
            lblRLiberar = new Label();
            btnLiberar = new Button();
            errorProvider1 = new ErrorProvider(components);
            lbTVR = new ListBox();
            txtNumeroLB = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tpBuscarLugar.SuspendLayout();
            tpReservar.SuspendLayout();
            tpLiberar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpBuscarLugar);
            tabControl1.Controls.Add(tpReservar);
            tabControl1.Controls.Add(tpLiberar);
            tabControl1.Location = new Point(36, 36);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(707, 469);
            tabControl1.TabIndex = 0;
            // 
            // tpBuscarLugar
            // 
            tpBuscarLugar.BackColor = Color.FromArgb(30, 90, 120);
            tpBuscarLugar.Controls.Add(lbTVehiB);
            tpBuscarLugar.Controls.Add(lblSST);
            tpBuscarLugar.Controls.Add(lblRBuscar);
            tpBuscarLugar.Controls.Add(btnBuscar);
            tpBuscarLugar.Font = new Font("Segoe UI", 12F);
            tpBuscarLugar.ForeColor = SystemColors.ControlText;
            tpBuscarLugar.Location = new Point(4, 34);
            tpBuscarLugar.Name = "tpBuscarLugar";
            tpBuscarLugar.Padding = new Padding(3);
            tpBuscarLugar.RightToLeft = RightToLeft.No;
            tpBuscarLugar.Size = new Size(699, 431);
            tpBuscarLugar.TabIndex = 0;
            tpBuscarLugar.Text = "Buscar Lugar";
            // 
            // lbTVehiB
            // 
            lbTVehiB.FormattingEnabled = true;
            lbTVehiB.ItemHeight = 32;
            lbTVehiB.Items.AddRange(new object[] { "Auto", "Camioneta", "Moto" });
            lbTVehiB.Location = new Point(279, 74);
            lbTVehiB.Name = "lbTVehiB";
            lbTVehiB.ScrollAlwaysVisible = true;
            lbTVehiB.Size = new Size(154, 100);
            lbTVehiB.Sorted = true;
            lbTVehiB.TabIndex = 9;
            // 
            // lblSST
            // 
            lblSST.AutoSize = true;
            lblSST.ForeColor = SystemColors.ButtonHighlight;
            lblSST.Location = new Point(183, 22);
            lblSST.Name = "lblSST";
            lblSST.Size = new Size(328, 32);
            lblSST.TabIndex = 3;
            lblSST.Text = "Selecione su tipo de vehiculo";
            // 
            // lblRBuscar
            // 
            lblRBuscar.BorderStyle = BorderStyle.Fixed3D;
            lblRBuscar.ForeColor = SystemColors.ButtonHighlight;
            lblRBuscar.Location = new Point(142, 296);
            lblRBuscar.Name = "lblRBuscar";
            lblRBuscar.Size = new Size(447, 85);
            lblRBuscar.TabIndex = 1;
            lblRBuscar.Text = "Click en buscar lugar y aparecera aqui un lugar disponible";
            lblRBuscar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(297, 202);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 75);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar Lugar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tpReservar
            // 
            tpReservar.BackColor = Color.FromArgb(30, 90, 130);
            tpReservar.Controls.Add(label2);
            tpReservar.Controls.Add(label1);
            tpReservar.Controls.Add(textBox1);
            tpReservar.Controls.Add(lbTVR);
            tpReservar.Controls.Add(lblRLD);
            tpReservar.Controls.Add(lblLugarR);
            tpReservar.Controls.Add(btnReservar);
            tpReservar.Font = new Font("Segoe UI", 12F);
            tpReservar.Location = new Point(4, 34);
            tpReservar.Name = "tpReservar";
            tpReservar.Padding = new Padding(3);
            tpReservar.Size = new Size(699, 431);
            tpReservar.TabIndex = 1;
            tpReservar.Text = "Reservar Lugar";
            // 
            // lblRLD
            // 
            lblRLD.AutoSize = true;
            lblRLD.ForeColor = SystemColors.ButtonHighlight;
            lblRLD.Location = new Point(253, 14);
            lblRLD.Name = "lblRLD";
            lblRLD.Size = new Size(192, 32);
            lblRLD.TabIndex = 7;
            lblRLD.Text = "Reserve un lugar";
            // 
            // lblLugarR
            // 
            lblLugarR.BorderStyle = BorderStyle.Fixed3D;
            lblLugarR.ForeColor = SystemColors.ButtonHighlight;
            lblLugarR.Location = new Point(133, 329);
            lblLugarR.Name = "lblLugarR";
            lblLugarR.Size = new Size(447, 85);
            lblLugarR.TabIndex = 5;
            lblLugarR.Text = " Su lugar reservado es X";
            lblLugarR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReservar
            // 
            btnReservar.Cursor = Cursors.Hand;
            btnReservar.FlatStyle = FlatStyle.Popup;
            btnReservar.ForeColor = SystemColors.ButtonHighlight;
            btnReservar.Location = new Point(294, 239);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(112, 75);
            btnReservar.TabIndex = 4;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = true;
            btnReservar.Click += btnReservar_Click;
            // 
            // tpLiberar
            // 
            tpLiberar.BackColor = Color.FromArgb(30, 90, 140);
            tpLiberar.Controls.Add(txtNumeroLB);
            tpLiberar.Controls.Add(lblSSL);
            tpLiberar.Controls.Add(lblRLiberar);
            tpLiberar.Controls.Add(btnLiberar);
            tpLiberar.Font = new Font("Segoe UI", 12F);
            tpLiberar.Location = new Point(4, 34);
            tpLiberar.Name = "tpLiberar";
            tpLiberar.Size = new Size(699, 431);
            tpLiberar.TabIndex = 2;
            tpLiberar.Text = "Liberar Lugar";
            // 
            // lblSSL
            // 
            lblSSL.AutoSize = true;
            lblSSL.ForeColor = SystemColors.ButtonHighlight;
            lblSSL.Location = new Point(150, 21);
            lblSSL.Name = "lblSSL";
            lblSSL.Size = new Size(413, 32);
            lblSSL.TabIndex = 7;
            lblSSL.Text = "Indique el numero  del lugar a liberar";
            // 
            // lblRLiberar
            // 
            lblRLiberar.BorderStyle = BorderStyle.Fixed3D;
            lblRLiberar.ForeColor = SystemColors.ButtonHighlight;
            lblRLiberar.Location = new Point(128, 283);
            lblRLiberar.Name = "lblRLiberar";
            lblRLiberar.Size = new Size(447, 85);
            lblRLiberar.TabIndex = 5;
            lblRLiberar.Text = "El lugar X a sido liberado";
            lblRLiberar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLiberar
            // 
            btnLiberar.Cursor = Cursors.Hand;
            btnLiberar.FlatStyle = FlatStyle.Popup;
            btnLiberar.ForeColor = SystemColors.ButtonHighlight;
            btnLiberar.Location = new Point(292, 187);
            btnLiberar.Name = "btnLiberar";
            btnLiberar.Size = new Size(112, 75);
            btnLiberar.TabIndex = 4;
            btnLiberar.Text = "Liberar Lugar";
            btnLiberar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lbTVR
            // 
            lbTVR.FormattingEnabled = true;
            lbTVR.ItemHeight = 32;
            lbTVR.Items.AddRange(new object[] { "Auto", "Camioneta", "Moto" });
            lbTVR.Location = new Point(274, 79);
            lbTVR.Name = "lbTVR";
            lbTVR.ScrollAlwaysVisible = true;
            lbTVR.Size = new Size(154, 100);
            lbTVR.Sorted = true;
            lbTVR.TabIndex = 10;
            // 
            // txtNumeroLB
            // 
            txtNumeroLB.Location = new Point(267, 106);
            txtNumeroLB.Name = "txtNumeroLB";
            txtNumeroLB.Size = new Size(150, 39);
            txtNumeroLB.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(274, 185);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 39);
            textBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(113, 188);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 12;
            label1.Text = "Dominio";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(76, 79);
            label2.Name = "label2";
            label2.Size = new Size(192, 76);
            label2.TabIndex = 13;
            label2.Text = "seleccione su tipo de vehiculo";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Programa
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(30, 50, 90);
            ClientSize = new Size(778, 544);
            Controls.Add(tabControl1);
            ForeColor = SystemColors.ControlText;
            Name = "Programa";
            Text = "Programa";
            tabControl1.ResumeLayout(false);
            tpBuscarLugar.ResumeLayout(false);
            tpBuscarLugar.PerformLayout();
            tpReservar.ResumeLayout(false);
            tpReservar.PerformLayout();
            tpLiberar.ResumeLayout(false);
            tpLiberar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpBuscarLugar;
        private TabPage tpReservar;
        private TabPage tpLiberar;
        private Label lblSST;
        private Label lblRBuscar;
        private Button btnBuscar;
        private Label lblRLD;
        private Label lblLugarR;
        private Button btnReservar;
        private Label lblSSL;
        private Label lblRLiberar;
        private Button btnLiberar;
        private ListBox lbTVehiB;
        private ErrorProvider errorProvider1;
        private ListBox lbTVR;
        private TextBox txtNumeroLB;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
    }
}