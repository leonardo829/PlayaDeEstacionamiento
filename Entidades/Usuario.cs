using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Usuario : Vehiculo
    {
        #region atributos
        int idUsuarios;
        string nombre {  get; set; }
        int telefono { get; set; }

        Vehiculo Vehiculo = new Vehiculo();
        #endregion

        #region Constructor
        public void Usuarios()
        {
            nombre = string.Empty;
            telefono = 0;
        }
        #endregion

        #region propiedades/encapsulamiento
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Telefono
        {
            get { return telefono; } 
            set { telefono = value; }
        }

        #endregion
    }
}
