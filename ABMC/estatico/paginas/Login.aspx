<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ABMC.estatico.paginas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="Desafio técnico para Bitsion" />
    <meta name="author" content="Godoy Matias" />
    <link href="../img/logoipsum-logo-50.svg" rel="icon" type="image/x-icon"/>
    <title>Ficticia - Login</title>
    <%-- cdn de bootstrap 5--%>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous" />
    <style>
        .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            user-select: none;
        }

        @media (min-width: 768px) {
            .bd-placeholder-img-lg {
                font-size: 3.5rem;
            }
        }

        .b-example-divider {
            height: 3rem;
            background-color: rgba(0, 0, 0, .1);
            border: solid rgba(0, 0, 0, .15);
            border-width: 1px 0;
            box-shadow: inset 0 .5em 1.5em rgba(0, 0, 0, .1), inset 0 .125em .5em rgba(0, 0, 0, .15);
        }

        .b-example-vr {
            flex-shrink: 0;
            width: 1.5rem;
            height: 100vh;
        }

        .bi {
            vertical-align: -.125em;
            fill: currentColor;
        }

        .nav-scroller {
            position: relative;
            z-index: 2;
            height: 2.75rem;
            overflow-y: hidden;
        }

        .nav-scroller .nav {
                display: flex;
                flex-wrap: nowrap;
                padding-bottom: 1rem;
                margin-top: -1px;
                overflow-x: auto;
                text-align: center;
                white-space: nowrap;
                -webkit-overflow-scrolling: touch;
            }
    </style>
    <link href="../css/signin.css" rel="stylesheet" />
</head>
<body class="text-center">
    <main class="form-signin w-100 m-auto">
        <form id="frmLogin" runat="server">
            <img class="mb-4" src="../img/logoipsum-logo-50.svg" alt="" width="150" height="50" />
            <h1 class="h3 mb-3 fw-normal">Ingresá a tu cuenta</h1>

            <div class="form-floating">
                <asp:TextBox ID="txtUsername" runat="server" TextMode="SingleLine" CssClass="form-control" placeholder="nombre@ejemplo.com"></asp:TextBox>
                <label for="<%= txtUsername.ClientID %>">Usuario</label>
            </div>
            <div class="form-floating">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="Password" ></asp:TextBox>
                <label for="<%= txtPassword.ClientID %>">Contraseña</label>                
            </div>
            <div class="form-floating">
                <div runat="server" id="loginFeedBack" class="alert alert-warning" role="alert" >
                  Usuario y/o contraseña incorrecto/s.
                </div>
            </div>
            

            <div class="checkbox mb-3">
                <label>
                    <input type="checkbox" value="remember-me" />
                    Recordarme
                </label>
            </div>
            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="w-100 btn btn-lg btn-primary" OnClick="btnIngresar_Click" />
            <%--<button class="" type="submit"></button>--%>
            <p class="mt-5 mb-3 text-muted">&copy; Godoy Matias 2022</p>
        </form>
    </main>
    <!-- JavaScript Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2" crossorigin="anonymous"></script>
</body>
</html>
