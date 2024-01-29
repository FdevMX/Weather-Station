using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Station
{
    public partial class datos : Form
    {
        public datos()
        {
            InitializeComponent();

            cargarDatos();
        }

        private void cargarDatos(string filtro = "")
        {
            wsDatos.Rows.Clear();
            wsDatos.Refresh();
        }
    }
}
