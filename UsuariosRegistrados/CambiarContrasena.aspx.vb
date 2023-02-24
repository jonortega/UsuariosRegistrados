Imports System.Data.SqlClient

Public Class WebForm7
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblError.Text() = ""
    End Sub

    Protected Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        AccesoDatos.AccesoDatos.Konektatu()
        Dim correo As String = Convert.ToString(System.Web.HttpContext.Current.Session(“correo”))

        Dim user As SqlDataReader = AccesoDatos.AccesoDatos.ErabiltzaileakLortu(correo)

        Dim pasahitza As String = ""
        While user.Read()
            pasahitza = user("pasahitza").ToString()
        End While

        AccesoDatos.AccesoDatos.ItxiKonexioa()
        AccesoDatos.AccesoDatos.Konektatu()
        Dim contrasenaActual As String = Convert.ToString(txtBContraActual.Text())
        Dim contrasenaNueva1 As String = Convert.ToString(txtBContraNueva1.Text())
        Dim contrasenaNueva2 As String = Convert.ToString(txtBContraNueva2.Text())

        If contrasenaActual = pasahitza Then
            If contrasenaNueva1 = contrasenaNueva2 Then
                AccesoDatos.AccesoDatos.ErabiltzailearenPasahitzaAldatu(correo, contrasenaNueva2)
                lblError.Text() = "La contraseña se ha cambiado."

            Else
                lblError.Text() = "Las contraseñas no coinciden."
            End If
        Else
            lblError.Text() = "La contraseña actual es incorrecta."
        End If

        AccesoDatos.AccesoDatos.ItxiKonexioa()
    End Sub
End Class