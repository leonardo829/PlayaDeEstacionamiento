﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    public class EspacioEstacionamiento
    {
        #region atributos
        int nEspacio {  get; set; }
        string tVehiculo { get; set; }
        bool disponibilidad { get; set; }
        #endregion

        #region Constructor
        public void Espacios()
        {
            nEspacio = 0;
            tVehiculo = string.Empty;
            disponibilidad = true;
        }
        #endregion

        #region propiedades/encapsulamiento
        public int NEspacio
        {
            get { return nEspacio; }
            set { nEspacio = value; }
        }
        public string TVehiculo
        {
            get { return tVehiculo; }
            set { tVehiculo = value; }
        }
        public bool Disponibilidad
        {
            get { return disponibilidad;}
            set { disponibilidad = value;}
        }
        #endregion
    }
}
