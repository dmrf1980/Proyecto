Public Class FrmPreDiagnosticoyDiagnostico
    Private Sub BtnVolverAEntrevista_Click(sender As Object, e As EventArgs) Handles BtnVolverAEntrevista.Click
        Form1.AbrirFormDentroDePanelPForm(Of FrmEntrevistaInicial)()
    End Sub

    Private Sub BtnContinuarAPlan_Click(sender As Object, e As EventArgs) Handles BtnContinuarAPlan.Click
        Form1.AbrirFormDentroDePanelPForm(Of FrmPlanTratamiento)()
    End Sub

    Private Sub BtnPreDigCancelar_Click(sender As Object, e As EventArgs) Handles BtnPreDigCancelar.Click
        Me.Close()
    End Sub


End Class