﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimiento))
        Me.GbxIngresoPacientes = New System.Windows.Forms.GroupBox()
        Me.ComEstadocivil = New System.Windows.Forms.ComboBox()
        Me.BtncargarImagen = New System.Windows.Forms.Button()
        Me.NumEdadPaciente = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTimeFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.TxtIngresoAnalisis = New System.Windows.Forms.TextBox()
        Me.TxtEnferMaternas = New System.Windows.Forms.TextBox()
        Me.TxtEnfermedPaternas = New System.Windows.Forms.TextBox()
        Me.TxtCirujias = New System.Windows.Forms.TextBox()
        Me.TxtAlergiasMedicamentos = New System.Windows.Forms.TextBox()
        Me.TxtEnfermeAnteriores = New System.Windows.Forms.TextBox()
        Me.PictureImagenPerfil = New System.Windows.Forms.PictureBox()
        Me.TxtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.TxtTelefAcompañante = New System.Windows.Forms.TextBox()
        Me.TxtNombreAcompañante = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtEscolaridad = New System.Windows.Forms.TextBox()
        Me.TxtOcupacion = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.TxtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.TxtGenero = New System.Windows.Forms.TextBox()
        Me.TxtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LblApellidoMaterno = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LblFechadeNacimiento = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblApellidoPaterno = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblSegundoNombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.LblDatosDireccion = New System.Windows.Forms.Label()
        Me.LblDatosEstadoCivil = New System.Windows.Forms.Label()
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
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
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
        Me.TxtBuscarPaciente = New System.Windows.Forms.TextBox()
        Me.BtnBuscarPaciente = New System.Windows.Forms.Button()
        Me.BtnIngresoNuevoPaciente = New System.Windows.Forms.Button()
        Me.OFcargarImagen = New System.Windows.Forms.OpenFileDialog()
        Me.GbxIngresoPacientes.SuspendLayout()
        CType(Me.NumEdadPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureImagenPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GbxIngresoPacientes.Controls.Add(Me.ComEstadocivil)
        Me.GbxIngresoPacientes.Controls.Add(Me.BtncargarImagen)
        Me.GbxIngresoPacientes.Controls.Add(Me.NumEdadPaciente)
        Me.GbxIngresoPacientes.Controls.Add(Me.Label13)
        Me.GbxIngresoPacientes.Controls.Add(Me.DateTimeFechaNacimiento)
        Me.GbxIngresoPacientes.Controls.Add(Me.DateTimeFechaAlta)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtIngresoAnalisis)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtEnferMaternas)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtEnfermedPaternas)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtCirujias)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtAlergiasMedicamentos)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtEnfermeAnteriores)
        Me.GbxIngresoPacientes.Controls.Add(Me.PictureImagenPerfil)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtApellidoPaterno)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtTelefAcompañante)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtNombreAcompañante)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtEmail)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtEscolaridad)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtOcupacion)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtDireccion)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtApellidoMaterno)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtPrimerNombre)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtGenero)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtSegundoNombre)
        Me.GbxIngresoPacientes.Controls.Add(Me.TxtCedula)
        Me.GbxIngresoPacientes.Controls.Add(Me.Label18)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblApellidoMaterno)
        Me.GbxIngresoPacientes.Controls.Add(Me.Label11)
        Me.GbxIngresoPacientes.Controls.Add(Me.Label17)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblFechadeNacimiento)
        Me.GbxIngresoPacientes.Controls.Add(Me.Label6)
        Me.GbxIngresoPacientes.Controls.Add(Me.Label16)
        Me.GbxIngresoPacientes.Controls.Add(Me.Label7)
        Me.GbxIngresoPacientes.Controls.Add(Me.Label15)
        Me.GbxIngresoPacientes.Controls.Add(Me.Label10)
        Me.GbxIngresoPacientes.Controls.Add(Me.Label12)
        Me.GbxIngresoPacientes.Controls.Add(Me.Label5)
        Me.GbxIngresoPacientes.Controls.Add(Me.Label4)
        Me.GbxIngresoPacientes.Controls.Add(Me.Label9)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblApellidoPaterno)
        Me.GbxIngresoPacientes.Controls.Add(Me.Label3)
        Me.GbxIngresoPacientes.Controls.Add(Me.Label8)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblSegundoNombre)
        Me.GbxIngresoPacientes.Controls.Add(Me.Label2)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblPrimerNombre)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblCedula)
        Me.GbxIngresoPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GbxIngresoPacientes.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxIngresoPacientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.GbxIngresoPacientes.Location = New System.Drawing.Point(25, 99)
        Me.GbxIngresoPacientes.Name = "GbxIngresoPacientes"
        Me.GbxIngresoPacientes.Size = New System.Drawing.Size(970, 599)
        Me.GbxIngresoPacientes.TabIndex = 0
        Me.GbxIngresoPacientes.TabStop = False
        Me.GbxIngresoPacientes.Text = "Anamnesis"
        Me.GbxIngresoPacientes.Visible = False
        '
        'ComEstadocivil
        '
        Me.ComEstadocivil.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComEstadocivil.FormattingEnabled = True
        Me.ComEstadocivil.Items.AddRange(New Object() {"Soltero/a", "Casado/a", "Divorciado/a", "Viudo/a "})
        Me.ComEstadocivil.Location = New System.Drawing.Point(588, 171)
        Me.ComEstadocivil.Name = "ComEstadocivil"
        Me.ComEstadocivil.Size = New System.Drawing.Size(215, 28)
        Me.ComEstadocivil.TabIndex = 12
        '
        'BtncargarImagen
        '
        Me.BtncargarImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtncargarImagen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtncargarImagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtncargarImagen.FlatAppearance.BorderSize = 0
        Me.BtncargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtncargarImagen.Font = New System.Drawing.Font("Ubuntu", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtncargarImagen.Location = New System.Drawing.Point(816, 189)
        Me.BtncargarImagen.MaximumSize = New System.Drawing.Size(140, 33)
        Me.BtncargarImagen.MinimumSize = New System.Drawing.Size(145, 33)
        Me.BtncargarImagen.Name = "BtncargarImagen"
        Me.BtncargarImagen.Size = New System.Drawing.Size(145, 33)
        Me.BtncargarImagen.TabIndex = 6
        Me.BtncargarImagen.Text = "Cargar imagen"
        Me.BtncargarImagen.UseVisualStyleBackColor = False
        '
        'NumEdadPaciente
        '
        Me.NumEdadPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumEdadPaciente.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumEdadPaciente.Location = New System.Drawing.Point(290, 138)
        Me.NumEdadPaciente.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.NumEdadPaciente.MinimumSize = New System.Drawing.Size(120, 0)
        Me.NumEdadPaciente.Name = "NumEdadPaciente"
        Me.NumEdadPaciente.Size = New System.Drawing.Size(120, 26)
        Me.NumEdadPaciente.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(455, 240)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 20)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Fecha de ingreso"
        '
        'DateTimeFechaNacimiento
        '
        Me.DateTimeFechaNacimiento.CalendarFont = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeFechaNacimiento.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DateTimeFechaNacimiento.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DateTimeFechaNacimiento.Checked = False
        Me.DateTimeFechaNacimiento.CustomFormat = "MMMM dd, yyyy - dddd"
        Me.DateTimeFechaNacimiento.Font = New System.Drawing.Font("Ubuntu", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFechaNacimiento.Location = New System.Drawing.Point(588, 43)
        Me.DateTimeFechaNacimiento.MaximumSize = New System.Drawing.Size(214, 26)
        Me.DateTimeFechaNacimiento.MinDate = New Date(1930, 1, 1, 0, 0, 0, 0)
        Me.DateTimeFechaNacimiento.MinimumSize = New System.Drawing.Size(214, 26)
        Me.DateTimeFechaNacimiento.Name = "DateTimeFechaNacimiento"
        Me.DateTimeFechaNacimiento.Size = New System.Drawing.Size(214, 26)
        Me.DateTimeFechaNacimiento.TabIndex = 9
        Me.DateTimeFechaNacimiento.Value = New Date(2020, 7, 18, 0, 0, 0, 0)
        '
        'DateTimeFechaAlta
        '
        Me.DateTimeFechaAlta.CalendarFont = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeFechaAlta.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DateTimeFechaAlta.Checked = False
        Me.DateTimeFechaAlta.CustomFormat = "MMMM dd, yyyy - dddd"
        Me.DateTimeFechaAlta.Font = New System.Drawing.Font("Ubuntu", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFechaAlta.Location = New System.Drawing.Point(588, 237)
        Me.DateTimeFechaAlta.MaximumSize = New System.Drawing.Size(214, 26)
        Me.DateTimeFechaAlta.MinDate = New Date(1930, 1, 1, 0, 0, 0, 0)
        Me.DateTimeFechaAlta.MinimumSize = New System.Drawing.Size(214, 26)
        Me.DateTimeFechaAlta.Name = "DateTimeFechaAlta"
        Me.DateTimeFechaAlta.Size = New System.Drawing.Size(214, 26)
        Me.DateTimeFechaAlta.TabIndex = 9
        Me.DateTimeFechaAlta.Value = New Date(2020, 7, 18, 16, 13, 7, 0)
        '
        'TxtIngresoAnalisis
        '
        Me.TxtIngresoAnalisis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtIngresoAnalisis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIngresoAnalisis.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIngresoAnalisis.Location = New System.Drawing.Point(203, 547)
        Me.TxtIngresoAnalisis.MaximumSize = New System.Drawing.Size(705, 40)
        Me.TxtIngresoAnalisis.MaxLength = 250
        Me.TxtIngresoAnalisis.MinimumSize = New System.Drawing.Size(705, 40)
        Me.TxtIngresoAnalisis.Multiline = True
        Me.TxtIngresoAnalisis.Name = "TxtIngresoAnalisis"
        Me.TxtIngresoAnalisis.Size = New System.Drawing.Size(705, 40)
        Me.TxtIngresoAnalisis.TabIndex = 7
        '
        'TxtEnferMaternas
        '
        Me.TxtEnferMaternas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEnferMaternas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEnferMaternas.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEnferMaternas.Location = New System.Drawing.Point(203, 499)
        Me.TxtEnferMaternas.MaximumSize = New System.Drawing.Size(705, 40)
        Me.TxtEnferMaternas.MaxLength = 250
        Me.TxtEnferMaternas.MinimumSize = New System.Drawing.Size(705, 40)
        Me.TxtEnferMaternas.Multiline = True
        Me.TxtEnferMaternas.Name = "TxtEnferMaternas"
        Me.TxtEnferMaternas.Size = New System.Drawing.Size(705, 40)
        Me.TxtEnferMaternas.TabIndex = 7
        '
        'TxtEnfermedPaternas
        '
        Me.TxtEnfermedPaternas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEnfermedPaternas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEnfermedPaternas.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEnfermedPaternas.Location = New System.Drawing.Point(203, 451)
        Me.TxtEnfermedPaternas.MaximumSize = New System.Drawing.Size(705, 40)
        Me.TxtEnfermedPaternas.MaxLength = 250
        Me.TxtEnfermedPaternas.MinimumSize = New System.Drawing.Size(705, 40)
        Me.TxtEnfermedPaternas.Multiline = True
        Me.TxtEnfermedPaternas.Name = "TxtEnfermedPaternas"
        Me.TxtEnfermedPaternas.Size = New System.Drawing.Size(705, 40)
        Me.TxtEnfermedPaternas.TabIndex = 7
        '
        'TxtCirujias
        '
        Me.TxtCirujias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCirujias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCirujias.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCirujias.Location = New System.Drawing.Point(203, 403)
        Me.TxtCirujias.MaximumSize = New System.Drawing.Size(705, 40)
        Me.TxtCirujias.MaxLength = 250
        Me.TxtCirujias.MinimumSize = New System.Drawing.Size(705, 40)
        Me.TxtCirujias.Multiline = True
        Me.TxtCirujias.Name = "TxtCirujias"
        Me.TxtCirujias.Size = New System.Drawing.Size(705, 40)
        Me.TxtCirujias.TabIndex = 7
        '
        'TxtAlergiasMedicamentos
        '
        Me.TxtAlergiasMedicamentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAlergiasMedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAlergiasMedicamentos.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAlergiasMedicamentos.Location = New System.Drawing.Point(203, 355)
        Me.TxtAlergiasMedicamentos.MaximumSize = New System.Drawing.Size(705, 40)
        Me.TxtAlergiasMedicamentos.MaxLength = 250
        Me.TxtAlergiasMedicamentos.MinimumSize = New System.Drawing.Size(705, 40)
        Me.TxtAlergiasMedicamentos.Multiline = True
        Me.TxtAlergiasMedicamentos.Name = "TxtAlergiasMedicamentos"
        Me.TxtAlergiasMedicamentos.Size = New System.Drawing.Size(705, 40)
        Me.TxtAlergiasMedicamentos.TabIndex = 7
        '
        'TxtEnfermeAnteriores
        '
        Me.TxtEnfermeAnteriores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEnfermeAnteriores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEnfermeAnteriores.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEnfermeAnteriores.Location = New System.Drawing.Point(203, 307)
        Me.TxtEnfermeAnteriores.MaximumSize = New System.Drawing.Size(705, 40)
        Me.TxtEnfermeAnteriores.MaxLength = 250
        Me.TxtEnfermeAnteriores.MinimumSize = New System.Drawing.Size(705, 40)
        Me.TxtEnfermeAnteriores.Multiline = True
        Me.TxtEnfermeAnteriores.Name = "TxtEnfermeAnteriores"
        Me.TxtEnfermeAnteriores.Size = New System.Drawing.Size(705, 40)
        Me.TxtEnfermeAnteriores.TabIndex = 7
        '
        'PictureImagenPerfil
        '
        Me.PictureImagenPerfil.BackgroundImage = CType(resources.GetObject("PictureImagenPerfil.BackgroundImage"), System.Drawing.Image)
        Me.PictureImagenPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureImagenPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureImagenPerfil.Location = New System.Drawing.Point(816, 43)
        Me.PictureImagenPerfil.MaximumSize = New System.Drawing.Size(145, 140)
        Me.PictureImagenPerfil.MinimumSize = New System.Drawing.Size(140, 140)
        Me.PictureImagenPerfil.Name = "PictureImagenPerfil"
        Me.PictureImagenPerfil.Size = New System.Drawing.Size(145, 140)
        Me.PictureImagenPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureImagenPerfil.TabIndex = 6
        Me.PictureImagenPerfil.TabStop = False
        '
        'TxtApellidoPaterno
        '
        Me.TxtApellidoPaterno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtApellidoPaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtApellidoPaterno.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellidoPaterno.Location = New System.Drawing.Point(203, 105)
        Me.TxtApellidoPaterno.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtApellidoPaterno.MaxLength = 15
        Me.TxtApellidoPaterno.MinimumSize = New System.Drawing.Size(210, 26)
        Me.TxtApellidoPaterno.Name = "TxtApellidoPaterno"
        Me.TxtApellidoPaterno.Size = New System.Drawing.Size(210, 26)
        Me.TxtApellidoPaterno.TabIndex = 3
        '
        'TxtTelefAcompañante
        '
        Me.TxtTelefAcompañante.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTelefAcompañante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelefAcompañante.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefAcompañante.Location = New System.Drawing.Point(588, 269)
        Me.TxtTelefAcompañante.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtTelefAcompañante.MaxLength = 15
        Me.TxtTelefAcompañante.MinimumSize = New System.Drawing.Size(214, 26)
        Me.TxtTelefAcompañante.Name = "TxtTelefAcompañante"
        Me.TxtTelefAcompañante.Size = New System.Drawing.Size(214, 26)
        Me.TxtTelefAcompañante.TabIndex = 2
        '
        'TxtNombreAcompañante
        '
        Me.TxtNombreAcompañante.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNombreAcompañante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombreAcompañante.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreAcompañante.Location = New System.Drawing.Point(203, 270)
        Me.TxtNombreAcompañante.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtNombreAcompañante.MaxLength = 35
        Me.TxtNombreAcompañante.MinimumSize = New System.Drawing.Size(210, 26)
        Me.TxtNombreAcompañante.Name = "TxtNombreAcompañante"
        Me.TxtNombreAcompañante.Size = New System.Drawing.Size(210, 26)
        Me.TxtNombreAcompañante.TabIndex = 2
        '
        'TxtEmail
        '
        Me.TxtEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmail.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(203, 237)
        Me.TxtEmail.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtEmail.MaxLength = 25
        Me.TxtEmail.MinimumSize = New System.Drawing.Size(210, 26)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(210, 26)
        Me.TxtEmail.TabIndex = 2
        '
        'TxtEscolaridad
        '
        Me.TxtEscolaridad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEscolaridad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEscolaridad.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEscolaridad.Location = New System.Drawing.Point(203, 204)
        Me.TxtEscolaridad.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtEscolaridad.MaxLength = 25
        Me.TxtEscolaridad.MinimumSize = New System.Drawing.Size(210, 26)
        Me.TxtEscolaridad.Name = "TxtEscolaridad"
        Me.TxtEscolaridad.Size = New System.Drawing.Size(210, 26)
        Me.TxtEscolaridad.TabIndex = 2
        '
        'TxtOcupacion
        '
        Me.TxtOcupacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtOcupacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOcupacion.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOcupacion.Location = New System.Drawing.Point(203, 171)
        Me.TxtOcupacion.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtOcupacion.MaxLength = 25
        Me.TxtOcupacion.MinimumSize = New System.Drawing.Size(210, 26)
        Me.TxtOcupacion.Name = "TxtOcupacion"
        Me.TxtOcupacion.Size = New System.Drawing.Size(210, 26)
        Me.TxtOcupacion.TabIndex = 2
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDireccion.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(588, 205)
        Me.TxtDireccion.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtDireccion.MaxLength = 25
        Me.TxtDireccion.MinimumSize = New System.Drawing.Size(214, 26)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(214, 26)
        Me.TxtDireccion.TabIndex = 2
        '
        'TxtApellidoMaterno
        '
        Me.TxtApellidoMaterno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtApellidoMaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtApellidoMaterno.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellidoMaterno.Location = New System.Drawing.Point(588, 107)
        Me.TxtApellidoMaterno.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtApellidoMaterno.MaxLength = 15
        Me.TxtApellidoMaterno.MinimumSize = New System.Drawing.Size(214, 26)
        Me.TxtApellidoMaterno.Name = "TxtApellidoMaterno"
        Me.TxtApellidoMaterno.Size = New System.Drawing.Size(214, 26)
        Me.TxtApellidoMaterno.TabIndex = 2
        '
        'TxtPrimerNombre
        '
        Me.TxtPrimerNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPrimerNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrimerNombre.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrimerNombre.Location = New System.Drawing.Point(203, 75)
        Me.TxtPrimerNombre.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtPrimerNombre.MaxLength = 15
        Me.TxtPrimerNombre.MinimumSize = New System.Drawing.Size(210, 26)
        Me.TxtPrimerNombre.Name = "TxtPrimerNombre"
        Me.TxtPrimerNombre.Size = New System.Drawing.Size(210, 26)
        Me.TxtPrimerNombre.TabIndex = 4
        '
        'TxtGenero
        '
        Me.TxtGenero.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGenero.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGenero.Location = New System.Drawing.Point(588, 139)
        Me.TxtGenero.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtGenero.MaxLength = 25
        Me.TxtGenero.MinimumSize = New System.Drawing.Size(214, 26)
        Me.TxtGenero.Name = "TxtGenero"
        Me.TxtGenero.Size = New System.Drawing.Size(214, 26)
        Me.TxtGenero.TabIndex = 2
        '
        'TxtSegundoNombre
        '
        Me.TxtSegundoNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSegundoNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSegundoNombre.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSegundoNombre.Location = New System.Drawing.Point(588, 75)
        Me.TxtSegundoNombre.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtSegundoNombre.MaxLength = 15
        Me.TxtSegundoNombre.MinimumSize = New System.Drawing.Size(214, 26)
        Me.TxtSegundoNombre.Name = "TxtSegundoNombre"
        Me.TxtSegundoNombre.Size = New System.Drawing.Size(214, 26)
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
        Me.TxtCedula.Location = New System.Drawing.Point(203, 45)
        Me.TxtCedula.MaximumSize = New System.Drawing.Size(214, 26)
        Me.TxtCedula.MaxLength = 8
        Me.TxtCedula.MinimumSize = New System.Drawing.Size(210, 26)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(210, 26)
        Me.TxtCedula.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(61, 550)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(137, 20)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Ingreso de analisis"
        '
        'LblApellidoMaterno
        '
        Me.LblApellidoMaterno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblApellidoMaterno.AutoSize = True
        Me.LblApellidoMaterno.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellidoMaterno.Location = New System.Drawing.Point(455, 113)
        Me.LblApellidoMaterno.Name = "LblApellidoMaterno"
        Me.LblApellidoMaterno.Size = New System.Drawing.Size(133, 20)
        Me.LblApellidoMaterno.TabIndex = 0
        Me.LblApellidoMaterno.Text = "Segundo apellido"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 502)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(182, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Enfermedades maternas"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(139, 404)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 20)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Cirujias"
        '
        'LblFechadeNacimiento
        '
        Me.LblFechadeNacimiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFechadeNacimiento.AutoSize = True
        Me.LblFechadeNacimiento.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechadeNacimiento.Location = New System.Drawing.Point(430, 47)
        Me.LblFechadeNacimiento.Name = "LblFechadeNacimiento"
        Me.LblFechadeNacimiento.Size = New System.Drawing.Size(156, 20)
        Me.LblFechadeNacimiento.TabIndex = 0
        Me.LblFechadeNacimiento.Text = "Fecha de nacimiento"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Alergias a medicamentos"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(447, 271)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(138, 20)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Tel. Acompañante"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 453)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Enfermedades paternas"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(30, 274)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(168, 20)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Nombre acompañante"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(510, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Direccion"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(51, 241)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(147, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Correo electronico"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Enfermedades  anteriores"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(108, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Escolaridad"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(499, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Estado civil"
        '
        'LblApellidoPaterno
        '
        Me.LblApellidoPaterno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblApellidoPaterno.AutoSize = True
        Me.LblApellidoPaterno.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellidoPaterno.Location = New System.Drawing.Point(81, 108)
        Me.LblApellidoPaterno.Name = "LblApellidoPaterno"
        Me.LblApellidoPaterno.Size = New System.Drawing.Size(116, 20)
        Me.LblApellidoPaterno.TabIndex = 0
        Me.LblApellidoPaterno.Text = "Primer apellido"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ocupacion"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(523, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Genero"
        '
        'LblSegundoNombre
        '
        Me.LblSegundoNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSegundoNombre.AutoSize = True
        Me.LblSegundoNombre.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSegundoNombre.Location = New System.Drawing.Point(453, 81)
        Me.LblSegundoNombre.Name = "LblSegundoNombre"
        Me.LblSegundoNombre.Size = New System.Drawing.Size(133, 20)
        Me.LblSegundoNombre.TabIndex = 0
        Me.LblSegundoNombre.Text = "Segundo nombre"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Edad"
        '
        'LblPrimerNombre
        '
        Me.LblPrimerNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPrimerNombre.AutoSize = True
        Me.LblPrimerNombre.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrimerNombre.Location = New System.Drawing.Point(82, 76)
        Me.LblPrimerNombre.Name = "LblPrimerNombre"
        Me.LblPrimerNombre.Size = New System.Drawing.Size(116, 20)
        Me.LblPrimerNombre.TabIndex = 0
        Me.LblPrimerNombre.Text = "Primer nombre"
        '
        'LblCedula
        '
        Me.LblCedula.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCedula.AutoSize = True
        Me.LblCedula.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCedula.Location = New System.Drawing.Point(139, 43)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(59, 20)
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
        Me.BtnMantenimientoGuardarDatos.Location = New System.Drawing.Point(791, 15)
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
        Me.BtnMantenimientoCancelar.Location = New System.Drawing.Point(648, 15)
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
        Me.DateDatosConsultasAnteriores.MaximumSize = New System.Drawing.Size(156, 15)
        Me.DateDatosConsultasAnteriores.MinDate = New Date(1930, 1, 1, 0, 0, 0, 0)
        Me.DateDatosConsultasAnteriores.Name = "DateDatosConsultasAnteriores"
        Me.DateDatosConsultasAnteriores.Size = New System.Drawing.Size(156, 15)
        Me.DateDatosConsultasAnteriores.TabIndex = 12
        Me.DateDatosConsultasAnteriores.Value = New Date(2020, 7, 18, 0, 0, 0, 0)
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
        Me.GroupBox1.Location = New System.Drawing.Point(25, 587)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(689, 99)
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
        Me.LbxConsultasAnteriores.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbxConsultasAnteriores.ForeColor = System.Drawing.Color.Black
        Me.LbxConsultasAnteriores.FormattingEnabled = True
        Me.LbxConsultasAnteriores.HorizontalScrollbar = True
        Me.LbxConsultasAnteriores.ItemHeight = 15
        Me.LbxConsultasAnteriores.Location = New System.Drawing.Point(105, 34)
        Me.LbxConsultasAnteriores.MaximumSize = New System.Drawing.Size(565, 49)
        Me.LbxConsultasAnteriores.Name = "LbxConsultasAnteriores"
        Me.LbxConsultasAnteriores.Size = New System.Drawing.Size(565, 49)
        Me.LbxConsultasAnteriores.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnMantenimientoGuardarDatos)
        Me.GroupBox3.Controls.Add(Me.BtnMantenimientoCancelar)
        Me.GroupBox3.Location = New System.Drawing.Point(25, 700)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(970, 67)
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
        Me.GrxDatosDelPaciente.Controls.Add(Me.LblDatosDireccion)
        Me.GrxDatosDelPaciente.Controls.Add(Me.LblDatosEstadoCivil)
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
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label36)
        Me.GrxDatosDelPaciente.Controls.Add(Me.Label37)
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
        Me.GrxDatosDelPaciente.Location = New System.Drawing.Point(1007, 5)
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
        Me.LblDatosEnferMaternas.Location = New System.Drawing.Point(130, 517)
        Me.LblDatosEnferMaternas.MaximumSize = New System.Drawing.Size(565, 66)
        Me.LblDatosEnferMaternas.MinimumSize = New System.Drawing.Size(522, 66)
        Me.LblDatosEnferMaternas.Name = "LblDatosEnferMaternas"
        Me.LblDatosEnferMaternas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblDatosEnferMaternas.Size = New System.Drawing.Size(565, 66)
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
        Me.LblDatosEnfermPaternas.Location = New System.Drawing.Point(130, 445)
        Me.LblDatosEnfermPaternas.MaximumSize = New System.Drawing.Size(565, 66)
        Me.LblDatosEnfermPaternas.MinimumSize = New System.Drawing.Size(522, 66)
        Me.LblDatosEnfermPaternas.Name = "LblDatosEnfermPaternas"
        Me.LblDatosEnfermPaternas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblDatosEnfermPaternas.Size = New System.Drawing.Size(565, 66)
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
        Me.LblDatosCirujias.Location = New System.Drawing.Point(130, 374)
        Me.LblDatosCirujias.MaximumSize = New System.Drawing.Size(565, 66)
        Me.LblDatosCirujias.MinimumSize = New System.Drawing.Size(522, 66)
        Me.LblDatosCirujias.Name = "LblDatosCirujias"
        Me.LblDatosCirujias.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblDatosCirujias.Size = New System.Drawing.Size(565, 66)
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
        Me.LblDatosAlergiasAmedicamentos.Location = New System.Drawing.Point(130, 302)
        Me.LblDatosAlergiasAmedicamentos.MaximumSize = New System.Drawing.Size(565, 66)
        Me.LblDatosAlergiasAmedicamentos.MinimumSize = New System.Drawing.Size(522, 66)
        Me.LblDatosAlergiasAmedicamentos.Name = "LblDatosAlergiasAmedicamentos"
        Me.LblDatosAlergiasAmedicamentos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblDatosAlergiasAmedicamentos.Size = New System.Drawing.Size(565, 66)
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
        Me.LblDatosEnferAnterior.Location = New System.Drawing.Point(130, 230)
        Me.LblDatosEnferAnterior.MaximumSize = New System.Drawing.Size(565, 66)
        Me.LblDatosEnferAnterior.MinimumSize = New System.Drawing.Size(522, 66)
        Me.LblDatosEnferAnterior.Name = "LblDatosEnferAnterior"
        Me.LblDatosEnferAnterior.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblDatosEnferAnterior.Size = New System.Drawing.Size(565, 66)
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
        Me.LblDatosFechaIngreso.Location = New System.Drawing.Point(405, 208)
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
        Me.LblDatosSegApell.Location = New System.Drawing.Point(405, 106)
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
        'LblDatosDireccion
        '
        Me.LblDatosDireccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDatosDireccion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblDatosDireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDatosDireccion.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosDireccion.ForeColor = System.Drawing.Color.Black
        Me.LblDatosDireccion.Location = New System.Drawing.Point(405, 183)
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
        Me.LblDatosEstadoCivil.Location = New System.Drawing.Point(405, 158)
        Me.LblDatosEstadoCivil.MaximumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosEstadoCivil.MinimumSize = New System.Drawing.Size(137, 17)
        Me.LblDatosEstadoCivil.Name = "LblDatosEstadoCivil"
        Me.LblDatosEstadoCivil.Size = New System.Drawing.Size(137, 17)
        Me.LblDatosEstadoCivil.TabIndex = 44
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
        Me.LblDatosGenero.Location = New System.Drawing.Point(405, 133)
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
        Me.LblDatosEmail.Location = New System.Drawing.Point(127, 183)
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
        Me.LblDatosEscolaridad.Location = New System.Drawing.Point(127, 158)
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
        Me.LblprimApell.Location = New System.Drawing.Point(127, 106)
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
        Me.LblDatosocupacion.Location = New System.Drawing.Point(127, 133)
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
        Me.LbldatosPrimNombre.Location = New System.Drawing.Point(127, 79)
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
        Me.Lbldatoscedula.Location = New System.Drawing.Point(127, 54)
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
        Me.Label42.Location = New System.Drawing.Point(22, 517)
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
        Me.Label43.Location = New System.Drawing.Point(22, 376)
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
        Me.Label44.Location = New System.Drawing.Point(30, 303)
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
        Me.Label45.Location = New System.Drawing.Point(22, 446)
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
        Me.Label46.Location = New System.Drawing.Point(22, 230)
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
        Me.Label33.Location = New System.Drawing.Point(297, 210)
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
        Me.Label35.Location = New System.Drawing.Point(296, 106)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(103, 15)
        Me.Label35.TabIndex = 20
        Me.Label35.Text = "Segundo apellido:"
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
        Me.Label37.Location = New System.Drawing.Point(335, 183)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(65, 15)
        Me.Label37.TabIndex = 22
        Me.Label37.Text = "Direccion:"
        '
        'Label38
        '
        Me.Label38.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(328, 158)
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
        Me.Label39.Location = New System.Drawing.Point(349, 133)
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
        Me.Label26.Location = New System.Drawing.Point(8, 183)
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
        Me.Label27.Location = New System.Drawing.Point(48, 158)
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
        Me.Label29.Location = New System.Drawing.Point(27, 106)
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
        Me.Label30.Location = New System.Drawing.Point(53, 133)
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
        Me.Label31.Location = New System.Drawing.Point(27, 79)
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
        Me.Label32.Location = New System.Drawing.Point(73, 54)
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
        Me.GroupBox2.Location = New System.Drawing.Point(1007, 700)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(751, 67)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtBuscarPaciente)
        Me.GroupBox4.Controls.Add(Me.BtnBuscarPaciente)
        Me.GroupBox4.Controls.Add(Me.BtnIngresoNuevoPaciente)
        Me.GroupBox4.Font = New System.Drawing.Font("Ubuntu", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(25, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(970, 86)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pacientes"
        '
        'TxtBuscarPaciente
        '
        Me.TxtBuscarPaciente.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.TxtBuscarPaciente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscarPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscarPaciente.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscarPaciente.Location = New System.Drawing.Point(848, 38)
        Me.TxtBuscarPaciente.MaximumSize = New System.Drawing.Size(214, 30)
        Me.TxtBuscarPaciente.MaxLength = 8
        Me.TxtBuscarPaciente.Name = "TxtBuscarPaciente"
        Me.TxtBuscarPaciente.Size = New System.Drawing.Size(113, 26)
        Me.TxtBuscarPaciente.TabIndex = 11
        '
        'BtnBuscarPaciente
        '
        Me.BtnBuscarPaciente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuscarPaciente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnBuscarPaciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnBuscarPaciente.FlatAppearance.BorderSize = 0
        Me.BtnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarPaciente.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarPaciente.Location = New System.Drawing.Point(588, 29)
        Me.BtnBuscarPaciente.Name = "BtnBuscarPaciente"
        Me.BtnBuscarPaciente.Size = New System.Drawing.Size(204, 42)
        Me.BtnBuscarPaciente.TabIndex = 5
        Me.BtnBuscarPaciente.Text = "Buscar paciente"
        Me.BtnBuscarPaciente.UseVisualStyleBackColor = False
        '
        'BtnIngresoNuevoPaciente
        '
        Me.BtnIngresoNuevoPaciente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnIngresoNuevoPaciente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnIngresoNuevoPaciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnIngresoNuevoPaciente.FlatAppearance.BorderSize = 0
        Me.BtnIngresoNuevoPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIngresoNuevoPaciente.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresoNuevoPaciente.Location = New System.Drawing.Point(219, 29)
        Me.BtnIngresoNuevoPaciente.Name = "BtnIngresoNuevoPaciente"
        Me.BtnIngresoNuevoPaciente.Size = New System.Drawing.Size(205, 42)
        Me.BtnIngresoNuevoPaciente.TabIndex = 5
        Me.BtnIngresoNuevoPaciente.Text = "Ingresar nuevo paciente"
        Me.BtnIngresoNuevoPaciente.UseVisualStyleBackColor = False
        '
        'OFcargarImagen
        '
        Me.OFcargarImagen.Title = "Seleccionar imagen"
        '
        'FrmMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1770, 800)
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
        CType(Me.NumEdadPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureImagenPerfil, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureImagenPerfil As PictureBox
    Friend WithEvents TxtEscolaridad As TextBox
    Friend WithEvents TxtOcupacion As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtGenero As TextBox
    Friend WithEvents TxtAlergiasMedicamentos As TextBox
    Friend WithEvents TxtEnfermeAnteriores As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtEnferMaternas As TextBox
    Friend WithEvents TxtEnfermedPaternas As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DateTimeFechaAlta As DateTimePicker
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DateTimeFechaNacimiento As DateTimePicker
    Friend WithEvents TxtCirujias As TextBox
    Friend WithEvents TxtTelefAcompañante As TextBox
    Friend WithEvents TxtNombreAcompañante As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents BtnBuscarConsultasAnteriores As Button
    Friend WithEvents DateDatosConsultasAnteriores As DateTimePicker
    Friend WithEvents RbtnFechaConsultasAnteriores As RadioButton
    Friend WithEvents RbtnCedulaConsultasAnteriores As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtIngresoAnalisis As TextBox
    Friend WithEvents Label18 As Label
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
    Friend WithEvents NumEdadPaciente As NumericUpDown
    Friend WithEvents BtncargarImagen As Button
    Friend WithEvents OFcargarImagen As OpenFileDialog
    Friend WithEvents ComEstadocivil As ComboBox
End Class
