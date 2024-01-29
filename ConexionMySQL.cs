using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Weather_Station
{
    internal class ConexionMySQL : Conexion
    {
        private MySqlConnection connection;
        private string cadenaConexion;

        public ConexionMySQL()
        {
            cadenaConexion = "Database=" + database + 
                "; DataSource=" + server + 
                "; User Id=" + user + 
                "; Password=" + password;

            connection = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection getConexion()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return connection;
        }

        public void closeConexion()
        {
            connection.Close();
        }
    }
}
