using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    //puse los datos del Vehiculo en si en el usuario por que me parecio mas facil para hacer una base de datos relacional


    public class Usuario 
    {
        #region atributos
        private int UsuarioID {  get; set; }
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
            UsuarioID = 0;
        }
        #endregion

        #region propiedades/encapsulamiento
        public int usuarioID
        {
            get { return UsuarioID; }
            set { UsuarioID = value; }
        }
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
