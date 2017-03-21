Public Class Registro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ButtonRegistrar_Click(sender As Object, e As EventArgs) Handles ButtonRegistrar.Click
        Dim resultado As String

        resultado = LibreriaFunciones.Funciones.insertarUsuario(TextBoxEmail.Text, TextBoxNombre.Text, TextBoxApellidos.Text, TextBoxDNI.Text, TextBoxContraseña.Text, TextBoxPreguntaSecreta.Text, TextBoxRespuestaSecreta.Text)

        If resultado = "OK" Then
            Response.Redirect("./ResultadoRegistroHecho.aspx?state=ok")
        Else
            Response.Redirect("./ResultadoRegistroHecho.aspx?state=error")
        End If
    End Sub

    Protected Sub ButtonVolver_Click(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        Response.Redirect("./Inicio.aspx")
    End Sub

End Class