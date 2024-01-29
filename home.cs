using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Weather_Station
{
    public partial class Weather_Station : Form
    {
        SerialPort SerialPort1 = new SerialPort();
        System.Windows.Forms.Timer loop;
        sensores sensores;
        String datos;

        public Weather_Station()
        {
            InitializeComponent();

            SerialPort1.BaudRate = 9600;
            SerialPort1.Parity = Parity.None;
            SerialPort1.StopBits = StopBits.One;
            SerialPort1.DataBits = 8;

            loop = new System.Windows.Forms.Timer();
            loop.Interval = 500;
            //loop.Tick += new EventHandler(timer_Tick);
            loop.Tick += Loop_Tick;
            loop.Start();

            sensores = new sensores();

            Control.CheckForIllegalCrossThreadCalls = false;
            foreach (string ListaSerialPorts in SerialPort.GetPortNames())
            {
                selectPort.Items.Add(ListaSerialPorts);
            }
            SerialPort1.DataReceived += new
            SerialDataReceivedEventHandler(SerialPort1_DataReceived);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            loop.Stop(); // Detener el temporizador
            SerialPort1.Close();
        }

        private void selectPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialPort1.PortName = selectPort.Text;
            try
            {
                SerialPort1.Open();
            }
            catch
            {
                MessageBox.Show("Puerto no válido");
                return;
            }
            selectPort.Enabled = false;
        }

        private string[] datosRecibidos = new string[5];

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            datos = SerialPort1.ReadLine();
            string[] substrings = datos.Split(',');
            if(substrings.Length == 5)
            {
                sensores.strTemp = substrings[0];
                sensores.strRain = substrings[1];
                sensores.strHumidity = substrings[2];
                sensores.strAir = substrings[3];
                sensores.strWind = substrings[4];
                sensores.ObtenerValores();
            }
        }

        private void Loop_Tick(object sender, EventArgs e)
        {
            gauTemp.Value = (float)sensores.sensorTemp;
            txtTemp.Text = sensores.strTemp + " ºC";
            txtTemper.Text = sensores.strTemp;
            txtValTemp.Text = sensores.ObtenerCondicionTemperatura();

            var condicionImagen = sensores.ObtenerCondicionLluvia();
            pictureRain.Image = condicionImagen.Imagen;
            txtLluvia.Text = sensores.strRain;
            lblRain.Text = condicionImagen.Condicion;

            gauHum.Value = (float)sensores.sensorHumidity;
            txtHumidity.Text = sensores.strHumidity + " %";
            txtHumed.Text = sensores.strHumidity;
            txtValHum.Text = sensores.ObtenerCondicionHumedad();

            gauAir.Value = (float)sensores.sensorAir;
            txtAir.Text = sensores.strAir + " PPM";
            txtAire.Text = sensores.strAir;
            txtValAir.Text = sensores.ObtenerCondicionAir();

            gauWind.Value = (float)sensores.sensorWind;
            txtWind.Text = sensores.strWind + " m/s";
            txtViento.Text = sensores.strWind;
            txtValWind.Text = sensores.ObtenerCondicionWind();
 
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        public string GetTimeOfDay()
        {
            DateTime now = DateTime.Now;
            int hour = now.Hour;
            string timeOfDay = "";
            Image image = null;

            if (hour >= 6 && hour < 12)
            {
                timeOfDay = "Todavia es de Mañana";
                image = Properties.Resources.manana;
            }
            else if (hour >= 12 && hour < 14)
            {
                timeOfDay = "Es mediodia";
                image = Properties.Resources.mediodia;
            }
            else if (hour >= 14 && hour < 19)
            {
                timeOfDay = "Ya es tarde";
                image = Properties.Resources.tarde;
            }
            else
            {
                timeOfDay = "Ya es de noche";
                image = Properties.Resources.noche;
            }

            // Asignar la imagen al control PictureBox
            pictureDay.Image = image;

            return timeOfDay;
        }


        private void home_Load(object sender, EventArgs e)
        {
            lblDay.Text = GetTimeOfDay();
        }

        private void gauHum_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {

        }

        private bool datosInsertar()
        {
            if (txtTemp.Text.Trim().Equals(""))
            {
                return false;
            }
            if (txtHumidity.Text.Trim().Equals(""))
            {
                return false;
            }
            if (txtAir.Text.Trim().Equals(""))
            {
                return false;
            }
            if (txtWind.Text.Trim().Equals(""))
            {
                return false;
            }
            if (txtLluvia.Text.Trim().Equals(""))
            {
                return false;
            }

            if (!float.TryParse(txtTemp.Text.Trim(), out float temperatura))
            {
                return false;
            }
            if (!float.TryParse(txtHumidity.Text.Trim(), out float humedad))
            {
                return false;
            }
            if (!float.TryParse(txtAir.Text.Trim(), out float aire))
            {
                return false;
            }
            if (!float.TryParse(txtWind.Text.Trim(), out float viento))
            {
                return false;
            }
            if (!float.TryParse(txtLluvia.Text.Trim(), out float lluvia))
            {
                return false;
            }

            return true;
        }
    }
}
