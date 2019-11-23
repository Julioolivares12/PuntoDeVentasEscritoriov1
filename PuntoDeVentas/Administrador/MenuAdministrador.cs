using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoDeVentas.VistaReportes;

namespace PuntoDeVentas.Administrador
{
    public partial class MenuAdministrador : Form
    {
        Repuestos repuestos;
        ClasesVehiculos clasesVehiculos;
        public MenuAdministrador()
        {
            InitializeComponent();
        }
        
        private void mantenimientoRepuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (repuestos == null)
            {
                repuestos = new Repuestos();
                repuestos.MdiParent = this;
                repuestos.FormClosed += new FormClosedEventHandler(cerrarRepuestos);
                repuestos.Show();
            }
            else
            {
                repuestos.Activate();
            }
        }

        private void cerrarRepuestos(object sender, FormClosedEventArgs e)
        {
            repuestos = null;
        }

        private void mantenimientoClasesDeVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clasesVehiculos == null)
            {
                clasesVehiculos = new ClasesVehiculos();
                clasesVehiculos.MdiParent = this;
                clasesVehiculos.FormClosed += new FormClosedEventHandler(cerrarClasesVehiculos);
                clasesVehiculos.Show();
            }
            else
            {
                clasesVehiculos.Activate();
            }
        }

        private void cerrarClasesVehiculos(object sender, FormClosedEventArgs e)
        {
            clasesVehiculos = null;
        }

        Clientes clientes;
        private void mantenimientoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clientes == null)
            {
                clientes = new Clientes();
                clientes.MdiParent = this;
                clientes.FormClosed += new FormClosedEventHandler(cerrarClientes);
                clientes.Show();
            }
            else
            {
                clientes.Activate();
            }
        }

        private void cerrarClientes(object sender, FormClosedEventArgs e)
        {
            clientes = null;
        }

        Empleado empleado;
        private void mantenimientoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (empleado == null)
            {
                empleado = new Empleado();
                empleado.MdiParent = this;
                empleado.FormClosed += new FormClosedEventHandler(cerrarEmpleado);
                empleado.Show();
            }
            else
            {
                empleado.Activate();
            }
        }

        private void cerrarEmpleado(object sender, FormClosedEventArgs e)
        {
            empleado = null;
        }
        MarcasVehiculos marcasVehiculos;
        private void mantenimientoMarcasDeVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (marcasVehiculos == null)
            {
                marcasVehiculos = new MarcasVehiculos();
                marcasVehiculos.MdiParent = this;
                marcasVehiculos.FormClosed += new FormClosedEventHandler(cerrarMarcas);
                marcasVehiculos.Show();
            }
            else
            {
                marcasVehiculos.Activate();
            }
        }

        private void cerrarMarcas(object sender, FormClosedEventArgs e)
        {
            marcasVehiculos = null;
        }

        ModeloVehiculocs modeloVehiculocs;
        private void mantenimientoModeloDeVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modeloVehiculocs == null)
            {
                modeloVehiculocs = new ModeloVehiculocs();
                modeloVehiculocs.MdiParent = this;
                modeloVehiculocs.FormClosed += new FormClosedEventHandler(cerrarModelo);
                modeloVehiculocs.Show();
            }
            else
            {
                modeloVehiculocs.Activate();
            }
        }

        private void cerrarModelo(object sender, FormClosedEventArgs e)
        {
            modeloVehiculocs = null;
        }

        Perfil perfil;
        private void mantenimientosPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (perfil==null)
            {
                perfil = new Perfil();
                perfil.MdiParent = this;
                perfil.FormClosed += new FormClosedEventHandler(cerrarPerfil);
                perfil.Show();
            }
            else
            {
                perfil.Activate();
            }
        }

        private void cerrarPerfil(object sender, FormClosedEventArgs e)
        {
            perfil = null;
        }

        Cargos cargos;
        private void mantenimientoCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cargos == null)
            {
                cargos = new Cargos();
                cargos.MdiParent = this;
                cargos.FormClosed += new FormClosedEventHandler(cerrarCargos);
                cargos.Show();
            }
            else
            {
                cargos.Activate();
            }
        }

        private void cerrarCargos(object sender, FormClosedEventArgs e)
        {
            cargos = null;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.GetInstance().Show();
        }
        ReporteDeVentas reporteDeVentas;
        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reporteDeVentas == null)
            {
                reporteDeVentas = new ReporteDeVentas();
                reporteDeVentas.MdiParent = this;
                reporteDeVentas.FormClosed += new  FormClosedEventHandler(cerrarReporteVentas);
                reporteDeVentas.Show();
            }
            else
            {
                reporteDeVentas.Activate();
            }
        }

        private void cerrarReporteVentas(object sender, FormClosedEventArgs e)
        {
            reporteDeVentas = null;
        }

        ProductoMasVendido productoMasVendido;
        private void productoMasVendidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (productoMasVendido == null)
            {
                productoMasVendido = new ProductoMasVendido();
                productoMasVendido.MdiParent = this;
                productoMasVendido.FormClosed += new FormClosedEventHandler(cerrarProductoMasVendido);
                productoMasVendido.Show();
            }
            else
            {
                productoMasVendido.Activate();
            }
        }

        private void cerrarProductoMasVendido(object sender, FormClosedEventArgs e)
        {
            productoMasVendido = null;
        }

        ProductoMenosVendido productoMenosVendido;
        private void productoMenosVendidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (productoMenosVendido == null)
            {
                productoMenosVendido = new ProductoMenosVendido();
                productoMenosVendido.MdiParent = this;
                productoMenosVendido.FormClosed += new FormClosedEventHandler(cerrarProductoMenosVendido);
                productoMenosVendido.Show();
            }
            else
            {
                productoMenosVendido.Activate();
            }
        }

        private void cerrarProductoMenosVendido(object sender, FormClosedEventArgs e)
        {
            productoMenosVendido = null;
        }

        ClienteCompraMas clienteCompraMas;
        private void ventasPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clienteCompraMas == null)
            {
                clienteCompraMas = new ClienteCompraMas();
                clienteCompraMas.MdiParent = this;
                clienteCompraMas.FormClosed += new FormClosedEventHandler(cerrarVentasPorUsuario);
                clienteCompraMas.Show();
            }
            else
            {
                clienteCompraMas.Activate();
            }
        }

        private void cerrarVentasPorUsuario(object sender, FormClosedEventArgs e)
        {
            clienteCompraMas = null;
        }
    }
}
