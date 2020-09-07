Public Class FrmExploracionYDolor

    Private Sub BtnVolverAEntrevista_Click(sender As Object, e As EventArgs) Handles BtnVolverAEntrevista.Click
        Form1.AbrirFormDentroDePanelPForm(Of FrmEntrevistaInicial)()
    End Sub

    Private Sub BtnContinuarADiagnostico_Click(sender As Object, e As EventArgs) Handles BtnContinuarADiagnostico.Click
        Form1.AbrirFormDentroDePanelPForm(Of FrmPreDiagnosticoyDiagnostico)()
    End Sub

    Private Sub BtnExploracionCancelar_Click(sender As Object, e As EventArgs) Handles BtnExploracionCancelar.Click
        Me.Close()
    End Sub

    Private Sub RadioKleinPositivo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioKleinPositivo.CheckedChanged
        If RadioKleinPositivo.Checked Then
            LbxSintomasExploracion.Items.Add("INSUFIENCIA VERTEBRO-BASILAR?")
        Else
            LbxSintomasExploracion.Items.Remove("INSUFIENCIA VERTEBRO-BASILAR?")
        End If

    End Sub

    Private Sub RadioEstabilidadPositivo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioEstabilidadPositivo.CheckedChanged
        If RadioEstabilidadPositivo.Checked Then
            LbxSintomasExploracion.Items.Add("INESTABILIDAD COMPLEJO CERVICAL SUPERIOR?")
        Else
            LbxSintomasExploracion.Items.Remove("INESTABILIDAD COMPLEJO CERVICAL SUPERIOR?")
        End If

    End Sub

    Private Sub RadioWainnerPositivo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioWainnerPositivo.CheckedChanged
        If RadioWainnerPositivo.Checked Then
            LbxSintomasExploracion.Items.Add("RADICULOPATIAS?")
        Else
            LbxSintomasExploracion.Items.Remove("RADICULOPATIAS?")
        End If

    End Sub

    Private Sub RadioHoffmanDesviacion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioHoffmanDesviacion.CheckedChanged
        If RadioHoffmanDesviacion.Checked Then
            LbxSintomasExploracion.Items.Add("MIELOPATIAS?")
        Else
            LbxSintomasExploracion.Items.Remove("MIELOPATIAS?")
        End If

    End Sub

    Private Sub RadioPercusionPositivo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioPercusionPositivo.CheckedChanged
        If RadioPercusionPositivo.Checked Then
            LbxSintomasExploracion.Items.Add("FRACTURA?")
        Else
            LbxSintomasExploracion.Items.Remove("FRACTURA?")
        End If

    End Sub

    Private Sub RadioAlodiniaSi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioAlodiniaSi.CheckedChanged
        If RadioAlodiniaSi.Checked Then
            LbxSintomasNeurologicos.Items.Add("POSIBLE AFECTACION SISTEMA NERVIOSO CENTRAL")
        Else
            LbxSintomasNeurologicos.Items.Remove("POSIBLE AFECTACION SISTEMA NERVIOSO CENTRAL")
        End If

    End Sub

    Private Sub RadioNeurologicosIntensos_CheckedChanged(sender As Object, e As EventArgs) Handles RadioNeurologicosIntensos.CheckedChanged
        If RadioNeurologicosIntensos.Checked Then
            GrxSLR.Visible = True
            GrxIncontinencias.Visible = True
        End If
    End Sub

    Private Sub RadioNeurologicosLeves_CheckedChanged(sender As Object, e As EventArgs) Handles RadioNeurologicosLeves.CheckedChanged
        If RadioNeurologicosLeves.Checked Then
            GrxSLR.Visible = False
            GrxIncontinencias.Visible = False
            LblFisoterapia.Visible = True
            LbxSintomasNeurologicos.Items.Add("FISOTERAPIA")
        Else
            LbxSintomasNeurologicos.Items.Remove("FISOTERAPIA")
            LblFisoterapia.Visible = False
        End If
    End Sub

    Private Sub RadioSLRpositivo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioSLRpositivo.CheckedChanged
        If RadioSLRpositivo.Checked Then
            LbxSintomasNeurologicos.Items.Add("RADICULOPATIAS?")
        Else
            LbxSintomasNeurologicos.Items.Remove("RADICULOPATIAS?")

        End If

    End Sub

    Private Sub RadioIncontinencia_CheckedChanged(sender As Object, e As EventArgs) Handles RadioIncontinencia.CheckedChanged
        If RadioIncontinencia.Checked Then
            LbxSintomasNeurologicos.Items.Add("SINDROME COLA DE CABALLO?")
        Else
            LbxSintomasNeurologicos.Items.Remove("SINDROME COLA DE CABALLO?")
        End If

    End Sub

    Private Sub RadadioAlodiniaVergrupo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioAlodiniaVergrupo.CheckedChanged
        If RadioAlodiniaVergrupo.Checked Then
            GrxAlodinia.Visible = True
            GrxSintomasNeurologicos.Visible = False

        End If
    End Sub

    Private Sub RadioIncontinenciasVergrupo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioIncontinenciasVergrupo.CheckedChanged
        If RadioIncontinenciasVergrupo.Checked Then
            GrxAlodinia.Visible = False
            GrxSintomasNeurologicos.Visible = True

        End If
    End Sub

    Private Sub RadioneurologicasGruposCierra_CheckedChanged(sender As Object, e As EventArgs) Handles RadioneurologicasGruposCierra.CheckedChanged
        GrxAlodinia.Visible = False
        GrxSintomasNeurologicos.Visible = False
    End Sub

    Private Sub RadioPalpitantePunzante_CheckedChanged(sender As Object, e As EventArgs) Handles RadioPalpitantePunzante.CheckedChanged

        If RadioPalpitantePunzante.Checked Then
            LbxSintomasDolor.Items.Add("ANEURISMA?")
        Else
            LbxSintomasDolor.Items.Remove("ANEURISMA?")
        End If
    End Sub

    Private Sub RadioAgudoEIntensoSinRazonAparente_CheckedChanged(sender As Object, e As EventArgs) Handles RadioAgudoEIntensoSinRazonAparente.CheckedChanged
        If RadioAgudoEIntensoSinRazonAparente.Checked Then
            GrxAgudoIntenso.Visible = True
            GrxvariaConMovimiento.Visible = False
        End If
    End Sub

    Private Sub RadioVariaConMovimiento_CheckedChanged(sender As Object, e As EventArgs) Handles RadioVariaConMovimiento.CheckedChanged
        If RadioVariaConMovimiento.Checked Then
            GrxAgudoIntenso.Visible = False
            GrxvariaConMovimiento.Visible = True
        End If
    End Sub

    Private Sub RadioDolorSinDolor_CheckedChanged(sender As Object, e As EventArgs) Handles RadioDolorSinDolor.CheckedChanged
        If RadioDolorSinDolor.Checked Then
            GrxvariaConMovimiento.Visible = False
            GrxAgudoIntenso.Visible = False
        End If
    End Sub

    Private Sub RadioVariaMovSi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioVariaMovSi.CheckedChanged

        If RadioVariaMovSi.Checked Then

            GrxMejoraEnReposo.Visible = True
            GrxDolornocturno.Visible = False
        End If

    End Sub

    Private Sub RadioVariaMovNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioVariaMovNo.CheckedChanged

        If RadioVariaMovNo.Checked Then

            GrxMejoraEnReposo.Visible = False
            GrxDolornocturno.Visible = True
            GrxDolornocturno.BringToFront()
        End If

    End Sub

    Private Sub RadioDolorInflamatorioSi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioDolorInflamatorioSi.CheckedChanged
        If RadioDolorInflamatorioSi.Checked Then
            LbxSintomasDolor.Items.Add("POSIBLE DERIVACION")
        Else
            LbxSintomasDolor.Items.Remove("POSIBLE DERIVACION")
        End If
    End Sub

    Private Sub RadioMejoraReposoSi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMejoraReposoSi.CheckedChanged
        If RadioMejoraReposoSi.Checked Then
            GrxPeorConActividad.Visible = True
            GrxDolorInflamatorio.Visible = False
        End If
    End Sub

    Private Sub RadioMejoraReposoNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMejoraReposoNo.CheckedChanged
        If RadioMejoraReposoNo.Checked Then
            GrxDolorInflamatorio.Visible = True
            GrxPeorConActividad.Visible = False
        End If
    End Sub

    Private Sub RadioPeorConActividadSi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioPeorConActividadSi.CheckedChanged
        If RadioPeorConActividadSi.Checked Then
            GrxDolorMecanico.Visible = True
            GrxDolorInflamatorio.Visible = False
        End If
    End Sub

    Private Sub RadioPeorConActividadNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioPeorConActividadNo.CheckedChanged
        If RadioPeorConActividadNo.Checked Then
            GrxDolorInflamatorio.Visible = True
            GrxDolorMecanico.Visible = False
        End If
    End Sub

    Private Sub RadioDolorMecanicoSi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioDolorMecanicoSi.CheckedChanged
        If RadioDolorMecanicoSi.Checked Then
            GrxDolorIrradiado.Visible = True
        End If

    End Sub

    Private Sub RadioDolorMecanicoNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioDolorMecanicoNo.CheckedChanged
        If RadioDolorMecanicoNo.Checked Then
            LbxSintomasDolor.Items.Add("RECETAR ANALGESICOS?")
            GrxDolorIrradiado.Visible = False
        Else
            LbxSintomasDolor.Items.Remove("RECETAR ANALGESICOS?")
        End If
    End Sub

    Private Sub RadioDolorIrradiadoNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioDolorIrradiadoNo.CheckedChanged
        If RadioDolorIrradiadoNo.Checked Then
            LbxSintomasDolor.Items.Add("FISOTERAPIA")
            LblVolveraSintomasNeurologicos.Visible = False
        Else
            LbxSintomasDolor.Items.Remove("FISOTERAPIA")
        End If
    End Sub

    Private Sub RadioDolorIrradiadoSi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioDolorIrradiadoSi.CheckedChanged
        If RadioDolorIrradiadoSi.Checked Then
            LblVolveraSintomasNeurologicos.Visible = True

            GrxSintomasNeurologicos.Visible = True
            GrxSLR.Visible = True
            GrxIncontinencias.Visible = True

        End If
    End Sub

    Private Sub RadioNocturnoSi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioNocturnoSi.CheckedChanged
        If RadioNocturnoSi.Checked Then
            GrxCambioPostura.Visible = True
            GrxMejoraConMedicacion.Visible = False
        End If
    End Sub

    Private Sub RadioNocturnoSiMucho_CheckedChanged(sender As Object, e As EventArgs) Handles RadioNocturnoSiMucho.CheckedChanged
        If RadioNocturnoSiMucho.Checked Then
            GrxCambioPostura.Visible = False
            GrxMejoraConMedicacion.Visible = True
        End If
    End Sub

    Private Sub RadionocturnoNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadionocturnoNo.CheckedChanged
        If RadionocturnoNo.Checked Then
            GrxDolornocturno.Visible = False
        End If
    End Sub

    Private Sub RadiocambioPosturaSi_CheckedChanged(sender As Object, e As EventArgs) Handles RadiocambioPosturaSi.CheckedChanged
        If RadiocambioPosturaSi.Checked Then
            LblCorrelacionaExploracion.Visible = True
            LbxSintomasDolor.Items.Add("POSIBLE DERIVACION")
        Else
            LbxSintomasDolor.Items.Remove("POSIBLE DERIVACION")
        End If

    End Sub

    Private Sub RadiocambioPosturaNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadiocambioPosturaNo.CheckedChanged
        If RadiocambioPosturaNo.Checked Then
            LbxSintomasDolor.Items.Add("BANDERA ROJA")
            LblCorrelacionaExploracion.Visible = False
        Else
            LbxSintomasDolor.Items.Remove("BANDERA ROJA")
        End If

    End Sub

    Private Sub RadioMejoramedicacionSi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMejoramedicacionSi.CheckedChanged
        If RadioMejoramedicacionSi.Checked Then
            LblCorrelacionaConMedicacion.Visible = True
            LbxSintomasDolor.Items.Add("POSIBLE DERIVACION")
        Else
            LbxSintomasDolor.Items.Remove("POSIBLE DERIVACION")
        End If
    End Sub

    Private Sub RadioMejoramedicacionNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMejoramedicacionNo.CheckedChanged
        If RadioMejoramedicacionNo.Checked Then
            LbxSintomasDolor.Items.Add("BANDERA ROJA")
            LblCorrelacionaConMedicacion.Visible = False
        Else
            LbxSintomasDolor.Items.Remove("BANDERA ROJA")
        End If
    End Sub


End Class