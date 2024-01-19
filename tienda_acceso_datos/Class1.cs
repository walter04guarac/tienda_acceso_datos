using System;
using System.Data.SqlClient;

namespace tienda_acceso_datos
{
    public class ConexionBD
    {
        private SqlConnection connection;

        public ConexionBD()
        {
            // Reemplaza 'TuServidor' y 'TuBaseDeDatos' con los valores correctos
            string connectionString = "Server=SOLO-MIAU(SQL Server 16.0.1000.6)\\SQLEXPRESS;Database=El que tu quieras;Integrated Security=True;";
            connection = new SqlConnection(connectionString);
        }

        // Método para abrir la conexión a la base de datos
        public void AbrirConexion()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                    Console.WriteLine("Conexión abierta correctamente");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
        }

        // Método para cerrar la conexión a la base de datos
        public void CerrarConexion()
        {
            try
            {
                // Cierra la conexión si está abierta
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                    Console.WriteLine("Conexión cerrada correctamente");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }
}
