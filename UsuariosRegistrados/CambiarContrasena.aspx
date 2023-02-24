<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CambiarContrasena.aspx.vb" Inherits="UsuariosRegistrados.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Cambio de Contraseña</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblContraAct" runat="server" Text="Contraseña actual:"></asp:Label>
            <asp:TextBox ID="txtBContraActual" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblContraNueva1" runat="server" Text="Nueva contraseña:"></asp:Label>
        <asp:TextBox ID="txtBContraNueva1" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblContraNueva2" runat="server" Text="Repite la contraseña:"></asp:Label>
            <asp:TextBox ID="txtBContraNueva2" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        <p>
        <asp:Button ID="btnCambiar" runat="server" Text="Cambiar contraseña" />
        </p>
    </form>
</body>
</html>
