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
    public partial class ProductoMasVendido : Form
    {
        public ProductoMasVendido()
        {
            InitializeComponent();
        }

        private void ProductoMasVendido_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
