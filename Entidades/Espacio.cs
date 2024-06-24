using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    public class Espacio
    {
        
        #region atributos
        private int NEspacio {  get; set; }
        private string TVehiculo { get; set; }
        private string Disponibilidad { get; set; }


        #endregion

        #region Constructor
        public void Espacios()
        {
            NEspacio = 0;
            TVehiculo = string.Empty;
            Disponibilidad = "s" ;
        }
        #endregion

        #region propiedades/encapsulamiento
        public int nEspacio
        {
            get { return NEspacio; }
            set { NEspacio = value; }
        }
        public string tVehiculo
        {
            get { return TVehiculo; }
            set { TVehiculo = value; }
        }
        public string disponibilidad
        {
            get { return Disponibilidad;}
            set { Disponibilidad = value;}
        }
        #endregion
    }
}
