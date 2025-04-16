Public Class Form1
  Private interpreter As New Interpreter()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicialización de la app
    End Sub

    Private Sub EjecutarComando(comando As String)
        interpreter.Ejecutar(comando)
    End Sub
End Class
