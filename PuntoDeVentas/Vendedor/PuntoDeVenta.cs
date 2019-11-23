using Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Modelos;
using System.Drawing.Printing;
using Models;

namespace PuntoDeVentas.Vendedor
{
    public partial class PuntoDeVenta : Form
    {
        double iva = 0.00;
        double subTotal = 0.00;
        double montoTotal = 0.00;
        double consolidado = 0.00;
        double tomar = 0.00;
        double dar = 0.00;
        double descuento = 0.00;

        String id_venta;
        String tracking;
        String iduser = "56f0cf9c-e0d0-4390-96f9-b7cc76725809";
        String idcliente = "aa84542e-b5c5-43e4-ae1a-3bc7dcc602af";
        String idrepuesto = "aa84542e-b5c5-43e4-ae1a-3bc7dcc602af";
        String nrodoc;
        String idTipoDoc;
        String fechaventa;
        private int idCliente =0;
        private int idRepuesto = 0;

        Repuesto repuesto = new Repuesto();

        public Cliente Cliente{ get; set; }
        public PuntoDeVenta()
        {
            InitializeComponent();
        }

        private void TxtItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!string.IsNullOrWhiteSpace(txtItem.Text) && !string.IsNullOrEmpty(txtItem.Text))
                {
                    var item = CRepuestos.GetRepuestoByUPC(txtItem.Text);
                    fila.CreateCells(dgvItems);
                    fila.Cells[0].Value = item.UPC;
                    fila.Cells[1].Value = item.Nombe;
                    fila.Cells[2].Value = item.Cantidad;
                    fila.Cells[3].Value = item.Descuento;
                    fila.Cells[4].Value = item.PrecioVenta;
                    fila.Cells[5].Value = item.PrecioVenta;

                    consolidado += item.PrecioVenta;
                    iva = item.PrecioVenta / 1.13;
                    subTotal += item.PrecioVenta - (item.PrecioVenta / 1.13);
                    montoTotal += item.PrecioVenta;
                    llenarTextos();
                    habilitarTomar();
                    dgvItems.Rows.Add(fila);
                    txtItem.Text = "";
                }
                else
                {
                    MessageBox.Show("escribe un codigo de UPC ");
                }
               
            }
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            Busqueda.BuscarClientes buscar = new Busqueda.BuscarClientes();
            buscar.ShowDialog();
            if (buscar.DialogResult == DialogResult.OK)
            {
                idCliente = buscar.IdCliente;
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila");
            }
        }

        private void BtnClienteNuevo_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscarItem_Click(object sender, EventArgs e)
        {
            Busqueda.BuscarProductos buscarProductos = new Busqueda.BuscarProductos();
            buscarProductos.ShowDialog();
            if (buscarProductos.DialogResult == DialogResult.OK)
            {
                repuesto = buscarProductos.repuesto;
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila");
            }
        }

        private void CmbMetodo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbMetodo2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void BtnTomar_Click(object sender, EventArgs e)
        {
            string pattern = "^[0-9]+(\\,[0-9]{1,2})?$";
            if (Regex.IsMatch(this.txtTomar.Text, pattern))
            {
                tomar = Convert.ToDouble(txtTomar.Text);
                consolidado -= tomar;
                llenarTextos();
                pagosYvueltos("Tomar", cmbMetodo1.Text, txtTomar.Text);

                if (consolidado < 0.00)
                {
                    habilitarVuelto();
                }
                else if (consolidado > 0.00)
                {
                    habilitarTomar();
                }
                else
                {
                    btnPagarImprimir.Enabled = true;
                    btnPagar.Enabled = true;
                    iceTime();
                }

            }
            else
            {
                MessageBox.Show("Solo Numeros Porfavor");

            }
        }

        private void BtnDar_Click(object sender, EventArgs e)
        {
            string pattern = "^[0-9]+(\\,[0-9]{1,2})?$";
            if (Regex.IsMatch(this.txtDar.Text, pattern))
            {
                dar = Convert.ToDouble(txtDar.Text);
                consolidado += dar;
                llenarTextos();
                pagosYvueltos("DAR", cmbMetodo2.Text, txtDar.Text);

                if (consolidado < 0.00)
                {
                    habilitarVuelto();
                }
                else if (consolidado > 0.00)
                {
                    habilitarTomar();
                }
                else
                {
                    btnPagarImprimir.Enabled = true;
                    btnPagar.Enabled = true;
                    iceTime();
                }

            }
            else
            {
                MessageBox.Show("Solo Numeros Porfavor");

            }
        }

        private void BtnPagarImprimir_Click(object sender, EventArgs e)
        {
            id_venta = DateTime.Now.ToString("ddMMyyyy") + txtTracking.Text;
            //user defaul
            //cliente defaul
            //repuesto defaul
            nrodoc = txtTracking.Text;
            idTipoDoc = "1";
            tracking = txtTracking.Text;
            fechaventa = DateTime.Now.ToString("dd/MM/yyyy");
            DateTime fecha2 = DateTime.Now;

            var mod = new Venta();
           // mod.ID_VENTA = id_venta;
            //mod.ID_USUARIO = iduser;
            mod.ID_CLIENTE = idCliente;
            mod.ID_REPUESTOS = repuesto.ID;
            mod.NRODOC = tracking;
            mod.NRO_CF = tracking;
            mod.ID_TIPODOC = idTipoDoc;
            mod.FECHAVENTA = fecha2;
            mod.SUBTOTAL = subTotal;
            mod.DESCUENTO = descuento;
            mod.IVA = iva;
            mod.MONTOTOTAL = montoTotal;
            Int32 contador = 0;
            var r0 = CVentas.InsertarVenta(mod);
            if (r0 > 0)
            {
                MessageBox.Show("Venta realizada con exito Trackin number" + tracking);
            }
            else
            {
                MessageBox.Show("ocurrio un error");
            }
            var filasPagos = dgvPagos.RowCount;
            var colPagos = dgvPagos.ColumnCount;
            for (int i = 0; i < filasPagos; i++)
            {
                for (int j = 0; j < colPagos-1; j++)
                {

                }
            }
            
            printDocument1 = new PrintDocument();
            var printerSettins = new PrinterSettings();
            printDocument1.PrinterSettings = printerSettins;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial",15,FontStyle.Regular);
            //x , y, width, height
            //RectangleF(0, 10, 120, 20);
            var width = 200;
            var height = 20;
            var y = 20;
            e.Graphics.DrawString("Punto de venta",font,Brushes.AliceBlue,new RectangleF(0,y+=20,width,height));
            e.Graphics.DrawString("IVA : "+iva,font,Brushes.AliceBlue,new RectangleF(0,y+=20,width,height));
            e.Graphics.DrawString("SubTotal: "+subTotal,font,Brushes.AliceBlue,new RectangleF(0,y+=20,width,height));
            e.Graphics.DrawString("Monto total : "+montoTotal,font,Brushes.AliceBlue,new RectangleF(0,y+=20,width,height));
            
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void PuntoDeVenta_Load(object sender, EventArgs e)
        {
            txtDar.Enabled = false;
            cargarClientesComboBox();
            cargarCBMetodo1();
            cargarCBMetodo2();
            
        }

        private void habilitarVuelto()
        {
            txtConsolidado.Text = consolidado.ToString();
            txtDar.Text = (consolidado * -1).ToString();
            txtDar.Enabled = true;
            btnDar.Enabled = true;
            txtTomar.Text = "";
            txtTomar.Enabled = false;
            btnTomar.Enabled = false;

        }
        private void habilitarTomar()
        {
            txtConsolidado.Text = consolidado.ToString();
            txtTomar.Text = consolidado.ToString();
            txtTomar.Enabled = true;
            btnTomar.Enabled = true;

            btnDar.Enabled = false;
            txtDar.Text = "";
            txtDar.Enabled = false;
        }
        private void llenarTextos()
        {
            txtIva.Text = iva.ToString();
            txtSubtotal.Text = subTotal.ToString();
            txtMontoTotal.Text = montoTotal.ToString();
            txtConsolidado.Text = consolidado.ToString();
        }

        private void pagosYvueltos(String tipo, string metodo, string valor)
        {
            DataGridViewRow metods = new DataGridViewRow();
            metods.CreateCells(dgvPagos);
            metods.Cells[0].Value = tipo;
            metods.Cells[1].Value = metodo;
            metods.Cells[2].Value = valor;
            dgvPagos.Rows.Add(metods);
        }

       
        private void iceTime()
        {
            txtTomar.Text = "";
            txtDar.Text = "";
            txtTomar.Enabled = false;
            txtDar.Enabled = false;
            btnTomar.Enabled = false;
            btnDar.Enabled = false;
        }

        private void txtCliente_keyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cargarClientesComboBox()
        {
            
            CB_Clientes.ValueMember = "ID_CLIENTE";
            CB_Clientes.DisplayMember = "cliente";
            CB_Clientes.DataSource = CCliente.GetClientesComboBox();
        }

        private void cargarCBMetodo1()
        {
            cmbMetodo1.ValueMember = "ID_METODO";
            cmbMetodo1.DisplayMember = "METODO";
            cmbMetodo1.DataSource = CMetodosTomar.GetMetodosTomar();
        }

        private void cargarCBMetodo2()
        {
            cmbMetodo2.ValueMember = "ID_METODO";
            cmbMetodo2.DisplayMember = "METODO";
            cmbMetodo2.DataSource = CMetodosDar.GetMetodosDar();
        }

        private void CB_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = CB_Clientes.SelectedIndex;
            var id =Convert.ToInt32(CB_Clientes.Items[i].ToString());
            idCliente = id;
        }
    }
}
