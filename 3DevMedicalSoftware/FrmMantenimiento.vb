Public Class FrmMantenimiento
    Private Sub BtnMantenimientoCancelar_Click(sender As Object, e As EventArgs) Handles BtnMantenimientoCancelar.Click
        MsgBox("Desea salir sin guardar los datos?")
        Me.Close()
    End Sub

    Private Sub BtnContinuarAEntrevista_Click(sender As Object, e As EventArgs) Handles BtnContinuarAEntrevista.Click
        Form1.AbrirFormDentroDePanelPForm(Of FrmEntrevistaInicial)()
    End Sub

    Private Sub BtnIngresoNuevoPaciente_Click(sender As Object, e As EventArgs) Handles BtnIngresoNuevoPaciente.Click
        GbxIngresoPacientes.Visible = True
    End Sub

    Private Sub BtncargarImagen_Click(sender As Object, e As EventArgs) Handles BtncargarImagen.Click

        If OFcargarImagen.ShowDialog = Windows.Forms.DialogResult.OK Then

            PictureImagenPerfil.Image = Image.FromFile(OFcargarImagen.FileName)
            PictureImagenPerfil.SizeMode = PictureBoxSizeMode.StretchImage

        End If



    End Sub
End Class