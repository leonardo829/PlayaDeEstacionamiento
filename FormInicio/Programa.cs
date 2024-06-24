using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class Programa : Form
    {
        public Programa()
        {
            InitializeComponent();
        }
        public Usuario objEntUsuario = new Usuario();
        public NegUsuarios objNegUsuarios = new NegUsuarios();
        public Espacio objEntEspacio = new Espacio();
        public NegEspacios objNegEspacios = new NegEspacios();
        public Reserva objEntReserva = new Reserva();
        public NegReservas objNegReservas = new NegReservas();
        private void btnReservar_Click(object sender, EventArgs e)
        {

        }

        
         
        private void btnBuscar_Click(object sender, EventArgs e)
            
        {
            int Consultasql = -1 ;
            Consultasql = objNegEspacios.mmEspacios("Modificar", objEntEspacio);


            if (lbTVehiB.SelectedItem == null)
            {
                errorProvider1.SetError(lbTVehiB, "seleccione un tipo de vehiculo");
                return;
            }
            if (Consultasql == -1)
            {
                errorProvider1.SetError(lblLugarR, "no hay lugares disponibles para su tipo de vahiculo");
            }

            else errorProvider1.SetError(lbTVehiB, "");
            {
                objEntEspacio.tVehiculo = (string)lbTVehiB.SelectedItem;
                lblRBuscar.Text = "Los lugares disponibles son" + Consultasql;
            }
        }
    }
}
