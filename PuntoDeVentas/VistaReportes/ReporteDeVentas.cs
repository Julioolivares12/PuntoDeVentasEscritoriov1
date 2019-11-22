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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var inicio = dateTimePickerFechaInicial.Value;
            var final = dateTimePickerFechaFinal.Value;

            cargarDatos(inicio,final);
        }

        private void btnAhora_Click(object sender, EventArgs e)
        {
            var inicio = DateTime.Today;
            var final = DateTime.Now;
            cargarDatos(inicio,final);
        }


        private void cargarDatos(DateTime inicio,DateTime final)
        {
            this.sp_reporte_ventasTableAdapter1.Fill(new ReportesDataSet.sp_reporte_ventasDataTable(), inicio, final);
            this.reportViewer1.RefreshReport();
        }
    }
}
