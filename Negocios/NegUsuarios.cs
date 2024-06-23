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
    public class NegUsuarios
    {
        DatosUsuarios objDatosUsuarios = new DatosUsuarios();
        public int aUsuarios(string accion, Usuario objUsuario)
        {
            return objDatosUsuarios.aUsuarios(accion, objUsuario);
        }
    }
}
