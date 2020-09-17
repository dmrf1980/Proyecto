<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMantenimiento
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
        Me.GbxIngresoPacientes = New System.Windows.Forms.GroupBox()
        Me.TxtEdadCalculada = New System.Windows.Forms.TextBox()
        Me.ComEstadocivil = New System.Windows.Forms.ComboBox()
        Me.LblFechIngresos = New System.Windows.Forms.Label()
        Me.DateTimeFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.TxtIngresoAnalisis = New System.Windows.Forms.TextBox()
        Me.TxtEnferMaternas = New System.Windows.Forms.TextBox()
        Me.TxtEnfermedPaternas = New System.Windows.Forms.TextBox()
        Me.TxtCirujias = New System.Windows.Forms.TextBox()
        Me.TxtAlergiasMedicamentos = New System.Windows.Forms.TextBox()
        Me.TxtEnfermeAnteriores = New System.Windows.Forms.TextBox()
        Me.TxtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.TxtTelefAcompañante = New System.Windows.Forms.TextBox()
        Me.TxtNombreAcompañante = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtEscolaridad = New System.Windows.Forms.TextBox()
        Me.TxtOcupacion = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.TxtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.TxtGenero = New System.Windows.Forms.TextBox()
        Me.TxtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.LblIngresoAnalisis = New System.Windows.Forms.Label()
        Me.LblApellidoMaterno = New System.Windows.Forms.Label()
        Me.lblEnfMaternas = New System.Windows.Forms.Label()
        Me.LblCirujias = New System.Windows.Forms.Label()
        Me.LblFechadeNacimiento = New System.Windows.Forms.Label()
        Me.LblAlergiasMedicamentos = New System.Windows.Forms.Label()
        Me.LblTelAcomp = New System.Windows.Forms.Label()
        Me.LblEnfPaternas = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblNomAcomp = New System.Windows.Forms.Label()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.LblEMail = New System.Windows.Forms.Label()
        Me.LblEnfAnteriores = New System.Windows.Forms.Label()
        Me.LblEscolaridad = New System.Windows.Forms.Label()
        Me.LblEstadoCivil = New System.Windows.Forms.Label()
        Me.LblApellidoPaterno = New System.Windows.Forms.Label()
        Me.LblOcupacion = New System.Windows.Forms.Label()
        Me.LblGenero = New System.Windows.Forms.Label()
        Me.LblSegundoNombre = New System.Windows.Forms.Label()
        Me.LblEdad = New System.Windows.Forms.Label()
        Me.LblPrimerNombre = New System.Windows.Forms.Label()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.BtnMantenimientoGuardarDatos = New System.Windows.Forms.Button()
        Me.BtnMantenimientoCancelar = New System.Windows.Forms.Button()
        Me.RbtnCedulaConsultasAnteriores = New System.Windows.Forms.RadioButton()
        Me.RbtnFechaConsultasAnteriores = New System.Windows.Forms.RadioButton()
        Me.DateDatosConsultasAnteriores = New System.Windows.Forms.DateTimePicker()
        Me.BtnBuscarConsultasAnteriores = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbxConsultasAnteriores = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GrxDatosDelPaciente = New System.Windows.Forms.GroupBox()
        Me.LblDatosEnferMaternas = New System.Windows.Forms.Label()
        Me.LblDatosEnfermPaternas = New System.Windows.Forms.Label()
        Me.LblDatosCirujias = New System.Windows.Forms.Label()
        Me.LblDatosAlergiasAmedicamentos = New System.Windows.Forms.Label()
        Me.LblDatosEnferAnterior = New System.Windows.Forms.Label()
        Me.LblDatosFechaIngreso = New System.Windows.Forms.Label()
        Me.LblDatosSegApell = New System.Windows.Forms.Label()
        Me.LbldatosFechaNacimiento = New System.Windows.Forms.Label()
        Me.LblDatosTelefono = New System.Windows.Forms.Label()
        Me.LblDatosDireccion = New System.Windows.Forms.Label()
        Me.LblDatosEstadoCivil = New System.Windows.Forms.Label()
        Me.LblDatosEdad = New System.Windows.Forms.Label()
        Me.LblDatosGenero = New System.Windows.Forms.Label()
        Me.LblDatosSegunNom = New System.Windows.Forms.Label()
        Me.LblDatosEmail = New System.Windows.Forms.Label()
        Me.LblDatosEscolaridad = New System.Windows.Forms.Label()
        Me.LblprimApell = New System.Windows.Forms.Label()
        Me.LblDatosocupacion = New System.Windows.Forms.Label()
        Me.LbldatosPrimNombre = New System.Windows.Forms.Label()
        Me.Lbldatoscedula = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.PicDatosExistentes = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BtnContinuarAEntrevista = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscarPaciente = New System.Windows.Forms.TextBox()
        Me.BtnBuscarPaciente = New System.Windows.Forms.Button()
        Me.BtnIngresoNuevoPaciente = New System.Windows.Forms.Button()
        Me.GbxIngresoPacientes.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GrxDatosDelPaciente.SuspendLayout()
        CType(Me.PicDatosExistentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbxIngresoPacientes
        '
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtEdadCalculada)
        Me.GbxIngresoPacientes.Controls.Add(Me.ComEstadocivil)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblFechIngresos)
        Me.GbxIngresoPacientes.Controls.Add(Me.DateTimeFechaNacimiento)
        Me.GbxIngresoPacientes.Controls.Add(Me.DateTimeFechaAlta)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtIngresoAnalisis)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtEnferMaternas)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtEnfermedPaternas)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtCirujias)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtAlergiasMedicamentos)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtEnfermeAnteriores)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtApellidoPaterno)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtTelefAcompañante)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtNombreAcompañante)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtEmail)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtEscolaridad)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtOcupacion)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtTelefono)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtDireccion)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtApellidoMaterno)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtPrimerNombre)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtGenero)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtSegundoNombre)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtCedula)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblIngresoAnalisis)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblApellidoMaterno)
        Me.GbxIngresoPacientes.Controls.Add(Me.lblEnfMaternas)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblCirujias)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblFechadeNacimiento)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblAlergiasMedicamentos)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblTelAcomp)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblEnfPaternas)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblTelefono)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblNomAcomp)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblDireccion)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblEMail)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblEnfAnteriores)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblEscolaridad)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblEstadoCivil)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblApellidoPaterno)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblOcupacion)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblGenero)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblSegundoNombre)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblEdad)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblPrimerNombre)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblCedula)
        Me.GbxIngresoPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GbxIngresoPacientes.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxIngresoPacientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.GbxIngresoPacientes.Location = New System.Drawing.Point(25, 99)
        Me.GbxIngresoPacientes.Name = "GbxIngresoPacientes"
        Me.GbxIngresoPacientes.Size = New System.Drawing.Size(690, 610)
        Me.GbxIngresoPacientes.TabIndex = 0
        Me.GbxIngresoPacientes.TabStop = False
        Me.GbxIngresoPacientes.Text = "Anamnesis"
        Me.GbxIngresoPacientes.Visible = False
        '
        'TxtEdadCalculada
        '
        Me.TxtEdadCalculada.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEdadCalculada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEdadCalculada.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEdadCalculada.Location = New System.Drawing.Point(140, 120)
        Me.TxtEdadCalculada.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtEdadCalculada.MaxLength = 15
        Me.TxtEdadCalculada.MinimumSize = New System.Drawing.Size(150, 26)
        Me.TxtEdadCalculada.Name = "TxtEdadCalculada"
        Me.TxtEdadCalculada.Size = New System.Drawing.Size(150, 26)
        Me.TxtEdadCalculada.TabIndex = 13
        '
        'ComEstadocivil
        '
        Me.ComEstadocivil.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComEstadocivil.FormattingEnabled = True
        Me.ComEstadocivil.Items.AddRange(New Object() {"Soltero/a", "Casado/a", "Divorciado/a", "Viudo/a "})
        Me.ComEstadocivil.Location = New System.Drawing.Point(406, 153)
        Me.ComEstadocivil.MinimumSize = New System.Drawing.Size(150, 0)
        Me.ComEstadocivil.Name = "ComEstadocivil"
        Me.ComEstadocivil.Size = New System.Drawing.Size(150, 28)
        Me.ComEstadocivil.TabIndex = 12
        '
        'LblFechIngresos
        '
        Me.LblFechIngresos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFechIngresos.AutoSize = True
        Me.LblFechIngresos.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechIngresos.Location = New System.Drawing.Point(315, 255)
        Me.LblFechIngresos.Name = "LblFechIngresos"
        Me.LblFechIngresos.Size = New System.Drawing.Size(91, 16)
        Me.LblFechIngresos.TabIndex = 10
        Me.LblFechIngresos.Text = "Fecha de ingreso"
        '
        'DateTimeFechaNacimiento
        '
        Me.DateTimeFechaNacimiento.CalendarFont = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeFechaNacimiento.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DateTimeFechaNacimiento.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DateTimeFechaNacimiento.Checked = False
        Me.DateTimeFechaNacimiento.CustomFormat = "MMMM dd, yyyy - dddd"
        Me.DateTimeFechaNacimiento.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFechaNacimiento.Location = New System.Drawing.Point(406, 25)
        Me.DateTimeFechaNacimiento.MaxDate = New Date(2020, 9, 7, 0, 0, 0, 0)
        Me.DateTimeFechaNacimiento.MaximumSize = New System.Drawing.Size(214, 26)
        Me.DateTimeFechaNacimiento.MinDate = New Date(1930, 1, 1, 0, 0, 0, 0)
        Me.DateTimeFechaNacimiento.MinimumSize = New System.Drawing.Size(150, 26)
        Me.DateTimeFechaNacimiento.Name = "DateTimeFechaNacimiento"
        Me.DateTimeFechaNacimiento.Size = New System.Drawing.Size(150, 26)
        Me.DateTimeFechaNacimiento.TabIndex = 9
        Me.DateTimeFechaNacimiento.Value = New Date(2020, 9, 7, 0, 0, 0, 0)
        '
        'DateTimeFechaAlta
        '
        Me.DateTimeFechaAlta.CalendarFont = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeFechaAlta.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DateTimeFechaAlta.Checked = False
        Me.DateTimeFechaAlta.CustomFormat = "MMMM dd, yyyy - dddd"
        Me.DateTimeFechaAlta.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFechaAlta.Location = New System.Drawing.Point(406, 252)
        Me.DateTimeFechaAlta.MaxDate = New Date(2020, 9, 14, 0, 0, 0, 0)
        Me.DateTimeFechaAlta.MaximumSize = New System.Drawing.Size(214, 26)
        Me.DateTimeFechaAlta.MinDate = New Date(1930, 1, 1, 0, 0, 0, 0)
        Me.DateTimeFechaAlta.MinimumSize = New System.Drawing.Size(150, 26)
        Me.DateTimeFechaAlta.Name = "DateTimeFechaAlta"
        Me.DateTimeFechaAlta.Size = New System.Drawing.Size(150, 26)
        Me.DateTimeFechaAlta.TabIndex = 9
        Me.DateTimeFechaAlta.Value = New Date(2020, 7, 18, 16, 13, 7, 0)
        '
        'TxtIngresoAnalisis
        '
        Me.TxtIngresoAnalisis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIngresoAnalisis.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIngresoAnalisis.Location = New System.Drawing.Point(140, 562)
        Me.TxtIngresoAnalisis.MaximumSize = New System.Drawing.Size(705, 40)
        Me.TxtIngresoAnalisis.MaxLength = 250
        Me.TxtIngresoAnalisis.Multiline = True
        Me.TxtIngresoAnalisis.Name = "TxtIngresoAnalisis"
        Me.TxtIngresoAnalisis.Size = New System.Drawing.Size(527, 40)
        Me.TxtIngresoAnalisis.TabIndex = 7
        '
        'TxtEnferMaternas
        '
        Me.TxtEnferMaternas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEnferMaternas.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEnferMaternas.Location = New System.Drawing.Point(140, 514)
        Me.TxtEnferMaternas.MaximumSize = New System.Drawing.Size(705, 40)
        Me.TxtEnferMaternas.MaxLength = 250
        Me.TxtEnferMaternas.Multiline = True
        Me.TxtEnferMaternas.Name = "TxtEnferMaternas"
        Me.TxtEnferMaternas.Size = New System.Drawing.Size(527, 40)
        Me.TxtEnferMaternas.TabIndex = 7
        '
        'TxtEnfermedPaternas
        '
        Me.TxtEnfermedPaternas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEnfermedPaternas.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEnfermedPaternas.Location = New System.Drawing.Point(140, 466)
        Me.TxtEnfermedPaternas.MaximumSize = New System.Drawing.Size(705, 40)
        Me.TxtEnfermedPaternas.MaxLength = 250
        Me.TxtEnfermedPaternas.Multiline = True
        Me.TxtEnfermedPaternas.Name = "TxtEnfermedPaternas"
        Me.TxtEnfermedPaternas.Size = New System.Drawing.Size(527, 40)
        Me.TxtEnfermedPaternas.TabIndex = 7
        '
        'TxtCirujias
        '
        Me.TxtCirujias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCirujias.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCirujias.Location = New System.Drawing.Point(140, 418)
        Me.TxtCirujias.MaximumSize = New System.Drawing.Size(705, 40)
        Me.TxtCirujias.MaxLength = 250
        Me.TxtCirujias.Multiline = True
        Me.TxtCirujias.Name = "TxtCirujias"
        Me.TxtCirujias.Size = New System.Drawing.Size(527, 40)
        Me.TxtCirujias.TabIndex = 7
        '
        'TxtAlergiasMedicamentos
        '
        Me.TxtAlergiasMedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAlergiasMedicamentos.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAlergiasMedicamentos.Location = New System.Drawing.Point(140, 370)
        Me.TxtAlergiasMedicamentos.MaximumSize = New System.Drawing.Size(705, 40)
        Me.TxtAlergiasMedicamentos.MaxLength = 250
        Me.TxtAlergiasMedicamentos.Multiline = True
        Me.TxtAlergiasMedicamentos.Name = "TxtAlergiasMedicamentos"
        Me.TxtAlergiasMedicamentos.Size = New System.Drawing.Size(527, 40)
        Me.TxtAlergiasMedicamentos.TabIndex = 7
        '
        'TxtEnfermeAnteriores
        '
        Me.TxtEnfermeAnteriores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEnfermeAnteriores.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEnfermeAnteriores.Location = New System.Drawing.Point(140, 322)
        Me.TxtEnfermeAnteriores.MaximumSize = New System.Drawing.Size(705, 40)
        Me.TxtEnfermeAnteriores.MaxLength = 250
        Me.TxtEnfermeAnteriores.MinimumSize = New System.Drawing.Size(400, 40)
        Me.TxtEnfermeAnteriores.Multiline = True
        Me.TxtEnfermeAnteriores.Name = "TxtEnfermeAnteriores"
        Me.TxtEnfermeAnteriores.Size = New System.Drawing.Size(527, 40)
        Me.TxtEnfermeAnteriores.TabIndex = 7
        '
        'TxtApellidoPaterno
        '
        Me.TxtApellidoPaterno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtApellidoPaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtApellidoPaterno.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellidoPaterno.Location = New System.Drawing.Point(140, 89)
        Me.TxtApellidoPaterno.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtApellidoPaterno.MaxLength = 15
        Me.TxtApellidoPaterno.MinimumSize = New System.Drawing.Size(150, 26)
        Me.TxtApellidoPaterno.Name = "TxtApellidoPaterno"
        Me.TxtApellidoPaterno.Size = New System.Drawing.Size(150, 26)
        Me.TxtApellidoPaterno.TabIndex = 3
        '
        'TxtTelefAcompañante
        '
        Me.TxtTelefAcompañante.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTelefAcompañante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelefAcompañante.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefAcompañante.Location = New System.Drawing.Point(139, 284)
        Me.TxtTelefAcompañante.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtTelefAcompañante.MaxLength = 15
        Me.TxtTelefAcompañante.MinimumSize = New System.Drawing.Size(150, 26)
        Me.TxtTelefAcompañante.Name = "TxtTelefAcompañante"
        Me.TxtTelefAcompañante.Size = New System.Drawing.Size(150, 26)
        Me.TxtTelefAcompañante.TabIndex = 2
        '
        'TxtNombreAcompañante
        '
        Me.TxtNombreAcompañante.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNombreAcompañante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombreAcompañante.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreAcompañante.Location = New System.Drawing.Point(140, 252)
        Me.TxtNombreAcompañante.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtNombreAcompañante.MaxLength = 35
        Me.TxtNombreAcompañante.MinimumSize = New System.Drawing.Size(150, 26)
        Me.TxtNombreAcompañante.Name = "TxtNombreAcompañante"
        Me.TxtNombreAcompañante.Size = New System.Drawing.Size(150, 26)
        Me.TxtNombreAcompañante.TabIndex = 2
        '
        'TxtEmail
        '
        Me.TxtEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmail.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(140, 218)
        Me.TxtEmail.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtEmail.MaxLength = 25
        Me.TxtEmail.MinimumSize = New System.Drawing.Size(150, 26)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(150, 26)
        Me.TxtEmail.TabIndex = 2
        '
        'TxtEscolaridad
        '
        Me.TxtEscolaridad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEscolaridad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEscolaridad.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEscolaridad.Location = New System.Drawing.Point(140, 186)
        Me.TxtEscolaridad.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtEscolaridad.MaxLength = 25
        Me.TxtEscolaridad.MinimumSize = New System.Drawing.Size(150, 26)
        Me.TxtEscolaridad.Name = "TxtEscolaridad"
        Me.TxtEscolaridad.Size = New System.Drawing.Size(150, 26)
        Me.TxtEscolaridad.TabIndex = 2
        '
        'TxtOcupacion
        '
        Me.TxtOcupacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtOcupacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOcupacion.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOcupacion.Location = New System.Drawing.Point(140, 153)
        Me.TxtOcupacion.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtOcupacion.MaxLength = 25
        Me.TxtOcupacion.MinimumSize = New System.Drawing.Size(150, 26)
        Me.TxtOcupacion.Name = "TxtOcupacion"
        Me.TxtOcupacion.Size = New System.Drawing.Size(150, 26)
        Me.TxtOcupacion.TabIndex = 2
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelefono.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(406, 219)
        Me.TxtTelefono.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtTelefono.MaxLength = 25
        Me.TxtTelefono.MinimumSize = New System.Drawing.Size(150, 26)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(150, 26)
        Me.TxtTelefono.TabIndex = 2
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDireccion.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(406, 187)
        Me.TxtDireccion.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtDireccion.MaxLength = 25
        Me.TxtDireccion.MinimumSize = New System.Drawing.Size(150, 26)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(150, 26)
        Me.TxtDireccion.TabIndex = 2
        '
        'TxtApellidoMaterno
        '
        Me.TxtApellidoMaterno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtApellidoMaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtApellidoMaterno.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellidoMaterno.Location = New System.Drawing.Point(406, 89)
        Me.TxtApellidoMaterno.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtApellidoMaterno.MaxLength = 15
        Me.TxtApellidoMaterno.MinimumSize = New System.Drawing.Size(150, 26)
        Me.TxtApellidoMaterno.Name = "TxtApellidoMaterno"
        Me.TxtApellidoMaterno.Size = New System.Drawing.Size(150, 26)
        Me.TxtApellidoMaterno.TabIndex = 2
        '
        'TxtPrimerNombre
        '
        Me.TxtPrimerNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPrimerNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrimerNombre.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrimerNombre.Location = New System.Drawing.Point(140, 57)
        Me.TxtPrimerNombre.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtPrimerNombre.MaxLength = 15
        Me.TxtPrimerNombre.MinimumSize = New System.Drawing.Size(150, 26)
        Me.TxtPrimerNombre.Name = "TxtPrimerNombre"
        Me.TxtPrimerNombre.Size = New System.Drawing.Size(150, 26)
        Me.TxtPrimerNombre.TabIndex = 4
        '
        'TxtGenero
        '
        Me.TxtGenero.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGenero.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGenero.Location = New System.Drawing.Point(406, 121)
        Me.TxtGenero.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtGenero.MaxLength = 25
        Me.TxtGenero.MinimumSize = New System.Drawing.Size(150, 26)
        Me.TxtGenero.Name = "TxtGenero"
        Me.TxtGenero.Size = New System.Drawing.Size(150, 26)
        Me.TxtGenero.TabIndex = 2
        '
        'TxtSegundoNombre
        '
        Me.TxtSegundoNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSegundoNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSegundoNombre.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSegundoNombre.Location = New System.Drawing.Point(406, 57)
        Me.TxtSegundoNombre.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtSegundoNombre.MaxLength = 15
        Me.TxtSegundoNombre.MinimumSize = New System.Drawing.Size(150, 26)
        Me.TxtSegundoNombre.Name = "TxtSegundoNombre"
        Me.TxtSegundoNombre.Size = New System.Drawing.Size(150, 26)
        Me.TxtSegundoNombre.TabIndex = 2
        '
        'TxtCedula
        '
        Me.TxtCedula.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.TxtCedula.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCedula.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCedula.Location = New System.Drawing.Point(140, 27)
        Me.TxtCedula.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtCedula.MaxLength = 8
        Me.TxtCedula.MinimumSize = New System.Drawing.Size(150, 26)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(150, 26)
        Me.TxtCedula.TabIndex = 2
        '
        'LblIngresoAnalisis
        '
        Me.LblIngresoAnalisis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblIngresoAnalisis.AutoSize = True
        Me.LblIngresoAnalisis.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIngresoAnalisis.Location = New System.Drawing.Point(40, 565)
        Me.LblIngresoAnalisis.Name = "LblIngresoAnalisis"
        Me.LblIngresoAnalisis.Size = New System.Drawing.Size(99, 16)
        Me.LblIngresoAnalisis.TabIndex = 0
        Me.LblIngresoAnalisis.Text = "Ingreso de analisis"
        '
        'LblApellidoMaterno
        '
        Me.LblApellidoMaterno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblApellidoMaterno.AutoSize = True
        Me.LblApellidoMaterno.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellidoMaterno.Location = New System.Drawing.Point(314, 95)
        Me.LblApellidoMaterno.Name = "LblApellidoMaterno"
        Me.LblApellidoMaterno.Size = New System.Drawing.Size(92, 16)
        Me.LblApellidoMaterno.TabIndex = 0
        Me.LblApellidoMaterno.Text = "Segundo apellido"
        '
        'lblEnfMaternas
        '
        Me.lblEnfMaternas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEnfMaternas.AutoSize = True
        Me.lblEnfMaternas.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnfMaternas.Location = New System.Drawing.Point(11, 517)
        Me.lblEnfMaternas.Name = "lblEnfMaternas"
        Me.lblEnfMaternas.Size = New System.Drawing.Size(128, 16)
        Me.lblEnfMaternas.TabIndex = 0
        Me.lblEnfMaternas.Text = "Enfermedades maternas"
        '
        'LblCirujias
        '
        Me.LblCirujias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCirujias.AutoSize = True
        Me.LblCirujias.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCirujias.Location = New System.Drawing.Point(94, 419)
        Me.LblCirujias.Name = "LblCirujias"
        Me.LblCirujias.Size = New System.Drawing.Size(45, 16)
        Me.LblCirujias.TabIndex = 0
        Me.LblCirujias.Text = "Cirujias"
        '
        'LblFechadeNacimiento
        '
        Me.LblFechadeNacimiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFechadeNacimiento.AutoSize = True
        Me.LblFechadeNacimiento.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechadeNacimiento.Location = New System.Drawing.Point(296, 29)
        Me.LblFechadeNacimiento.Name = "LblFechadeNacimiento"
        Me.LblFechadeNacimiento.Size = New System.Drawing.Size(110, 16)
        Me.LblFechadeNacimiento.TabIndex = 0
        Me.LblFechadeNacimiento.Text = "Fecha de nacimiento"
        '
        'LblAlergiasMedicamentos
        '
        Me.LblAlergiasMedicamentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAlergiasMedicamentos.AutoSize = True
        Me.LblAlergiasMedicamentos.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAlergiasMedicamentos.Location = New System.Drawing.Point(7, 371)
        Me.LblAlergiasMedicamentos.Name = "LblAlergiasMedicamentos"
        Me.LblAlergiasMedicamentos.Size = New System.Drawing.Size(132, 16)
        Me.LblAlergiasMedicamentos.TabIndex = 0
        Me.LblAlergiasMedicamentos.Text = "Alergias a medicamentos"
        '
        'LblTelAcomp
        '
        Me.LblTelAcomp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTelAcomp.AutoSize = True
        Me.LblTelAcomp.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelAcomp.Location = New System.Drawing.Point(44, 286)
        Me.LblTelAcomp.Name = "LblTelAcomp"
        Me.LblTelAcomp.Size = New System.Drawing.Size(95, 16)
        Me.LblTelAcomp.TabIndex = 0
        Me.LblTelAcomp.Text = "Tel. Acompañante"
        '
        'LblEnfPaternas
        '
        Me.LblEnfPaternas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblEnfPaternas.AutoSize = True
        Me.LblEnfPaternas.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnfPaternas.Location = New System.Drawing.Point(14, 468)
        Me.LblEnfPaternas.Name = "LblEnfPaternas"
        Me.LblEnfPaternas.Size = New System.Drawing.Size(125, 16)
        Me.LblEnfPaternas.TabIndex = 0
        Me.LblEnfPaternas.Text = "Enfermedades paternas"
        Me.LblEnfPaternas.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblTelefono
        '
        Me.LblTelefono.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefono.Location = New System.Drawing.Point(352, 222)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(49, 16)
        Me.LblTelefono.TabIndex = 0
        Me.LblTelefono.Text = "Telefono"
        '
        'LblNomAcomp
        '
        Me.LblNomAcomp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblNomAcomp.AutoSize = True
        Me.LblNomAcomp.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomAcomp.Location = New System.Drawing.Point(22, 256)
        Me.LblNomAcomp.Name = "LblNomAcomp"
        Me.LblNomAcomp.Size = New System.Drawing.Size(117, 16)
        Me.LblNomAcomp.TabIndex = 0
        Me.LblNomAcomp.Text = "Nombre acompañante"
        '
        'LblDireccion
        '
        Me.LblDireccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDireccion.Location = New System.Drawing.Point(352, 190)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(54, 16)
        Me.LblDireccion.TabIndex = 0
        Me.LblDireccion.Text = "Direccion"
        '
        'LblEMail
        '
        Me.LblEMail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblEMail.AutoSize = True
        Me.LblEMail.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEMail.Location = New System.Drawing.Point(40, 222)
        Me.LblEMail.Name = "LblEMail"
        Me.LblEMail.Size = New System.Drawing.Size(99, 16)
        Me.LblEMail.TabIndex = 0
        Me.LblEMail.Text = "Correo electronico"
        '
        'LblEnfAnteriores
        '
        Me.LblEnfAnteriores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblEnfAnteriores.AutoSize = True
        Me.LblEnfAnteriores.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnfAnteriores.Location = New System.Drawing.Point(4, 324)
        Me.LblEnfAnteriores.Name = "LblEnfAnteriores"
        Me.LblEnfAnteriores.Size = New System.Drawing.Size(135, 16)
        Me.LblEnfAnteriores.TabIndex = 0
        Me.LblEnfAnteriores.Text = "Enfermedades  anteriores"
        Me.LblEnfAnteriores.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblEscolaridad
        '
        Me.LblEscolaridad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblEscolaridad.AutoSize = True
        Me.LblEscolaridad.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEscolaridad.Location = New System.Drawing.Point(75, 190)
        Me.LblEscolaridad.Name = "LblEscolaridad"
        Me.LblEscolaridad.Size = New System.Drawing.Size(64, 16)
        Me.LblEscolaridad.TabIndex = 0
        Me.LblEscolaridad.Text = "Escolaridad"
        '
        'LblEstadoCivil
        '
        Me.LblEstadoCivil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblEstadoCivil.AutoSize = True
        Me.LblEstadoCivil.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstadoCivil.Location = New System.Drawing.Point(342, 158)
        Me.LblEstadoCivil.Name = "LblEstadoCivil"
        Me.LblEstadoCivil.Size = New System.Drawing.Size(64, 16)
        Me.LblEstadoCivil.TabIndex = 0
        Me.LblEstadoCivil.Text = "Estado civil"
        '
        'LblApellidoPaterno
        '
        Me.LblApellidoPaterno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblApellidoPaterno.AutoSize = True
        Me.LblApellidoPaterno.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellidoPaterno.Location = New System.Drawing.Point(56, 92)
        Me.LblApellidoPaterno.Name = "LblApellidoPaterno"
        Me.LblApellidoPaterno.Size = New System.Drawing.Size(83, 16)
        Me.LblApellidoPaterno.TabIndex = 0
        Me.LblApellidoPaterno.Text = "Primer apellido"
        '
        'LblOcupacion
        '
        Me.LblOcupacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblOcupacion.AutoSize = True
        Me.LblOcupacion.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOcupacion.Location = New System.Drawing.Point(79, 159)
        Me.LblOcupacion.Name = "LblOcupacion"
        Me.LblOcupacion.Size = New System.Drawing.Size(60, 16)
        Me.LblOcupacion.TabIndex = 0
        Me.LblOcupacion.Text = "Ocupacion"
        '
        'LblGenero
        '
        Me.LblGenero.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblGenero.AutoSize = True
        Me.LblGenero.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGenero.Location = New System.Drawing.Point(362, 126)
        Me.LblGenero.Name = "LblGenero"
        Me.LblGenero.Size = New System.Drawing.Size(44, 16)
        Me.LblGenero.TabIndex = 0
        Me.LblGenero.Text = "Genero"
        '
        'LblSegundoNombre
        '
        Me.LblSegundoNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSegundoNombre.AutoSize = True
        Me.LblSegundoNombre.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSegundoNombre.Location = New System.Drawing.Point(316, 63)
        Me.LblSegundoNombre.Name = "LblSegundoNombre"
        Me.LblSegundoNombre.Size = New System.Drawing.Size(90, 16)
        Me.LblSegundoNombre.TabIndex = 0
        Me.LblSegundoNombre.Text = "Segundo nombre"
        '
        'LblEdad
        '
        Me.LblEdad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblEdad.AutoSize = True
        Me.LblEdad.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEdad.Location = New System.Drawing.Point(107, 125)
        Me.LblEdad.Name = "LblEdad"
        Me.LblEdad.Size = New System.Drawing.Size(32, 16)
        Me.LblEdad.TabIndex = 0
        Me.LblEdad.Text = "Edad"
        '
        'LblPrimerNombre
        '
        Me.LblPrimerNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPrimerNombre.AutoSize = True
        Me.LblPrimerNombre.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrimerNombre.Location = New System.Drawing.Point(58, 58)
        Me.LblPrimerNombre.Name = "LblPrimerNombre"
        Me.LblPrimerNombre.Size = New System.Drawing.Size(81, 16)
        Me.LblPrimerNombre.TabIndex = 0
        Me.LblPrimerNombre.Text = "Primer nombre"
        '
        'LblCedula
        '
        Me.LblCedula.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCedula.AutoSize = True
        Me.LblCedula.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCedula.Location = New System.Drawing.Point(97, 25)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(42, 16)
        Me.LblCedula.TabIndex = 0
        Me.LblCedula.Text = "Cedula"
        '
        'BtnMantenimientoGuardarDatos
        '
        Me.BtnMantenimientoGuardarDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMantenimientoGuardarDatos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnMantenimientoGuardarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnMantenimientoGuardarDatos.FlatAppearance.BorderSize = 0
        Me.BtnMantenimientoGuardarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMantenimientoGuardarDatos.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMantenimientoGuardarDatos.Location = New System.Drawing.Point(547, 15)
        Me.BtnMantenimientoGuardarDatos.Name = "BtnMantenimientoGuardarDatos"
        Me.BtnMantenimientoGuardarDatos.Size = New System.Drawing.Size(117, 42)
        Me.BtnMantenimientoGuardarDatos.TabIndex = 5
        Me.BtnMantenimientoGuardarDatos.Text = "Guardar"
        Me.BtnMantenimientoGuardarDatos.UseVisualStyleBackColor = False
        '
        'BtnMantenimientoCancelar
        '
        Me.BtnMantenimientoCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMantenimientoCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnMantenimientoCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnMantenimientoCancelar.FlatAppearance.BorderSize = 0
        Me.BtnMantenimientoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMantenimientoCancelar.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMantenimientoCancelar.Location = New System.Drawing.Point(404, 15)
        Me.BtnMantenimientoCancelar.Name = "BtnMantenimientoCancelar"
        Me.BtnMantenimientoCancelar.Size = New System.Drawing.Size(117, 42)
        Me.BtnMantenimientoCancelar.TabIndex = 5
        Me.BtnMantenimientoCancelar.Text = "Cancelar"
        Me.BtnMantenimientoCancelar.UseVisualStyleBackColor = False
        '
        'RbtnCedulaConsultasAnteriores
        '
        Me.RbtnCedulaConsultasAnteriores.AutoSize = True
        Me.RbtnCedulaConsultasAnteriores.Checked = True
        Me.RbtnCedulaConsultasAnteriores.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnCedulaConsultasAnteriores.Location = New System.Drawing.Point(214, 12)
        Me.RbtnCedulaConsultasAnteriores.Name = "RbtnCedulaConsultasAnteriores"
        Me.RbtnCedulaConsultasAnteriores.Size = New System.Drawing.Size(81, 19)
        Me.RbtnCedulaConsultasAnteriores.TabIndex = 11
        Me.RbtnCedulaConsultasAnteriores.TabStop = True
        Me.RbtnCedulaConsultasAnteriores.Text = "Por cedula"
        Me.RbtnCedulaConsultasAnteriores.UseVisualStyleBackColor = True
        '
        'RbtnFechaConsultasAnteriores
        '
        Me.RbtnFechaConsultasAnteriores.AutoSize = True
        Me.RbtnFechaConsultasAnteriores.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnFechaConsultasAnteriores.Location = New System.Drawing.Point(333, 12)
        Me.RbtnFechaConsultasAnteriores.Name = "RbtnFechaConsultasAnteriores"
        Me.RbtnFechaConsultasAnteriores.Size = New System.Drawing.Size(75, 19)
        Me.RbtnFechaConsultasAnteriores.TabIndex = 11
        Me.RbtnFechaConsultasAnteriores.Text = "Por fecha"
        Me.RbtnFechaConsultasAnteriores.UseVisualStyleBackColor = True
        '
        'DateDatosConsultasAnteriores
        '
        Me.DateDatosConsultasAnteriores.CalendarFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDatosConsultasAnteriores.Checked = False
        Me.DateDatosConsultasAnteriores.CustomFormat = "MMMM dd, yyyy - dddd"
        Me.DateDatosConsultasAnteriores.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDatosConsultasAnteriores.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDatosConsultasAnteriores.Location = New System.Drawing.Point(436, 15)
        Me.DateDatosConsultasAnteriores.MaxDate = New Date(2020, 9, 15, 0, 0, 0, 0)
        Me.DateDatosConsultasAnteriores.MaximumSize = New System.Drawing.Size(156, 15)
        Me.DateDatosConsultasAnteriores.MinDate = New Date(2020, 8, 23, 0, 0, 0, 0)
        Me.DateDatosConsultasAnteriores.Name = "DateDatosConsultasAnteriores"
        Me.DateDatosConsultasAnteriores.Size = New System.Drawing.Size(156, 15)
        Me.DateDatosConsultasAnteriores.TabIndex = 12
        Me.DateDatosConsultasAnteriores.Value = New Date(2020, 8, 23, 0, 0, 0, 0)
        '
        'BtnBuscarConsultasAnteriores
        '
        Me.BtnBuscarConsultasAnteriores.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnBuscarConsultasAnteriores.FlatAppearance.BorderSize = 0
        Me.BtnBuscarConsultasAnteriores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarConsultasAnteriores.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarConsultasAnteriores.Location = New System.Drawing.Point(813, 26)
        Me.BtnBuscarConsultasAnteriores.Name = "BtnBuscarConsultasAnteriores"
        Me.BtnBuscarConsultasAnteriores.Size = New System.Drawing.Size(114, 41)
        Me.BtnBuscarConsultasAnteriores.TabIndex = 13
        Me.BtnBuscarConsultasAnteriores.Text = "Buscar"
        Me.BtnBuscarConsultasAnteriores.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnBuscarConsultasAnteriores)
        Me.GroupBox1.Controls.Add(Me.DateDatosConsultasAnteriores)
        Me.GroupBox1.Controls.Add(Me.RbtnFechaConsultasAnteriores)
        Me.GroupBox1.Controls.Add(Me.RbtnCedulaConsultasAnteriores)
        Me.GroupBox1.Controls.Add(Me.LbxConsultasAnteriores)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 565)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(689, 121)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultas anteriores"
        '
        'LbxConsultasAnteriores
        '
        Me.LbxConsultasAnteriores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbxConsultasAnteriores.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbxConsultasAnteriores.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbxConsultasAnteriores.ForeColor = System.Drawing.Color.Black
        Me.LbxConsultasAnteriores.FormattingEnabled = True
        Me.LbxConsultasAnteriores.HorizontalScrollbar = True
        Me.LbxConsultasAnteriores.ItemHeight = 15
        Me.LbxConsultasAnteriores.Location = New System.Drawing.Point(105, 34)
        Me.LbxConsultasAnteriores.MaximumSize = New System.Drawing.Size(565, 80)
        Me.LbxConsultasAnteriores.Name = "LbxConsultasAnteriores"
        Me.LbxConsultasAnteriores.Size = New System.Drawing.Size(565, 79)
        Me.LbxConsultasAnteriores.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnMantenimientoGuardarDatos)
        Me.GroupBox3.Controls.Add(Me.BtnMantenimientoCancelar)
        Me.GroupBox3.Location = New System.Drawing.Point(25, 709)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(690, 67)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'GrxDatosDelPaciente
        '
        Me.GrxDatosDelPaciente.BackColor = System.Drawing.Color.White
        Me.GrxDatosDelPaciente.Controls.Add(Me.LblDatosEnferMaternas)
        Me.GrxDatosDelPaciente.Controls.Add(Me.LblDatosEnfermPaternas)
        Me.GrxDatosDelPaciente.Controls.Add(Me.GroupBox1)
        Me.GrxDatosDelPaciente.Controls.Add(Me.LblDatosCirujias)
        Me.GrxDatosDelPaciente.Controls.Add(Me.LblDatosAlergiasAmedicamentos)
        Me.GrxDatosDelPaciente.Controls.Add(Me.LblDatosEnferAnterior)
        Me.GrxDatosDelPaciente.Controls.Add(Me.LblDatosFechaIngreso)
        Me.GrxDatosDelPaciente.Controls.Add(Me.LblDatosSegApell)
        Me.GrxDatosDelPaciente.Controls.Add(Me.LbldatosFechaNacimiento)
        Me.GrxDatosDelPaciente.Controls.Add(Me.LblDatosTelefono)
        Me.GrxDatosDelPaciente.Controls.Add(Me.LblDatosDireccion)
        Me.GrxDatosDelPaciente.Controls.Add(Me.LblDatosEstadoCivil)
        Me.GrxDatosDelPaciente.Controls.Add(Me.LblDatosEdad)
        Me.GrxDatosDelPaciente.Controls.Add(Me.LblDatosGenero)
        Me.GrxDatosDelPaciente.Controls.Add(Me.LblDatosSegunNom)
        Me.GrxDatosDelPaciente.Controls.Add(Me.LblDatosEmail)
        Me.GrxDatosDelPaciente.Controls.Add(Me.LblDatosEscolaridad)
        Me.GrxDatosDelPaciente.Controls.Add(Me.LblprimApell)
        Me.GrxDatosDelPaciente.Controls.Add(Me.LblDatosocupacion)
        Me.GrxDatosDelPaciente.Controls.Add(Me.LbldatosPrimNombre)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Lbldatoscedula)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label42)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label43)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label44)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label45)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label46)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label33)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label35)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label2)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label36)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label37)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label3)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label38)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label39)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label40)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label26)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label27)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label29)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label30)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label31)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label32)
        Me.GrxDatosDelPaciente.Controls.Add(Me.PicDatosExistentes)
        Me.GrxDatosDelPaciente.Controls.Add(Me.PictureBox4)
        Me.GrxDatosDelPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GrxDatosDelPaciente.Font = New System.Drawing.Font("Ubuntu", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.GrxDatosDelPaciente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.GrxDatosDelPaciente.Location = New System.Drawing.Point(726, 4)
        Me.GrxDatosDelPaciente.Name = "GrxDatosDelPaciente"
        Me.GrxDatosDelPaciente.Size = New System.Drawing.Size(751, 695)
        Me.GrxDatosDelPaciente.TabIndex = 19
        Me.GrxDatosDelPaciente.TabStop = False
        Me.GrxDatosDelPaciente.Text = "Datos existentes del paciente"
        '
        'LblDatosEnferMaternas
        '
        Me.LblDatosEnferMaternas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDatosEnferMaternas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblDatosEnferMaternas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDatosEnferMaternas.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosEnferMaternas.ForeColor = System.Drawing.Color.Black
        Me.LblDatosEnferMaternas.Location = New System.Drawing.Point(130, 502)
        Me.LblDatosEnferMaternas.MaximumSize = New System.Drawing.Size(565, 66)
        Me.LblDatosEnferMaternas.Name = "LblDatosEnferMaternas"
        Me.LblDatosEnferMaternas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblDatosEnferMaternas.Size = New System.Drawing.Size(565, 53)
        Me.LblDatosEnferMaternas.TabIndex = 52
        Me.LblDatosEnferMaternas.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblDatosEnfermPaternas
        '
        Me.LblDatosEnfermPaternas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDatosEnfermPaternas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblDatosEnfermPaternas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDatosEnfermPaternas.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosEnfermPaternas.ForeColor = System.Drawing.Color.Black
        Me.LblDatosEnfermPaternas.Location = New System.Drawing.Point(130, 439)
        Me.LblDatosEnfermPaternas.MaximumSize = New System.Drawing.Size(565, 66)
        Me.LblDatosEnfermPaternas.Name = "LblDatosEnfermPaternas"
        Me.LblDatosEnfermPaternas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblDatosEnfermPaternas.Size = New System.Drawing.Size(565, 53)
        Me.LblDatosEnfermPaternas.TabIndex = 52
        Me.LblDatosEnfermPaternas.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblDatosCirujias
        '
        Me.LblDatosCirujias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDatosCirujias.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblDatosCirujias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDatosCirujias.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosCirujias.ForeColor = System.Drawing.Color.Black
        Me.LblDatosCirujias.Location = New System.Drawing.Point(130, 376)
        Me.LblDatosCirujias.MaximumSize = New System.Drawing.Size(565, 66)
        Me.LblDatosCirujias.Name = "LblDatosCirujias"
        Me.LblDatosCirujias.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblDatosCirujias.Size = New System.Drawing.Size(565, 53)
        Me.LblDatosCirujias.TabIndex = 52
        Me.LblDatosCirujias.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblDatosAlergiasAmedicamentos
        '
        Me.LblDatosAlergiasAmedicamentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDatosAlergiasAmedicamentos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblDatosAlergiasAmedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDatosAlergiasAmedicamentos.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosAlergiasAmedicamentos.ForeColor = System.Drawing.Color.Black
        Me.LblDatosAlergiasAmedicamentos.Location = New System.Drawing.Point(130, 313)
        Me.LblDatosAlergiasAmedicamentos.MaximumSize = New System.Drawing.Size(565, 66)
        Me.LblDatosAlergiasAmedicamentos.Name = "LblDatosAlergiasAmedicamentos"
        Me.LblDatosAlergiasAmedicamentos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblDatosAlergiasAmedicamentos.Size = New System.Drawing.Size(565, 53)
        Me.LblDatosAlergiasAmedicamentos.TabIndex = 52
        Me.LblDatosAlergiasAmedicamentos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblDatosEnferAnterior
        '
        Me.LblDatosEnferAnterior.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDatosEnferAnterior.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblDatosEnferAnterior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDatosEnferAnterior.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosEnferAnterior.ForeColor = System.Drawing.Color.Black
        Me.LblDatosEnferAnterior.Location = New System.Drawing.Point(130, 250)
        Me.LblDatosEnferAnterior.MaximumSize = New System.Drawing.Size(565, 66)
        Me.LblDatosEnferAnterior.Name = "LblDatosEnferAnterior"
        Me.LblDatosEnferAnterior.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblDatosEnferAnterior.Size = New System.Drawing.Size(565, 53)
        Me.LblDatosEnferAnterior.TabIndex = 52
        Me.LblDatosEnferAnterior.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblDatosFechaIngreso
        '
        Me.LblDatosFechaIngreso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDatosFechaIngreso.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblDatosFechaIngreso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDatosFechaIngreso.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosFechaIngreso.ForeColor = System.Drawing.Color.Black
        Me.LblDatosFechaIngreso.Location = New System.Drawing.Point(405, 226)
        Me.LblDatosFechaIngreso.MaximumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosFechaIngreso.MinimumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosFechaIngreso.Name = "LblDatosFechaIngreso"
        Me.LblDatosFechaIngreso.Size = New System.Drawing.Size(137, 17)
        Me.LblDatosFechaIngreso.TabIndex = 47
        '
        'LblDatosSegApell
        '
        Me.LblDatosSegApell.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDatosSegApell.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblDatosSegApell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDatosSegApell.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosSegApell.ForeColor = System.Drawing.Color.Black
        Me.LblDatosSegApell.Location = New System.Drawing.Point(405, 105)
        Me.LblDatosSegApell.MaximumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosSegApell.MinimumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosSegApell.Name = "LblDatosSegApell"
        Me.LblDatosSegApell.Size = New System.Drawing.Size(137, 17)
        Me.LblDatosSegApell.TabIndex = 41
        '
        'LbldatosFechaNacimiento
        '
        Me.LbldatosFechaNacimiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbldatosFechaNacimiento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbldatosFechaNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbldatosFechaNacimiento.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbldatosFechaNacimiento.ForeColor = System.Drawing.Color.Black
        Me.LbldatosFechaNacimiento.Location = New System.Drawing.Point(405, 54)
        Me.LbldatosFechaNacimiento.MaximumSize = New System.Drawing.Size(137, 17)
        Me.LbldatosFechaNacimiento.MinimumSize = New System.Drawing.Size(137, 17)
        Me.LbldatosFechaNacimiento.Name = "LbldatosFechaNacimiento"
        Me.LbldatosFechaNacimiento.Size = New System.Drawing.Size(137, 17)
        Me.LbldatosFechaNacimiento.TabIndex = 42
        '
        'LblDatosTelefono
        '
        Me.LblDatosTelefono.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDatosTelefono.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblDatosTelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDatosTelefono.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosTelefono.ForeColor = System.Drawing.Color.Black
        Me.LblDatosTelefono.Location = New System.Drawing.Point(405, 202)
        Me.LblDatosTelefono.MaximumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosTelefono.MinimumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosTelefono.Name = "LblDatosTelefono"
        Me.LblDatosTelefono.Size = New System.Drawing.Size(137, 17)
        Me.LblDatosTelefono.TabIndex = 43
        '
        'LblDatosDireccion
        '
        Me.LblDatosDireccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDatosDireccion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblDatosDireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDatosDireccion.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosDireccion.ForeColor = System.Drawing.Color.Black
        Me.LblDatosDireccion.Location = New System.Drawing.Point(405, 179)
        Me.LblDatosDireccion.MaximumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosDireccion.MinimumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosDireccion.Name = "LblDatosDireccion"
        Me.LblDatosDireccion.Size = New System.Drawing.Size(137, 17)
        Me.LblDatosDireccion.TabIndex = 43
        '
        'LblDatosEstadoCivil
        '
        Me.LblDatosEstadoCivil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDatosEstadoCivil.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblDatosEstadoCivil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDatosEstadoCivil.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosEstadoCivil.ForeColor = System.Drawing.Color.Black
        Me.LblDatosEstadoCivil.Location = New System.Drawing.Point(405, 155)
        Me.LblDatosEstadoCivil.MaximumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosEstadoCivil.MinimumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosEstadoCivil.Name = "LblDatosEstadoCivil"
        Me.LblDatosEstadoCivil.Size = New System.Drawing.Size(137, 17)
        Me.LblDatosEstadoCivil.TabIndex = 44
        '
        'LblDatosEdad
        '
        Me.LblDatosEdad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDatosEdad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblDatosEdad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDatosEdad.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosEdad.ForeColor = System.Drawing.Color.Black
        Me.LblDatosEdad.Location = New System.Drawing.Point(128, 131)
        Me.LblDatosEdad.MaximumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosEdad.MinimumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosEdad.Name = "LblDatosEdad"
        Me.LblDatosEdad.Size = New System.Drawing.Size(137, 17)
        Me.LblDatosEdad.TabIndex = 45
        '
        'LblDatosGenero
        '
        Me.LblDatosGenero.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDatosGenero.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblDatosGenero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDatosGenero.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosGenero.ForeColor = System.Drawing.Color.Black
        Me.LblDatosGenero.Location = New System.Drawing.Point(405, 130)
        Me.LblDatosGenero.MaximumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosGenero.MinimumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosGenero.Name = "LblDatosGenero"
        Me.LblDatosGenero.Size = New System.Drawing.Size(137, 17)
        Me.LblDatosGenero.TabIndex = 45
        '
        'LblDatosSegunNom
        '
        Me.LblDatosSegunNom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDatosSegunNom.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblDatosSegunNom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDatosSegunNom.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosSegunNom.ForeColor = System.Drawing.Color.Black
        Me.LblDatosSegunNom.Location = New System.Drawing.Point(405, 79)
        Me.LblDatosSegunNom.MaximumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosSegunNom.MinimumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosSegunNom.Name = "LblDatosSegunNom"
        Me.LblDatosSegunNom.Size = New System.Drawing.Size(137, 17)
        Me.LblDatosSegunNom.TabIndex = 46
        '
        'LblDatosEmail
        '
        Me.LblDatosEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDatosEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblDatosEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDatosEmail.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosEmail.ForeColor = System.Drawing.Color.Black
        Me.LblDatosEmail.Location = New System.Drawing.Point(128, 204)
        Me.LblDatosEmail.MaximumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosEmail.MinimumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosEmail.Name = "LblDatosEmail"
        Me.LblDatosEmail.Size = New System.Drawing.Size(137, 17)
        Me.LblDatosEmail.TabIndex = 33
        '
        'LblDatosEscolaridad
        '
        Me.LblDatosEscolaridad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDatosEscolaridad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblDatosEscolaridad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDatosEscolaridad.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosEscolaridad.ForeColor = System.Drawing.Color.Black
        Me.LblDatosEscolaridad.Location = New System.Drawing.Point(128, 179)
        Me.LblDatosEscolaridad.MaximumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosEscolaridad.MinimumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosEscolaridad.Name = "LblDatosEscolaridad"
        Me.LblDatosEscolaridad.Size = New System.Drawing.Size(137, 17)
        Me.LblDatosEscolaridad.TabIndex = 34
        '
        'LblprimApell
        '
        Me.LblprimApell.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblprimApell.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblprimApell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblprimApell.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblprimApell.ForeColor = System.Drawing.Color.Black
        Me.LblprimApell.Location = New System.Drawing.Point(128, 107)
        Me.LblprimApell.MaximumSize = New System.Drawing.Size(137, 17)
        Me.LblprimApell.MinimumSize = New System.Drawing.Size(137, 17)
        Me.LblprimApell.Name = "LblprimApell"
        Me.LblprimApell.Size = New System.Drawing.Size(137, 17)
        Me.LblprimApell.TabIndex = 36
        '
        'LblDatosocupacion
        '
        Me.LblDatosocupacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDatosocupacion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblDatosocupacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDatosocupacion.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosocupacion.ForeColor = System.Drawing.Color.Black
        Me.LblDatosocupacion.Location = New System.Drawing.Point(128, 155)
        Me.LblDatosocupacion.MaximumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosocupacion.MinimumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosocupacion.Name = "LblDatosocupacion"
        Me.LblDatosocupacion.Size = New System.Drawing.Size(137, 17)
        Me.LblDatosocupacion.TabIndex = 37
        '
        'LbldatosPrimNombre
        '
        Me.LbldatosPrimNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbldatosPrimNombre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbldatosPrimNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbldatosPrimNombre.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbldatosPrimNombre.ForeColor = System.Drawing.Color.Black
        Me.LbldatosPrimNombre.Location = New System.Drawing.Point(128, 83)
        Me.LbldatosPrimNombre.MaximumSize = New System.Drawing.Size(137, 17)
        Me.LbldatosPrimNombre.MinimumSize = New System.Drawing.Size(137, 17)
        Me.LbldatosPrimNombre.Name = "LbldatosPrimNombre"
        Me.LbldatosPrimNombre.Size = New System.Drawing.Size(137, 17)
        Me.LbldatosPrimNombre.TabIndex = 38
        '
        'Lbldatoscedula
        '
        Me.Lbldatoscedula.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbldatoscedula.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Lbldatoscedula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbldatoscedula.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldatoscedula.ForeColor = System.Drawing.Color.Black
        Me.Lbldatoscedula.Location = New System.Drawing.Point(128, 56)
        Me.Lbldatoscedula.MaximumSize = New System.Drawing.Size(137, 17)
        Me.Lbldatoscedula.MinimumSize = New System.Drawing.Size(137, 17)
        Me.Lbldatoscedula.Name = "Lbldatoscedula"
        Me.Lbldatoscedula.Size = New System.Drawing.Size(137, 17)
        Me.Lbldatoscedula.TabIndex = 39
        '
        'Label42
        '
        Me.Label42.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label42.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(22, 502)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(102, 60)
        Me.Label42.TabIndex = 28
        Me.Label42.Text = "Enfermedades maternas:"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label43
        '
        Me.Label43.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label43.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(22, 374)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(102, 60)
        Me.Label43.TabIndex = 29
        Me.Label43.Text = "Cirujias:"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label44
        '
        Me.Label44.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label44.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(30, 313)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(94, 60)
        Me.Label44.TabIndex = 30
        Me.Label44.Text = "Alergias a medicamentos:"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label45
        '
        Me.Label45.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label45.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(22, 436)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(102, 60)
        Me.Label45.TabIndex = 31
        Me.Label45.Text = "Enfermedades paternas:"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label46
        '
        Me.Label46.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label46.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(22, 249)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(102, 60)
        Me.Label46.TabIndex = 32
        Me.Label46.Text = "Enfermedades  anteriores:"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label33
        '
        Me.Label33.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(297, 228)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(103, 15)
        Me.Label33.TabIndex = 26
        Me.Label33.Text = "Fecha de ingreso:"
        '
        'Label35
        '
        Me.Label35.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(296, 105)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(103, 15)
        Me.Label35.TabIndex = 20
        Me.Label35.Text = "Segundo apellido:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(335, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Telefono:"
        '
        'Label36
        '
        Me.Label36.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(279, 54)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(121, 15)
        Me.Label36.TabIndex = 21
        Me.Label36.Text = "Fecha de nacimiento:"
        '
        'Label37
        '
        Me.Label37.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(335, 179)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(65, 15)
        Me.Label37.TabIndex = 22
        Me.Label37.Text = "Direccion:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Edad:"
        '
        'Label38
        '
        Me.Label38.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(328, 155)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(72, 15)
        Me.Label38.TabIndex = 23
        Me.Label38.Text = "Estado civil:"
        '
        'Label39
        '
        Me.Label39.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(349, 130)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(51, 15)
        Me.Label39.TabIndex = 24
        Me.Label39.Text = "Genero:"
        '
        'Label40
        '
        Me.Label40.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(298, 79)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(102, 15)
        Me.Label40.TabIndex = 25
        Me.Label40.Text = "Segundo nombre:"
        '
        'Label26
        '
        Me.Label26.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(8, 205)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(114, 15)
        Me.Label26.TabIndex = 12
        Me.Label26.Text = "Correo electronico:"
        '
        'Label27
        '
        Me.Label27.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(48, 182)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(74, 15)
        Me.Label27.TabIndex = 13
        Me.Label27.Text = "Escolaridad:"
        '
        'Label29
        '
        Me.Label29.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(27, 107)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(96, 15)
        Me.Label29.TabIndex = 15
        Me.Label29.Text = "Primer apellido:"
        '
        'Label30
        '
        Me.Label30.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(53, 159)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(69, 15)
        Me.Label30.TabIndex = 16
        Me.Label30.Text = "Ocupacion:"
        '
        'Label31
        '
        Me.Label31.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(27, 80)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(95, 15)
        Me.Label31.TabIndex = 17
        Me.Label31.Text = "Primer nombre:"
        '
        'Label32
        '
        Me.Label32.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(73, 52)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(49, 15)
        Me.Label32.TabIndex = 18
        Me.Label32.Text = "Cedula:"
        '
        'PicDatosExistentes
        '
        Me.PicDatosExistentes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicDatosExistentes.Image = Global._3DevMedicalSoftware.My.Resources.Resources.user2
        Me.PicDatosExistentes.Location = New System.Drawing.Point(555, 55)
        Me.PicDatosExistentes.MaximumSize = New System.Drawing.Size(140, 140)
        Me.PicDatosExistentes.MinimumSize = New System.Drawing.Size(140, 140)
        Me.PicDatosExistentes.Name = "PicDatosExistentes"
        Me.PicDatosExistentes.Size = New System.Drawing.Size(140, 140)
        Me.PicDatosExistentes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicDatosExistentes.TabIndex = 11
        Me.PicDatosExistentes.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Image = Global._3DevMedicalSoftware.My.Resources.Resources.user2
        Me.PictureBox4.Location = New System.Drawing.Point(857, 120)
        Me.PictureBox4.MaximumSize = New System.Drawing.Size(137, 138)
        Me.PictureBox4.MinimumSize = New System.Drawing.Size(137, 138)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(137, 138)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'BtnContinuarAEntrevista
        '
        Me.BtnContinuarAEntrevista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnContinuarAEntrevista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnContinuarAEntrevista.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnContinuarAEntrevista.FlatAppearance.BorderSize = 0
        Me.BtnContinuarAEntrevista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnContinuarAEntrevista.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContinuarAEntrevista.Location = New System.Drawing.Point(484, 15)
        Me.BtnContinuarAEntrevista.MaximumSize = New System.Drawing.Size(260, 42)
        Me.BtnContinuarAEntrevista.Name = "BtnContinuarAEntrevista"
        Me.BtnContinuarAEntrevista.Size = New System.Drawing.Size(260, 42)
        Me.BtnContinuarAEntrevista.TabIndex = 6
        Me.BtnContinuarAEntrevista.Text = "Continuar a entrevista inicial >>>"
        Me.BtnContinuarAEntrevista.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnContinuarAEntrevista)
        Me.GroupBox2.Location = New System.Drawing.Point(728, 710)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(751, 67)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.TxtBuscarPaciente)
        Me.GroupBox4.Controls.Add(Me.BtnBuscarPaciente)
        Me.GroupBox4.Controls.Add(Me.BtnIngresoNuevoPaciente)
        Me.GroupBox4.Font = New System.Drawing.Font("Ubuntu", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(25, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(690, 86)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pacientes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(613, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 14)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "(Por Cedula)"
        '
        'TxtBuscarPaciente
        '
        Me.TxtBuscarPaciente.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.TxtBuscarPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscarPaciente.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscarPaciente.Location = New System.Drawing.Point(554, 32)
        Me.TxtBuscarPaciente.MaximumSize = New System.Drawing.Size(214, 30)
        Me.TxtBuscarPaciente.MaxLength = 8
        Me.TxtBuscarPaciente.Name = "TxtBuscarPaciente"
        Me.TxtBuscarPaciente.Size = New System.Drawing.Size(113, 26)
        Me.TxtBuscarPaciente.TabIndex = 11
        '
        'BtnBuscarPaciente
        '
        Me.BtnBuscarPaciente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnBuscarPaciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnBuscarPaciente.FlatAppearance.BorderSize = 0
        Me.BtnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarPaciente.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarPaciente.Location = New System.Drawing.Point(366, 29)
        Me.BtnBuscarPaciente.Name = "BtnBuscarPaciente"
        Me.BtnBuscarPaciente.Size = New System.Drawing.Size(151, 42)
        Me.BtnBuscarPaciente.TabIndex = 5
        Me.BtnBuscarPaciente.Text = "Buscar paciente"
        Me.BtnBuscarPaciente.UseVisualStyleBackColor = False
        '
        'BtnIngresoNuevoPaciente
        '
        Me.BtnIngresoNuevoPaciente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnIngresoNuevoPaciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnIngresoNuevoPaciente.FlatAppearance.BorderSize = 0
        Me.BtnIngresoNuevoPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIngresoNuevoPaciente.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresoNuevoPaciente.Location = New System.Drawing.Point(150, 29)
        Me.BtnIngresoNuevoPaciente.Name = "BtnIngresoNuevoPaciente"
        Me.BtnIngresoNuevoPaciente.Size = New System.Drawing.Size(187, 42)
        Me.BtnIngresoNuevoPaciente.TabIndex = 5
        Me.BtnIngresoNuevoPaciente.Text = "Ingresar nuevo paciente"
        Me.BtnIngresoNuevoPaciente.UseVisualStyleBackColor = False
        '
        'FrmMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1500, 800)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GrxDatosDelPaciente)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GbxIngresoPacientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMantenimiento"
        Me.Padding = New System.Windows.Forms.Padding(25, 5, 25, 10)
        Me.Text = "FrmMantenimiento"
        Me.GbxIngresoPacientes.ResumeLayout(False)
        Me.GbxIngresoPacientes.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GrxDatosDelPaciente.ResumeLayout(False)
        Me.GrxDatosDelPaciente.PerformLayout()
        CType(Me.PicDatosExistentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbxIngresoPacientes As GroupBox
    Friend WithEvents LblApellidoPaterno As Label
    Friend WithEvents LblPrimerNombre As Label
    Friend WithEvents LblCedula As Label
    Friend WithEvents LblApellidoMaterno As Label
    Friend WithEvents LblFechadeNacimiento As Label
    Friend WithEvents LblSegundoNombre As Label
    Friend WithEvents TxtApellidoPaterno As TextBox
    Friend WithEvents TxtPrimerNombre As TextBox
    Friend WithEvents TxtApellidoMaterno As TextBox
    Friend WithEvents TxtSegundoNombre As TextBox
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents BtnMantenimientoCancelar As Button
    Friend WithEvents BtnMantenimientoGuardarDatos As Button
    Friend WithEvents TxtEscolaridad As TextBox
    Friend WithEvents TxtOcupacion As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtGenero As TextBox
    Friend WithEvents TxtAlergiasMedicamentos As TextBox
    Friend WithEvents TxtEnfermeAnteriores As TextBox
    Friend WithEvents LblAlergiasMedicamentos As Label
    Friend WithEvents LblDireccion As Label
    Friend WithEvents LblEnfAnteriores As Label
    Friend WithEvents LblEscolaridad As Label
    Friend WithEvents LblEstadoCivil As Label
    Friend WithEvents LblOcupacion As Label
    Friend WithEvents LblGenero As Label
    Friend WithEvents LblEdad As Label
    Friend WithEvents TxtEnferMaternas As TextBox
    Friend WithEvents TxtEnfermedPaternas As TextBox
    Friend WithEvents lblEnfMaternas As Label
    Friend WithEvents LblEnfPaternas As Label
    Friend WithEvents LblFechIngresos As Label
    Friend WithEvents DateTimeFechaAlta As DateTimePicker
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents LblEMail As Label
    Friend WithEvents DateTimeFechaNacimiento As DateTimePicker
    Friend WithEvents TxtCirujias As TextBox
    Friend WithEvents TxtTelefAcompañante As TextBox
    Friend WithEvents TxtNombreAcompañante As TextBox
    Friend WithEvents LblCirujias As Label
    Friend WithEvents LblTelAcomp As Label
    Friend WithEvents LblNomAcomp As Label
    Friend WithEvents BtnBuscarConsultasAnteriores As Button
    Friend WithEvents DateDatosConsultasAnteriores As DateTimePicker
    Friend WithEvents RbtnFechaConsultasAnteriores As RadioButton
    Friend WithEvents RbtnCedulaConsultasAnteriores As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtIngresoAnalisis As TextBox
    Friend WithEvents LblIngresoAnalisis As Label
    Friend WithEvents GrxDatosDelPaciente As GroupBox
    Friend WithEvents LblDatosEnferMaternas As Label
    Friend WithEvents LblDatosEnfermPaternas As Label
    Friend WithEvents LblDatosCirujias As Label
    Friend WithEvents LblDatosAlergiasAmedicamentos As Label
    Friend WithEvents LblDatosEnferAnterior As Label
    Friend WithEvents LblDatosFechaIngreso As Label
    Friend WithEvents LblDatosSegApell As Label
    Friend WithEvents LbldatosFechaNacimiento As Label
    Friend WithEvents LblDatosDireccion As Label
    Friend WithEvents LblDatosEstadoCivil As Label
    Friend WithEvents LblDatosGenero As Label
    Friend WithEvents LblDatosSegunNom As Label
    Friend WithEvents LblDatosEmail As Label
    Friend WithEvents LblDatosEscolaridad As Label
    Friend WithEvents LblprimApell As Label
    Friend WithEvents LblDatosocupacion As Label
    Friend WithEvents LbldatosPrimNombre As Label
    Friend WithEvents Lbldatoscedula As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents PicDatosExistentes As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LbxConsultasAnteriores As ListBox
    Friend WithEvents BtnContinuarAEntrevista As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtBuscarPaciente As TextBox
    Friend WithEvents BtnBuscarPaciente As Button
    Friend WithEvents BtnIngresoNuevoPaciente As Button
    Friend WithEvents ComEstadocivil As ComboBox
    Friend WithEvents TxtEdadCalculada As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents LblTelefono As Label
    Friend WithEvents LblDatosTelefono As Label
    Friend WithEvents LblDatosEdad As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
