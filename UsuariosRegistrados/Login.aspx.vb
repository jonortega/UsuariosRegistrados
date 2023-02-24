Imports System.Data.SqlClient

Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblContraError.Text() = ""
        lblUserError.Text() = ""
    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' HAY QUE COMPROBAR QUE PUEDE AHCER LOGIN O NO
        Dim correo As String = Convert.ToString(tbCorreo.Text())
        Dim contra As String = Convert.ToString(tbContrasenia.Text())

        AccesoDatos.AccesoDatos.Konektatu()

        Dim user As SqlDataReader = Nothing
        user = AccesoDatos.AccesoDatos.ErabiltzaileakLortu(correo)
        Console.WriteLine(user.ToString)
        Dim pasahitza As String = ""

        If user.HasRows Then
            While user.Read()
                Dim email As String = user("email").ToString()
                pasahitza = user("pasahitza").ToString()
            End While

            If contra = pasahitza Then
                Response.Redirect("Menu.aspx")
            Else
                lblContraError.Text() = "Contraseña incorrecta."
            End If
        Else
            lblUserError.Text() = "Usuario incorrecto"
        End If

        AccesoDatos.AccesoDatos.ItxiKonexioa()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("Register.aspx")

    End Sub
End Class