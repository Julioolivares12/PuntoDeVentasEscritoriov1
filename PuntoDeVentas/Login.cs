using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoDeVentas.Vendedor;

namespace PuntoDeVentas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var correo = txtEmail.Text;
            var pass = txtPassword.Text;
            if (!string.IsNullOrWhiteSpace(correo) && !string.IsNullOrEmpty(correo))
            {
                if(!string.IsNullOrWhiteSpace(pass) && !string.IsNullOrEmpty(pass))
                {
                    if (Validaciones.Validacion.isEmailValid(correo))
                    {
                        var login = Consultas.CLogin.login(correo, pass);
                        if (login != null)
                        {
                            if (login.Perfil.Equals("cajero"))
                            {
                                this.Hide();
                                var punto = new PuntoDeVenta();
                                punto.Show();
                            }
                            else if (login.Perfil.Equals("administrador"))
                            {
                                //falta administrador
                                MessageBox.Show("login con  exito");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ingresa un correo valido");
                        EmailInvalid();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Ingresa una contraseña");
                    txtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingresa un correo electronico");
                txtEmail.Focus();
            }
        }
        private void EmailInvalid()
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtEmail.Focus();
        }
    }
}
