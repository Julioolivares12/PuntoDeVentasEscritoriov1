using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Models;
using Consultas;
using Modelos;

namespace PuntoDeVentas.Administrador
{
    public partial class Cargos : Form
    {
        public Cargos()
        {
            InitializeComponent();
        }

        private void gridCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizarCargo_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarCargo_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearCargo_Click(object sender, EventArgs e)
        {
            var pNombreCargo = txtNombCargo.Text.Trim();
            var pDescripCargo = txtDescripCargo.Text.Trim();

            var user = new Cargo();
            user.Nombre = pNombreCargo;
            user.Descripcion = pDescripCargo;

            var r = CCargo.crearCargo(user);
            if (r > 0)
            {
                MessageBox.Show("agregado con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("ocurrio un error");

            }
        }

        private void Cargos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'repuestos3DataSet.CARGOS' Puede moverla o quitarla según sea necesario.
            this.cARGOSTableAdapter.Fill(this.repuestos3DataSet.CARGOS);

        }
    }
}
