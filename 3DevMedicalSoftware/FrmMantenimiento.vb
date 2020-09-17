
Public Class FrmMantenimiento

    'VARIABLES GLOBALES---------------------------------------------------------------

    Public cedula, edad, telefono As Integer
    Public fechaDeNac, fechaDeIng As Date
    Public primerNom, segundoNom, apellPate, apellMate, genero, ocupacion,
        estadoCivil, escolaridad, direccion, correoElec, nomComAcomp, enfAnteriores,
         alergias, cirujias, enfPaternas, enfMaternas, ingAnalisis As String

    Private Sub BtnBuscarPaciente_Click(sender As Object, e As EventArgs) Handles BtnBuscarPaciente.Click

    End Sub

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


    'METODO PARA RESTRINGIR LETRAS-------------------------------------------------
    Private Shadows Sub KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtCedula.KeyPress, TxtTelefAcompañante.KeyPress, TxtBuscarPaciente.KeyPress, TxtTelefono.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then

            MsgBox("Solo se aceptan numeros")

        End If

    End Sub

    'METODO PARA RESTRINGIR NUMEROS-------------------------------------------------
    Private Shadows Sub KeyPress2(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtPrimerNombre.KeyPress, TxtSegundoNombre.KeyPress, TxtApellidoPaterno.KeyPress,
        TxtApellidoMaterno.KeyPress, TxtGenero.KeyPress, TxtGenero.KeyPress, TxtOcupacion.KeyPress, ComEstadocivil.KeyPress, LblDatosEscolaridad.KeyPress, TxtNombreAcompañante.KeyPress

        e.Handled = IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        If IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then

            MsgBox("Solo se aceptan letras")

        End If

    End Sub

    Private Sub BtnMantenimientoGuardarDatos_Click(sender As Object, e As EventArgs) Handles BtnMantenimientoGuardarDatos.Click
        cedula = TxtCedula.Text
        primerNom = TxtPrimerNombre.Text
        segundoNom = TxtSegundoNombre.Text
        apellPate = TxtApellidoPaterno.Text
        apellMate = TxtApellidoMaterno.Text
        ocupacion = TxtOcupacion.Text
        escolaridad = TxtEscolaridad.Text
        telefono = TxtTelefono.Text
        correoElec = TxtEmail.Text
        fechaDeNac = DateTimeFechaNacimiento.Text
        genero = TxtGenero.Text
        estadoCivil = ComEstadocivil.Text
        direccion = TxtDireccion.Text
        fechaDeIng = DateTimeFechaAlta.Text
        enfAnteriores = TxtEnfermeAnteriores.Text
        alergias = TxtAlergiasMedicamentos.Text
        cirujias = TxtCirujias.Text
        enfPaternas = TxtEnfermedPaternas.Text
        enfMaternas = TxtEnferMaternas.Text
        ingAnalisis = TxtIngresoAnalisis.Text
    End Sub



    'CALCULO DE EDAD --------------------------------------------------------------------------------------------------------
    Private Sub DateTimeFechaNacimiento_TextChanged(sender As Object, e As EventArgs) Handles DateTimeFechaNacimiento.TextChanged

        Dim edad As Integer = DateTime.Today.AddTicks(-DateTimeFechaNacimiento.Value.Ticks).Year - 1
        TxtEdadCalculada.Text = edad.ToString
    End Sub


End Class