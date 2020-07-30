Public Class FrmEntrevistaInicial
    Dim tipoFormulario As Integer
    Private Sub BtnEntrevistaInicialCancelar_Click(sender As Object, e As EventArgs) Handles BtnEntrevistaInicialCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnEntrevistaInicialGuardarYContinuar_Click(sender As Object, e As EventArgs) Handles BtnEntrevistaInicialGuardarYContinuar.Click

        If MsgBox("Desea abrir un formulario orientado a Fibre, Dolor o  Malestar?", MsgBoxStyle.YesNoCancel) Then
            LblGuardelosdatos.Visible = False
            TbcRegistroyAnalisisFisico.Visible = True

            GrxCambiarContinurDiagnostico.Visible = True

        Else
            Me.Close()
        End If

    End Sub

    Private Sub BtnRegistroCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnContinuarADiagnostico_Click(sender As Object, e As EventArgs) Handles BtnContinuarADiagnostico.Click
        Form1.AbrirFormDentroDePanelPForm(Of FrmPreDiagnosticoyDiagnostico)()
        Form1.PanelIzquierdo.Width = 90
    End Sub

    Private Sub BtnCrearEntrevista_Click(sender As Object, e As EventArgs) Handles BtnCrearEntrevista.Click
        GbxInspecciongeneral.Visible = True
        GbxConstantesVitales.Visible = True
        GbxMotivosdeConsulta.Visible = True
    End Sub

End Class