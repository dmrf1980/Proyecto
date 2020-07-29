Public Class FrmPlanTratamiento
    Private Sub BtnCrearTratamiento_Click(sender As Object, e As EventArgs) Handles BtnCrearTratamiento.Click
        GrxTratamiento.Visible = True
    End Sub

    Private Sub BtnPreDigCancelar_Click(sender As Object, e As EventArgs) Handles BtnPreDigCancelar.Click
        Me.Close()
    End Sub
End Class