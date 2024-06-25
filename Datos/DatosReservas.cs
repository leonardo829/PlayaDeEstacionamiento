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

        //todo esto aun no se si funciona no lo llegue a utilizar aun
        public int abReservas(string accion, Reserva objReservas)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
                orden = "insert into Reservas values (" + objReservas.usuarioID +
                ",'" + objReservas.nEspacio + "');";
            if (accion == "Baja")
                orden = "DELETE FROM Reserva WHERE ReservaID = " + objReservas.nEspacio + ";";
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
