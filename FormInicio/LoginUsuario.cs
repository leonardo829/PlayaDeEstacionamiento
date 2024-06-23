using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class LoginUsuario : Form
    {
        public LoginUsuario()
        {
            InitializeComponent();
        }

        public Usuario objEntUsuario = new Usuario();
        public NegUsuarios objNegUsuarios = new NegUsuarios();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Int64 verificacion;

            if (txtTelefono.Text == "")
            {
                errorProvider1.SetError(txtTelefono, "este campo es obligatorio");
                txtTelefono.Focus();
                return;
            }
            if (!Int64.TryParse(txtTelefono.Text, out verificacion))
            {
                    errorProvider1.SetError(txtTelefono, "ingrese numeros enteros");
                    return;
            }

            if (!string.IsNullOrEmpty(txtDominio.Text))
            {
                    errorProvider1.SetError(txtDominio, "ingrese un dominio");
            }

            if (lbTVehi.SelectedItem == null)
            {
                    errorProvider1.SetError(lbTVehi, "seleccione un tipo de vehiculo");
            }

            else
            {
                    objEntUsuario.Nombre = txtNombre.Text;
                    objEntUsuario.Telefono = Int64.Parse(txtTelefono.Text);
                    objEntUsuario.Dominio = txtDominio.Text;
                    objEntUsuario.Tipo = (string)lbTVehi.SelectedItem;
            }

            int Ingresados = -1;
            //llamo al método que carga los datos del objeto
            Ingresados = objNegUsuarios.aUsuarios("Alta", objEntUsuario); //invoco a la capa de negocio
            if (Ingresados == -1)
                MessageBox.Show("No pudo crear usuario");
            else
            {
                this.Close();
                Programa programaForm = new Programa();
                programaForm.Show();
            }


        }
    }
}
