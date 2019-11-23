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
using Modelos;
using Consultas;

namespace PuntoDeVentas.Administrador
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'repuestos3DataSet.PERFIL' Puede moverla o quitarla según sea necesario.
            this.pERFILTableAdapter.Fill(this.repuestos3DataSet.PERFIL);

        }

        private void btnCrearPerfil_Click(object sender, EventArgs e)
        {
            var pNombre = txtNombPerfil.Text.Trim();
            var pDescripcion = txtDescripPerfil.Text.Trim();

            var user = new Perfiles();
            user.Nombre = pNombre;
            user.Descripcion = pDescripcion;

            var r = CPerfiles.crearPerfil(user);
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
                return Convert.ToInt32(gridPerfil.Rows[gridPerfil.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return 0;
            }
        }

        private void gridPerfil_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = getID();

            var perfil = CPerfiles.getPerfilId(id);

            txtNombPerfil.Text = perfil.Nombre;
            txtDescripPerfil.Text = perfil.Descripcion;
        }

        private void gridPerfil_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            var id = getID();

            var perfil = CPerfiles.getPerfilId(id);
            txtNombPerfil.Text = perfil.Nombre;
            txtDescripPerfil.Text = perfil.Descripcion;
        }

        private void btnActualizarPerfil_Click(object sender, EventArgs e)
        {
            var perfil = new Perfiles();
            perfil.ID = getID();

            perfil.Nombre = txtNombPerfil.Text;
            perfil.Descripcion = txtDescripPerfil.Text;

            var rs = CPerfiles.ActualizarPerfil(perfil);
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
