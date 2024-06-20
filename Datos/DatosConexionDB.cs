using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosConexionDB
    {
        public SqlConnection conexion;
        public string cadenaConexion = @"Data Source=DESKTOP-LF6ERKD\SQLEXPRESS;Initial Catalog=PlayaEstacionamiento;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

             public DatosConexionDB()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexion", e);
            }
        }

        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexion", e);
            }
        }
    }
}
