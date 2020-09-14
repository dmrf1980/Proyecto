Public Class FrmPreDiagnosticoyDiagnostico
    Private Sub BtnVolverAExploracion_Click(sender As Object, e As EventArgs) Handles BtnVolverAExploracion.Click
        Form1.AbrirFormDentroDePanelPForm(Of FrmExploracionYDolor)()
    End Sub

    Private Sub BtnContinuarAPlan_Click(sender As Object, e As EventArgs) Handles BtnContinuarAPlan.Click
        Form1.AbrirFormDentroDePanelPForm(Of FrmPlanTratamiento)()
    End Sub

    Private Sub BtnPreDigCancelar_Click(sender As Object, e As EventArgs) Handles BtnPreDigCancelar.Click
        Me.Close()
    End Sub


End Class