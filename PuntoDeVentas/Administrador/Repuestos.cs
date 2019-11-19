using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVentas.Administrador
{
    public partial class Repuestos : Form
    {
        public Repuestos()
        {
            InitializeComponent();
        }

        private void Repuestos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'repuestos3DataSet.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter.Fill(this.repuestos3DataSet.USUARIOS);

        }
    }
}
