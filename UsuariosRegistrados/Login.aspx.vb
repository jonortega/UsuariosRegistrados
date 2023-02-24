Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' HAY QUE COMPROBAR QUE PUEDE AHCER LOGIN O NO
        Response.Redirect("Menu.aspx")
    End Sub
End Class