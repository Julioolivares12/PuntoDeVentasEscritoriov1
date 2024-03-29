﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoDeVentas.Vendedor;
using PuntoDeVentas.Administrador;

namespace PuntoDeVentas
{
    public partial class Login : Form
    {
        private static Login login;
        public Login()
        {
            InitializeComponent();
        }
       public static Login GetInstance()
        {
            if(login == null)
            {
                login = new Login();
            }
            return login;
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
                                this.Hide();
                                var MenuAdministrador = new MenuAdministrador();
                                MenuAdministrador.Show();
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
