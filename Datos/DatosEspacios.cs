using Entidades;
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
    public class DatosEspacios : DatosConexionDB
    {
        public int mEspacios (string accion, Espacio objEspacios)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Modificar")
                orden = "UPDATE Espacios SET Disponibilidad = '" + objEspacios.Disponibilidad + "';";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de modificar disponibilidad", e);
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
