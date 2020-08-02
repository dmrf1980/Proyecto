<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPlanTratamiento
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GbxPlan = New System.Windows.Forms.GroupBox()
        Me.GrxTratamiento = New System.Windows.Forms.GroupBox()
        Me.LblNumEntrevista = New System.Windows.Forms.Label()
        Me.LblProximaConsulta = New System.Windows.Forms.Label()
        Me.CbxEstadoTratamientoPlan = New System.Windows.Forms.ComboBox()
        Me.LblEstadoDeTratamiento = New System.Windows.Forms.Label()
        Me.DateproximaConsulta = New System.Windows.Forms.DateTimePicker()
        Me.DateFinTratamiento = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaFinTratam = New System.Windows.Forms.Label()
        Me.DateInicioTratamiento = New System.Windows.Forms.DateTimePicker()
        Me.LblFechadeNacimiento = New System.Windows.Forms.Label()
        Me.TxtRegistrodeTratamiento = New System.Windows.Forms.TextBox()
        Me.TxtNombreTratamiento = New System.Windows.Forms.TextBox()
        Me.LblRegistrodeControles = New System.Windows.Forms.Label()
        Me.LblNombretratamiento = New System.Windows.Forms.Label()
        Me.LblIdTratamiento = New System.Windows.Forms.Label()
        Me.BtnCrearTratamiento = New System.Windows.Forms.Button()
        Me.GrxBotonesGuardarCancelarContinuar = New System.Windows.Forms.GroupBox()
        Me.BtnVolverADiagnostico = New System.Windows.Forms.Button()
        Me.BtnPreDigCancelar = New System.Windows.Forms.Button()
        Me.BtnPreDiagGuardar = New System.Windows.Forms.Button()
        Me.GbxPlan.SuspendLayout()
        Me.GrxTratamiento.SuspendLayout()
        Me.GrxBotonesGuardarCancelarContinuar.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbxPlan
        '
        Me.GbxPlan.Controls.Add(Me.GrxTratamiento)
        Me.GbxPlan.Controls.Add(Me.BtnCrearTratamiento)
        Me.GbxPlan.Font = New System.Drawing.Font("Ubuntu", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxPlan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.GbxPlan.Location = New System.Drawing.Point(25, 5)
        Me.GbxPlan.MaximumSize = New System.Drawing.Size(1000, 1063)
        Me.GbxPlan.Name = "GbxPlan"
        Me.GbxPlan.Size = New System.Drawing.Size(850, 655)
        Me.GbxPlan.TabIndex = 3
        Me.GbxPlan.TabStop = False
        Me.GbxPlan.Text = "Plan "
        '
        'GrxTratamiento
        '
        Me.GrxTratamiento.Controls.Add(Me.LblNumEntrevista)
        Me.GrxTratamiento.Controls.Add(Me.LblProximaConsulta)
        Me.GrxTratamiento.Controls.Add(Me.CbxEstadoTratamientoPlan)
        Me.GrxTratamiento.Controls.Add(Me.LblEstadoDeTratamiento)
        Me.GrxTratamiento.Controls.Add(Me.DateproximaConsulta)
        Me.GrxTratamiento.Controls.Add(Me.DateFinTratamiento)
        Me.GrxTratamiento.Controls.Add(Me.LblFechaFinTratam)
        Me.GrxTratamiento.Controls.Add(Me.DateInicioTratamiento)
        Me.GrxTratamiento.Controls.Add(Me.LblFechadeNacimiento)
        Me.GrxTratamiento.Controls.Add(Me.TxtRegistrodeTratamiento)
        Me.GrxTratamiento.Controls.Add(Me.TxtNombreTratamiento)
        Me.GrxTratamiento.Controls.Add(Me.LblRegistrodeControles)
        Me.GrxTratamiento.Controls.Add(Me.LblNombretratamiento)
        Me.GrxTratamiento.Controls.Add(Me.LblIdTratamiento)
        Me.GrxTratamiento.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxTratamiento.Location = New System.Drawing.Point(31, 96)
        Me.GrxTratamiento.Name = "GrxTratamiento"
        Me.GrxTratamiento.Size = New System.Drawing.Size(793, 530)
        Me.GrxTratamiento.TabIndex = 17
        Me.GrxTratamiento.TabStop = False
        Me.GrxTratamiento.Text = "Tratamiento"
        Me.GrxTratamiento.Visible = False
        '
        'LblNumEntrevista
        '
        Me.LblNumEntrevista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNumEntrevista.Font = New System.Drawing.Font("Ubuntu Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumEntrevista.Location = New System.Drawing.Point(599, 59)
        Me.LblNumEntrevista.MaximumSize = New System.Drawing.Size(94, 30)
        Me.LblNumEntrevista.MinimumSize = New System.Drawing.Size(94, 30)
        Me.LblNumEntrevista.Name = "LblNumEntrevista"
        Me.LblNumEntrevista.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblNumEntrevista.Size = New System.Drawing.Size(94, 30)
        Me.LblNumEntrevista.TabIndex = 17
        Me.LblNumEntrevista.Text = "00000"
        Me.LblNumEntrevista.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblProximaConsulta
        '
        Me.LblProximaConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblProximaConsulta.AutoSize = True
        Me.LblProximaConsulta.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProximaConsulta.Location = New System.Drawing.Point(52, 466)
        Me.LblProximaConsulta.Name = "LblProximaConsulta"
        Me.LblProximaConsulta.Size = New System.Drawing.Size(190, 20)
        Me.LblProximaConsulta.TabIndex = 15
        Me.LblProximaConsulta.Text = "Proxima Consulta(aprox.)"
        '
        'CbxEstadoTratamientoPlan
        '
        Me.CbxEstadoTratamientoPlan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbxEstadoTratamientoPlan.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxEstadoTratamientoPlan.FormattingEnabled = True
        Me.CbxEstadoTratamientoPlan.Items.AddRange(New Object() {"Ingreso", "Final consulta", "En espera", "Evolucionando", "Publicacion"})
        Me.CbxEstadoTratamientoPlan.Location = New System.Drawing.Point(245, 387)
        Me.CbxEstadoTratamientoPlan.Name = "CbxEstadoTratamientoPlan"
        Me.CbxEstadoTratamientoPlan.Size = New System.Drawing.Size(448, 28)
        Me.CbxEstadoTratamientoPlan.TabIndex = 16
        '
        'LblEstadoDeTratamiento
        '
        Me.LblEstadoDeTratamiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblEstadoDeTratamiento.AutoSize = True
        Me.LblEstadoDeTratamiento.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstadoDeTratamiento.Location = New System.Drawing.Point(70, 393)
        Me.LblEstadoDeTratamiento.Name = "LblEstadoDeTratamiento"
        Me.LblEstadoDeTratamiento.Size = New System.Drawing.Size(172, 20)
        Me.LblEstadoDeTratamiento.TabIndex = 15
        Me.LblEstadoDeTratamiento.Text = "Estado del tratamiento"
        '
        'DateproximaConsulta
        '
        Me.DateproximaConsulta.CalendarFont = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateproximaConsulta.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DateproximaConsulta.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DateproximaConsulta.Checked = False
        Me.DateproximaConsulta.CustomFormat = "MMMM dd, yyyy - dddd"
        Me.DateproximaConsulta.Font = New System.Drawing.Font("Ubuntu", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateproximaConsulta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateproximaConsulta.Location = New System.Drawing.Point(479, 460)
        Me.DateproximaConsulta.MaximumSize = New System.Drawing.Size(214, 26)
        Me.DateproximaConsulta.MinDate = New Date(1930, 1, 1, 0, 0, 0, 0)
        Me.DateproximaConsulta.MinimumSize = New System.Drawing.Size(214, 26)
        Me.DateproximaConsulta.Name = "DateproximaConsulta"
        Me.DateproximaConsulta.Size = New System.Drawing.Size(214, 26)
        Me.DateproximaConsulta.TabIndex = 14
        Me.DateproximaConsulta.Value = New Date(2020, 7, 18, 16, 13, 7, 0)
        '
        'DateFinTratamiento
        '
        Me.DateFinTratamiento.CalendarFont = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFinTratamiento.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DateFinTratamiento.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DateFinTratamiento.Checked = False
        Me.DateFinTratamiento.CustomFormat = "MMMM dd, yyyy - dddd"
        Me.DateFinTratamiento.Font = New System.Drawing.Font("Ubuntu", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFinTratamiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFinTratamiento.Location = New System.Drawing.Point(479, 318)
        Me.DateFinTratamiento.MaximumSize = New System.Drawing.Size(214, 26)
        Me.DateFinTratamiento.MinDate = New Date(1930, 1, 1, 0, 0, 0, 0)
        Me.DateFinTratamiento.MinimumSize = New System.Drawing.Size(214, 26)
        Me.DateFinTratamiento.Name = "DateFinTratamiento"
        Me.DateFinTratamiento.Size = New System.Drawing.Size(214, 26)
        Me.DateFinTratamiento.TabIndex = 14
        Me.DateFinTratamiento.Value = New Date(2020, 7, 18, 16, 13, 7, 0)
        '
        'LblFechaFinTratam
        '
        Me.LblFechaFinTratam.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFechaFinTratam.AutoSize = True
        Me.LblFechaFinTratam.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaFinTratam.Location = New System.Drawing.Point(248, 318)
        Me.LblFechaFinTratam.Name = "LblFechaFinTratam"
        Me.LblFechaFinTratam.Size = New System.Drawing.Size(97, 20)
        Me.LblFechaFinTratam.TabIndex = 13
        Me.LblFechaFinTratam.Text = "Fecha de fin"
        '
        'DateInicioTratamiento
        '
        Me.DateInicioTratamiento.CalendarFont = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateInicioTratamiento.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DateInicioTratamiento.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DateInicioTratamiento.Checked = False
        Me.DateInicioTratamiento.CustomFormat = "MMMM dd, yyyy - dddd"
        Me.DateInicioTratamiento.Font = New System.Drawing.Font("Ubuntu", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateInicioTratamiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateInicioTratamiento.Location = New System.Drawing.Point(479, 178)
        Me.DateInicioTratamiento.MaximumSize = New System.Drawing.Size(214, 26)
        Me.DateInicioTratamiento.MinDate = New Date(1930, 1, 1, 0, 0, 0, 0)
        Me.DateInicioTratamiento.MinimumSize = New System.Drawing.Size(214, 26)
        Me.DateInicioTratamiento.Name = "DateInicioTratamiento"
        Me.DateInicioTratamiento.Size = New System.Drawing.Size(214, 26)
        Me.DateInicioTratamiento.TabIndex = 14
        Me.DateInicioTratamiento.Value = New Date(2020, 7, 18, 16, 13, 7, 0)
        '
        'LblFechadeNacimiento
        '
        Me.LblFechadeNacimiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFechadeNacimiento.AutoSize = True
        Me.LblFechadeNacimiento.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechadeNacimiento.Location = New System.Drawing.Point(248, 178)
        Me.LblFechadeNacimiento.Name = "LblFechadeNacimiento"
        Me.LblFechadeNacimiento.Size = New System.Drawing.Size(114, 20)
        Me.LblFechadeNacimiento.TabIndex = 13
        Me.LblFechadeNacimiento.Text = "Fecha de inicio"
        '
        'TxtRegistrodeTratamiento
        '
        Me.TxtRegistrodeTratamiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRegistrodeTratamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRegistrodeTratamiento.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRegistrodeTratamiento.Location = New System.Drawing.Point(245, 226)
        Me.TxtRegistrodeTratamiento.MaximumSize = New System.Drawing.Size(448, 67)
        Me.TxtRegistrodeTratamiento.MinimumSize = New System.Drawing.Size(353, 67)
        Me.TxtRegistrodeTratamiento.Multiline = True
        Me.TxtRegistrodeTratamiento.Name = "TxtRegistrodeTratamiento"
        Me.TxtRegistrodeTratamiento.Size = New System.Drawing.Size(448, 67)
        Me.TxtRegistrodeTratamiento.TabIndex = 11
        '
        'TxtNombreTratamiento
        '
        Me.TxtNombreTratamiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNombreTratamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombreTratamiento.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreTratamiento.Location = New System.Drawing.Point(245, 129)
        Me.TxtNombreTratamiento.MinimumSize = New System.Drawing.Size(214, 30)
        Me.TxtNombreTratamiento.Name = "TxtNombreTratamiento"
        Me.TxtNombreTratamiento.Size = New System.Drawing.Size(448, 26)
        Me.TxtNombreTratamiento.TabIndex = 11
        '
        'LblRegistrodeControles
        '
        Me.LblRegistrodeControles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblRegistrodeControles.AutoSize = True
        Me.LblRegistrodeControles.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegistrodeControles.Location = New System.Drawing.Point(78, 226)
        Me.LblRegistrodeControles.Name = "LblRegistrodeControles"
        Me.LblRegistrodeControles.Size = New System.Drawing.Size(164, 20)
        Me.LblRegistrodeControles.TabIndex = 9
        Me.LblRegistrodeControles.Text = "Registro de controles"
        '
        'LblNombretratamiento
        '
        Me.LblNombretratamiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblNombretratamiento.AutoSize = True
        Me.LblNombretratamiento.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombretratamiento.Location = New System.Drawing.Point(85, 128)
        Me.LblNombretratamiento.Name = "LblNombretratamiento"
        Me.LblNombretratamiento.Size = New System.Drawing.Size(157, 20)
        Me.LblNombretratamiento.TabIndex = 9
        Me.LblNombretratamiento.Text = "Nombre Tratamiento"
        '
        'LblIdTratamiento
        '
        Me.LblIdTratamiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblIdTratamiento.AutoSize = True
        Me.LblIdTratamiento.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIdTratamiento.Location = New System.Drawing.Point(482, 65)
        Me.LblIdTratamiento.Name = "LblIdTratamiento"
        Me.LblIdTratamiento.Size = New System.Drawing.Size(115, 20)
        Me.LblIdTratamiento.TabIndex = 9
        Me.LblIdTratamiento.Text = "Id Tratamiento:"
        '
        'BtnCrearTratamiento
        '
        Me.BtnCrearTratamiento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCrearTratamiento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnCrearTratamiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCrearTratamiento.FlatAppearance.BorderSize = 0
        Me.BtnCrearTratamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCrearTratamiento.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrearTratamiento.Location = New System.Drawing.Point(248, 21)
        Me.BtnCrearTratamiento.Name = "BtnCrearTratamiento"
        Me.BtnCrearTratamiento.Size = New System.Drawing.Size(224, 42)
        Me.BtnCrearTratamiento.TabIndex = 12
        Me.BtnCrearTratamiento.Text = "Crear Tratamiento"
        Me.BtnCrearTratamiento.UseVisualStyleBackColor = False
        '
        'GrxBotonesGuardarCancelarContinuar
        '
        Me.GrxBotonesGuardarCancelarContinuar.Controls.Add(Me.BtnVolverADiagnostico)
        Me.GrxBotonesGuardarCancelarContinuar.Controls.Add(Me.BtnPreDigCancelar)
        Me.GrxBotonesGuardarCancelarContinuar.Controls.Add(Me.BtnPreDiagGuardar)
        Me.GrxBotonesGuardarCancelarContinuar.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxBotonesGuardarCancelarContinuar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrxBotonesGuardarCancelarContinuar.Location = New System.Drawing.Point(25, 690)
        Me.GrxBotonesGuardarCancelarContinuar.Name = "GrxBotonesGuardarCancelarContinuar"
        Me.GrxBotonesGuardarCancelarContinuar.Size = New System.Drawing.Size(850, 79)
        Me.GrxBotonesGuardarCancelarContinuar.TabIndex = 7
        Me.GrxBotonesGuardarCancelarContinuar.TabStop = False
        '
        'BtnVolverADiagnostico
        '
        Me.BtnVolverADiagnostico.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnVolverADiagnostico.FlatAppearance.BorderSize = 0
        Me.BtnVolverADiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolverADiagnostico.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolverADiagnostico.Location = New System.Drawing.Point(18, 23)
        Me.BtnVolverADiagnostico.MaximumSize = New System.Drawing.Size(260, 42)
        Me.BtnVolverADiagnostico.Name = "BtnVolverADiagnostico"
        Me.BtnVolverADiagnostico.Size = New System.Drawing.Size(260, 42)
        Me.BtnVolverADiagnostico.TabIndex = 6
        Me.BtnVolverADiagnostico.Text = "<<< Volver a diagnosticos"
        Me.BtnVolverADiagnostico.UseVisualStyleBackColor = False
        '
        'BtnPreDigCancelar
        '
        Me.BtnPreDigCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPreDigCancelar.FlatAppearance.BorderSize = 0
        Me.BtnPreDigCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPreDigCancelar.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreDigCancelar.Location = New System.Drawing.Point(573, 24)
        Me.BtnPreDigCancelar.Name = "BtnPreDigCancelar"
        Me.BtnPreDigCancelar.Size = New System.Drawing.Size(117, 42)
        Me.BtnPreDigCancelar.TabIndex = 5
        Me.BtnPreDigCancelar.Text = "Cancelar"
        Me.BtnPreDigCancelar.UseVisualStyleBackColor = False
        '
        'BtnPreDiagGuardar
        '
        Me.BtnPreDiagGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPreDiagGuardar.FlatAppearance.BorderSize = 0
        Me.BtnPreDiagGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPreDiagGuardar.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreDiagGuardar.Location = New System.Drawing.Point(715, 24)
        Me.BtnPreDiagGuardar.Name = "BtnPreDiagGuardar"
        Me.BtnPreDiagGuardar.Size = New System.Drawing.Size(117, 42)
        Me.BtnPreDiagGuardar.TabIndex = 5
        Me.BtnPreDiagGuardar.Text = "Guardar"
        Me.BtnPreDiagGuardar.UseVisualStyleBackColor = False
        '
        'FrmPlanTratamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(904, 800)
        Me.Controls.Add(Me.GbxPlan)
        Me.Controls.Add(Me.GrxBotonesGuardarCancelarContinuar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPlanTratamiento"
        Me.Padding = New System.Windows.Forms.Padding(25, 5, 25, 10)
        Me.Text = "FrmPlanTratamiento"
        Me.GbxPlan.ResumeLayout(False)
        Me.GrxTratamiento.ResumeLayout(False)
        Me.GrxTratamiento.PerformLayout()
        Me.GrxBotonesGuardarCancelarContinuar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbxPlan As GroupBox
    Friend WithEvents LblRegistrodeControles As Label
    Friend WithEvents LblIdTratamiento As Label
    Friend WithEvents GrxBotonesGuardarCancelarContinuar As GroupBox
    Friend WithEvents BtnVolverADiagnostico As Button
    Friend WithEvents BtnPreDigCancelar As Button
    Friend WithEvents BtnPreDiagGuardar As Button
    Friend WithEvents BtnCrearTratamiento As Button
    Friend WithEvents TxtNombreTratamiento As TextBox
    Friend WithEvents LblNombretratamiento As Label
    Friend WithEvents TxtRegistrodeTratamiento As TextBox
    Friend WithEvents DateInicioTratamiento As DateTimePicker
    Friend WithEvents LblFechadeNacimiento As Label
    Friend WithEvents DateFinTratamiento As DateTimePicker
    Friend WithEvents LblFechaFinTratam As Label
    Friend WithEvents CbxEstadoTratamientoPlan As ComboBox
    Friend WithEvents LblEstadoDeTratamiento As Label
    Friend WithEvents GrxTratamiento As GroupBox
    Friend WithEvents LblProximaConsulta As Label
    Friend WithEvents DateproximaConsulta As DateTimePicker
    Friend WithEvents LblNumEntrevista As Label
End Class
