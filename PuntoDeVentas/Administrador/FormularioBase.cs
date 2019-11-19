using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVentas
{
    public partial class FormularioBase : Form
    {
        public FormularioBase()
        {
            InitializeComponent();
        }

        private void FormularioBase_Load(object sender, EventArgs e)
        {

        }

        public virtual void cargarDatos()
        {

        }
        public virtual bool insertar()
        {
            return false;
        }
        public virtual bool actualizar()
        {
            return false;
        }
        public virtual bool eliminar()
        {
            return false;
        }

        private void Mantenimientos_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }


    }
}
