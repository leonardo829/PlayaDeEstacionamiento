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
    public class NegEspacios
    {
        DatosEspacios objDatosEspacios = new DatosEspacios();
        public int mmEspacios(string accion, Espacio objEspacios)
        {
            return objDatosEspacios.mmEspacios(accion, objEspacios);
        }
    }
}
