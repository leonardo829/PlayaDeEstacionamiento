using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;

namespace Negocios
{
    public class NegReservas
    {
        DatosReservas objDatosReservas = new DatosReservas();
        public int abReservas(string accion, Reserva objReservas)
        {
            return objDatosReservas.abReservas(accion, objReservas);
        }
    }
}
