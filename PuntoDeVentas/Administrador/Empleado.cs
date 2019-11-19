using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Models;
using Consultas;

namespace PuntoDeVentas.Administrador
{
    public partial class Empleado : Form
    {

        public char s;
        public char est;
        private int id_cargo;
        private int id_pefil;

        public int Id_cargo { get => id_cargo; set => id_cargo = value; }
        public int Id_pefil { get => id_pefil; set => id_pefil = value; }

        public Empleado()
        {
            InitializeComponent();
        }

       

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            var pNombre = txtNombreEmpleado.Text.Trim();
            var pApellido = txtApellidosEmpleados.Text.Trim();
            var direccion = txtDireccionEmpleado.Text;
            var telefono = txtTelEmpleado.Text.Trim();
            var fechaNac = txtFechaNacEmpleado.Text.Trim();
            var correo = txtEmailEmpleado.Text.Trim();


            var user = new Usuario();
            user.ID_CARGO = Id_cargo;
            user.ID_PERFIL = Id_pefil;
            user.PrimerNombre = pNombre;
            user.PrimerApellido = pApellido;
            user.Direccion = direccion;
            user.Telefono = telefono;
            user.FechaNac = fechaNac;
            user.Email = correo;
            user.Sexo = s;
            user.EstadoCivil = est;



            var r = CEmpleado.crearEpleadoAsync(user);
            if (r > 0)
            {
                MessageBox.Show("agregado con exito");
                this.uSUARIOSTableAdapter.Fill(this.repuestos3DataSet.USUARIOS);

            }
            else
            {
                MessageBox.Show("ocurrio un error");
            }

        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            cargarCargos();
            cargarPerfiles();
        }



        private void CbEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = cbEstadoCivil.SelectedIndex;
            est = Convert.ToChar(cbEstadoCivil.Items[i].ToString());

        }

        public virtual void cargarPerfiles()
        {

            cbPerfil.ValueMember = "ID_PERFIL";
            cbPerfil.DisplayMember = "NOMBRE";
            cbPerfil.DataSource = CEmpleado.getPerfiles();

        }
        public virtual void cargarCargos()
        {

            cbCargo.ValueMember = "ID_CARGO";
            cbCargo.DisplayMember = "NOMBRE";
            cbCargo.DataSource = CEmpleado.getCargos();
        }

        
        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.ID = getID();
            usuario.PrimerNombre = txtNombreEmpleado.Text;
            usuario.PrimerApellido = txtApellidosEmpleados.Text;
            usuario.Direccion = txtDireccionEmpleado.Text;
            usuario.Telefono = txtTelEmpleado.Text;
            usuario.FechaNac = txtFechaNacEmpleado.Text;
            usuario.Email = txtEmailEmpleado.Text;

            var rs = CEmpleado.ActualizarUsuario(usuario);
            if (rs > 0)
            {
                MessageBox.Show("registro actualizado");
            }
            else
            {
                MessageBox.Show("Ocurio un error");
            }

        }

        public  int getID()
        {

            try
            {
                return Convert.ToInt32(gridEmpleado.Rows[gridEmpleado.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return 0;
            }
        }

        private void Empleado_Load_1(object sender, EventArgs e)
        {
            cargarCargos();
            cargarPerfiles();
            // TODO: esta línea de código carga datos en la tabla 'repuestos3DataSet.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter.Fill(this.repuestos3DataSet.USUARIOS);

        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id_cargo = Convert.ToInt32(cbCargo.SelectedValue.ToString());
        }

        private void cbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id_pefil = Convert.ToInt32(cbPerfil.SelectedValue.ToString());
        }

        private void cbSexo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var i = cbSexo.SelectedIndex;
            s = Convert.ToChar(cbSexo.Items[i].ToString());
        }

        private void cbEstadoCivil_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void gridEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridEmpleado_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            var id = getID();

            var usuario = CEmpleado.getUsuarioId(id);

            txtNombreEmpleado.Text = usuario.PrimerNombre;
            txtApellidosEmpleados.Text = usuario.PrimerApellido;
            txtDireccionEmpleado.Text = usuario.Direccion;
            txtTelEmpleado.Text = usuario.Telefono;
            txtFechaNacEmpleado.Text = usuario.FechaNac;
            txtEmailEmpleado.Text = usuario.Email;
        }

        private void gridEmpleado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = getID();

            var usuario = CEmpleado.getUsuarioId(id);

            txtNombreEmpleado.Text = usuario.PrimerNombre;
            txtApellidosEmpleados.Text = usuario.PrimerApellido;
            txtDireccionEmpleado.Text = usuario.Direccion;
            txtTelEmpleado.Text = usuario.Telefono;
            txtFechaNacEmpleado.Text = usuario.FechaNac;
            txtEmailEmpleado.Text = usuario.Email;
        }

        private void btnActualizarEmpleado_Click_1(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.ID = getID();
            usuario.PrimerNombre = txtNombreEmpleado.Text;
            usuario.PrimerApellido = txtApellidosEmpleados.Text;
            usuario.Direccion = txtDireccionEmpleado.Text;
            usuario.Telefono = txtTelEmpleado.Text;
            usuario.FechaNac = txtFechaNacEmpleado.Text;
            usuario.Email = txtEmailEmpleado.Text;
            usuario.ID_CARGO = Id_cargo;
            usuario.ID_PERFIL = Id_pefil;
            usuario.Sexo = s;
            usuario.EstadoCivil = est;

            var rs = CEmpleado.ActualizarUsuario(usuario);
            if (rs > 0)
            {
                MessageBox.Show("registro actualizado");
                cargarDatos();
            }
            else
            {
                MessageBox.Show("Ocurio un error");
            }
        }

        private void cargarDatos()
        {
            this.uSUARIOSTableAdapter.Fill(this.repuestos3DataSet.USUARIOS);
        }
    }
}
