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

namespace PuntoDeVentas.Administrador
{
    public partial class ClasesVehiculos : Form
    {
        public ClasesVehiculos()
        {
            InitializeComponent();
        }

        private void btnCrearClaseVehi_Click(object sender, EventArgs e)
        {
            var pDescripcion = txtNombClaseVehi.Text.Trim();

            var user = new ClaseDeVehiculo();
            user.Descripcion = pDescripcion;


            var r = CClaseDeVehiculo.crearClaseVehiculo(user);
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

        private void ClasesVehiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'repuestos3DataSet.CLASESVEHICULOS' Puede moverla o quitarla según sea necesario.
            this.cLASESVEHICULOSTableAdapter.Fill(this.repuestos3DataSet.CLASESVEHICULOS);

        }

        public int getID()
        {
            try
            {
                return Convert.ToInt32(gridClaseVehi.Rows[gridClaseVehi.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return 0;
            }
        }

        private void gridClaseVehi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = getID();

            var claseVeh = CClaseDeVehiculo.GetClaseDeVehiculo(id);
            txtNombClaseVehi.Text = claseVeh.Descripcion;
        }

        private void gridClaseVehi_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            var id = getID();

            var claseVeh = CClaseDeVehiculo.GetClaseDeVehiculo(id);
            txtNombClaseVehi.Text = claseVeh.Descripcion;
        }

        private void btnActualizarClaseVehi_Click(object sender, EventArgs e)
        {
            var claseV = new ClaseDeVehiculo();
            claseV.ID = getID();

            claseV.Descripcion = txtNombClaseVehi.Text;

            var rs = CClaseDeVehiculo.ActualizarClaseVehiculo(claseV);
            if (rs > 0)
            {
                MessageBox.Show("registro actualizado");
            }
            else
            {
                MessageBox.Show("Ocurio un error");
            }
        }
    }
}
