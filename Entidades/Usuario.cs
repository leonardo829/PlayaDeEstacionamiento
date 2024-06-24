using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Usuario 
    {
        #region atributos
        private int UsuarioID;
        private string Nombre {  get; set; }
        private Int64 Telefono { get; set; }

        private string Tipo { get; set; }
        private string Dominio { get; set; }

        #endregion

        #region Constructor
        public void Usuarios()
        {
            Nombre = string.Empty;
            Telefono = 0;
            Dominio = string.Empty;
            Tipo = string.Empty;
            
        }
        #endregion

        #region propiedades/encapsulamiento
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public Int64 telefono
        {
            get { return Telefono; } 
            set { Telefono = value; }
        }
        public string dominio
        {
            get { return Dominio; }
            set { Dominio = value; }
        }
        public string tipo
        {
            get { return Tipo; } 
            set { Tipo = value; }
        }
        


        #endregion
    }
}
