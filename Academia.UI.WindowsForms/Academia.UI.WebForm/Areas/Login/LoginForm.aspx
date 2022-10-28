<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="Academia.UI.WebForm.Login.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <section class="vh-100">
        <div class="container-fluid h-100">
            <div class="row d-flex justify-content-center align-items-center h-100">
                <div class="col-md-9 col-lg-6 col-xl-5">
                    <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-login-form/draw2.webp"
                        class="img-fluid" alt="Sample image" />
                </div>
                <div class="col-md-8 col-lg-6 col-xl-4 offset-xl-1">
                    <form runat="server">
                        <!-- Usuario input -->
                        <div class="form-outline mb-4">
                            <asp:TextBox ID="txtUsername"
                                class="form-control form-control-lg"
                                placeholder="Ingrese nombre de usuario"
                                required="required"
                                runat="server"></asp:TextBox>
                            <label class="form-label" for="txtUsername">Usuario</label>
                        </div>

                        <!-- Password input -->
                        <div class="form-outline mb-3">
                            <asp:TextBox ID="txtPassword"
                                type="password"
                                class="form-control form-control-lg"
                                placeholder="Ingrese contraseña"
                                required="required"
                                runat="server"></asp:TextBox>
                            <label class="form-label" for="txtPassword">Contraseña</label>
                        </div>

                        <div class="text-center text-lg-start mt-4 pt-2">
                            <asp:Button ID="btnLogin"
                                type="button" 
                                class="btn btn-primary btn-lg"
                                style="padding-left: 2.5rem; padding-right: 2.5rem;"
                                OnClick="btnLogin_Click"
                                runat="server"
                                Text="Login">
                            </asp:Button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
        <div class="d-flex flex-column flex-md-row text-center text-md-start justify-content-between py-4 px-4 px-xl-5 bg-primary">   
            <div class="text-white mb-3 mb-md-0">
                Autogestión Academia 2022.
            </div>
        </div>
    </section>
    <script src="../../Scripts/jquery-3.4.1.min.js"></script>
    <script src="../../Scripts/popper.min.js"></script>
    <script src="../../Scripts/bootstrap.min.js"></script>
</body>
</html>
