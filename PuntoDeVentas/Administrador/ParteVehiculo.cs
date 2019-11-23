using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Consultas;

namespace PuntoDeVentas.Administrador
{
    public partial class ParteVehiculo : Form
    {
        public ParteVehiculo()
        {
            InitializeComponent();
        }

        private void ParteVehiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'repuestos3DataSet.PARTESVEHICULOS' Puede moverla o quitarla según sea necesario.
            this.pARTESVEHICULOSTableAdapter.Fill(this.repuestos3DataSet.PARTESVEHICULOS);

        }

        private void btnCrearModelo_Click(object sender, EventArgs e)
        {
            var pDescripcion = txtNombParte.Text.Trim();

            var user = new ParteDeVehiculo();
            user.DESCRIPCION = pDescripcion;


            var r = CParteVehiculo.crearParteVehiculo(user);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarModelo_Click(object sender, EventArgs e)
        {
            var parte = new ParteDeVehiculo();
            parte.ID = getID();

            parte.DESCRIPCION = txtNombParte.Text;
            var rs = CParteVehiculo.ActualizarParte(parte);
            if (rs > 0)
            {
                MessageBox.Show("registro actualizado");
            }
            else
            {
                MessageBox.Show("Ocurio un error");
            }
        }

        private void gridModelo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = getID();

            var parte = CParteVehiculo.getParteId(id);

            txtNombParte.Text = parte.DESCRIPCION;

        }

        private void gridModelo_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            var id = getID();

            var parte = CParteVehiculo.getParteId(id);

            txtNombParte.Text = parte.DESCRIPCION;
        }

        public int getID()
        {
            try
            {
                return Convert.ToInt32(gridModelo.Rows[gridModelo.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return 0;
            }
        }

    }
}
