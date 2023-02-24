Imports System.Data.SqlClient

Public Class WebForm7
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblError.Text() = ""
    End Sub

    Protected Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        Dim correo As String = System.Web.HttpContext.Current.Session(“correo”)
        MsgBox(correo)
        AccesoDatos.AccesoDatos.Konektatu()

        Dim user As SqlDataReader = AccesoDatos.AccesoDatos.ErabiltzaileakLortu(correo)
        Dim pasahitza As String = ""
        While user.Read()
            pasahitza = user("pasahitza").ToString()
        End While
        Dim contrasenaActual As String = txtBContraActual.Text()
        Dim contrasenaNueva1 As String = txtBContraNueva1.Text()
        Dim contrasenaNueva2 As String = txtBContraNueva2.Text()

        If contrasenaActual = pasahitza Then
            If contrasenaNueva1 = contrasenaNueva2 Then
                AccesoDatos.AccesoDatos.ErabiltzailearenPasahitzaAldatu(correo, contrasenaNueva1)
            Else
                lblError.Text() = "Las contraseñas no coinciden."
            End If
        Else
            lblError.Text() = "La contraseña actual es incorrecta."
        End If

        AccesoDatos.AccesoDatos.ItxiKonexioa()
    End Sub
End Class