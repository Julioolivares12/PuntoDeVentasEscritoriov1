using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVentas.VistaReportes
{
    public partial class ReporteDeVentas : Form
    {
        public ReporteDeVentas()
        {
            InitializeComponent();
        }

        private void ReporteDeVentas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
