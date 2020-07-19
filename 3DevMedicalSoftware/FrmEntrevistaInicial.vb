Public Class FrmEntrevistaInicial
    Dim tipoFormulario As Integer
    Private Sub BtnEntrevistaInicialCancelar_Click(sender As Object, e As EventArgs) Handles BtnEntrevistaInicialCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnEntrevistaInicialGuardar_Click(sender As Object, e As EventArgs) Handles BtnEntrevistaInicialGuardar.Click

    End Sub

    Private Sub AbrirFormDentroRegistro(Of Miform As {Form, New})()
        Dim Formulario As Form

        'Busca el formulario en la coleccion de 3, fiebre dolor malestar'
        Formulario = PanelDeRegistrosFormularios.Controls.OfType(Of Miform)().FirstOrDefault()
        'Si form no fue econtrado/ no existe'
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.None
            PanelDeRegistrosFormularios.Controls.Add(Formulario)
            PanelDeRegistrosFormularios.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If

    End Sub



    Private Sub BtnEntrevistaInicialGuardarYContinuar_Click(sender As Object, e As EventArgs) Handles BtnEntrevistaInicialGuardarYContinuar.Click

        If MsgBox("Desea abrir un formulario orientado a Fibre, Dolor o  Malestar?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            tipoFormulario = InputBox("1-FIEBRE, 2-DOLOR, 3-MALESTAR")

            Select Case tipoFormulario
                Case 1
                    AbrirFormDentroRegistro(Of FrmFiebre)()
                Case 2
                    AbrirFormDentroRegistro(Of FrmDolor)()
                Case 3
                    AbrirFormDentroRegistro(Of FrmMalestar)()

            End Select
            BtnCambiarFormulario.Visible = True
        End If

    End Sub





    Private Sub BtnRegistroCancelar_Click(sender As Object, e As EventArgs) Handles BtnRegistroCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnRegistroGuardar_Click(sender As Object, e As EventArgs) Handles BtnRegistroGuardar.Click

    End Sub

    Private Sub BtnRegistroGuardarYContinuar_Click(sender As Object, e As EventArgs) Handles BtnRegistroGuardarYContinuar.Click

    End Sub

    Private Sub BtnCambiarFormulario_Click(sender As Object, e As EventArgs) Handles BtnCambiarFormulario.Click
        If MsgBox("Desea abrir un formulario orientado a Fibre, Dolor o  Malestar?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            tipoFormulario = InputBox("1-FIEBRE, 2-DOLOR, 3-MALESTAR")

            Select Case tipoFormulario
                Case 1
                    AbrirFormDentroRegistro(Of FrmFiebre)()
                Case 2
                    AbrirFormDentroRegistro(Of FrmDolor)()
                Case 3
                    AbrirFormDentroRegistro(Of FrmMalestar)()

            End Select

        End If
    End Sub
End Class