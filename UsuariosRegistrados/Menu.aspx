<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Menu.aspx.vb" Inherits="UsuariosRegistrados.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>
            Menu
        </h1>
        <div>
            <asp:HyperLink ID="hlCambioContra" runat="server" NavigateUrl="~/CambiarContrasena.aspx">Cambiar de contraseña</asp:HyperLink>
        </div>
        <p>
            <asp:HyperLink ID="hlCerrar" runat="server" NavigateUrl="~/Final.aspx">Cerrar</asp:HyperLink>
        </p>
    </form>
</body>
</html>
