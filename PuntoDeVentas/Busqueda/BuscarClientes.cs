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
    public partial class BuscarClientes : Form
    {
        int idCliente = 0;

        public int IdCliente { get { return idCliente; } set { idCliente = value; } }
        public BuscarClientes()
        {
            InitializeComponent();
        }

        private void BuscarClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                dgvClientes.DataSource = CBusquedaClientes.GetClienteByName(txtNombre.Text);
            }
        }

        //obtiene el id de la fila seleccionada
        public virtual int getID()
        {
            try
            {
                return Convert.ToInt32(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return 0;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            IdCliente = getID();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
