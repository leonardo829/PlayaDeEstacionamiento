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
            tabControl1 = new TabControl();
            tpBuscarLugar = new TabPage();
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
            tabControl1.SuspendLayout();
            tpBuscarLugar.SuspendLayout();
            tpReservar.SuspendLayout();
            tpLiberar.SuspendLayout();
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
            btnBuscar.Location = new Point(289, 141);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 75);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar Lugar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tpReservar
            // 
            tpReservar.BackColor = Color.FromArgb(30, 90, 130);
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
            lblRLD.Location = new Point(257, 29);
            lblRLD.Name = "lblRLD";
            lblRLD.Size = new Size(192, 32);
            lblRLD.TabIndex = 7;
            lblRLD.Text = "Reserve un lugar";
            // 
            // lblLugarR
            // 
            lblLugarR.BorderStyle = BorderStyle.Fixed3D;
            lblLugarR.ForeColor = SystemColors.ButtonHighlight;
            lblLugarR.Location = new Point(131, 286);
            lblLugarR.Name = "lblLugarR";
            lblLugarR.Size = new Size(447, 85);
            lblLugarR.TabIndex = 5;
            lblLugarR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReservar
            // 
            btnReservar.Cursor = Cursors.Hand;
            btnReservar.FlatStyle = FlatStyle.Popup;
            btnReservar.ForeColor = SystemColors.ButtonHighlight;
            btnReservar.Location = new Point(298, 172);
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
            lblSSL.Location = new Point(195, 36);
            lblSSL.Name = "lblSSL";
            lblSSL.Size = new Size(297, 32);
            lblSSL.TabIndex = 7;
            lblSSL.Text = "Selecione el lugar a liberar";
            // 
            // lblRLiberar
            // 
            lblRLiberar.BorderStyle = BorderStyle.Fixed3D;
            lblRLiberar.ForeColor = SystemColors.ButtonHighlight;
            lblRLiberar.Location = new Point(128, 283);
            lblRLiberar.Name = "lblRLiberar";
            lblRLiberar.Size = new Size(447, 85);
            lblRLiberar.TabIndex = 5;
            lblRLiberar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLiberar
            // 
            btnLiberar.Cursor = Cursors.Hand;
            btnLiberar.FlatStyle = FlatStyle.Popup;
            btnLiberar.ForeColor = SystemColors.ButtonHighlight;
            btnLiberar.Location = new Point(288, 147);
            btnLiberar.Name = "btnLiberar";
            btnLiberar.Size = new Size(112, 75);
            btnLiberar.TabIndex = 4;
            btnLiberar.Text = "Liberar Lugar";
            btnLiberar.UseVisualStyleBackColor = true;
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
    }
}