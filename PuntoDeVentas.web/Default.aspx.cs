using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuntoDeVentas.web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtCorreo.Text;
            var pass = txtPassword.Text;

            if(!string.IsNullOrWhiteSpace(email) && !string.IsNullOrEmpty(email))
            {
                if(!string.IsNullOrWhiteSpace(pass) && !string.IsNullOrEmpty(pass))
                {
                    if (Validaciones.Validacion.isEmailValid(email))
                    {
                        var login = Consultas.CLogin.login(email, pass);
                        if (login != null)
                        {
                            if (login.Perfil.Equals("cajero"))
                            {
                                Session["tipo"] = login.Perfil;
                                Session["nombreUsuario"] = login.PrimerNombre;
                                Session["idUsuario"] = login.ID_USUARIO;
                                Response.Redirect("cajero.aspx");
                            }
                            else if (login.Perfil.Equals("administrador"))
                            {
                                Session["tipo"] = login.Perfil;
                                Session["nombreUsuario"] = login.PrimerNombre;
                                Session["idUsuario"] = login.ID_USUARIO;
                                Response.Redirect("administrador.aspx");
                            }
                            
                        }
                    }
                }
            }
        }
    }
}