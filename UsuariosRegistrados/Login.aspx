<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="UsuariosRegistrados.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Login</div>
        Correo:
        <asp:TextBox ID="tbCorreo" runat="server"></asp:TextBox>
        <p>
            Contraseña:
            <asp:TextBox ID="tbContrasenia" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnLogin" runat="server" Text="Login" />
    </form>
</body>
</html>
