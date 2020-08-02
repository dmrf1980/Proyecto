Public Class FrmEntrevistaInicial
    Dim tipoFormulario As Integer

    Private Sub BtnEntrevistaInicialCancelar_Click(sender As Object, e As EventArgs) Handles BtnEntrevistaInicialCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnContinuarADiagnostico_Click(sender As Object, e As EventArgs) Handles BtnContinuarADiagnostico.Click
        Form1.AbrirFormDentroDePanelPForm(Of FrmExploracionYDolor)()

    End Sub

    Private Sub BtnCrearEntrevista_Click(sender As Object, e As EventArgs) Handles BtnCrearEntrevista.Click
        GbxInspecciongeneral.Visible = True
        GbxConstantesVitales.Visible = True
        GbxMotivosdeConsulta.Visible = True
        LblNumEntrevista.Text = "00001"
    End Sub

    Private Sub BtnVolverAMantenimiento_Click(sender As Object, e As EventArgs) Handles BtnVolverAMantenimiento.Click
        Form1.AbrirFormDentroDePanelPForm(Of FrmMantenimiento)()
    End Sub

    Private Sub BtnEntrevistaInicialGuardar_Click(sender As Object, e As EventArgs) Handles BtnEntrevistaInicialGuardar.Click
        If ComestadoConsciencia.Text = "" Or ComMovilidad.Text = "" Or ComGradoDeColaboracion.Text = "" Or ComActitud.Text = "" Or ComEstadoDeNutricion.Text = "" Or ComGradoDeHidratacion.Text = "" Or ComPulso.Text = "" Then

            MsgBox("Complete todos los campos")
        Else

            LblDatoEstadoConsciencia.Text = ComestadoConsciencia.Text
            LblDatosMovilidad.Text = ComMovilidad.Text
            LblDatosNutricion.Text = ComEstadoDeNutricion.Text
            LbldatosColaboracion.Text = ComGradoDeColaboracion.Text
            LbldatosActitud.Text = ComActitud.Text
            LbldatosHidratacion.Text = ComGradoDeHidratacion.Text
            LbldatosPulso.Text = ComPulso.Text
            LblDatostemperatura.Text = NudTemperatura.Text
            LbldatosFrecuenciaCardiaca.Text = NudFrecuenciacardiaca.Text
            LblDatosFrecuenciaRespiratoria.Text = NudfrecuenciaRespiratoria.Text
            LblDatosPresionArterial.Text = NudPresionArterialSist.Text
            LblDatosMotivo.Text = TxtMotivoprincipal.Text
            LbldatosAmpliarMotivos.Text = TxtAmpliarMotivo.Text
            LbldatostratamientoActual.Text = TxtTratamientoActual.Text
            LblDatosIdEntrevista.Text = LblNumEntrevista.Text

        End If

    End Sub

End Class