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
    public partial class Clientes : Form
    {

        public char s;
        public char est;
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'repuestos3DataSet.CLIENTES' Puede moverla o quitarla según sea necesario.
            this.cLIENTESTableAdapter.Fill(this.repuestos3DataSet.CLIENTES);

        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            var Primernombre = txtPrimerNombreCliente.Text.Trim();
            var primerapellido = txtPrimerApellidoCliente.Text.Trim();
            var fechanac = txtFechaNacCliente.Text.Trim();
            var sexo = cbSexoCliente.Text.Trim();
            var estado_civil = cbEstadoCivilCliente.Text.Trim();
            var lugartrabajo = txtTrabajoCliente.Text.Trim();
            var dui_nit = txtDuiCliente.Text.Trim();
            var tel_casa = txtTelefonoCasaCliente.Text.Trim();
            var tel_trabajo = txtTelefTrabajoCliente.Text.Trim();
            var celular = txtCelularCliente.Text.Trim();
            var direccioncasa = txtDireccionCasaCliente.Text.Trim();
            var nit = txtNit.Text.Trim();

            var user = new Cliente();

            user.PrimerApellido = primerapellido;
            user.PrimerNombre = Primernombre;
            user.FechaNac = fechanac;
            user.LUGARTRABAJO = lugartrabajo;
            user.DUI = dui_nit;
            user.TEL_CASA = tel_casa;
            user.TEL_TRABAJO = tel_trabajo;
            user.TEL_TRABAJO = tel_casa;
            user.CELULAR = celular;
            user.DIRECCIONCASA = direccioncasa;
            user.NIT = nit;

            var r = CCliente.crearCliente(user);
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

        private void cbSexoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = cbSexoCliente.SelectedIndex;
            s = Convert.ToChar(cbSexoCliente.Items[i].ToString());
        }

        private void cbEstadoCivilCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = cbEstadoCivilCliente.SelectedIndex;
            est = Convert.ToChar(cbEstadoCivilCliente.Items[i].ToString());

        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {

        }

        public int getID()
        {

            try
            {
                return Convert.ToInt32(gridCliente.Rows[gridCliente.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return 0;
            }
        }

        private void gridCliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = getID();

            var cliente = CCliente.getClienteId(id);

            txtPrimerNombreCliente.Text = cliente.PrimerNombre;
            txtPrimerApellidoCliente.Text = cliente.PrimerApellido;
            txtFechaNacCliente.Text = cliente.FechaNac;
            txtTrabajoCliente.Text = cliente.LUGARTRABAJO;
            txtDuiCliente.Text = cliente.DUI;
            txtNit.Text = cliente.NIT;
            txtTelefonoCasaCliente.Text = cliente.TEL_CASA;
            txtCelularCliente.Text = cliente.CELULAR;
            txtDireccionCasaCliente.Text = cliente.DIRECCIONCASA;
            txtTelefTrabajoCliente.Text = cliente.TEL_TRABAJO;
        }

        private void gridCliente_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            var id = getID();

            var cliente = CCliente.getClienteId(id);

            txtPrimerNombreCliente.Text = cliente.PrimerNombre;
            txtPrimerApellidoCliente.Text = cliente.PrimerApellido;
            txtFechaNacCliente.Text = cliente.FechaNac;
            txtTrabajoCliente.Text = cliente.LUGARTRABAJO;
            txtDuiCliente.Text = cliente.DUI;
            txtNit.Text = cliente.NIT;
            txtTelefonoCasaCliente.Text = cliente.TEL_CASA;
            txtCelularCliente.Text = cliente.CELULAR;
            txtDireccionCasaCliente.Text = cliente.DIRECCIONCASA;
            txtTelefTrabajoCliente.Text = cliente.TEL_TRABAJO;
        }
    }
}
