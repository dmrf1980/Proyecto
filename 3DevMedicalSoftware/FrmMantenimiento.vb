Public Class FrmMantenimiento
    Private Sub BtnMantenimientoCancelar_Click(sender As Object, e As EventArgs) Handles BtnMantenimientoCancelar.Click
        MsgBox("Desea salir sin guardar los datos?")
        Me.Close()
    End Sub


End Class