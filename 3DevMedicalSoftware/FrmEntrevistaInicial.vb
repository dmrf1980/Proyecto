Public Class FrmEntrevistaInicial
    Dim tipoFormulario As Integer
    Private Sub BtnEntrevistaInicialCancelar_Click(sender As Object, e As EventArgs) Handles BtnEntrevistaInicialCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnEntrevistaInicialGuardar_Click(sender As Object, e As EventArgs) Handles BtnEntrevistaInicialGuardar.Click

    End Sub

    'Private Sub AbrirFormDentroRegistro(Of Miform As {Form, New})()
    '    Dim Formulario As Form

    '    'Busca el formulario en la coleccion de 3, fiebre dolor malestar'
    '    Formulario = PanelDeRegistrosFormularios.Controls.OfType(Of Miform)().FirstOrDefault()
    '    'Si form no fue econtrado/ no existe'
    '    If Formulario Is Nothing Then
    '        Formulario = New Miform()
    '        Formulario.TopLevel = False
    '        Formulario.FormBorderStyle = FormBorderStyle.None
    '        Formulario.Dock = DockStyle.Fill
    '        PanelDeRegistrosFormularios.Controls.Add(Formulario)
    '        PanelDeRegistrosFormularios.Tag = Formulario
    '        Formulario.Show()
    '        Formulario.BringToFront()
    '    Else
    '        Formulario.BringToFront()
    '    End If

    'End Sub



    Private Sub BtnEntrevistaInicialGuardarYContinuar_Click(sender As Object, e As EventArgs) Handles BtnEntrevistaInicialGuardarYContinuar.Click

        If MsgBox("Desea abrir un formulario orientado a Fibre, Dolor o  Malestar?", MsgBoxStyle.YesNoCancel) Then

            TbcRegistroyAnalisisFisico.Visible = True
            'BtnCambiarFormulario.Visible = True
            GrxCambiarContinurDiagnostico.Visible = True

        Else
            Me.Close()
        End If

    End Sub





    Private Sub BtnRegistroCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnRegistroGuardar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnRegistroGuardarYContinuar_Click(sender As Object, e As EventArgs)

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

    Private Sub LblNumEntrevista_Click(sender As Object, e As EventArgs) Handles LblNumEntrevista.Click

    End Sub
End Class