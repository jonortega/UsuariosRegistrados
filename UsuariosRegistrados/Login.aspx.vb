Imports System.Data.SqlClient

Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblContraError.Text() = ""
        lblUserError.Text() = ""
    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        AccesoDatos.AccesoDatos.Konektatu()

        Dim correo As String = tbCorreo.Text()
        Dim contra As String = tbContrasenia.Text()

        Dim user As SqlDataReader = AccesoDatos.AccesoDatos.ErabiltzaileakLortu(correo)

        If user.HasRows Then
            While user.Read()
                Dim pasahitza As String = user("pasahitza").ToString()
                Dim egiaztatua As Boolean = user("egiaztatua")

                If contra = pasahitza Then
                    If egiaztatua Then
                        System.Web.HttpContext.Current.Session(“correo”) = correo
                        Response.Redirect("Menu.aspx")
                    Else
                        lblContraError.Text() = "El usuario no esta verificado."
                    End If
                Else
                    lblContraError.Text() = "Contraseña incorrecta."
                End If
            End While
        Else
            lblUserError.Text() = "No existe el correo."
        End If
        AccesoDatos.AccesoDatos.ItxiKonexioa()
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AccesoDatos.AccesoDatos.Konektatu()
        Dim correo As String = tbCorreo.Text()
        System.Web.HttpContext.Current.Session(“correo”) = correo
        Dim user As SqlDataReader = AccesoDatos.AccesoDatos.ErabiltzaileakLortu(correo)
        If Not user.HasRows Then
            lblUserError.Text() = "No existe el correo."
        Else
            Response.Redirect("RecuperarContra.aspx")
        End If
        AccesoDatos.AccesoDatos.ItxiKonexioa()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("Register.aspx")
    End Sub
End Class