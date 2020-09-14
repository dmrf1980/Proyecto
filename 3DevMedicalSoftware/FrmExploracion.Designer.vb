<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExploracionYDolor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExploracionYDolor))
        Me.GrxExploracion = New System.Windows.Forms.GroupBox()
        Me.GrxExplracionNeurologica = New System.Windows.Forms.GroupBox()
        Me.GrxSintomasNeurologicos = New System.Windows.Forms.GroupBox()
        Me.GrxIntensoOLeve = New System.Windows.Forms.GroupBox()
        Me.RadioNeurologicosIntensos = New System.Windows.Forms.RadioButton()
        Me.RadioNeurologicosLeves = New System.Windows.Forms.RadioButton()
        Me.GrxIncontinencias = New System.Windows.Forms.GroupBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioIncontinencia = New System.Windows.Forms.RadioButton()
        Me.GrxSLR = New System.Windows.Forms.GroupBox()
        Me.RadioSLRpositivo = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.LblFisoterapia = New System.Windows.Forms.Label()
        Me.RadioneurologicasGruposCierra = New System.Windows.Forms.RadioButton()
        Me.RadioIncontinenciasVergrupo = New System.Windows.Forms.RadioButton()
        Me.RadioAlodiniaVergrupo = New System.Windows.Forms.RadioButton()
        Me.GrxAlodinia = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioAlodiniaSi = New System.Windows.Forms.RadioButton()
        Me.GrxTestOrtopedicospositivos = New System.Windows.Forms.GroupBox()
        Me.GrxTestKlein = New System.Windows.Forms.GroupBox()
        Me.RadioKleinNegativo = New System.Windows.Forms.RadioButton()
        Me.RadioKleinPositivo = New System.Windows.Forms.RadioButton()
        Me.GrxTestEstabilidadLigamento = New System.Windows.Forms.GroupBox()
        Me.RadioEstabilidadNegativo = New System.Windows.Forms.RadioButton()
        Me.RadioEstabilidadPositivo = New System.Windows.Forms.RadioButton()
        Me.GrxWainerCluster = New System.Windows.Forms.GroupBox()
        Me.RadioWainnerNegativo = New System.Windows.Forms.RadioButton()
        Me.RadioWainnerPositivo = New System.Windows.Forms.RadioButton()
        Me.GrxTestHoffman = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioHoffmanDesviacion = New System.Windows.Forms.RadioButton()
        Me.GrxtestPercusion = New System.Windows.Forms.GroupBox()
        Me.RadioPercusionNegativo = New System.Windows.Forms.RadioButton()
        Me.RadioPercusionPositivo = New System.Windows.Forms.RadioButton()
        Me.GrxBotonesGuardarCancelarContinuar = New System.Windows.Forms.GroupBox()
        Me.BtnVolverAEntrevista = New System.Windows.Forms.Button()
        Me.BtnExploracionCancelar = New System.Windows.Forms.Button()
        Me.GrxCambiarContinurDiagnostico = New System.Windows.Forms.GroupBox()
        Me.BtnContinuarADiagnostico = New System.Windows.Forms.Button()
        Me.GrxComportamientoDelDolor = New System.Windows.Forms.GroupBox()
        Me.GrxInteriorAComportamientoDolor = New System.Windows.Forms.GroupBox()
        Me.GrxvariaConMovimiento = New System.Windows.Forms.GroupBox()
        Me.GrxMejoraEnReposo = New System.Windows.Forms.GroupBox()
        Me.GrxPeorConActividad = New System.Windows.Forms.GroupBox()
        Me.GrxDolorMecanico = New System.Windows.Forms.GroupBox()
        Me.GrxDolorIrradiado = New System.Windows.Forms.GroupBox()
        Me.LblVolveraSintomasNeurologicos = New System.Windows.Forms.Label()
        Me.RadioDolorIrradiadoNo = New System.Windows.Forms.RadioButton()
        Me.RadioDolorIrradiadoSi = New System.Windows.Forms.RadioButton()
        Me.RadioDolorMecanicoSi = New System.Windows.Forms.RadioButton()
        Me.RadioDolorMecanicoNo = New System.Windows.Forms.RadioButton()
        Me.LblFuerte = New System.Windows.Forms.Label()
        Me.RadioPeorConActividadSi = New System.Windows.Forms.RadioButton()
        Me.RadioPeorConActividadNo = New System.Windows.Forms.RadioButton()
        Me.RadioMejoraReposoSi = New System.Windows.Forms.RadioButton()
        Me.RadioMejoraReposoNo = New System.Windows.Forms.RadioButton()
        Me.GrxDolorInflamatorio = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadioDolorInflamatorioNo = New System.Windows.Forms.RadioButton()
        Me.RadioDolorInflamatorioSi = New System.Windows.Forms.RadioButton()
        Me.GrxDolornocturno = New System.Windows.Forms.GroupBox()
        Me.RadioNocturnoSi = New System.Windows.Forms.RadioButton()
        Me.RadionocturnoNo = New System.Windows.Forms.RadioButton()
        Me.RadioNocturnoSiMucho = New System.Windows.Forms.RadioButton()
        Me.GrxCambioPostura = New System.Windows.Forms.GroupBox()
        Me.LblCorrelacionaExploracion = New System.Windows.Forms.Label()
        Me.RadiocambioPosturaSi = New System.Windows.Forms.RadioButton()
        Me.RadiocambioPosturaNo = New System.Windows.Forms.RadioButton()
        Me.GrxMejoraConMedicacion = New System.Windows.Forms.GroupBox()
        Me.LblCorrelacionaConMedicacion = New System.Windows.Forms.Label()
        Me.RadioMejoramedicacionNo = New System.Windows.Forms.RadioButton()
        Me.RadioMejoramedicacionSi = New System.Windows.Forms.RadioButton()
        Me.RadioVariaMovSi = New System.Windows.Forms.RadioButton()
        Me.RadioVariaMovNo = New System.Windows.Forms.RadioButton()
        Me.RadioAgudoEIntensoSinRazonAparente = New System.Windows.Forms.RadioButton()
        Me.RadioDolorSinDolor = New System.Windows.Forms.RadioButton()
        Me.RadioVariaConMovimiento = New System.Windows.Forms.RadioButton()
        Me.GrxAgudoIntenso = New System.Windows.Forms.GroupBox()
        Me.RadioPalpitantePunzante = New System.Windows.Forms.RadioButton()
        Me.RadioAgudoIntensoNegativo = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbxSintomasExploracion = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbxSintomasNeurologicos = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbxSintomasDolor = New System.Windows.Forms.ListBox()
        Me.GrxSintomas = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GrxExploracion.SuspendLayout()
        Me.GrxExplracionNeurologica.SuspendLayout()
        Me.GrxSintomasNeurologicos.SuspendLayout()
        Me.GrxIntensoOLeve.SuspendLayout()
        Me.GrxIncontinencias.SuspendLayout()
        Me.GrxSLR.SuspendLayout()
        Me.GrxAlodinia.SuspendLayout()
        Me.GrxTestOrtopedicospositivos.SuspendLayout()
        Me.GrxTestKlein.SuspendLayout()
        Me.GrxTestEstabilidadLigamento.SuspendLayout()
        Me.GrxWainerCluster.SuspendLayout()
        Me.GrxTestHoffman.SuspendLayout()
        Me.GrxtestPercusion.SuspendLayout()
        Me.GrxBotonesGuardarCancelarContinuar.SuspendLayout()
        Me.GrxCambiarContinurDiagnostico.SuspendLayout()
        Me.GrxComportamientoDelDolor.SuspendLayout()
        Me.GrxInteriorAComportamientoDolor.SuspendLayout()
        Me.GrxvariaConMovimiento.SuspendLayout()
        Me.GrxMejoraEnReposo.SuspendLayout()
        Me.GrxPeorConActividad.SuspendLayout()
        Me.GrxDolorMecanico.SuspendLayout()
        Me.GrxDolorIrradiado.SuspendLayout()
        Me.GrxDolorInflamatorio.SuspendLayout()
        Me.GrxDolornocturno.SuspendLayout()
        Me.GrxCambioPostura.SuspendLayout()
        Me.GrxMejoraConMedicacion.SuspendLayout()
        Me.GrxAgudoIntenso.SuspendLayout()
        Me.GrxSintomas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrxExploracion
        '
        Me.GrxExploracion.Controls.Add(Me.GrxExplracionNeurologica)
        Me.GrxExploracion.Controls.Add(Me.GrxTestOrtopedicospositivos)
        Me.GrxExploracion.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrxExploracion.Font = New System.Drawing.Font("Ubuntu", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxExploracion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.GrxExploracion.Location = New System.Drawing.Point(10, 5)
        Me.GrxExploracion.Margin = New System.Windows.Forms.Padding(0)
        Me.GrxExploracion.MaximumSize = New System.Drawing.Size(1000, 1063)
        Me.GrxExploracion.Name = "GrxExploracion"
        Me.GrxExploracion.Size = New System.Drawing.Size(733, 496)
        Me.GrxExploracion.TabIndex = 2
        Me.GrxExploracion.TabStop = False
        Me.GrxExploracion.Text = "Exploracion"
        '
        'GrxExplracionNeurologica
        '
        Me.GrxExplracionNeurologica.Controls.Add(Me.GrxSintomasNeurologicos)
        Me.GrxExplracionNeurologica.Controls.Add(Me.RadioneurologicasGruposCierra)
        Me.GrxExplracionNeurologica.Controls.Add(Me.RadioIncontinenciasVergrupo)
        Me.GrxExplracionNeurologica.Controls.Add(Me.RadioAlodiniaVergrupo)
        Me.GrxExplracionNeurologica.Controls.Add(Me.GrxAlodinia)
        Me.GrxExplracionNeurologica.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrxExplracionNeurologica.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxExplracionNeurologica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrxExplracionNeurologica.Location = New System.Drawing.Point(26, 269)
        Me.GrxExplracionNeurologica.Name = "GrxExplracionNeurologica"
        Me.GrxExplracionNeurologica.Size = New System.Drawing.Size(685, 219)
        Me.GrxExplracionNeurologica.TabIndex = 7
        Me.GrxExplracionNeurologica.TabStop = False
        Me.GrxExplracionNeurologica.Text = "Exploracion neurologica"
        '
        'GrxSintomasNeurologicos
        '
        Me.GrxSintomasNeurologicos.Controls.Add(Me.GrxIntensoOLeve)
        Me.GrxSintomasNeurologicos.Controls.Add(Me.GrxIncontinencias)
        Me.GrxSintomasNeurologicos.Controls.Add(Me.GrxSLR)
        Me.GrxSintomasNeurologicos.Controls.Add(Me.LblFisoterapia)
        Me.GrxSintomasNeurologicos.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxSintomasNeurologicos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GrxSintomasNeurologicos.Location = New System.Drawing.Point(0, 78)
        Me.GrxSintomasNeurologicos.Name = "GrxSintomasNeurologicos"
        Me.GrxSintomasNeurologicos.Size = New System.Drawing.Size(669, 135)
        Me.GrxSintomasNeurologicos.TabIndex = 5
        Me.GrxSintomasNeurologicos.TabStop = False
        Me.GrxSintomasNeurologicos.Text = "Sintomas neurologicos"
        Me.GrxSintomasNeurologicos.Visible = False
        '
        'GrxIntensoOLeve
        '
        Me.GrxIntensoOLeve.Controls.Add(Me.RadioNeurologicosIntensos)
        Me.GrxIntensoOLeve.Controls.Add(Me.RadioNeurologicosLeves)
        Me.GrxIntensoOLeve.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxIntensoOLeve.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GrxIntensoOLeve.Location = New System.Drawing.Point(210, 13)
        Me.GrxIntensoOLeve.Name = "GrxIntensoOLeve"
        Me.GrxIntensoOLeve.Size = New System.Drawing.Size(428, 38)
        Me.GrxIntensoOLeve.TabIndex = 9
        Me.GrxIntensoOLeve.TabStop = False
        Me.GrxIntensoOLeve.Text = "Sintomas"
        '
        'RadioNeurologicosIntensos
        '
        Me.RadioNeurologicosIntensos.AutoSize = True
        Me.RadioNeurologicosIntensos.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioNeurologicosIntensos.Location = New System.Drawing.Point(135, 11)
        Me.RadioNeurologicosIntensos.Name = "RadioNeurologicosIntensos"
        Me.RadioNeurologicosIntensos.Size = New System.Drawing.Size(77, 21)
        Me.RadioNeurologicosIntensos.TabIndex = 6
        Me.RadioNeurologicosIntensos.TabStop = True
        Me.RadioNeurologicosIntensos.Text = "Intensos"
        Me.RadioNeurologicosIntensos.UseVisualStyleBackColor = True
        '
        'RadioNeurologicosLeves
        '
        Me.RadioNeurologicosLeves.AutoSize = True
        Me.RadioNeurologicosLeves.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioNeurologicosLeves.Location = New System.Drawing.Point(335, 11)
        Me.RadioNeurologicosLeves.Name = "RadioNeurologicosLeves"
        Me.RadioNeurologicosLeves.Size = New System.Drawing.Size(62, 21)
        Me.RadioNeurologicosLeves.TabIndex = 3
        Me.RadioNeurologicosLeves.Text = "Leves"
        Me.RadioNeurologicosLeves.UseVisualStyleBackColor = True
        '
        'GrxIncontinencias
        '
        Me.GrxIncontinencias.Controls.Add(Me.RadioButton6)
        Me.GrxIncontinencias.Controls.Add(Me.RadioIncontinencia)
        Me.GrxIncontinencias.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrxIncontinencias.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxIncontinencias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GrxIncontinencias.Location = New System.Drawing.Point(210, 91)
        Me.GrxIncontinencias.Name = "GrxIncontinencias"
        Me.GrxIncontinencias.Size = New System.Drawing.Size(424, 38)
        Me.GrxIncontinencias.TabIndex = 7
        Me.GrxIncontinencias.TabStop = False
        Me.GrxIncontinencias.Text = "Incontinencias"
        Me.GrxIncontinencias.Visible = False
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Checked = True
        Me.RadioButton6.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.Location = New System.Drawing.Point(335, 11)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(82, 21)
        Me.RadioButton6.TabIndex = 3
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Negativo"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioIncontinencia
        '
        Me.RadioIncontinencia.AutoSize = True
        Me.RadioIncontinencia.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioIncontinencia.Location = New System.Drawing.Point(133, 11)
        Me.RadioIncontinencia.Name = "RadioIncontinencia"
        Me.RadioIncontinencia.Size = New System.Drawing.Size(198, 21)
        Me.RadioIncontinencia.TabIndex = 5
        Me.RadioIncontinencia.TabStop = True
        Me.RadioIncontinencia.Text = "Incontinencia urinaria o fecal"
        Me.RadioIncontinencia.UseVisualStyleBackColor = True
        '
        'GrxSLR
        '
        Me.GrxSLR.Controls.Add(Me.RadioSLRpositivo)
        Me.GrxSLR.Controls.Add(Me.RadioButton5)
        Me.GrxSLR.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrxSLR.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxSLR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GrxSLR.Location = New System.Drawing.Point(210, 53)
        Me.GrxSLR.Name = "GrxSLR"
        Me.GrxSLR.Size = New System.Drawing.Size(425, 38)
        Me.GrxSLR.TabIndex = 8
        Me.GrxSLR.TabStop = False
        Me.GrxSLR.Text = "Slr"
        Me.GrxSLR.Visible = False
        '
        'RadioSLRpositivo
        '
        Me.RadioSLRpositivo.AutoSize = True
        Me.RadioSLRpositivo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioSLRpositivo.Location = New System.Drawing.Point(133, 11)
        Me.RadioSLRpositivo.Name = "RadioSLRpositivo"
        Me.RadioSLRpositivo.Size = New System.Drawing.Size(100, 21)
        Me.RadioSLRpositivo.TabIndex = 6
        Me.RadioSLRpositivo.TabStop = True
        Me.RadioSLRpositivo.Text = "SLR positivo"
        Me.RadioSLRpositivo.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Checked = True
        Me.RadioButton5.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(335, 11)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(82, 21)
        Me.RadioButton5.TabIndex = 3
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Negativo"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'LblFisoterapia
        '
        Me.LblFisoterapia.AutoSize = True
        Me.LblFisoterapia.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFisoterapia.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LblFisoterapia.Location = New System.Drawing.Point(27, 76)
        Me.LblFisoterapia.Name = "LblFisoterapia"
        Me.LblFisoterapia.Size = New System.Drawing.Size(464, 17)
        Me.LblFisoterapia.TabIndex = 14
        Me.LblFisoterapia.Text = "FISOTERAPIA: terapia manual, ejercicio terapeutico, educacion en dolor"
        Me.LblFisoterapia.Visible = False
        '
        'RadioneurologicasGruposCierra
        '
        Me.RadioneurologicasGruposCierra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioneurologicasGruposCierra.AutoSize = True
        Me.RadioneurologicasGruposCierra.Checked = True
        Me.RadioneurologicasGruposCierra.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioneurologicasGruposCierra.Location = New System.Drawing.Point(544, 43)
        Me.RadioneurologicasGruposCierra.Name = "RadioneurologicasGruposCierra"
        Me.RadioneurologicasGruposCierra.Size = New System.Drawing.Size(82, 21)
        Me.RadioneurologicasGruposCierra.TabIndex = 7
        Me.RadioneurologicasGruposCierra.TabStop = True
        Me.RadioneurologicasGruposCierra.Text = "Negativo"
        Me.RadioneurologicasGruposCierra.UseVisualStyleBackColor = True
        '
        'RadioIncontinenciasVergrupo
        '
        Me.RadioIncontinenciasVergrupo.AutoSize = True
        Me.RadioIncontinenciasVergrupo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioIncontinenciasVergrupo.Location = New System.Drawing.Point(358, 43)
        Me.RadioIncontinenciasVergrupo.Name = "RadioIncontinenciasVergrupo"
        Me.RadioIncontinenciasVergrupo.Size = New System.Drawing.Size(163, 21)
        Me.RadioIncontinenciasVergrupo.TabIndex = 7
        Me.RadioIncontinenciasVergrupo.Text = "Sintomas neurologicos"
        Me.RadioIncontinenciasVergrupo.UseVisualStyleBackColor = True
        '
        'RadioAlodiniaVergrupo
        '
        Me.RadioAlodiniaVergrupo.AutoSize = True
        Me.RadioAlodiniaVergrupo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioAlodiniaVergrupo.Location = New System.Drawing.Point(261, 43)
        Me.RadioAlodiniaVergrupo.Name = "RadioAlodiniaVergrupo"
        Me.RadioAlodiniaVergrupo.Size = New System.Drawing.Size(75, 21)
        Me.RadioAlodiniaVergrupo.TabIndex = 8
        Me.RadioAlodiniaVergrupo.Text = "Alodinia"
        Me.RadioAlodiniaVergrupo.UseVisualStyleBackColor = True
        '
        'GrxAlodinia
        '
        Me.GrxAlodinia.Controls.Add(Me.Label5)
        Me.GrxAlodinia.Controls.Add(Me.RadioButton4)
        Me.GrxAlodinia.Controls.Add(Me.RadioAlodiniaSi)
        Me.GrxAlodinia.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrxAlodinia.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxAlodinia.Location = New System.Drawing.Point(27, 78)
        Me.GrxAlodinia.Margin = New System.Windows.Forms.Padding(0)
        Me.GrxAlodinia.Name = "GrxAlodinia"
        Me.GrxAlodinia.Size = New System.Drawing.Size(632, 44)
        Me.GrxAlodinia.TabIndex = 6
        Me.GrxAlodinia.TabStop = False
        Me.GrxAlodinia.Text = "Alodinia"
        Me.GrxAlodinia.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(109, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(267, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "*Correlacionar resto de exploracion"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(518, 15)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(82, 21)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Negativo"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioAlodiniaSi
        '
        Me.RadioAlodiniaSi.AutoSize = True
        Me.RadioAlodiniaSi.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioAlodiniaSi.Location = New System.Drawing.Point(428, 17)
        Me.RadioAlodiniaSi.Name = "RadioAlodiniaSi"
        Me.RadioAlodiniaSi.Size = New System.Drawing.Size(36, 21)
        Me.RadioAlodiniaSi.TabIndex = 5
        Me.RadioAlodiniaSi.TabStop = True
        Me.RadioAlodiniaSi.Text = "Si"
        Me.RadioAlodiniaSi.UseVisualStyleBackColor = True
        '
        'GrxTestOrtopedicospositivos
        '
        Me.GrxTestOrtopedicospositivos.Controls.Add(Me.GrxTestKlein)
        Me.GrxTestOrtopedicospositivos.Controls.Add(Me.GrxTestEstabilidadLigamento)
        Me.GrxTestOrtopedicospositivos.Controls.Add(Me.GrxWainerCluster)
        Me.GrxTestOrtopedicospositivos.Controls.Add(Me.GrxTestHoffman)
        Me.GrxTestOrtopedicospositivos.Controls.Add(Me.GrxtestPercusion)
        Me.GrxTestOrtopedicospositivos.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxTestOrtopedicospositivos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrxTestOrtopedicospositivos.Location = New System.Drawing.Point(14, 38)
        Me.GrxTestOrtopedicospositivos.Name = "GrxTestOrtopedicospositivos"
        Me.GrxTestOrtopedicospositivos.Size = New System.Drawing.Size(697, 233)
        Me.GrxTestOrtopedicospositivos.TabIndex = 6
        Me.GrxTestOrtopedicospositivos.TabStop = False
        Me.GrxTestOrtopedicospositivos.Text = "Test ortopedicos positivos"
        '
        'GrxTestKlein
        '
        Me.GrxTestKlein.Controls.Add(Me.RadioKleinNegativo)
        Me.GrxTestKlein.Controls.Add(Me.RadioKleinPositivo)
        Me.GrxTestKlein.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrxTestKlein.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxTestKlein.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GrxTestKlein.Location = New System.Drawing.Point(27, 28)
        Me.GrxTestKlein.Name = "GrxTestKlein"
        Me.GrxTestKlein.Size = New System.Drawing.Size(642, 40)
        Me.GrxTestKlein.TabIndex = 2
        Me.GrxTestKlein.TabStop = False
        Me.GrxTestKlein.Text = "Test de Klein"
        '
        'RadioKleinNegativo
        '
        Me.RadioKleinNegativo.AutoSize = True
        Me.RadioKleinNegativo.Checked = True
        Me.RadioKleinNegativo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioKleinNegativo.Location = New System.Drawing.Point(551, 14)
        Me.RadioKleinNegativo.Name = "RadioKleinNegativo"
        Me.RadioKleinNegativo.Size = New System.Drawing.Size(82, 21)
        Me.RadioKleinNegativo.TabIndex = 2
        Me.RadioKleinNegativo.TabStop = True
        Me.RadioKleinNegativo.Text = "Negativo"
        Me.RadioKleinNegativo.UseVisualStyleBackColor = True
        '
        'RadioKleinPositivo
        '
        Me.RadioKleinPositivo.AutoSize = True
        Me.RadioKleinPositivo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioKleinPositivo.Location = New System.Drawing.Point(461, 14)
        Me.RadioKleinPositivo.Name = "RadioKleinPositivo"
        Me.RadioKleinPositivo.Size = New System.Drawing.Size(75, 21)
        Me.RadioKleinPositivo.TabIndex = 2
        Me.RadioKleinPositivo.Text = "Positivo"
        Me.RadioKleinPositivo.UseVisualStyleBackColor = True
        '
        'GrxTestEstabilidadLigamento
        '
        Me.GrxTestEstabilidadLigamento.Controls.Add(Me.RadioEstabilidadNegativo)
        Me.GrxTestEstabilidadLigamento.Controls.Add(Me.RadioEstabilidadPositivo)
        Me.GrxTestEstabilidadLigamento.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrxTestEstabilidadLigamento.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxTestEstabilidadLigamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GrxTestEstabilidadLigamento.Location = New System.Drawing.Point(27, 65)
        Me.GrxTestEstabilidadLigamento.Name = "GrxTestEstabilidadLigamento"
        Me.GrxTestEstabilidadLigamento.Size = New System.Drawing.Size(642, 40)
        Me.GrxTestEstabilidadLigamento.TabIndex = 3
        Me.GrxTestEstabilidadLigamento.TabStop = False
        Me.GrxTestEstabilidadLigamento.Text = "Test de estabilidad ligamentos alares y ligamento transverso"
        '
        'RadioEstabilidadNegativo
        '
        Me.RadioEstabilidadNegativo.AutoSize = True
        Me.RadioEstabilidadNegativo.Checked = True
        Me.RadioEstabilidadNegativo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioEstabilidadNegativo.Location = New System.Drawing.Point(551, 13)
        Me.RadioEstabilidadNegativo.Name = "RadioEstabilidadNegativo"
        Me.RadioEstabilidadNegativo.Size = New System.Drawing.Size(82, 21)
        Me.RadioEstabilidadNegativo.TabIndex = 3
        Me.RadioEstabilidadNegativo.TabStop = True
        Me.RadioEstabilidadNegativo.Text = "Negativo"
        Me.RadioEstabilidadNegativo.UseVisualStyleBackColor = True
        '
        'RadioEstabilidadPositivo
        '
        Me.RadioEstabilidadPositivo.AutoSize = True
        Me.RadioEstabilidadPositivo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioEstabilidadPositivo.Location = New System.Drawing.Point(461, 13)
        Me.RadioEstabilidadPositivo.Name = "RadioEstabilidadPositivo"
        Me.RadioEstabilidadPositivo.Size = New System.Drawing.Size(75, 21)
        Me.RadioEstabilidadPositivo.TabIndex = 4
        Me.RadioEstabilidadPositivo.Text = "Positivo"
        Me.RadioEstabilidadPositivo.UseVisualStyleBackColor = True
        '
        'GrxWainerCluster
        '
        Me.GrxWainerCluster.Controls.Add(Me.RadioWainnerNegativo)
        Me.GrxWainerCluster.Controls.Add(Me.RadioWainnerPositivo)
        Me.GrxWainerCluster.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrxWainerCluster.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxWainerCluster.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GrxWainerCluster.Location = New System.Drawing.Point(27, 105)
        Me.GrxWainerCluster.Name = "GrxWainerCluster"
        Me.GrxWainerCluster.Size = New System.Drawing.Size(642, 40)
        Me.GrxWainerCluster.TabIndex = 6
        Me.GrxWainerCluster.TabStop = False
        Me.GrxWainerCluster.Text = "Wainner cluster"
        '
        'RadioWainnerNegativo
        '
        Me.RadioWainnerNegativo.AutoSize = True
        Me.RadioWainnerNegativo.Checked = True
        Me.RadioWainnerNegativo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioWainnerNegativo.Location = New System.Drawing.Point(551, 13)
        Me.RadioWainnerNegativo.Name = "RadioWainnerNegativo"
        Me.RadioWainnerNegativo.Size = New System.Drawing.Size(82, 21)
        Me.RadioWainnerNegativo.TabIndex = 3
        Me.RadioWainnerNegativo.TabStop = True
        Me.RadioWainnerNegativo.Text = "Negativo"
        Me.RadioWainnerNegativo.UseVisualStyleBackColor = True
        '
        'RadioWainnerPositivo
        '
        Me.RadioWainnerPositivo.AutoSize = True
        Me.RadioWainnerPositivo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioWainnerPositivo.Location = New System.Drawing.Point(461, 13)
        Me.RadioWainnerPositivo.Name = "RadioWainnerPositivo"
        Me.RadioWainnerPositivo.Size = New System.Drawing.Size(75, 21)
        Me.RadioWainnerPositivo.TabIndex = 4
        Me.RadioWainnerPositivo.Text = "Positivo"
        Me.RadioWainnerPositivo.UseVisualStyleBackColor = True
        '
        'GrxTestHoffman
        '
        Me.GrxTestHoffman.Controls.Add(Me.RadioButton1)
        Me.GrxTestHoffman.Controls.Add(Me.RadioHoffmanDesviacion)
        Me.GrxTestHoffman.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrxTestHoffman.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxTestHoffman.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GrxTestHoffman.Location = New System.Drawing.Point(27, 146)
        Me.GrxTestHoffman.Name = "GrxTestHoffman"
        Me.GrxTestHoffman.Size = New System.Drawing.Size(642, 40)
        Me.GrxTestHoffman.TabIndex = 5
        Me.GrxTestHoffman.TabStop = False
        Me.GrxTestHoffman.Text = "Test de Hoffman y signo de Babinski"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(551, 13)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(82, 21)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Negativo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioHoffmanDesviacion
        '
        Me.RadioHoffmanDesviacion.AutoSize = True
        Me.RadioHoffmanDesviacion.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioHoffmanDesviacion.Location = New System.Drawing.Point(364, 13)
        Me.RadioHoffmanDesviacion.Name = "RadioHoffmanDesviacion"
        Me.RadioHoffmanDesviacion.Size = New System.Drawing.Size(172, 21)
        Me.RadioHoffmanDesviacion.TabIndex = 4
        Me.RadioHoffmanDesviacion.Text = "Desviacion de la marcha"
        Me.RadioHoffmanDesviacion.UseVisualStyleBackColor = True
        '
        'GrxtestPercusion
        '
        Me.GrxtestPercusion.Controls.Add(Me.RadioPercusionNegativo)
        Me.GrxtestPercusion.Controls.Add(Me.RadioPercusionPositivo)
        Me.GrxtestPercusion.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrxtestPercusion.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxtestPercusion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GrxtestPercusion.Location = New System.Drawing.Point(27, 186)
        Me.GrxtestPercusion.Name = "GrxtestPercusion"
        Me.GrxtestPercusion.Size = New System.Drawing.Size(642, 40)
        Me.GrxtestPercusion.TabIndex = 4
        Me.GrxtestPercusion.TabStop = False
        Me.GrxtestPercusion.Text = "Test de percusion rotulo pubiana"
        '
        'RadioPercusionNegativo
        '
        Me.RadioPercusionNegativo.AutoSize = True
        Me.RadioPercusionNegativo.Checked = True
        Me.RadioPercusionNegativo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioPercusionNegativo.Location = New System.Drawing.Point(551, 13)
        Me.RadioPercusionNegativo.Name = "RadioPercusionNegativo"
        Me.RadioPercusionNegativo.Size = New System.Drawing.Size(82, 21)
        Me.RadioPercusionNegativo.TabIndex = 3
        Me.RadioPercusionNegativo.TabStop = True
        Me.RadioPercusionNegativo.Text = "Negativo"
        Me.RadioPercusionNegativo.UseVisualStyleBackColor = True
        '
        'RadioPercusionPositivo
        '
        Me.RadioPercusionPositivo.AutoSize = True
        Me.RadioPercusionPositivo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioPercusionPositivo.Location = New System.Drawing.Point(461, 13)
        Me.RadioPercusionPositivo.Name = "RadioPercusionPositivo"
        Me.RadioPercusionPositivo.Size = New System.Drawing.Size(75, 21)
        Me.RadioPercusionPositivo.TabIndex = 4
        Me.RadioPercusionPositivo.Text = "Positivo"
        Me.RadioPercusionPositivo.UseVisualStyleBackColor = True
        '
        'GrxBotonesGuardarCancelarContinuar
        '
        Me.GrxBotonesGuardarCancelarContinuar.Controls.Add(Me.BtnVolverAEntrevista)
        Me.GrxBotonesGuardarCancelarContinuar.Controls.Add(Me.BtnExploracionCancelar)
        Me.GrxBotonesGuardarCancelarContinuar.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxBotonesGuardarCancelarContinuar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrxBotonesGuardarCancelarContinuar.Location = New System.Drawing.Point(12, 894)
        Me.GrxBotonesGuardarCancelarContinuar.Name = "GrxBotonesGuardarCancelarContinuar"
        Me.GrxBotonesGuardarCancelarContinuar.Size = New System.Drawing.Size(731, 86)
        Me.GrxBotonesGuardarCancelarContinuar.TabIndex = 8
        Me.GrxBotonesGuardarCancelarContinuar.TabStop = False
        '
        'BtnVolverAEntrevista
        '
        Me.BtnVolverAEntrevista.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnVolverAEntrevista.FlatAppearance.BorderSize = 0
        Me.BtnVolverAEntrevista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolverAEntrevista.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolverAEntrevista.Location = New System.Drawing.Point(19, 23)
        Me.BtnVolverAEntrevista.MaximumSize = New System.Drawing.Size(260, 42)
        Me.BtnVolverAEntrevista.Name = "BtnVolverAEntrevista"
        Me.BtnVolverAEntrevista.Size = New System.Drawing.Size(260, 42)
        Me.BtnVolverAEntrevista.TabIndex = 6
        Me.BtnVolverAEntrevista.Text = "<<< Volver a entrevista"
        Me.BtnVolverAEntrevista.UseVisualStyleBackColor = False
        '
        'BtnExploracionCancelar
        '
        Me.BtnExploracionCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnExploracionCancelar.FlatAppearance.BorderSize = 0
        Me.BtnExploracionCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExploracionCancelar.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExploracionCancelar.Location = New System.Drawing.Point(597, 23)
        Me.BtnExploracionCancelar.Name = "BtnExploracionCancelar"
        Me.BtnExploracionCancelar.Size = New System.Drawing.Size(117, 42)
        Me.BtnExploracionCancelar.TabIndex = 5
        Me.BtnExploracionCancelar.Text = "Cancelar"
        Me.BtnExploracionCancelar.UseVisualStyleBackColor = False
        '
        'GrxCambiarContinurDiagnostico
        '
        Me.GrxCambiarContinurDiagnostico.Controls.Add(Me.BtnContinuarADiagnostico)
        Me.GrxCambiarContinurDiagnostico.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxCambiarContinurDiagnostico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrxCambiarContinurDiagnostico.Location = New System.Drawing.Point(755, 894)
        Me.GrxCambiarContinurDiagnostico.Name = "GrxCambiarContinurDiagnostico"
        Me.GrxCambiarContinurDiagnostico.Size = New System.Drawing.Size(739, 86)
        Me.GrxCambiarContinurDiagnostico.TabIndex = 10
        Me.GrxCambiarContinurDiagnostico.TabStop = False
        '
        'BtnContinuarADiagnostico
        '
        Me.BtnContinuarADiagnostico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnContinuarADiagnostico.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnContinuarADiagnostico.FlatAppearance.BorderSize = 0
        Me.BtnContinuarADiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnContinuarADiagnostico.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContinuarADiagnostico.Location = New System.Drawing.Point(479, 29)
        Me.BtnContinuarADiagnostico.Name = "BtnContinuarADiagnostico"
        Me.BtnContinuarADiagnostico.Size = New System.Drawing.Size(260, 42)
        Me.BtnContinuarADiagnostico.TabIndex = 5
        Me.BtnContinuarADiagnostico.Text = "Continuar a pre/diagnostico >>>"
        Me.BtnContinuarADiagnostico.UseVisualStyleBackColor = False
        '
        'GrxComportamientoDelDolor
        '
        Me.GrxComportamientoDelDolor.Controls.Add(Me.GrxInteriorAComportamientoDolor)
        Me.GrxComportamientoDelDolor.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrxComportamientoDelDolor.Font = New System.Drawing.Font("Ubuntu", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxComportamientoDelDolor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.GrxComportamientoDelDolor.Location = New System.Drawing.Point(12, 501)
        Me.GrxComportamientoDelDolor.Margin = New System.Windows.Forms.Padding(0)
        Me.GrxComportamientoDelDolor.MaximumSize = New System.Drawing.Size(1000, 1063)
        Me.GrxComportamientoDelDolor.Name = "GrxComportamientoDelDolor"
        Me.GrxComportamientoDelDolor.Size = New System.Drawing.Size(731, 392)
        Me.GrxComportamientoDelDolor.TabIndex = 8
        Me.GrxComportamientoDelDolor.TabStop = False
        Me.GrxComportamientoDelDolor.Text = "Comportamiento del dolor"
        '
        'GrxInteriorAComportamientoDolor
        '
        Me.GrxInteriorAComportamientoDolor.Controls.Add(Me.GrxvariaConMovimiento)
        Me.GrxInteriorAComportamientoDolor.Controls.Add(Me.RadioAgudoEIntensoSinRazonAparente)
        Me.GrxInteriorAComportamientoDolor.Controls.Add(Me.RadioDolorSinDolor)
        Me.GrxInteriorAComportamientoDolor.Controls.Add(Me.RadioVariaConMovimiento)
        Me.GrxInteriorAComportamientoDolor.Controls.Add(Me.GrxAgudoIntenso)
        Me.GrxInteriorAComportamientoDolor.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrxInteriorAComportamientoDolor.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxInteriorAComportamientoDolor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GrxInteriorAComportamientoDolor.Location = New System.Drawing.Point(26, 39)
        Me.GrxInteriorAComportamientoDolor.Name = "GrxInteriorAComportamientoDolor"
        Me.GrxInteriorAComportamientoDolor.Size = New System.Drawing.Size(697, 353)
        Me.GrxInteriorAComportamientoDolor.TabIndex = 6
        Me.GrxInteriorAComportamientoDolor.TabStop = False
        '
        'GrxvariaConMovimiento
        '
        Me.GrxvariaConMovimiento.Controls.Add(Me.GrxMejoraEnReposo)
        Me.GrxvariaConMovimiento.Controls.Add(Me.GrxDolornocturno)
        Me.GrxvariaConMovimiento.Controls.Add(Me.RadioVariaMovSi)
        Me.GrxvariaConMovimiento.Controls.Add(Me.RadioVariaMovNo)
        Me.GrxvariaConMovimiento.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrxvariaConMovimiento.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxvariaConMovimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GrxvariaConMovimiento.Location = New System.Drawing.Point(-2, 48)
        Me.GrxvariaConMovimiento.Name = "GrxvariaConMovimiento"
        Me.GrxvariaConMovimiento.Size = New System.Drawing.Size(684, 299)
        Me.GrxvariaConMovimiento.TabIndex = 3
        Me.GrxvariaConMovimiento.TabStop = False
        Me.GrxvariaConMovimiento.Text = "Varia con el movimiento"
        Me.GrxvariaConMovimiento.Visible = False
        '
        'GrxMejoraEnReposo
        '
        Me.GrxMejoraEnReposo.Controls.Add(Me.GrxPeorConActividad)
        Me.GrxMejoraEnReposo.Controls.Add(Me.RadioMejoraReposoSi)
        Me.GrxMejoraEnReposo.Controls.Add(Me.RadioMejoraReposoNo)
        Me.GrxMejoraEnReposo.Controls.Add(Me.GrxDolorInflamatorio)
        Me.GrxMejoraEnReposo.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxMejoraEnReposo.Location = New System.Drawing.Point(7, 41)
        Me.GrxMejoraEnReposo.Name = "GrxMejoraEnReposo"
        Me.GrxMejoraEnReposo.Size = New System.Drawing.Size(638, 241)
        Me.GrxMejoraEnReposo.TabIndex = 6
        Me.GrxMejoraEnReposo.TabStop = False
        Me.GrxMejoraEnReposo.Text = "Mejora en reposo"
        Me.GrxMejoraEnReposo.Visible = False
        '
        'GrxPeorConActividad
        '
        Me.GrxPeorConActividad.Controls.Add(Me.GrxDolorMecanico)
        Me.GrxPeorConActividad.Controls.Add(Me.RadioPeorConActividadSi)
        Me.GrxPeorConActividad.Controls.Add(Me.RadioPeorConActividadNo)
        Me.GrxPeorConActividad.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxPeorConActividad.Location = New System.Drawing.Point(20, 57)
        Me.GrxPeorConActividad.Name = "GrxPeorConActividad"
        Me.GrxPeorConActividad.Size = New System.Drawing.Size(580, 178)
        Me.GrxPeorConActividad.TabIndex = 9
        Me.GrxPeorConActividad.TabStop = False
        Me.GrxPeorConActividad.Text = "Peor con la actividad"
        Me.GrxPeorConActividad.Visible = False
        '
        'GrxDolorMecanico
        '
        Me.GrxDolorMecanico.Controls.Add(Me.GrxDolorIrradiado)
        Me.GrxDolorMecanico.Controls.Add(Me.RadioDolorMecanicoSi)
        Me.GrxDolorMecanico.Controls.Add(Me.RadioDolorMecanicoNo)
        Me.GrxDolorMecanico.Controls.Add(Me.LblFuerte)
        Me.GrxDolorMecanico.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxDolorMecanico.Location = New System.Drawing.Point(20, 42)
        Me.GrxDolorMecanico.Name = "GrxDolorMecanico"
        Me.GrxDolorMecanico.Size = New System.Drawing.Size(553, 130)
        Me.GrxDolorMecanico.TabIndex = 10
        Me.GrxDolorMecanico.TabStop = False
        Me.GrxDolorMecanico.Text = "Dolor mecanico"
        Me.GrxDolorMecanico.Visible = False
        '
        'GrxDolorIrradiado
        '
        Me.GrxDolorIrradiado.Controls.Add(Me.LblVolveraSintomasNeurologicos)
        Me.GrxDolorIrradiado.Controls.Add(Me.RadioDolorIrradiadoNo)
        Me.GrxDolorIrradiado.Controls.Add(Me.RadioDolorIrradiadoSi)
        Me.GrxDolorIrradiado.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxDolorIrradiado.Location = New System.Drawing.Point(6, 57)
        Me.GrxDolorIrradiado.Name = "GrxDolorIrradiado"
        Me.GrxDolorIrradiado.Size = New System.Drawing.Size(534, 56)
        Me.GrxDolorIrradiado.TabIndex = 9
        Me.GrxDolorIrradiado.TabStop = False
        Me.GrxDolorIrradiado.Text = "Dolor irradiado"
        Me.GrxDolorIrradiado.Visible = False
        '
        'LblVolveraSintomasNeurologicos
        '
        Me.LblVolveraSintomasNeurologicos.AutoSize = True
        Me.LblVolveraSintomasNeurologicos.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVolveraSintomasNeurologicos.ForeColor = System.Drawing.Color.DarkRed
        Me.LblVolveraSintomasNeurologicos.Location = New System.Drawing.Point(14, 26)
        Me.LblVolveraSintomasNeurologicos.Name = "LblVolveraSintomasNeurologicos"
        Me.LblVolveraSintomasNeurologicos.Size = New System.Drawing.Size(323, 17)
        Me.LblVolveraSintomasNeurologicos.TabIndex = 13
        Me.LblVolveraSintomasNeurologicos.Text = "*Volver a Sintomas neurologicos Slr e Incontinencias"
        Me.LblVolveraSintomasNeurologicos.Visible = False
        '
        'RadioDolorIrradiadoNo
        '
        Me.RadioDolorIrradiadoNo.AutoSize = True
        Me.RadioDolorIrradiadoNo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioDolorIrradiadoNo.Location = New System.Drawing.Point(488, 13)
        Me.RadioDolorIrradiadoNo.Name = "RadioDolorIrradiadoNo"
        Me.RadioDolorIrradiadoNo.Size = New System.Drawing.Size(43, 21)
        Me.RadioDolorIrradiadoNo.TabIndex = 7
        Me.RadioDolorIrradiadoNo.TabStop = True
        Me.RadioDolorIrradiadoNo.Text = "No"
        Me.RadioDolorIrradiadoNo.UseVisualStyleBackColor = True
        '
        'RadioDolorIrradiadoSi
        '
        Me.RadioDolorIrradiadoSi.AutoSize = True
        Me.RadioDolorIrradiadoSi.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioDolorIrradiadoSi.Location = New System.Drawing.Point(402, 13)
        Me.RadioDolorIrradiadoSi.Name = "RadioDolorIrradiadoSi"
        Me.RadioDolorIrradiadoSi.Size = New System.Drawing.Size(36, 21)
        Me.RadioDolorIrradiadoSi.TabIndex = 8
        Me.RadioDolorIrradiadoSi.TabStop = True
        Me.RadioDolorIrradiadoSi.Text = "Si"
        Me.RadioDolorIrradiadoSi.UseVisualStyleBackColor = True
        '
        'RadioDolorMecanicoSi
        '
        Me.RadioDolorMecanicoSi.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RadioDolorMecanicoSi.AutoSize = True
        Me.RadioDolorMecanicoSi.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioDolorMecanicoSi.Location = New System.Drawing.Point(406, 30)
        Me.RadioDolorMecanicoSi.Name = "RadioDolorMecanicoSi"
        Me.RadioDolorMecanicoSi.Size = New System.Drawing.Size(36, 21)
        Me.RadioDolorMecanicoSi.TabIndex = 8
        Me.RadioDolorMecanicoSi.TabStop = True
        Me.RadioDolorMecanicoSi.Text = "Si"
        Me.RadioDolorMecanicoSi.UseVisualStyleBackColor = True
        '
        'RadioDolorMecanicoNo
        '
        Me.RadioDolorMecanicoNo.AutoSize = True
        Me.RadioDolorMecanicoNo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioDolorMecanicoNo.Location = New System.Drawing.Point(493, 24)
        Me.RadioDolorMecanicoNo.Name = "RadioDolorMecanicoNo"
        Me.RadioDolorMecanicoNo.Size = New System.Drawing.Size(43, 21)
        Me.RadioDolorMecanicoNo.TabIndex = 7
        Me.RadioDolorMecanicoNo.TabStop = True
        Me.RadioDolorMecanicoNo.Text = "No"
        Me.RadioDolorMecanicoNo.UseVisualStyleBackColor = True
        '
        'LblFuerte
        '
        Me.LblFuerte.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LblFuerte.AutoSize = True
        Me.LblFuerte.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFuerte.Location = New System.Drawing.Point(286, 30)
        Me.LblFuerte.Name = "LblFuerte"
        Me.LblFuerte.Size = New System.Drawing.Size(63, 20)
        Me.LblFuerte.TabIndex = 9
        Me.LblFuerte.Text = "Fuerte?"
        '
        'RadioPeorConActividadSi
        '
        Me.RadioPeorConActividadSi.AutoSize = True
        Me.RadioPeorConActividadSi.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioPeorConActividadSi.Location = New System.Drawing.Point(427, 24)
        Me.RadioPeorConActividadSi.Name = "RadioPeorConActividadSi"
        Me.RadioPeorConActividadSi.Size = New System.Drawing.Size(36, 21)
        Me.RadioPeorConActividadSi.TabIndex = 8
        Me.RadioPeorConActividadSi.TabStop = True
        Me.RadioPeorConActividadSi.Text = "Si"
        Me.RadioPeorConActividadSi.UseVisualStyleBackColor = True
        '
        'RadioPeorConActividadNo
        '
        Me.RadioPeorConActividadNo.AutoSize = True
        Me.RadioPeorConActividadNo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioPeorConActividadNo.Location = New System.Drawing.Point(513, 24)
        Me.RadioPeorConActividadNo.Name = "RadioPeorConActividadNo"
        Me.RadioPeorConActividadNo.Size = New System.Drawing.Size(43, 21)
        Me.RadioPeorConActividadNo.TabIndex = 7
        Me.RadioPeorConActividadNo.TabStop = True
        Me.RadioPeorConActividadNo.Text = "No"
        Me.RadioPeorConActividadNo.UseVisualStyleBackColor = True
        '
        'RadioMejoraReposoSi
        '
        Me.RadioMejoraReposoSi.AutoSize = True
        Me.RadioMejoraReposoSi.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioMejoraReposoSi.Location = New System.Drawing.Point(446, 31)
        Me.RadioMejoraReposoSi.Name = "RadioMejoraReposoSi"
        Me.RadioMejoraReposoSi.Size = New System.Drawing.Size(36, 21)
        Me.RadioMejoraReposoSi.TabIndex = 6
        Me.RadioMejoraReposoSi.TabStop = True
        Me.RadioMejoraReposoSi.Text = "Si"
        Me.RadioMejoraReposoSi.UseVisualStyleBackColor = True
        '
        'RadioMejoraReposoNo
        '
        Me.RadioMejoraReposoNo.AutoSize = True
        Me.RadioMejoraReposoNo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioMejoraReposoNo.Location = New System.Drawing.Point(533, 30)
        Me.RadioMejoraReposoNo.Name = "RadioMejoraReposoNo"
        Me.RadioMejoraReposoNo.Size = New System.Drawing.Size(43, 21)
        Me.RadioMejoraReposoNo.TabIndex = 5
        Me.RadioMejoraReposoNo.TabStop = True
        Me.RadioMejoraReposoNo.Text = "No"
        Me.RadioMejoraReposoNo.UseVisualStyleBackColor = True
        '
        'GrxDolorInflamatorio
        '
        Me.GrxDolorInflamatorio.Controls.Add(Me.Label6)
        Me.GrxDolorInflamatorio.Controls.Add(Me.RadioDolorInflamatorioNo)
        Me.GrxDolorInflamatorio.Controls.Add(Me.RadioDolorInflamatorioSi)
        Me.GrxDolorInflamatorio.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxDolorInflamatorio.Location = New System.Drawing.Point(20, 57)
        Me.GrxDolorInflamatorio.Name = "GrxDolorInflamatorio"
        Me.GrxDolorInflamatorio.Size = New System.Drawing.Size(580, 40)
        Me.GrxDolorInflamatorio.TabIndex = 4
        Me.GrxDolorInflamatorio.TabStop = False
        Me.GrxDolorInflamatorio.Text = "Dolor inflamatorio"
        Me.GrxDolorInflamatorio.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(144, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(227, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "*Correlacionar resto de exploracion"
        '
        'RadioDolorInflamatorioNo
        '
        Me.RadioDolorInflamatorioNo.AutoSize = True
        Me.RadioDolorInflamatorioNo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioDolorInflamatorioNo.Location = New System.Drawing.Point(517, 13)
        Me.RadioDolorInflamatorioNo.Name = "RadioDolorInflamatorioNo"
        Me.RadioDolorInflamatorioNo.Size = New System.Drawing.Size(43, 21)
        Me.RadioDolorInflamatorioNo.TabIndex = 7
        Me.RadioDolorInflamatorioNo.TabStop = True
        Me.RadioDolorInflamatorioNo.Text = "No"
        Me.RadioDolorInflamatorioNo.UseVisualStyleBackColor = True
        '
        'RadioDolorInflamatorioSi
        '
        Me.RadioDolorInflamatorioSi.AutoSize = True
        Me.RadioDolorInflamatorioSi.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioDolorInflamatorioSi.Location = New System.Drawing.Point(427, 13)
        Me.RadioDolorInflamatorioSi.Name = "RadioDolorInflamatorioSi"
        Me.RadioDolorInflamatorioSi.Size = New System.Drawing.Size(36, 21)
        Me.RadioDolorInflamatorioSi.TabIndex = 8
        Me.RadioDolorInflamatorioSi.TabStop = True
        Me.RadioDolorInflamatorioSi.Text = "Si"
        Me.RadioDolorInflamatorioSi.UseVisualStyleBackColor = True
        '
        'GrxDolornocturno
        '
        Me.GrxDolornocturno.Controls.Add(Me.RadioNocturnoSi)
        Me.GrxDolornocturno.Controls.Add(Me.RadionocturnoNo)
        Me.GrxDolornocturno.Controls.Add(Me.RadioNocturnoSiMucho)
        Me.GrxDolornocturno.Controls.Add(Me.GrxCambioPostura)
        Me.GrxDolornocturno.Controls.Add(Me.GrxMejoraConMedicacion)
        Me.GrxDolornocturno.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrxDolornocturno.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxDolornocturno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GrxDolornocturno.Location = New System.Drawing.Point(7, 42)
        Me.GrxDolornocturno.Name = "GrxDolornocturno"
        Me.GrxDolornocturno.Size = New System.Drawing.Size(642, 236)
        Me.GrxDolornocturno.TabIndex = 10
        Me.GrxDolornocturno.TabStop = False
        Me.GrxDolornocturno.Text = "Dolor nocturno"
        Me.GrxDolornocturno.Visible = False
        '
        'RadioNocturnoSi
        '
        Me.RadioNocturnoSi.AutoSize = True
        Me.RadioNocturnoSi.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioNocturnoSi.Location = New System.Drawing.Point(405, 17)
        Me.RadioNocturnoSi.Name = "RadioNocturnoSi"
        Me.RadioNocturnoSi.Size = New System.Drawing.Size(36, 21)
        Me.RadioNocturnoSi.TabIndex = 9
        Me.RadioNocturnoSi.Text = "Si"
        Me.RadioNocturnoSi.UseVisualStyleBackColor = True
        '
        'RadionocturnoNo
        '
        Me.RadionocturnoNo.AutoSize = True
        Me.RadionocturnoNo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadionocturnoNo.Location = New System.Drawing.Point(538, 17)
        Me.RadionocturnoNo.Name = "RadionocturnoNo"
        Me.RadionocturnoNo.Size = New System.Drawing.Size(66, 21)
        Me.RadionocturnoNo.TabIndex = 7
        Me.RadionocturnoNo.Text = "Volver"
        Me.RadionocturnoNo.UseVisualStyleBackColor = True
        '
        'RadioNocturnoSiMucho
        '
        Me.RadioNocturnoSiMucho.AutoSize = True
        Me.RadioNocturnoSiMucho.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioNocturnoSiMucho.Location = New System.Drawing.Point(447, 17)
        Me.RadioNocturnoSiMucho.Name = "RadioNocturnoSiMucho"
        Me.RadioNocturnoSiMucho.Size = New System.Drawing.Size(83, 21)
        Me.RadioNocturnoSiMucho.TabIndex = 8
        Me.RadioNocturnoSiMucho.Text = "Si, mucho"
        Me.RadioNocturnoSiMucho.UseVisualStyleBackColor = True
        '
        'GrxCambioPostura
        '
        Me.GrxCambioPostura.Controls.Add(Me.LblCorrelacionaExploracion)
        Me.GrxCambioPostura.Controls.Add(Me.RadiocambioPosturaSi)
        Me.GrxCambioPostura.Controls.Add(Me.RadiocambioPosturaNo)
        Me.GrxCambioPostura.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxCambioPostura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GrxCambioPostura.Location = New System.Drawing.Point(20, 58)
        Me.GrxCambioPostura.Name = "GrxCambioPostura"
        Me.GrxCambioPostura.Size = New System.Drawing.Size(585, 105)
        Me.GrxCambioPostura.TabIndex = 4
        Me.GrxCambioPostura.TabStop = False
        Me.GrxCambioPostura.Text = "Cambios de postura o movimiento alivian"
        Me.GrxCambioPostura.Visible = False
        '
        'LblCorrelacionaExploracion
        '
        Me.LblCorrelacionaExploracion.AutoSize = True
        Me.LblCorrelacionaExploracion.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorrelacionaExploracion.ForeColor = System.Drawing.Color.DarkRed
        Me.LblCorrelacionaExploracion.Location = New System.Drawing.Point(47, 57)
        Me.LblCorrelacionaExploracion.Name = "LblCorrelacionaExploracion"
        Me.LblCorrelacionaExploracion.Size = New System.Drawing.Size(267, 20)
        Me.LblCorrelacionaExploracion.TabIndex = 10
        Me.LblCorrelacionaExploracion.Text = "*Correlacionar resto de exploracion"
        Me.LblCorrelacionaExploracion.Visible = False
        '
        'RadiocambioPosturaSi
        '
        Me.RadiocambioPosturaSi.AutoSize = True
        Me.RadiocambioPosturaSi.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadiocambioPosturaSi.Location = New System.Drawing.Point(431, 15)
        Me.RadiocambioPosturaSi.Name = "RadiocambioPosturaSi"
        Me.RadiocambioPosturaSi.Size = New System.Drawing.Size(36, 21)
        Me.RadiocambioPosturaSi.TabIndex = 9
        Me.RadiocambioPosturaSi.Text = "Si"
        Me.RadiocambioPosturaSi.UseVisualStyleBackColor = True
        '
        'RadiocambioPosturaNo
        '
        Me.RadiocambioPosturaNo.AutoSize = True
        Me.RadiocambioPosturaNo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadiocambioPosturaNo.Location = New System.Drawing.Point(519, 13)
        Me.RadiocambioPosturaNo.Name = "RadiocambioPosturaNo"
        Me.RadiocambioPosturaNo.Size = New System.Drawing.Size(43, 21)
        Me.RadiocambioPosturaNo.TabIndex = 7
        Me.RadiocambioPosturaNo.Text = "No"
        Me.RadiocambioPosturaNo.UseVisualStyleBackColor = True
        '
        'GrxMejoraConMedicacion
        '
        Me.GrxMejoraConMedicacion.Controls.Add(Me.LblCorrelacionaConMedicacion)
        Me.GrxMejoraConMedicacion.Controls.Add(Me.RadioMejoramedicacionNo)
        Me.GrxMejoraConMedicacion.Controls.Add(Me.RadioMejoramedicacionSi)
        Me.GrxMejoraConMedicacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrxMejoraConMedicacion.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxMejoraConMedicacion.Location = New System.Drawing.Point(20, 58)
        Me.GrxMejoraConMedicacion.Name = "GrxMejoraConMedicacion"
        Me.GrxMejoraConMedicacion.Size = New System.Drawing.Size(580, 105)
        Me.GrxMejoraConMedicacion.TabIndex = 10
        Me.GrxMejoraConMedicacion.TabStop = False
        Me.GrxMejoraConMedicacion.Text = "Mejora con la medicacion"
        Me.GrxMejoraConMedicacion.Visible = False
        '
        'LblCorrelacionaConMedicacion
        '
        Me.LblCorrelacionaConMedicacion.AutoSize = True
        Me.LblCorrelacionaConMedicacion.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorrelacionaConMedicacion.ForeColor = System.Drawing.Color.DarkRed
        Me.LblCorrelacionaConMedicacion.Location = New System.Drawing.Point(47, 57)
        Me.LblCorrelacionaConMedicacion.Name = "LblCorrelacionaConMedicacion"
        Me.LblCorrelacionaConMedicacion.Size = New System.Drawing.Size(300, 17)
        Me.LblCorrelacionaConMedicacion.TabIndex = 11
        Me.LblCorrelacionaConMedicacion.Text = "*Correlacionar tipo de medicacion con la mejora"
        Me.LblCorrelacionaConMedicacion.Visible = False
        '
        'RadioMejoramedicacionNo
        '
        Me.RadioMejoramedicacionNo.AutoSize = True
        Me.RadioMejoramedicacionNo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioMejoramedicacionNo.Location = New System.Drawing.Point(517, 16)
        Me.RadioMejoramedicacionNo.Name = "RadioMejoramedicacionNo"
        Me.RadioMejoramedicacionNo.Size = New System.Drawing.Size(43, 21)
        Me.RadioMejoramedicacionNo.TabIndex = 7
        Me.RadioMejoramedicacionNo.TabStop = True
        Me.RadioMejoramedicacionNo.Text = "No"
        Me.RadioMejoramedicacionNo.UseVisualStyleBackColor = True
        '
        'RadioMejoramedicacionSi
        '
        Me.RadioMejoramedicacionSi.AutoSize = True
        Me.RadioMejoramedicacionSi.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioMejoramedicacionSi.Location = New System.Drawing.Point(426, 15)
        Me.RadioMejoramedicacionSi.Name = "RadioMejoramedicacionSi"
        Me.RadioMejoramedicacionSi.Size = New System.Drawing.Size(36, 21)
        Me.RadioMejoramedicacionSi.TabIndex = 8
        Me.RadioMejoramedicacionSi.TabStop = True
        Me.RadioMejoramedicacionSi.Text = "Si"
        Me.RadioMejoramedicacionSi.UseVisualStyleBackColor = True
        '
        'RadioVariaMovSi
        '
        Me.RadioVariaMovSi.AutoSize = True
        Me.RadioVariaMovSi.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioVariaMovSi.Location = New System.Drawing.Point(457, 16)
        Me.RadioVariaMovSi.Name = "RadioVariaMovSi"
        Me.RadioVariaMovSi.Size = New System.Drawing.Size(36, 21)
        Me.RadioVariaMovSi.TabIndex = 4
        Me.RadioVariaMovSi.TabStop = True
        Me.RadioVariaMovSi.Text = "Si"
        Me.RadioVariaMovSi.UseVisualStyleBackColor = True
        '
        'RadioVariaMovNo
        '
        Me.RadioVariaMovNo.AutoSize = True
        Me.RadioVariaMovNo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioVariaMovNo.Location = New System.Drawing.Point(545, 16)
        Me.RadioVariaMovNo.Name = "RadioVariaMovNo"
        Me.RadioVariaMovNo.Size = New System.Drawing.Size(43, 21)
        Me.RadioVariaMovNo.TabIndex = 3
        Me.RadioVariaMovNo.TabStop = True
        Me.RadioVariaMovNo.Text = "No"
        Me.RadioVariaMovNo.UseVisualStyleBackColor = True
        '
        'RadioAgudoEIntensoSinRazonAparente
        '
        Me.RadioAgudoEIntensoSinRazonAparente.AutoSize = True
        Me.RadioAgudoEIntensoSinRazonAparente.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioAgudoEIntensoSinRazonAparente.Location = New System.Drawing.Point(39, 18)
        Me.RadioAgudoEIntensoSinRazonAparente.Name = "RadioAgudoEIntensoSinRazonAparente"
        Me.RadioAgudoEIntensoSinRazonAparente.Size = New System.Drawing.Size(239, 21)
        Me.RadioAgudoEIntensoSinRazonAparente.TabIndex = 3
        Me.RadioAgudoEIntensoSinRazonAparente.Text = "Agudo e intenso sin razon aparente"
        Me.RadioAgudoEIntensoSinRazonAparente.UseVisualStyleBackColor = True
        '
        'RadioDolorSinDolor
        '
        Me.RadioDolorSinDolor.AutoSize = True
        Me.RadioDolorSinDolor.Checked = True
        Me.RadioDolorSinDolor.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioDolorSinDolor.Location = New System.Drawing.Point(544, 18)
        Me.RadioDolorSinDolor.Name = "RadioDolorSinDolor"
        Me.RadioDolorSinDolor.Size = New System.Drawing.Size(79, 21)
        Me.RadioDolorSinDolor.TabIndex = 2
        Me.RadioDolorSinDolor.TabStop = True
        Me.RadioDolorSinDolor.Text = "Sin dolor"
        Me.RadioDolorSinDolor.UseVisualStyleBackColor = True
        '
        'RadioVariaConMovimiento
        '
        Me.RadioVariaConMovimiento.AutoSize = True
        Me.RadioVariaConMovimiento.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioVariaConMovimiento.Location = New System.Drawing.Point(346, 18)
        Me.RadioVariaConMovimiento.Name = "RadioVariaConMovimiento"
        Me.RadioVariaConMovimiento.Size = New System.Drawing.Size(172, 21)
        Me.RadioVariaConMovimiento.TabIndex = 2
        Me.RadioVariaConMovimiento.Text = "Varia con el movimiento"
        Me.RadioVariaConMovimiento.UseVisualStyleBackColor = True
        '
        'GrxAgudoIntenso
        '
        Me.GrxAgudoIntenso.Controls.Add(Me.RadioPalpitantePunzante)
        Me.GrxAgudoIntenso.Controls.Add(Me.RadioAgudoIntensoNegativo)
        Me.GrxAgudoIntenso.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxAgudoIntenso.Location = New System.Drawing.Point(6, 45)
        Me.GrxAgudoIntenso.Name = "GrxAgudoIntenso"
        Me.GrxAgudoIntenso.Size = New System.Drawing.Size(675, 40)
        Me.GrxAgudoIntenso.TabIndex = 2
        Me.GrxAgudoIntenso.TabStop = False
        Me.GrxAgudoIntenso.Text = "Agudo e intenso sin razon aparente"
        Me.GrxAgudoIntenso.Visible = False
        '
        'RadioPalpitantePunzante
        '
        Me.RadioPalpitantePunzante.AutoSize = True
        Me.RadioPalpitantePunzante.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioPalpitantePunzante.Location = New System.Drawing.Point(341, 13)
        Me.RadioPalpitantePunzante.Name = "RadioPalpitantePunzante"
        Me.RadioPalpitantePunzante.Size = New System.Drawing.Size(159, 21)
        Me.RadioPalpitantePunzante.TabIndex = 3
        Me.RadioPalpitantePunzante.Text = "Palpitante y punzante"
        Me.RadioPalpitantePunzante.UseVisualStyleBackColor = True
        '
        'RadioAgudoIntensoNegativo
        '
        Me.RadioAgudoIntensoNegativo.AutoSize = True
        Me.RadioAgudoIntensoNegativo.Checked = True
        Me.RadioAgudoIntensoNegativo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioAgudoIntensoNegativo.Location = New System.Drawing.Point(539, 13)
        Me.RadioAgudoIntensoNegativo.Name = "RadioAgudoIntensoNegativo"
        Me.RadioAgudoIntensoNegativo.Size = New System.Drawing.Size(82, 21)
        Me.RadioAgudoIntensoNegativo.TabIndex = 2
        Me.RadioAgudoIntensoNegativo.TabStop = True
        Me.RadioAgudoIntensoNegativo.Text = "Negativo"
        Me.RadioAgudoIntensoNegativo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Banderas del comportamiento del dolor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 26)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Banderas de la exploracion"
        '
        'LbxSintomasExploracion
        '
        Me.LbxSintomasExploracion.BackColor = System.Drawing.Color.Gainsboro
        Me.LbxSintomasExploracion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LbxSintomasExploracion.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbxSintomasExploracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbxSintomasExploracion.ForeColor = System.Drawing.Color.Red
        Me.LbxSintomasExploracion.FormattingEnabled = True
        Me.LbxSintomasExploracion.ItemHeight = 16
        Me.LbxSintomasExploracion.Location = New System.Drawing.Point(13, 124)
        Me.LbxSintomasExploracion.Name = "LbxSintomasExploracion"
        Me.LbxSintomasExploracion.Size = New System.Drawing.Size(372, 112)
        Me.LbxSintomasExploracion.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Ortopedicos positivos"
        '
        'LbxSintomasNeurologicos
        '
        Me.LbxSintomasNeurologicos.BackColor = System.Drawing.Color.Gainsboro
        Me.LbxSintomasNeurologicos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LbxSintomasNeurologicos.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbxSintomasNeurologicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbxSintomasNeurologicos.ForeColor = System.Drawing.Color.Red
        Me.LbxSintomasNeurologicos.FormattingEnabled = True
        Me.LbxSintomasNeurologicos.ItemHeight = 16
        Me.LbxSintomasNeurologicos.Location = New System.Drawing.Point(13, 283)
        Me.LbxSintomasNeurologicos.Name = "LbxSintomasNeurologicos"
        Me.LbxSintomasNeurologicos.Size = New System.Drawing.Size(372, 64)
        Me.LbxSintomasNeurologicos.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Exploracion neurologica"
        '
        'LbxSintomasDolor
        '
        Me.LbxSintomasDolor.BackColor = System.Drawing.Color.Gainsboro
        Me.LbxSintomasDolor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LbxSintomasDolor.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbxSintomasDolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbxSintomasDolor.ForeColor = System.Drawing.Color.Red
        Me.LbxSintomasDolor.FormattingEnabled = True
        Me.LbxSintomasDolor.ItemHeight = 16
        Me.LbxSintomasDolor.Location = New System.Drawing.Point(13, 405)
        Me.LbxSintomasDolor.Name = "LbxSintomasDolor"
        Me.LbxSintomasDolor.Size = New System.Drawing.Size(372, 176)
        Me.LbxSintomasDolor.TabIndex = 14
        '
        'GrxSintomas
        '
        Me.GrxSintomas.BackColor = System.Drawing.Color.Gainsboro
        Me.GrxSintomas.Controls.Add(Me.Label8)
        Me.GrxSintomas.Controls.Add(Me.Label7)
        Me.GrxSintomas.Controls.Add(Me.LbxSintomasDolor)
        Me.GrxSintomas.Controls.Add(Me.LbxSintomasNeurologicos)
        Me.GrxSintomas.Controls.Add(Me.LbxSintomasExploracion)
        Me.GrxSintomas.Controls.Add(Me.Label4)
        Me.GrxSintomas.Controls.Add(Me.Label3)
        Me.GrxSintomas.Controls.Add(Me.Label2)
        Me.GrxSintomas.Controls.Add(Me.Label1)
        Me.GrxSintomas.Controls.Add(Me.PictureBox1)
        Me.GrxSintomas.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrxSintomas.Font = New System.Drawing.Font("Ubuntu", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxSintomas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.GrxSintomas.Location = New System.Drawing.Point(752, 5)
        Me.GrxSintomas.Name = "GrxSintomas"
        Me.GrxSintomas.Size = New System.Drawing.Size(742, 888)
        Me.GrxSintomas.TabIndex = 16
        Me.GrxSintomas.TabStop = False
        Me.GrxSintomas.Text = "Sintomas "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(527, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Posterior"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(406, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Anterior"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(387, 124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(356, 405)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'FrmExploracionYDolor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1500, 992)
        Me.Controls.Add(Me.GrxSintomas)
        Me.Controls.Add(Me.GrxComportamientoDelDolor)
        Me.Controls.Add(Me.GrxCambiarContinurDiagnostico)
        Me.Controls.Add(Me.GrxBotonesGuardarCancelarContinuar)
        Me.Controls.Add(Me.GrxExploracion)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmExploracionYDolor"
        Me.Text = "FrmExploracion"
        Me.GrxExploracion.ResumeLayout(False)
        Me.GrxExplracionNeurologica.ResumeLayout(False)
        Me.GrxExplracionNeurologica.PerformLayout()
        Me.GrxSintomasNeurologicos.ResumeLayout(False)
        Me.GrxSintomasNeurologicos.PerformLayout()
        Me.GrxIntensoOLeve.ResumeLayout(False)
        Me.GrxIntensoOLeve.PerformLayout()
        Me.GrxIncontinencias.ResumeLayout(False)
        Me.GrxIncontinencias.PerformLayout()
        Me.GrxSLR.ResumeLayout(False)
        Me.GrxSLR.PerformLayout()
        Me.GrxAlodinia.ResumeLayout(False)
        Me.GrxAlodinia.PerformLayout()
        Me.GrxTestOrtopedicospositivos.ResumeLayout(False)
        Me.GrxTestKlein.ResumeLayout(False)
        Me.GrxTestKlein.PerformLayout()
        Me.GrxTestEstabilidadLigamento.ResumeLayout(False)
        Me.GrxTestEstabilidadLigamento.PerformLayout()
        Me.GrxWainerCluster.ResumeLayout(False)
        Me.GrxWainerCluster.PerformLayout()
        Me.GrxTestHoffman.ResumeLayout(False)
        Me.GrxTestHoffman.PerformLayout()
        Me.GrxtestPercusion.ResumeLayout(False)
        Me.GrxtestPercusion.PerformLayout()
        Me.GrxBotonesGuardarCancelarContinuar.ResumeLayout(False)
        Me.GrxCambiarContinurDiagnostico.ResumeLayout(False)
        Me.GrxComportamientoDelDolor.ResumeLayout(False)
        Me.GrxInteriorAComportamientoDolor.ResumeLayout(False)
        Me.GrxInteriorAComportamientoDolor.PerformLayout()
        Me.GrxvariaConMovimiento.ResumeLayout(False)
        Me.GrxvariaConMovimiento.PerformLayout()
        Me.GrxMejoraEnReposo.ResumeLayout(False)
        Me.GrxMejoraEnReposo.PerformLayout()
        Me.GrxPeorConActividad.ResumeLayout(False)
        Me.GrxPeorConActividad.PerformLayout()
        Me.GrxDolorMecanico.ResumeLayout(False)
        Me.GrxDolorMecanico.PerformLayout()
        Me.GrxDolorIrradiado.ResumeLayout(False)
        Me.GrxDolorIrradiado.PerformLayout()
        Me.GrxDolorInflamatorio.ResumeLayout(False)
        Me.GrxDolorInflamatorio.PerformLayout()
        Me.GrxDolornocturno.ResumeLayout(False)
        Me.GrxDolornocturno.PerformLayout()
        Me.GrxCambioPostura.ResumeLayout(False)
        Me.GrxCambioPostura.PerformLayout()
        Me.GrxMejoraConMedicacion.ResumeLayout(False)
        Me.GrxMejoraConMedicacion.PerformLayout()
        Me.GrxAgudoIntenso.ResumeLayout(False)
        Me.GrxAgudoIntenso.PerformLayout()
        Me.GrxSintomas.ResumeLayout(False)
        Me.GrxSintomas.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrxExploracion As GroupBox
    Friend WithEvents GrxTestOrtopedicospositivos As GroupBox
    Friend WithEvents GrxBotonesGuardarCancelarContinuar As GroupBox
    Friend WithEvents BtnVolverAEntrevista As Button
    Friend WithEvents BtnExploracionCancelar As Button
    Friend WithEvents GrxExplracionNeurologica As GroupBox
    Friend WithEvents GrxCambiarContinurDiagnostico As GroupBox
    Friend WithEvents BtnContinuarADiagnostico As Button
    Friend WithEvents GrxAlodinia As GroupBox
    Friend WithEvents RadioAlodiniaSi As RadioButton
    Friend WithEvents GrxSintomasNeurologicos As GroupBox
    Friend WithEvents RadioSLRpositivo As RadioButton
    Friend WithEvents GrxWainerCluster As GroupBox
    Friend WithEvents RadioWainnerNegativo As RadioButton
    Friend WithEvents RadioWainnerPositivo As RadioButton
    Friend WithEvents GrxTestHoffman As GroupBox
    Friend WithEvents RadioHoffmanDesviacion As RadioButton
    Friend WithEvents GrxtestPercusion As GroupBox
    Friend WithEvents RadioPercusionNegativo As RadioButton
    Friend WithEvents RadioPercusionPositivo As RadioButton
    Friend WithEvents GrxTestEstabilidadLigamento As GroupBox
    Friend WithEvents RadioEstabilidadNegativo As RadioButton
    Friend WithEvents RadioEstabilidadPositivo As RadioButton
    Friend WithEvents GrxTestKlein As GroupBox
    Friend WithEvents RadioKleinNegativo As RadioButton
    Friend WithEvents RadioKleinPositivo As RadioButton
    Friend WithEvents GrxComportamientoDelDolor As GroupBox
    Friend WithEvents GrxInteriorAComportamientoDolor As GroupBox
    Friend WithEvents GrxvariaConMovimiento As GroupBox
    Friend WithEvents RadioVariaMovNo As RadioButton
    Friend WithEvents RadioVariaMovSi As RadioButton
    Friend WithEvents GrxAgudoIntenso As GroupBox
    Friend WithEvents RadioAgudoIntensoNegativo As RadioButton
    Friend WithEvents GrxMejoraEnReposo As GroupBox
    Friend WithEvents GrxPeorConActividad As GroupBox
    Friend WithEvents GrxDolorMecanico As GroupBox
    Friend WithEvents RadioDolorMecanicoNo As RadioButton
    Friend WithEvents RadioDolorMecanicoSi As RadioButton
    Friend WithEvents RadioPeorConActividadNo As RadioButton
    Friend WithEvents RadioPeorConActividadSi As RadioButton
    Friend WithEvents GrxDolorInflamatorio As GroupBox
    Friend WithEvents RadioDolorInflamatorioNo As RadioButton
    Friend WithEvents RadioDolorInflamatorioSi As RadioButton
    Friend WithEvents RadioMejoraReposoNo As RadioButton
    Friend WithEvents RadioMejoraReposoSi As RadioButton
    Friend WithEvents RadioPalpitantePunzante As RadioButton
    Friend WithEvents GrxDolorIrradiado As GroupBox
    Friend WithEvents RadioDolorIrradiadoNo As RadioButton
    Friend WithEvents RadioDolorIrradiadoSi As RadioButton
    Friend WithEvents LblFuerte As Label
    Friend WithEvents GrxDolornocturno As GroupBox
    Friend WithEvents RadioNocturnoSi As RadioButton
    Friend WithEvents GrxMejoraConMedicacion As GroupBox
    Friend WithEvents LblCorrelacionaConMedicacion As Label
    Friend WithEvents RadioMejoramedicacionNo As RadioButton
    Friend WithEvents RadioMejoramedicacionSi As RadioButton
    Friend WithEvents RadionocturnoNo As RadioButton
    Friend WithEvents RadioNocturnoSiMucho As RadioButton
    Friend WithEvents GrxCambioPostura As GroupBox
    Friend WithEvents LblCorrelacionaExploracion As Label
    Friend WithEvents RadiocambioPosturaSi As RadioButton
    Friend WithEvents RadiocambioPosturaNo As RadioButton
    Friend WithEvents RadioAgudoEIntensoSinRazonAparente As RadioButton
    Friend WithEvents RadioDolorSinDolor As RadioButton
    Friend WithEvents RadioVariaConMovimiento As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LbxSintomasExploracion As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LbxSintomasNeurologicos As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LbxSintomasDolor As ListBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GrxSLR As GroupBox
    Friend WithEvents GrxIncontinencias As GroupBox
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioIncontinencia As RadioButton
    Friend WithEvents RadioneurologicasGruposCierra As RadioButton
    Friend WithEvents RadioIncontinenciasVergrupo As RadioButton
    Friend WithEvents RadioAlodiniaVergrupo As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents LblVolveraSintomasNeurologicos As Label
    Friend WithEvents GrxIntensoOLeve As GroupBox
    Friend WithEvents RadioNeurologicosIntensos As RadioButton
    Friend WithEvents RadioNeurologicosLeves As RadioButton
    Friend WithEvents LblFisoterapia As Label
    Friend WithEvents GrxSintomas As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
