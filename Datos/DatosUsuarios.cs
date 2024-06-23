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
    internal class DatosUsuarios : DatosConexionDB
    {
        public int abmUsuarios(string accion, Usuario objUsuario)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
                orden = "insert into Usuarios values (" + objUsuario.Telefono + ",'" + objUsuario.Nombre + ",'" + objUsuario.Dominio + ",'" + objUsuario.Tipo + ", ) ";
            if (accion == "Modificar")
                orden = "update Usuarios set Nombre='" + objUsuario.Nombre + "' where Telefono = "+ objUsuario.Telefono + "; ";

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de crear o modificar Usuarios", e);
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
