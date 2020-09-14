Imports MySql.Data.MySqlClient

Public Class FrmMantenimiento
    Private Sub FrmMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DateTimeFechaNacimiento.MaxDate = Date.Today





    End Sub
    Private Sub BtnMantenimientoCancelar_Click(sender As Object, e As EventArgs) Handles BtnMantenimientoCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnContinuarAEntrevista_Click(sender As Object, e As EventArgs) Handles BtnContinuarAEntrevista.Click
        Form1.AbrirFormDentroDePanelPForm(Of FrmEntrevistaInicial)()
    End Sub

    Private Sub BtnIngresoNuevoPaciente_Click(sender As Object, e As EventArgs) Handles BtnIngresoNuevoPaciente.Click
        GbxIngresoPacientes.Visible = True
    End Sub



    Private Shadows Sub KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtCedula.KeyPress, TxtTelefAcompañante.KeyPress, TxtBuscarPaciente.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then

            MsgBox("Solo se aceptan numeros")

        End If

    End Sub

    Private Sub BtnMantenimientoGuardarDatos_Click(sender As Object, e As EventArgs) Handles BtnMantenimientoGuardarDatos.Click
        Lbldatoscedula.Text = TxtCedula.Text
        LbldatosPrimNombre.Text = TxtPrimerNombre.Text
        LblprimApell.Text = TxtApellidoPaterno.Text
        LblDatosocupacion.Text = TxtOcupacion.Text
        LblDatosEscolaridad.Text = TxtEscolaridad.Text
        LblDatosEmail.Text = TxtEmail.Text
        LbldatosFechaNacimiento.Text = DateTimeFechaNacimiento.Text
        LblDatosSegunNom.Text = TxtSegundoNombre.Text
        LblDatosSegApell.Text = TxtApellidoMaterno.Text
        LblDatosGenero.Text = TxtGenero.Text
        LblDatosEstadoCivil.Text = ComEstadocivil.Text
        LblDatosDireccion.Text = TxtDireccion.Text
        LblDatosFechaIngreso.Text = DateTimeFechaAlta.Text
        LblDatosEnferAnterior.Text = TxtEnfermeAnteriores.Text
        LblDatosAlergiasAmedicamentos.Text = TxtAlergiasMedicamentos.Text
        LblDatosCirujias.Text = TxtCirujias.Text
        LblDatosEnfermPaternas.Text = TxtEnfermedPaternas.Text
        LblDatosEnferMaternas.Text = TxtEnferMaternas.Text

    End Sub




    Private Sub DateTimeFechaNacimiento_TextChanged(sender As Object, e As EventArgs) Handles DateTimeFechaNacimiento.TextChanged

        Dim edad As Integer = DateTime.Today.AddTicks(-DateTimeFechaNacimiento.Value.Ticks).Year - 1
        TxtEdadCalculada.Text = edad.ToString
    End Sub
End Class