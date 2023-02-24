Imports System.Data.SqlClient

Public Class WebForm6
    Inherits System.Web.UI.Page

    Dim correo As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblContraseña.Text() = ""
        AccesoDatos.AccesoDatos.Konektatu()
        correo = System.Web.HttpContext.Current.Session(“correo”)
        Dim user As SqlDataReader = AccesoDatos.AccesoDatos.ErabiltzaileakLortu(correo)
        Dim galderaEzkutua As String = ""
        While user.Read()
            galderaEzkutua = user("galderaEzkutua").ToString()
        End While
        lblPregunta.Text() = galderaEzkutua
        AccesoDatos.AccesoDatos.ItxiKonexioa()
    End Sub

    Protected Sub btnComprobar_Click(sender As Object, e As EventArgs) Handles btnComprobar.Click
        AccesoDatos.AccesoDatos.Konektatu()
        correo = System.Web.HttpContext.Current.Session(“correo”)
        Dim user As SqlDataReader = AccesoDatos.AccesoDatos.ErabiltzaileakLortu(correo)
        Dim erantzuna As String = ""
        Dim pasahitza As String = ""
        While user.Read()
            erantzuna = user("erantzuna").ToString()
            pasahitza = user("pasahitza").ToString()
        End While
        Dim res As String = txtbRespuesta.Text()
        If erantzuna = res Then
            lblContraseña.Text() = pasahitza
        Else
            lblContraseña.Text() = "Respuesta incorrecta."
        End If
        AccesoDatos.AccesoDatos.ItxiKonexioa()
    End Sub
End Class