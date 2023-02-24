<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RecuperarContra.aspx.vb" Inherits="UsuariosRegistrados.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Recuperar Contraseña</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblPregunta" runat="server" Text="Label"></asp:Label>
        </div>
        <p>
            <asp:TextBox ID="txtbRespuesta" runat="server" Height="19px"></asp:TextBox>
        </p>
        <asp:Label ID="lblContraseña" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Button ID="btnComprobar" runat="server" Text="Comprobar" />
        </p>
    </form>
</body>
</html>
