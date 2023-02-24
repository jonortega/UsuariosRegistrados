<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Register.aspx.vb" Inherits="UsuariosRegistrados.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>
            Register
        </h1>
        <p>
            Nombre:
        <asp:TextBox ID="tbNombre" runat="server"></asp:TextBox>
        </p>
        <p>
            Apellido:
            <asp:TextBox ID="tbApellido" runat="server"></asp:TextBox>
        </p>
        <p>
            Email:
            <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
        </p>
        <p>
            Contraseña:
            <input id="tbContrasenia" type="password" /></p>
        <p>
            Pregunta secreta:
            <asp:TextBox ID="tbPregunta" runat="server"></asp:TextBox>
        </p>
        <p>
            Respuesta a la pregunta secreta:
            <asp:TextBox ID="tbRespuesta" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnRegister" runat="server" Text="Register" />
        <p>
            <asp:HyperLink ID="hlValidacion" runat="server">Link</asp:HyperLink>
        </p>
    </form>
</body>
</html>
