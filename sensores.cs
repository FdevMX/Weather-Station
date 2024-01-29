using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Weather_Station
{
    class sensores
    {
        public double sensorTemp { get; set; }
        public double sensorRain { get; set; }
        public double sensorHumidity { get; set; }
        public double sensorAir { get; set; }
        public double sensorWind { get; set; }

        public string strTemp { get; set; }

        public string ObtenerCondicionTemperatura()
        {
            string calor = "";
            //double valorTemp = Convert.ToDouble(strTemp);
            double valorTemp;
            if (double.TryParse(strTemp, out valorTemp))
            {
                // La conversión se realizó correctamente
                Console.WriteLine("El valor convertido es: " + valorTemp);
            }
            else
            {
                // La conversión falló
                Console.WriteLine("No se pudo convertir el valorTemp.");
            }


            if (valorTemp < 0)
            {
                calor = "Temperatura muy fria";
            }
            else if (valorTemp == 0 && valorTemp <= 10)
            {
                calor = "Temperatura fria";
            }
            else if (valorTemp > 10 && valorTemp <= 20)
            {
                calor = "Temperatura fresca";
            }
            else if (valorTemp > 20 && valorTemp <= 30)
            {
                calor = "Temperatura cálida";
            }
            else if (valorTemp > 30)
            {
                calor = "Temperatura muy cálida";
            }

            return calor;
        }

        public string strRain { get; set; }

        Image imagenDespejado = Properties.Resources.imagen_despejado;
        Image imagenLlovizna = Properties.Resources.imagen_llovizna;
        Image imagenLluviaModerada = Properties.Resources.imagen_lluvia_moderada;
        Image imagenIntensa = Properties.Resources.imagen_lluvia_intensa;

        public class CondicionImagen
        {
            public string Condicion { get; set; }
            public Image Imagen { get; set; }
        }

        public CondicionImagen ObtenerCondicionLluvia()
        {
            CondicionImagen condicionImagen = new CondicionImagen();
            double valorLluvia = Convert.ToDouble(strRain);

            if (valorLluvia > 950)
            {
                condicionImagen.Condicion = "El clima esta despejado";
                condicionImagen.Imagen = imagenDespejado;
            }
            else if (valorLluvia <= 950 && valorLluvia > 600)
            {
                condicionImagen.Condicion = "Hay una llovizna";
                condicionImagen.Imagen = imagenLlovizna;
            }
            else if (valorLluvia <= 600 && valorLluvia > 300)
            {
                condicionImagen.Condicion = "Hay una lluvia moderada";
                condicionImagen.Imagen = imagenLluviaModerada;
            }
            else if (valorLluvia <= 300)
            {
                condicionImagen.Condicion = "La lluvia esta muy fuerte";
                condicionImagen.Imagen = imagenIntensa;
            }

            return condicionImagen;
        }


        public string strHumidity { get; set; }

        public string ObtenerCondicionHumedad()
        {
            string humedad = "";
            double valorHum = Convert.ToDouble(strHumidity);

            if (valorHum < 30)
            {
                humedad = "Aire seco";
            }
            else if (valorHum >= 30 && valorHum <= 60)
            {
                humedad = "Aire confortable y saludable";
            }
            else if (valorHum >= 60 && valorHum <= 90)
            {
                humedad = "Aire húmedo";
            }
            else if (valorHum >= 90)
            {
                humedad = "Aire muy húmedo";
            }

            return humedad;
        }

        public string strAir { get; set; }

        public string ObtenerCondicionAir()
        {
            string humedad = "";
            double valorHum = Convert.ToDouble(strAir);

            if (valorHum < 50)
            {
                humedad = "Excelente";
            }
            else if (valorHum > 50 && valorHum <= 100)
            {
                humedad = "Buena";
            }
            else if (valorHum > 100 && valorHum <= 150)
            {
                humedad = "Moderada";
            }
            else if (valorHum > 150 && valorHum <= 200)
            {
                humedad = "Mala";
            }
            else if (valorHum > 200 && valorHum <= 300)
            {
                humedad = "Muy mala";
            }
            else if (valorHum > 300)
            {
                humedad = "Peligroso";
            }

            return humedad;
        }

        public string strWind { get; set; }

        public string ObtenerCondicionWind()
        {
            string calidadAire = "";
            double valorWind = Convert.ToDouble(strWind);

            if (valorWind < 0.2)
            {
                calidadAire = "Calma";
            }
            else if (valorWind >= 0.2 && valorWind <= 1.5)
            {
                calidadAire = "Brisa muy suave";
            }
            else if (valorWind > 1.5 && valorWind <= 3.3)
            {
                calidadAire = "Brisa suave";
            }
            else if (valorWind > 3.3 && valorWind <= 5.4)
            {
                calidadAire = "Brisa moderada";
            }
            else if (valorWind > 5.4 && valorWind <= 7.9)
            {
                calidadAire = "Brisa fresca";
            }
            else if (valorWind > 7.9 && valorWind <= 10.7)
            {
                calidadAire = "Viento fresco";
            }
            else if (valorWind > 10.7 && valorWind <= 13.8)
            {
                calidadAire = "Viento fuerte";
            }
            else if (valorWind > 13.8 && valorWind <= 17.1)
            {
                calidadAire = "Viento muy fuerte";
            }
            else if (valorWind > 17.1 && valorWind <= 20.7)
            {
                calidadAire = "Temporal";
            }
            else if (valorWind > 20.7 && valorWind <= 24.4)
            {
                calidadAire = "Vendaval";
            }
            else if (valorWind > 24.4)
            {
                calidadAire = "Huracán";
            }

            return calidadAire;
        }


        public void ObtenerValores()
        {
            try
            {
                this.sensorTemp = Convert.ToDouble(strTemp);
                this.sensorHumidity = Convert.ToDouble(strHumidity);
                this.sensorAir = Convert.ToDouble(strAir);
                this.sensorWind = Convert.ToDouble(strWind);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Hubo un error de conversion");
            }

        }
        
    }
}
