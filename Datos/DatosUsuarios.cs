using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    //esto funciona bien me falta agregar la accion de ingresar cuando el usuario ya esa creado

    public class DatosUsuarios : DatosConexionDB
    {
        public int aUsuarios(string accion, Usuario objUsuario)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
            {
                orden = $"INSERT INTO Usuarios (Telefono, Nombre, Dominio, TipoVehiculo) VALUES ({objUsuario.telefono}, '{objUsuario.nombre}', '{objUsuario.dominio}', '{objUsuario.tipo}')";
            }

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de crear Usuarios", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }
    }
}
