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
    public class DatosReservas : DatosConexionDB
    {
        public int abReservas(string accion, Reserva objReservas)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
                orden = "insert into Reservas values (" + objReservas.UsuarioID +
                ",'" + objReservas.NEspacio + "');";
            if (accion == "Baja")
                orden = "DELETE FROM Reserva WHERE ReservaID = " + objReservas.NEspacio + ";";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de crear o borrar Reservas",e);
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
