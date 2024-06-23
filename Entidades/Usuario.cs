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
        private string nombre {  get; set; }
        private Int64 telefono { get; set; }

        private string tipo { get; set; }
        private string dominio { get; set; }

        #endregion

        #region Constructor
        public void Usuarios()
        {
            nombre = string.Empty;
            telefono = 0;
            dominio = string.Empty;
            tipo = string.Empty;
            
        }
        #endregion

        #region propiedades/encapsulamiento
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Int64 Telefono
        {
            get { return telefono; } 
            set { telefono = value; }
        }
        public string Dominio
        {
            get { return dominio; }
            set { dominio = value; }
        }
        public string Tipo
        {
            get { return tipo; } 
            set { tipo = value; }
        }
        


        #endregion
    }
}
