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
            var cargo = new Cargo();
            cargo.ID = getID();

            cargo.Nombre = txtNombCargo.Text;
            cargo.Descripcion = txtDescripCargo.Text;

            var rs = CCargo.ActualizarCargo(cargo);
            if (rs > 0)
            {
                MessageBox.Show("registro actualizado");
            }
            else
            {
                MessageBox.Show("Ocurio un error");
            }

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

        public int getID()
        {

            try
            {
                return Convert.ToInt32(gridCargo.Rows[gridCargo.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return 0;
            }
        }

        private void gridCargo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = getID();

            var cargo = CCargo.getCargoId(id);

            txtNombCargo.Text = cargo.Nombre;
            txtDescripCargo.Text = cargo.Descripcion;
        }

        private void gridCargo_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            var id = getID();

            var cargo = CCargo.getCargoId(id);
            txtNombCargo.Text = cargo.Nombre;
            txtDescripCargo.Text = cargo.Descripcion;
        }
    }
}
