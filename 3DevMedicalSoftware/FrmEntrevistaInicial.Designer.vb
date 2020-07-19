<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntrevistaInicial
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
        Me.GbxEntrevistaInicial = New System.Windows.Forms.GroupBox()
        Me.GbxMotivosdeConsulta = New System.Windows.Forms.GroupBox()
        Me.TxtMotivoDeLaConsulta = New System.Windows.Forms.TextBox()
        Me.GbxConstantesVitales = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComPulso = New System.Windows.Forms.ComboBox()
        Me.NudfrecuenciaRespiratoria = New System.Windows.Forms.NumericUpDown()
        Me.NudPresionArterialdiast = New System.Windows.Forms.NumericUpDown()
        Me.NudPresionArterialSist = New System.Windows.Forms.NumericUpDown()
        Me.NudFrecuenciacardiaca = New System.Windows.Forms.NumericUpDown()
        Me.NudTemperatura = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GbxInspecciongeneral = New System.Windows.Forms.GroupBox()
        Me.ComGradoDeColaboracion = New System.Windows.Forms.ComboBox()
        Me.ComActitud = New System.Windows.Forms.ComboBox()
        Me.ComMovilidad = New System.Windows.Forms.ComboBox()
        Me.ComGradoDeHidratacion = New System.Windows.Forms.ComboBox()
        Me.ComEstadoDeNutricion = New System.Windows.Forms.ComboBox()
        Me.ComestadoConsciencia = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEntrevistaInicialGuardarYContinuar = New System.Windows.Forms.Button()
        Me.BtnEntrevistaInicialGuardar = New System.Windows.Forms.Button()
        Me.BtnEntrevistaInicialCancelar = New System.Windows.Forms.Button()
        Me.GrxRegistro = New System.Windows.Forms.GroupBox()
        Me.BtnRegistroGuardarYContinuar = New System.Windows.Forms.Button()
        Me.BtnRegistroGuardar = New System.Windows.Forms.Button()
        Me.BtnRegistroCancelar = New System.Windows.Forms.Button()
        Me.PanelDeRegistrosFormularios = New System.Windows.Forms.Panel()
        Me.GbxEntrevistaInicial.SuspendLayout()
        Me.GbxMotivosdeConsulta.SuspendLayout()
        Me.GbxConstantesVitales.SuspendLayout()
        CType(Me.NudfrecuenciaRespiratoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudPresionArterialdiast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudPresionArterialSist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudFrecuenciacardiaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudTemperatura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbxInspecciongeneral.SuspendLayout()
        Me.GrxRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbxEntrevistaInicial
        '
        Me.GbxEntrevistaInicial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GbxEntrevistaInicial.Controls.Add(Me.GbxMotivosdeConsulta)
        Me.GbxEntrevistaInicial.Controls.Add(Me.GbxConstantesVitales)
        Me.GbxEntrevistaInicial.Controls.Add(Me.GbxInspecciongeneral)
        Me.GbxEntrevistaInicial.Controls.Add(Me.BtnEntrevistaInicialGuardarYContinuar)
        Me.GbxEntrevistaInicial.Controls.Add(Me.BtnEntrevistaInicialGuardar)
        Me.GbxEntrevistaInicial.Controls.Add(Me.BtnEntrevistaInicialCancelar)
        Me.GbxEntrevistaInicial.Font = New System.Drawing.Font("Ubuntu", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxEntrevistaInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.GbxEntrevistaInicial.Location = New System.Drawing.Point(32, 26)
        Me.GbxEntrevistaInicial.MaximumSize = New System.Drawing.Size(1000, 1063)
        Me.GbxEntrevistaInicial.Name = "GbxEntrevistaInicial"
        Me.GbxEntrevistaInicial.Size = New System.Drawing.Size(850, 1063)
        Me.GbxEntrevistaInicial.TabIndex = 1
        Me.GbxEntrevistaInicial.TabStop = False
        Me.GbxEntrevistaInicial.Text = "Entrevista Inicial"
        '
        'GbxMotivosdeConsulta
        '
        Me.GbxMotivosdeConsulta.Controls.Add(Me.TxtMotivoDeLaConsulta)
        Me.GbxMotivosdeConsulta.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxMotivosdeConsulta.Location = New System.Drawing.Point(26, 471)
        Me.GbxMotivosdeConsulta.Name = "GbxMotivosdeConsulta"
        Me.GbxMotivosdeConsulta.Size = New System.Drawing.Size(798, 189)
        Me.GbxMotivosdeConsulta.TabIndex = 6
        Me.GbxMotivosdeConsulta.TabStop = False
        Me.GbxMotivosdeConsulta.Text = "Motivo de la consulta"
        '
        'TxtMotivoDeLaConsulta
        '
        Me.TxtMotivoDeLaConsulta.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMotivoDeLaConsulta.Location = New System.Drawing.Point(25, 41)
        Me.TxtMotivoDeLaConsulta.Multiline = True
        Me.TxtMotivoDeLaConsulta.Name = "TxtMotivoDeLaConsulta"
        Me.TxtMotivoDeLaConsulta.Size = New System.Drawing.Size(752, 123)
        Me.TxtMotivoDeLaConsulta.TabIndex = 0
        '
        'GbxConstantesVitales
        '
        Me.GbxConstantesVitales.Controls.Add(Me.Label16)
        Me.GbxConstantesVitales.Controls.Add(Me.Label15)
        Me.GbxConstantesVitales.Controls.Add(Me.Label7)
        Me.GbxConstantesVitales.Controls.Add(Me.ComPulso)
        Me.GbxConstantesVitales.Controls.Add(Me.NudfrecuenciaRespiratoria)
        Me.GbxConstantesVitales.Controls.Add(Me.NudPresionArterialdiast)
        Me.GbxConstantesVitales.Controls.Add(Me.NudPresionArterialSist)
        Me.GbxConstantesVitales.Controls.Add(Me.NudFrecuenciacardiaca)
        Me.GbxConstantesVitales.Controls.Add(Me.NudTemperatura)
        Me.GbxConstantesVitales.Controls.Add(Me.Label8)
        Me.GbxConstantesVitales.Controls.Add(Me.Label10)
        Me.GbxConstantesVitales.Controls.Add(Me.Label14)
        Me.GbxConstantesVitales.Controls.Add(Me.Label13)
        Me.GbxConstantesVitales.Controls.Add(Me.Label9)
        Me.GbxConstantesVitales.Controls.Add(Me.Label11)
        Me.GbxConstantesVitales.Controls.Add(Me.Label12)
        Me.GbxConstantesVitales.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxConstantesVitales.Location = New System.Drawing.Point(26, 259)
        Me.GbxConstantesVitales.Name = "GbxConstantesVitales"
        Me.GbxConstantesVitales.Size = New System.Drawing.Size(798, 188)
        Me.GbxConstantesVitales.TabIndex = 6
        Me.GbxConstantesVitales.TabStop = False
        Me.GbxConstantesVitales.Text = "Constantes Vitales"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(609, 90)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 20)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Resp /min"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(234, 90)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 20)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Lat /min"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(218, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "°"
        '
        'ComPulso
        '
        Me.ComPulso.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComPulso.FormattingEnabled = True
        Me.ComPulso.Items.AddRange(New Object() {"Fuerte", "Debil", "Filiforme"})
        Me.ComPulso.Location = New System.Drawing.Point(535, 39)
        Me.ComPulso.Name = "ComPulso"
        Me.ComPulso.Size = New System.Drawing.Size(242, 28)
        Me.ComPulso.TabIndex = 2
        '
        'NudfrecuenciaRespiratoria
        '
        Me.NudfrecuenciaRespiratoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NudfrecuenciaRespiratoria.Location = New System.Drawing.Point(537, 86)
        Me.NudfrecuenciaRespiratoria.Maximum = New Decimal(New Integer() {70, 0, 0, 0})
        Me.NudfrecuenciaRespiratoria.Name = "NudfrecuenciaRespiratoria"
        Me.NudfrecuenciaRespiratoria.Size = New System.Drawing.Size(70, 28)
        Me.NudfrecuenciaRespiratoria.TabIndex = 1
        Me.NudfrecuenciaRespiratoria.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'NudPresionArterialdiast
        '
        Me.NudPresionArterialdiast.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NudPresionArterialdiast.Location = New System.Drawing.Point(292, 138)
        Me.NudPresionArterialdiast.Maximum = New Decimal(New Integer() {190, 0, 0, 0})
        Me.NudPresionArterialdiast.Minimum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NudPresionArterialdiast.Name = "NudPresionArterialdiast"
        Me.NudPresionArterialdiast.Size = New System.Drawing.Size(70, 28)
        Me.NudPresionArterialdiast.TabIndex = 1
        Me.NudPresionArterialdiast.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'NudPresionArterialSist
        '
        Me.NudPresionArterialSist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NudPresionArterialSist.Location = New System.Drawing.Point(162, 138)
        Me.NudPresionArterialSist.Maximum = New Decimal(New Integer() {190, 0, 0, 0})
        Me.NudPresionArterialSist.Minimum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NudPresionArterialSist.Name = "NudPresionArterialSist"
        Me.NudPresionArterialSist.Size = New System.Drawing.Size(70, 28)
        Me.NudPresionArterialSist.TabIndex = 1
        Me.NudPresionArterialSist.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'NudFrecuenciacardiaca
        '
        Me.NudFrecuenciacardiaca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NudFrecuenciacardiaca.Location = New System.Drawing.Point(164, 86)
        Me.NudFrecuenciacardiaca.Maximum = New Decimal(New Integer() {190, 0, 0, 0})
        Me.NudFrecuenciacardiaca.Minimum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NudFrecuenciacardiaca.Name = "NudFrecuenciacardiaca"
        Me.NudFrecuenciacardiaca.Size = New System.Drawing.Size(70, 28)
        Me.NudFrecuenciacardiaca.TabIndex = 1
        Me.NudFrecuenciacardiaca.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'NudTemperatura
        '
        Me.NudTemperatura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NudTemperatura.Location = New System.Drawing.Point(164, 38)
        Me.NudTemperatura.Name = "NudTemperatura"
        Me.NudTemperatura.Size = New System.Drawing.Size(48, 28)
        Me.NudTemperatura.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(360, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(172, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Frecuencia respiratoria"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(483, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Pulso"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(364, 142)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 20)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Diast."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(234, 142)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Sist."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(39, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Presion arterial"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Frecuencia cardiaca"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(58, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Temperatura"
        '
        'GbxInspecciongeneral
        '
        Me.GbxInspecciongeneral.Controls.Add(Me.ComGradoDeColaboracion)
        Me.GbxInspecciongeneral.Controls.Add(Me.ComActitud)
        Me.GbxInspecciongeneral.Controls.Add(Me.ComMovilidad)
        Me.GbxInspecciongeneral.Controls.Add(Me.ComGradoDeHidratacion)
        Me.GbxInspecciongeneral.Controls.Add(Me.ComEstadoDeNutricion)
        Me.GbxInspecciongeneral.Controls.Add(Me.ComestadoConsciencia)
        Me.GbxInspecciongeneral.Controls.Add(Me.Label6)
        Me.GbxInspecciongeneral.Controls.Add(Me.Label5)
        Me.GbxInspecciongeneral.Controls.Add(Me.Label3)
        Me.GbxInspecciongeneral.Controls.Add(Me.Label4)
        Me.GbxInspecciongeneral.Controls.Add(Me.Label2)
        Me.GbxInspecciongeneral.Controls.Add(Me.Label1)
        Me.GbxInspecciongeneral.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxInspecciongeneral.Location = New System.Drawing.Point(26, 46)
        Me.GbxInspecciongeneral.Name = "GbxInspecciongeneral"
        Me.GbxInspecciongeneral.Size = New System.Drawing.Size(798, 189)
        Me.GbxInspecciongeneral.TabIndex = 6
        Me.GbxInspecciongeneral.TabStop = False
        Me.GbxInspecciongeneral.Text = "Inspeccion general"
        '
        'ComGradoDeColaboracion
        '
        Me.ComGradoDeColaboracion.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComGradoDeColaboracion.FormattingEnabled = True
        Me.ComGradoDeColaboracion.Items.AddRange(New Object() {"Buena", "Normal", "Mala"})
        Me.ComGradoDeColaboracion.Location = New System.Drawing.Point(568, 38)
        Me.ComGradoDeColaboracion.Name = "ComGradoDeColaboracion"
        Me.ComGradoDeColaboracion.Size = New System.Drawing.Size(205, 28)
        Me.ComGradoDeColaboracion.TabIndex = 2
        '
        'ComActitud
        '
        Me.ComActitud.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComActitud.FormattingEnabled = True
        Me.ComActitud.Items.AddRange(New Object() {"Apatia", "Coma", "Exitacion"})
        Me.ComActitud.Location = New System.Drawing.Point(568, 88)
        Me.ComActitud.Name = "ComActitud"
        Me.ComActitud.Size = New System.Drawing.Size(209, 28)
        Me.ComActitud.TabIndex = 2
        '
        'ComMovilidad
        '
        Me.ComMovilidad.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComMovilidad.FormattingEnabled = True
        Me.ComMovilidad.Items.AddRange(New Object() {"Normal", "Limitada", "Inestable", "Enlentecimiento", "Mayor  dependencia", "Deteriorada"})
        Me.ComMovilidad.Location = New System.Drawing.Point(179, 88)
        Me.ComMovilidad.Name = "ComMovilidad"
        Me.ComMovilidad.Size = New System.Drawing.Size(205, 28)
        Me.ComMovilidad.TabIndex = 1
        '
        'ComGradoDeHidratacion
        '
        Me.ComGradoDeHidratacion.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComGradoDeHidratacion.FormattingEnabled = True
        Me.ComGradoDeHidratacion.Items.AddRange(New Object() {"Sin deshidratación", "Deshidratación moderada", "Deshidratación severa"})
        Me.ComGradoDeHidratacion.Location = New System.Drawing.Point(568, 141)
        Me.ComGradoDeHidratacion.Name = "ComGradoDeHidratacion"
        Me.ComGradoDeHidratacion.Size = New System.Drawing.Size(209, 28)
        Me.ComGradoDeHidratacion.TabIndex = 1
        '
        'ComEstadoDeNutricion
        '
        Me.ComEstadoDeNutricion.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComEstadoDeNutricion.FormattingEnabled = True
        Me.ComEstadoDeNutricion.Items.AddRange(New Object() {"Obesidad", "Anorexia", "Caquexia"})
        Me.ComEstadoDeNutricion.Location = New System.Drawing.Point(179, 141)
        Me.ComEstadoDeNutricion.Name = "ComEstadoDeNutricion"
        Me.ComEstadoDeNutricion.Size = New System.Drawing.Size(205, 28)
        Me.ComEstadoDeNutricion.TabIndex = 1
        '
        'ComestadoConsciencia
        '
        Me.ComestadoConsciencia.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComestadoConsciencia.FormattingEnabled = True
        Me.ComestadoConsciencia.Items.AddRange(New Object() {"Coma", "Estado vegetativo", "Estado de consciencia minimo", "Mutismo acinetico", "Delirio"})
        Me.ComestadoConsciencia.Location = New System.Drawing.Point(179, 34)
        Me.ComestadoConsciencia.Name = "ComestadoConsciencia"
        Me.ComestadoConsciencia.Size = New System.Drawing.Size(205, 28)
        Me.ComestadoConsciencia.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(408, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Grado de hidratacion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(505, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Actitud"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Estado de nutricion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(390, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = " Grado de colaboracion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Movilidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Estado de consciencia"
        '
        'BtnEntrevistaInicialGuardarYContinuar
        '
        Me.BtnEntrevistaInicialGuardarYContinuar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEntrevistaInicialGuardarYContinuar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnEntrevistaInicialGuardarYContinuar.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnEntrevistaInicialGuardarYContinuar.FlatAppearance.BorderSize = 0
        Me.BtnEntrevistaInicialGuardarYContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntrevistaInicialGuardarYContinuar.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntrevistaInicialGuardarYContinuar.Location = New System.Drawing.Point(649, 677)
        Me.BtnEntrevistaInicialGuardarYContinuar.Name = "BtnEntrevistaInicialGuardarYContinuar"
        Me.BtnEntrevistaInicialGuardarYContinuar.Size = New System.Drawing.Size(174, 42)
        Me.BtnEntrevistaInicialGuardarYContinuar.TabIndex = 5
        Me.BtnEntrevistaInicialGuardarYContinuar.Text = "Guardar y continuar"
        Me.BtnEntrevistaInicialGuardarYContinuar.UseVisualStyleBackColor = False
        '
        'BtnEntrevistaInicialGuardar
        '
        Me.BtnEntrevistaInicialGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEntrevistaInicialGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnEntrevistaInicialGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnEntrevistaInicialGuardar.FlatAppearance.BorderSize = 0
        Me.BtnEntrevistaInicialGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntrevistaInicialGuardar.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntrevistaInicialGuardar.Location = New System.Drawing.Point(511, 677)
        Me.BtnEntrevistaInicialGuardar.Name = "BtnEntrevistaInicialGuardar"
        Me.BtnEntrevistaInicialGuardar.Size = New System.Drawing.Size(117, 42)
        Me.BtnEntrevistaInicialGuardar.TabIndex = 5
        Me.BtnEntrevistaInicialGuardar.Text = "Guardar"
        Me.BtnEntrevistaInicialGuardar.UseVisualStyleBackColor = False
        '
        'BtnEntrevistaInicialCancelar
        '
        Me.BtnEntrevistaInicialCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEntrevistaInicialCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnEntrevistaInicialCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnEntrevistaInicialCancelar.FlatAppearance.BorderSize = 0
        Me.BtnEntrevistaInicialCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntrevistaInicialCancelar.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntrevistaInicialCancelar.Location = New System.Drawing.Point(373, 677)
        Me.BtnEntrevistaInicialCancelar.Name = "BtnEntrevistaInicialCancelar"
        Me.BtnEntrevistaInicialCancelar.Size = New System.Drawing.Size(117, 42)
        Me.BtnEntrevistaInicialCancelar.TabIndex = 5
        Me.BtnEntrevistaInicialCancelar.Text = "Cancelar"
        Me.BtnEntrevistaInicialCancelar.UseVisualStyleBackColor = False
        '
        'GrxRegistro
        '
        Me.GrxRegistro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrxRegistro.Controls.Add(Me.PanelDeRegistrosFormularios)
        Me.GrxRegistro.Controls.Add(Me.BtnRegistroGuardarYContinuar)
        Me.GrxRegistro.Controls.Add(Me.BtnRegistroGuardar)
        Me.GrxRegistro.Controls.Add(Me.BtnRegistroCancelar)
        Me.GrxRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GrxRegistro.Font = New System.Drawing.Font("Ubuntu", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.GrxRegistro.Location = New System.Drawing.Point(888, 26)
        Me.GrxRegistro.MaximumSize = New System.Drawing.Size(1000, 1063)
        Me.GrxRegistro.Name = "GrxRegistro"
        Me.GrxRegistro.Size = New System.Drawing.Size(850, 1063)
        Me.GrxRegistro.TabIndex = 7
        Me.GrxRegistro.TabStop = False
        Me.GrxRegistro.Text = "Registro"
        '
        'BtnRegistroGuardarYContinuar
        '
        Me.BtnRegistroGuardarYContinuar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRegistroGuardarYContinuar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnRegistroGuardarYContinuar.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnRegistroGuardarYContinuar.FlatAppearance.BorderSize = 0
        Me.BtnRegistroGuardarYContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistroGuardarYContinuar.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistroGuardarYContinuar.Location = New System.Drawing.Point(649, 677)
        Me.BtnRegistroGuardarYContinuar.Name = "BtnRegistroGuardarYContinuar"
        Me.BtnRegistroGuardarYContinuar.Size = New System.Drawing.Size(174, 42)
        Me.BtnRegistroGuardarYContinuar.TabIndex = 5
        Me.BtnRegistroGuardarYContinuar.Text = "Guardar y continuar"
        Me.BtnRegistroGuardarYContinuar.UseVisualStyleBackColor = False
        Me.BtnRegistroGuardarYContinuar.Visible = False
        '
        'BtnRegistroGuardar
        '
        Me.BtnRegistroGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRegistroGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnRegistroGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnRegistroGuardar.FlatAppearance.BorderSize = 0
        Me.BtnRegistroGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistroGuardar.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistroGuardar.Location = New System.Drawing.Point(511, 677)
        Me.BtnRegistroGuardar.Name = "BtnRegistroGuardar"
        Me.BtnRegistroGuardar.Size = New System.Drawing.Size(117, 42)
        Me.BtnRegistroGuardar.TabIndex = 5
        Me.BtnRegistroGuardar.Text = "Guardar"
        Me.BtnRegistroGuardar.UseVisualStyleBackColor = False
        Me.BtnRegistroGuardar.Visible = False
        '
        'BtnRegistroCancelar
        '
        Me.BtnRegistroCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRegistroCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnRegistroCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnRegistroCancelar.FlatAppearance.BorderSize = 0
        Me.BtnRegistroCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistroCancelar.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistroCancelar.Location = New System.Drawing.Point(373, 677)
        Me.BtnRegistroCancelar.Name = "BtnRegistroCancelar"
        Me.BtnRegistroCancelar.Size = New System.Drawing.Size(117, 42)
        Me.BtnRegistroCancelar.TabIndex = 5
        Me.BtnRegistroCancelar.Text = "Cancelar"
        Me.BtnRegistroCancelar.UseVisualStyleBackColor = False
        Me.BtnRegistroCancelar.Visible = False
        '
        'PanelDeRegistrosFormularios
        '
        Me.PanelDeRegistrosFormularios.Location = New System.Drawing.Point(14, 38)
        Me.PanelDeRegistrosFormularios.Name = "PanelDeRegistrosFormularios"
        Me.PanelDeRegistrosFormularios.Size = New System.Drawing.Size(818, 622)
        Me.PanelDeRegistrosFormularios.TabIndex = 6
        '
        'FrmEntrevistaInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1773, 1100)
        Me.Controls.Add(Me.GrxRegistro)
        Me.Controls.Add(Me.GbxEntrevistaInicial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEntrevistaInicial"
        Me.Text = "FrmEntrevistaInicial"
        Me.GbxEntrevistaInicial.ResumeLayout(False)
        Me.GbxMotivosdeConsulta.ResumeLayout(False)
        Me.GbxMotivosdeConsulta.PerformLayout()
        Me.GbxConstantesVitales.ResumeLayout(False)
        Me.GbxConstantesVitales.PerformLayout()
        CType(Me.NudfrecuenciaRespiratoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudPresionArterialdiast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudPresionArterialSist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudFrecuenciacardiaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudTemperatura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbxInspecciongeneral.ResumeLayout(False)
        Me.GbxInspecciongeneral.PerformLayout()
        Me.GrxRegistro.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbxEntrevistaInicial As GroupBox
    Friend WithEvents BtnEntrevistaInicialGuardarYContinuar As Button
    Friend WithEvents BtnEntrevistaInicialGuardar As Button
    Friend WithEvents BtnEntrevistaInicialCancelar As Button
    Friend WithEvents GbxInspecciongeneral As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GbxMotivosdeConsulta As GroupBox
    Friend WithEvents GbxConstantesVitales As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ComActitud As ComboBox
    Friend WithEvents ComEstadoDeNutricion As ComboBox
    Friend WithEvents ComestadoConsciencia As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComPulso As ComboBox
    Friend WithEvents NudfrecuenciaRespiratoria As NumericUpDown
    Friend WithEvents NudPresionArterialdiast As NumericUpDown
    Friend WithEvents NudPresionArterialSist As NumericUpDown
    Friend WithEvents NudFrecuenciacardiaca As NumericUpDown
    Friend WithEvents NudTemperatura As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComGradoDeColaboracion As ComboBox
    Friend WithEvents ComMovilidad As ComboBox
    Friend WithEvents ComGradoDeHidratacion As ComboBox
    Friend WithEvents TxtMotivoDeLaConsulta As TextBox
    Friend WithEvents GrxRegistro As GroupBox
    Friend WithEvents BtnRegistroGuardarYContinuar As Button
    Friend WithEvents BtnRegistroGuardar As Button
    Friend WithEvents BtnRegistroCancelar As Button
    Friend WithEvents PanelDeRegistrosFormularios As Panel
End Class
