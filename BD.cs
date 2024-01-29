using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Weather_Station
{
    class BD
    {
        private string connectionString;

        public BD(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertSensorData(double sensorTemp, double sensorRain, double sensorHumidity, double sensorAir, double sensorWind)
        {
            // crear una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // abrir la conexión
                connection.Open();

                // crear una consulta de inserción
                string insertQuery = "INSERT INTO registros (temperatura, humedad, aire, viento, lluvia, fecha, hora) VALUES (@Temperature, @Humidity, @Air, @Wind, @Rain, @Fecha, @Hora)";

                // crear un objeto de comando con la consulta de inserción y la conexión a la base de datos
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // establecer los parámetros de la consulta
                    command.Parameters.AddWithValue("@Temperature", sensorTemp);
                    command.Parameters.AddWithValue("@Humidity", sensorHumidity);
                    command.Parameters.AddWithValue("@Air", sensorAir);
                    command.Parameters.AddWithValue("@Wind", sensorWind);
                    command.Parameters.AddWithValue("@Rain", sensorRain);
                    command.Parameters.AddWithValue("@Fecha", DateTime.Today);
                    command.Parameters.AddWithValue("@Hora", DateTime.Now.TimeOfDay);


                    // ejecutar la consulta de inserción
                    command.ExecuteNonQuery();
                }

                // cerrar la conexión
                connection.Close();
            }
        }
    }

}
