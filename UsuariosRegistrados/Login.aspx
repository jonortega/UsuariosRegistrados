<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="UsuariosRegistrados.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Correo:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        Constraseña:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Login" Width="99px" />
            <asp:Button ID="Button2" runat="server" Text="Register" Width="90px" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Text="Recuperar contraseña" Width="185px" />
        </p>
    </form>
</body>
</html>
