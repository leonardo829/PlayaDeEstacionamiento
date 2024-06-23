using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    public class Reserva

    {
        #region atributos
        private int reservaID { get; set; }
        private int usuarioID { get; set; }
        private int nEspacio { get; set; }
        #endregion

        #region Constructor
        public void Reservas()
        {
            reservaID = 0;
            usuarioID = 0;
            nEspacio = 0;
        }
        #endregion

        #region propiedades/encapsulamiento
        public int NEspacio
        {
            get { return nEspacio; }
            set { nEspacio = value; }
        }
        public int UsuarioID
        {
            get { return usuarioID; }
            set { usuarioID = value; }
        }
        public int ReservaID
        {
            get { return reservaID; }
            set { reservaID = value; }
        }
        #endregion
    }
}
