using PuntoDeVentas.DataSets;
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
    public partial class ClienteCompraMas : Form
    {
        public ClienteCompraMas()
        {
            InitializeComponent();
        }

        private void ClienteCompraMas_Load(object sender, EventArgs e)
        {
            this.sp_reporte_cliente_que_compra_masTableAdapter1.Fill(new ReportesDataSet.sp_reporte_cliente_que_compra_masDataTable());
            this.reportViewer1.RefreshReport();
        }
    }
}
