Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Register.aspx")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim correo As String = TextBox1.Text
        Dim contra As String = TextBox2.Text

        If Regex.IsMatch(correo, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") Then
            AccesoDatos.AccesoDatos.Konektatu()

            Dim user As SqlDataReader = AccesoDatos.AccesoDatos.ErabiltzaileakLortu(correo)

            While user.Read()
                Dim pasahitza As String = user.GetString(11)
                If pasahitza = contra Then
                    Response.Redirect("Menu.aspx")
                Else

                End If
            End While
        Else
            ' La cadena no es una dirección de correo electrónico válida
        End If



    End Sub
End Class