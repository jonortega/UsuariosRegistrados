Imports System.Data.SqlClient

Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblContraError.Text() = ""
        lblUserError.Text() = ""
        AccesoDatos.AccesoDatos.Konektatu()
    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' HAY QUE COMPROBAR QUE PUEDE AHCER LOGIN O NO
        Dim correo As String = tbCorreo.Text()
        Dim contra As String = tbContrasenia.Text()

        Dim user As SqlDataReader = AccesoDatos.AccesoDatos.ErabiltzaileakLortu(correo)

        If user.HasRows Then
            While user.Read()
                Dim pasahitza As String = user("pasahitza").ToString()
                Dim egiaztatua As Boolean = user("egiaztatua")
                MsgBox(egiaztatua)
                If contra = pasahitza & egiaztatua Then
                    Response.Redirect("Menu.aspx")
                Else
                    lblContraError.Text() = "Contraseña incorrecta."
                End If
            End While
        Else
            lblUserError.Text() = "No existe el correo."
        End If
        AccesoDatos.AccesoDatos.ItxiKonexioa()
    End Sub
End Class