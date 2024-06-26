﻿using System;
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

    //falta agregar un ingreso de usuario que se me ocurrio para poder usar los datos de cada usuario en el 2do form
    //este form funciona al 100% segun mis testeos


    public partial class LoginUsuario : Form
    {
        public Usuario objEntUsuario = new Usuario();
        public NegUsuarios objNegUsuarios = new NegUsuarios();
        public Espacio objEntEspacio = new Espacio();
        public NegEspacios objNegEspacios = new NegEspacios();
        public Reserva objEntReserva = new Reserva();
        public NegReservas objNegReservas = new NegReservas();
        public LoginUsuario()
        {
            InitializeComponent();
        }

        

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

            if (txtDominio.Text == "")
            {
                    errorProvider1.SetError(txtDominio, "ingrese un dominio");
                    return ;
            }

            if (lbTVehi.SelectedItem == null)
            {
                    errorProvider1.SetError(lbTVehi, "seleccione un tipo de vehiculo");
                    return ;
            }

            else errorProvider1.SetError(txtTelefono, "");
            {
                    objEntUsuario.nombre = txtNombre.Text;
                    objEntUsuario.telefono = Int64.Parse(txtTelefono.Text);
                    objEntUsuario.dominio = txtDominio.Text;
                    objEntUsuario.tipo = (string)lbTVehi.SelectedItem;
            }

            int Ingresados = -1;
            //llamo al método que carga los datos del objeto
            Ingresados = objNegUsuarios.aUsuarios("Alta", objEntUsuario); //invoco a la capa de negocio
            if (Ingresados == -1)
                MessageBox.Show("No se pudo crear el usuario");
            else
            { 
                Programa programaForm = Application.OpenForms.OfType<Programa>().FirstOrDefault();
                if (programaForm == null)
                {
                    programaForm = new Programa();
                    programaForm.Show();
                }
                
            }
            this.Hide();
        }
    }
}
