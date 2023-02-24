Public Class WebForm5
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Crear una nueva entrada en la BD con AccesoDatos
        AccesoDatos.AccesoDatos.Konektatu()

        Dim email As String = tbEmail.Text
        Dim izena As String = tbNombre.Text
        Dim abizena As String = tbApellido.Text
        Dim pregunta As String = tbPregunta.Text
        Dim respuesta As String = tbRespuesta.Text
        Dim constraseña As String = tbContrasenia.Text
        Dim egiaztatzeZenbakia As Integer = CLng(Rnd() * 9000000) + 1000000

        Dim numeroRegistros As Integer = AccesoDatos.AccesoDatos.ErabiltzaileaTxertatu(email, izena, abizena, pregunta, respuesta, 0, egiaztatzeZenbakia, False, Nothing, Nothing, Nothing, constraseña)

        hlValidacion.NavigateUrl = "http://localhost:1633/egiaztatu.aspx?erab=juanmiguel.lopez@ehu.eus&egZenb=1234567"

        AccesoDatos.AccesoDatos.ItxiKonexioa()

    End Sub

End Class