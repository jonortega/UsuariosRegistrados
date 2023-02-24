Public Class WebForm5
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        hlValidacion.Text = ""
    End Sub

    Protected Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        AccesoDatos.AccesoDatos.Konektatu()

        Dim email As String = tbEmail.Text
        Dim izena As String = tbNombre.Text
        Dim abizena As String = tbApellido.Text
        Dim pregunta As String = tbPregunta.Text
        Dim respuesta As String = tbRespuesta.Text
        Dim constraseña As String = tbContrasenia.Text
        Dim egiaztatzeZenbakia As Integer = CLng(Rnd() * 9000000) + 1000000

        AccesoDatos.AccesoDatos.ErabiltzaileaTxertatu(email, izena, abizena, pregunta, respuesta, 0, egiaztatzeZenbakia, False, Nothing, Nothing, Nothing, constraseña)
        AccesoDatos.AccesoDatos.ItxiKonexioa()

        Dim puerto As Integer = Request.ServerVariables("server_port")
        hlValidacion.Text = "Pulse para validar"
        hlValidacion.NavigateUrl = "http://localhost:" & puerto & "/egiaztatu.aspx?erab=" & email & "&egZenb=" & egiaztatzeZenbakia
    End Sub

End Class