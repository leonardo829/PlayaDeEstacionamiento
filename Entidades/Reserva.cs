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
        private int ReservaID { get; set; }
        private int UsuarioID { get; set; }
        private int NEspacio { get; set; }
        #endregion

        #region Constructor
        public void Reservas()
        {
            ReservaID = 0;
            UsuarioID = 0;
            NEspacio = 0;
        }
        #endregion

        #region propiedades/encapsulamiento
        public int nEspacio
        {
            get { return NEspacio; }
            set { NEspacio = value; }
        }
        public int usuarioID
        {
            get { return UsuarioID; }
            set { UsuarioID = value; }
        }
        public int reservaID
        {
            get { return ReservaID; }
            set { ReservaID = value; }
        }
        #endregion
    }
}
