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
    public partial class Repuestos : Form
    {
        private int id_parteVeh;
        private int id_modeloVeh;

        public int Id_ParteVeh { get => id_parteVeh; set => id_parteVeh = value; }
        public int Id_ModeloVeh { get => id_modeloVeh; set => id_modeloVeh = value; }

        public Repuestos()
        {
            InitializeComponent();
        }

        private void Repuestos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'repuestos3DataSet.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter.Fill(this.repuestos3DataSet.USUARIOS);

        }

        private void btnCrearRepues_Click(object sender, EventArgs e)
        {
            var Pid_parteveh = cbParteVehi.Text.Trim();
            var Pid_marcaveh = cbParteVehi.Text.Trim();
            var Nombre = txtNombRepuest.Text.Trim();
            var descripcion = txtDescripRep.Text.Trim();
            var preciocompra = txtPrecioCompraResp.Text.Trim();
            var precioventa = txtPrecioVentaResp.Text.Trim();
            var descuento = txtDescVenta.Text.Trim();
            var num_motor = txtNumMotor.Text.Trim();
            var num_chasis = txtNumChasis.Text.Trim();
            var num_vin = txtNumVin.Text.Trim();
            var upc = txtUPC.Text.Trim();
            var cantidad = txtCantidad.Text.Trim();

            var user = new Repuesto();
            user.ID_PARTEVEH = id_parteVeh;
            user.ID_MARCAVEH = id_modeloVeh;
            user.Nombre = Nombre;
            user.Descripcion = descripcion;
            user.PrecioCompra = Convert.ToInt32(preciocompra);
            user.PrecioVenta = Convert.ToInt32(precioventa);
            user.Descuento = Convert.ToInt32(descuento);
            user.NumMotor = num_motor;
            user.NumChasis = num_chasis;
            user.NumVin = num_vin;
            user.UPC = upc;
            user.Cantidad = Convert.ToInt32(cantidad);


            var r = CRepuestos.crearRepuestos(user);
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

        public virtual void cargarMarcaVeh()
        {
            cbModeloVehi.ValueMember = "ID_MODELOVEH";
            cbModeloVehi.DisplayMember = "DESCRIPCION";
            cbModeloVehi.DataSource = CRepuestos.getModeloVeh();
        }

        public virtual void cargarParteVeh()
        {
            cbParteVehi.ValueMember = "ID_PARTEVEH";
            cbParteVehi.DisplayMember = "DESCRIPCION";
            cbParteVehi.DataSource = CRepuestos.getParteVeh();
        }

        private void cbParteVehi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id_ParteVeh = Convert.ToInt32(cbParteVehi.SelectedValue.ToString());

        }

        private void cbModeloVehi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id_ModeloVeh = Convert.ToInt32(cbModeloVehi.SelectedValue.ToString());
        }

        public int getID()
        {
            try
            {
                return Convert.ToInt32(gridRepuesto.Rows[gridRepuesto.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return 0;
            }
        }

        private void gridRepuesto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = getID();


            var repuesto = CRepuestos.GetRepuestoByID(id);

            txtNombRepuest.Text = repuesto.Nombre;
            txtDescripRep.Text = repuesto.Descripcion;
            txtPrecioCompraResp.Text = Convert.ToString(repuesto.PrecioCompra);
            txtPrecioVentaResp.Text = Convert.ToString(repuesto.PrecioVenta);
            txtDescVenta.Text = Convert.ToString(repuesto.Descuento);
            txtNumMotor.Text = repuesto.NumMotor;
            txtNumChasis.Text = repuesto.NumChasis;
            txtNumVin.Text = repuesto.NumVin;
            txtUPC.Text = repuesto.UPC;
            txtCantidad.Text = Convert.ToString(repuesto.Cantidad);
        }

        private void gridRepuesto_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            var id = getID();

            var repuesto = CRepuestos.GetRepuestoByID(id);

            txtNombRepuest.Text = repuesto.Nombre;
            txtDescripRep.Text = repuesto.Descripcion;
            txtPrecioCompraResp.Text = Convert.ToString(repuesto.PrecioCompra);
            txtPrecioVentaResp.Text = Convert.ToString(repuesto.PrecioVenta);
            txtDescVenta.Text = Convert.ToString(repuesto.Descuento);
            txtNumMotor.Text = repuesto.NumMotor;
            txtNumChasis.Text = repuesto.NumChasis;
            txtNumVin.Text = repuesto.NumVin;
            txtUPC.Text = repuesto.UPC;
            txtCantidad.Text = Convert.ToString(repuesto.Cantidad);
        }

        private void btnActualizarRepues_Click(object sender, EventArgs e)
        {
            var repuesto = new Repuesto();
            repuesto.ID = getID();

            repuesto.Nombre = txtNombRepuest.Text;
            repuesto.Nombre = txtNombRepuest.Text;
            repuesto.Descripcion = txtDescripRep.Text;
            repuesto.PrecioCompra = Convert.ToDouble(txtPrecioCompraResp.Text);
            repuesto.PrecioVenta = Convert.ToDouble(txtPrecioVentaResp.Text);
            repuesto.Descuento = Convert.ToDouble(txtDescVenta.Text);
            repuesto.NumMotor = txtNumMotor.Text;
            repuesto.NumChasis = txtNumChasis.Text;
            repuesto.NumVin = txtNumVin.Text;
            repuesto.UPC = txtUPC.Text;
            repuesto.Cantidad = Convert.ToInt32(txtCantidad.Text);

            var rs = CRepuestos.ActualizarRepuestos(repuesto);
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
