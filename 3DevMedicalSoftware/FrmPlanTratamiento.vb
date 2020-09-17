Imports MySql.Data.MySqlClient
Public Class FrmPlanTratamiento

    Private Sub BtnCrearTratamiento_Click(sender As Object, e As EventArgs) Handles BtnCrearTratamiento.Click
        GrxTratamiento.Visible = True
        LblNumEntrevista.Text = "00001"
    End Sub

    Private Sub BtnPreDigCancelar_Click(sender As Object, e As EventArgs) Handles BtnPreDigCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnVolverADiagnostico_Click(sender As Object, e As EventArgs) Handles BtnVolverADiagnostico.Click
        Form1.AbrirFormDentroDePanelPForm(Of FrmPreDiagnosticoyDiagnostico)()
    End Sub

    Private Sub FrmPlanTratamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class