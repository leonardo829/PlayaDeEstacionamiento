using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    public class Vehiculo 
    {
        #region atributos
        string tipo {  get; set; }
        string dominio { get; set; }
        #endregion

        #region Constructor
        public void Vehiculos()
        {
            dominio = string.Empty;
            tipo = string.Empty;
        }
        #endregion

        #region propiedades/encapsulamiento
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Dominio
        {
            get { return dominio; }
            set { dominio = value; }
        }
        #endregion

    }
}
