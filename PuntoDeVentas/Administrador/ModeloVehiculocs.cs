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
    public partial class ModeloVehiculocs : Form
    {
        public ModeloVehiculocs()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ModeloVehiculocs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'repuestos3DataSet.MODELOSVEHICULOS' Puede moverla o quitarla según sea necesario.
            this.mODELOSVEHICULOSTableAdapter.Fill(this.repuestos3DataSet.MODELOSVEHICULOS);

        }

        private void btnCrearModelo_Click(object sender, EventArgs e)
        {
            var pDescripcion = txtNombMode.Text.Trim();

            var user = new ModeloVehiculo();
            user.DESCRIPCION = pDescripcion;


            var r = CModeloDeVehiculo.crearModeloVehiculo(user);
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

        private void gridModelo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            var id = getID();
            var modelo = CModeloDeVehiculo.getModeloId(id);

            txtNombMode.Text = modelo.DESCRIPCION;
        }

        private void gridModelo_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            var id = getID();

            var modelo = CModeloDeVehiculo.getModeloId(id);

            txtNombMode.Text = modelo.DESCRIPCION;

        }

        private void btnActualizarModelo_Click(object sender, EventArgs e)
        {
            var modelo = new ModeloVehiculo();
            modelo.ID = getID();

            modelo.DESCRIPCION = txtNombMode.Text;

            /* var rs = CModeloDeVehiculo.getModeloId(modelo);

              if (rs > 0)
              {
                  MessageBox.Show("registro actualizado");
              }
              else
              {
                  MessageBox.Show("Ocurio un error");
              }*/

        }
    }
}
