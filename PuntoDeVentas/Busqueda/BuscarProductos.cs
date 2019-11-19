using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultas;
using Models;

namespace PuntoDeVentas.Busqueda
{
    public partial class BuscarProductos : Form
    {
        public Repuesto repuesto;
        public BuscarProductos()
        {
            InitializeComponent();
            repuesto = new Repuesto();
        }

        private void txtNombreRepuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombreRepuesto.Text) && !string.IsNullOrWhiteSpace(txtNombreRepuesto.Text))
            {
                dgvProductos.DataSource = CBusquedaRepuestos.GetRepuestosByNombre(txtNombreRepuesto.Text);
            }
            else
            {
                MessageBox.Show("escribe el nombre del repuesto");
            }
        }

        private void BuscarProductos_Load(object sender, EventArgs e)
        {
            cargarMarcas();
            cargarPartes();
        }

        private void cbParteVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = cbParteVehiculo.SelectedIndex;
            var idParte = Convert.ToInt32(cbParteVehiculo.Items[i].ToString());
            dgvProductos.DataSource = CBusquedaRepuestos.GetRepuestosByParte(idParte);
        }

        private void cbMarcaVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = cbMarcaVehiculo.SelectedIndex;
            var idMarca = Convert.ToInt32(cbMarcaVehiculo.Items[i].ToString());
            dgvProductos.DataSource = CBusquedaRepuestos.GetRepuestosByMarca(idMarca);
        }


       private void cargarMarcas()
        {
            cbMarcaVehiculo.ValueMember = "ID_MARCAVEH";
            cbMarcaVehiculo.DisplayMember = "DESCRIPCION";
            cbMarcaVehiculo.DataSource = CMarcaVehiculo.GetMarcas();
        }

        private void cargarPartes()
        {
            cbParteVehiculo.ValueMember = "ID_PARTEVEH";
            cbParteVehiculo.DisplayMember = "DESCRIPCION";
            cbParteVehiculo.DataSource = CParteVehiculo.getParteDeVehiculo();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var id = getID();
            if (id > 0)
            {
                repuesto = CRepuestos.GetRepuestoByID(id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //obtiene el id de la fila seleccionada
        public int getID()
        {
            try
            {
                return Convert.ToInt32(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return 0;
            }
        }
    }
}
