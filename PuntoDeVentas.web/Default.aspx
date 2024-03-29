﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PuntoDeVentas.web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 <style>
        body {
  margin: 0;
  padding: 0;
  background-color: #17a2b8;
  height: 100vh;
}
#login .container #login-row #login-column #login-box {
  margin-top: 120px;
  max-width: 600px;
  height: 320px;
  border: 1px solid #9C9C9C;
  background-color: #EAEAEA;
}
#login .container #login-row #login-column #login-box #login-form {
  padding: 20px;
}
#login .container #login-row #login-column #login-box #login-form #register-link {
  margin-top: -85px;
}
    </style>
       <div id="login">
        <h3 class="text-center text-white pt-5">Login form</h3>
        <div class="container">
            <div id="login-row" class="row justify-content-center align-items-center">
                <div id="login-column" class="col-md-6">
                    <div id="login-box" class="col-md-12">
                        
                            <h3 class="text-center text-info">Login</h3>
                            <div class="form-group">
                                <label for="txtCorreo" class="text-info">Correo:</label><br>
                                
                                <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="txtPassword" class="text-info">Password:</label><br>
                                <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server"></asp:TextBox>
                               
                            </div>
                            <div class="form-group">
                                <label for="remember-me" class="text-info"><span>Remember me</span> <span><asp:CheckBox ID="rememberMe" runat="server" /></span></label><br>
                                
                                <asp:Button ID="btnLogin" CssClass="btn btn-info btn-md" runat="server" Text="Iniciar" OnClick="btnLogin_Click" />
                            </div>
                            <div id="register-link" class="text-right">
                                    
                                <a href="#" class="text-info">Register here</a>
                            </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
