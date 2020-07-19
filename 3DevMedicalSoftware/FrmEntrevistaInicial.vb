Public Class FrmEntrevistaInicial
    Private Sub BtnEntrevistaInicialCancelar_Click(sender As Object, e As EventArgs) Handles BtnEntrevistaInicialCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnEntrevistaInicialGuardar_Click(sender As Object, e As EventArgs) Handles BtnEntrevistaInicialGuardar.Click

    End Sub

    Private Sub AbrirFormDentroRegistro(Of Miform As {Form, New})()
        Dim Formulario As Form

        'Busca el formulario en la coleccion'
        Formulario = PanelDeRegistrosFormularios.Controls.OfType(Of Miform)().FirstOrDefault()
        'Si form no fue econtrado/ no existe'
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            PanelDeRegistrosFormularios.Controls.Add(Formulario)
            PanelDeRegistrosFormularios.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If

    End Sub



    Private Sub BtnEntrevistaInicialGuardarYContinuar_Click(sender As Object, e As EventArgs) Handles BtnEntrevistaInicialGuardarYContinuar.Click
        Dim tipoFormulario As Integer
        If MsgBox("Desea abrir un formulario orientado a Fibre, Dolor o  Malestar?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            tipoFormulario = InputBox("1-FIEBRE, 2-DOLOR, 3-MALESTAR")
            'If tipoFormulario = 1 Then
            '    GrxFiebre.Visible = True
            'ElseIf tipoFormulario = 2 Then
            '    GrxDolor.Visible = True
            'ElseIf tipoFormulario = 3 Then
            '    GrxMalestar.Visible = True

            'End If

            Select Case tipoFormulario
                Case 1
                    AbrirFormDentroRegistro(Of FrmFiebre)()
                Case 2

                Case 3


            End Select

        End If

    End Sub





    Private Sub BtnRegistroCancelar_Click(sender As Object, e As EventArgs) Handles BtnRegistroCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnRegistroGuardar_Click(sender As Object, e As EventArgs) Handles BtnRegistroGuardar.Click

    End Sub

    Private Sub BtnRegistroGuardarYContinuar_Click(sender As Object, e As EventArgs) Handles BtnRegistroGuardarYContinuar.Click

    End Sub
End Class