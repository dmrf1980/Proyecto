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
        Me.GbxIngresoPacientes = New System.Windows.Forms.GroupBox()
        Me.PicturemantenimientoPaciente = New System.Windows.Forms.PictureBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LbxIngresodeAnalisis = New System.Windows.Forms.ListBox()
        Me.LbxConsultasAnteriores = New System.Windows.Forms.ListBox()
        Me.LblIngresodeAnalisis = New System.Windows.Forms.Label()
        Me.LblApellidoMaterno = New System.Windows.Forms.Label()
        Me.LblConsultasAnteriores = New System.Windows.Forms.Label()
        Me.LblFechadeNacimiento = New System.Windows.Forms.Label()
        Me.LblApellidoPaterno = New System.Windows.Forms.Label()
        Me.LblSegundoNombre = New System.Windows.Forms.Label()
        Me.LblPrimerNombre = New System.Windows.Forms.Label()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnMantenimientoCancelar = New System.Windows.Forms.Button()
        Me.GbxIngresoPacientes.SuspendLayout()
        CType(Me.PicturemantenimientoPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbxIngresoPacientes
        '
        Me.GbxIngresoPacientes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GbxIngresoPacientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GbxIngresoPacientes.Controls.Add(Me.PicturemantenimientoPaciente)
        Me.GbxIngresoPacientes.Controls.Add(Me.TextBox5)
        Me.GbxIngresoPacientes.Controls.Add(Me.TextBox6)
        Me.GbxIngresoPacientes.Controls.Add(Me.TextBox4)
        Me.GbxIngresoPacientes.Controls.Add(Me.TextBox3)
        Me.GbxIngresoPacientes.Controls.Add(Me.TextBox2)
        Me.GbxIngresoPacientes.Controls.Add(Me.TextBox1)
        Me.GbxIngresoPacientes.Controls.Add(Me.LbxIngresodeAnalisis)
        Me.GbxIngresoPacientes.Controls.Add(Me.LbxConsultasAnteriores)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblIngresodeAnalisis)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblApellidoMaterno)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblConsultasAnteriores)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblFechadeNacimiento)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblApellidoPaterno)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblSegundoNombre)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblPrimerNombre)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblCedula)
        Me.GbxIngresoPacientes.Controls.Add(Me.Button3)
        Me.GbxIngresoPacientes.Controls.Add(Me.Button2)
        Me.GbxIngresoPacientes.Controls.Add(Me.BtnMantenimientoCancelar)
        Me.GbxIngresoPacientes.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxIngresoPacientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.GbxIngresoPacientes.Location = New System.Drawing.Point(294, 109)
        Me.GbxIngresoPacientes.MaximumSize = New System.Drawing.Size(1200, 900)
        Me.GbxIngresoPacientes.Name = "GbxIngresoPacientes"
        Me.GbxIngresoPacientes.Size = New System.Drawing.Size(917, 628)
        Me.GbxIngresoPacientes.TabIndex = 0
        Me.GbxIngresoPacientes.TabStop = False
        Me.GbxIngresoPacientes.Text = "Ingreso de Pacientes"
        '
        'PicturemantenimientoPaciente
        '
        Me.PicturemantenimientoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicturemantenimientoPaciente.Image = Global._3DevMedicalSoftware.My.Resources.Resources.user2
        Me.PicturemantenimientoPaciente.Location = New System.Drawing.Point(760, 66)
        Me.PicturemantenimientoPaciente.Name = "PicturemantenimientoPaciente"
        Me.PicturemantenimientoPaciente.Size = New System.Drawing.Size(137, 138)
        Me.PicturemantenimientoPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicturemantenimientoPaciente.TabIndex = 6
        Me.PicturemantenimientoPaciente.TabStop = False
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Location = New System.Drawing.Point(171, 178)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(214, 26)
        Me.TextBox5.TabIndex = 3
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.Location = New System.Drawing.Point(171, 122)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(214, 26)
        Me.TextBox6.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Location = New System.Drawing.Point(542, 66)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(202, 26)
        Me.TextBox4.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(542, 178)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(202, 26)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(542, 122)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(202, 26)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(171, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(214, 26)
        Me.TextBox1.TabIndex = 2
        '
        'LbxIngresodeAnalisis
        '
        Me.LbxIngresodeAnalisis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbxIngresodeAnalisis.FormattingEnabled = True
        Me.LbxIngresodeAnalisis.ItemHeight = 20
        Me.LbxIngresodeAnalisis.Location = New System.Drawing.Point(168, 403)
        Me.LbxIngresodeAnalisis.Name = "LbxIngresodeAnalisis"
        Me.LbxIngresodeAnalisis.Size = New System.Drawing.Size(729, 124)
        Me.LbxIngresodeAnalisis.TabIndex = 1
        '
        'LbxConsultasAnteriores
        '
        Me.LbxConsultasAnteriores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbxConsultasAnteriores.FormattingEnabled = True
        Me.LbxConsultasAnteriores.ItemHeight = 20
        Me.LbxConsultasAnteriores.Location = New System.Drawing.Point(171, 244)
        Me.LbxConsultasAnteriores.Name = "LbxConsultasAnteriores"
        Me.LbxConsultasAnteriores.Size = New System.Drawing.Size(729, 124)
        Me.LbxConsultasAnteriores.TabIndex = 1
        '
        'LblIngresodeAnalisis
        '
        Me.LblIngresodeAnalisis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblIngresodeAnalisis.AutoSize = True
        Me.LblIngresodeAnalisis.Location = New System.Drawing.Point(27, 399)
        Me.LblIngresodeAnalisis.Name = "LblIngresodeAnalisis"
        Me.LblIngresodeAnalisis.Size = New System.Drawing.Size(137, 20)
        Me.LblIngresodeAnalisis.TabIndex = 0
        Me.LblIngresodeAnalisis.Text = "Ingreso de analisis"
        '
        'LblApellidoMaterno
        '
        Me.LblApellidoMaterno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblApellidoMaterno.AutoSize = True
        Me.LblApellidoMaterno.Location = New System.Drawing.Point(409, 181)
        Me.LblApellidoMaterno.Name = "LblApellidoMaterno"
        Me.LblApellidoMaterno.Size = New System.Drawing.Size(133, 20)
        Me.LblApellidoMaterno.TabIndex = 0
        Me.LblApellidoMaterno.Text = "Apellido Materno"
        '
        'LblConsultasAnteriores
        '
        Me.LblConsultasAnteriores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblConsultasAnteriores.AutoSize = True
        Me.LblConsultasAnteriores.Location = New System.Drawing.Point(8, 244)
        Me.LblConsultasAnteriores.Name = "LblConsultasAnteriores"
        Me.LblConsultasAnteriores.Size = New System.Drawing.Size(157, 20)
        Me.LblConsultasAnteriores.TabIndex = 0
        Me.LblConsultasAnteriores.Text = "Consultas anteriores"
        '
        'LblFechadeNacimiento
        '
        Me.LblFechadeNacimiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFechadeNacimiento.AutoSize = True
        Me.LblFechadeNacimiento.Location = New System.Drawing.Point(386, 69)
        Me.LblFechadeNacimiento.Name = "LblFechadeNacimiento"
        Me.LblFechadeNacimiento.Size = New System.Drawing.Size(156, 20)
        Me.LblFechadeNacimiento.TabIndex = 0
        Me.LblFechadeNacimiento.Text = "Fecha de nacimiento"
        '
        'LblApellidoPaterno
        '
        Me.LblApellidoPaterno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblApellidoPaterno.AutoSize = True
        Me.LblApellidoPaterno.Location = New System.Drawing.Point(34, 181)
        Me.LblApellidoPaterno.Name = "LblApellidoPaterno"
        Me.LblApellidoPaterno.Size = New System.Drawing.Size(130, 20)
        Me.LblApellidoPaterno.TabIndex = 0
        Me.LblApellidoPaterno.Text = "Apellido Paterno"
        '
        'LblSegundoNombre
        '
        Me.LblSegundoNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSegundoNombre.AutoSize = True
        Me.LblSegundoNombre.Location = New System.Drawing.Point(407, 125)
        Me.LblSegundoNombre.Name = "LblSegundoNombre"
        Me.LblSegundoNombre.Size = New System.Drawing.Size(135, 20)
        Me.LblSegundoNombre.TabIndex = 0
        Me.LblSegundoNombre.Text = "Segundo Nombre"
        '
        'LblPrimerNombre
        '
        Me.LblPrimerNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPrimerNombre.AutoSize = True
        Me.LblPrimerNombre.Location = New System.Drawing.Point(46, 125)
        Me.LblPrimerNombre.Name = "LblPrimerNombre"
        Me.LblPrimerNombre.Size = New System.Drawing.Size(118, 20)
        Me.LblPrimerNombre.TabIndex = 0
        Me.LblPrimerNombre.Text = "Primer Nombre"
        '
        'LblCedula
        '
        Me.LblCedula.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCedula.AutoSize = True
        Me.LblCedula.Location = New System.Drawing.Point(105, 69)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(59, 20)
        Me.LblCedula.TabIndex = 0
        Me.LblCedula.Text = "Cedula"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(721, 548)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(174, 42)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Guardar y continuar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(581, 548)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 42)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BtnMantenimientoCancelar
        '
        Me.BtnMantenimientoCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMantenimientoCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnMantenimientoCancelar.FlatAppearance.BorderSize = 0
        Me.BtnMantenimientoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMantenimientoCancelar.Location = New System.Drawing.Point(434, 548)
        Me.BtnMantenimientoCancelar.Name = "BtnMantenimientoCancelar"
        Me.BtnMantenimientoCancelar.Size = New System.Drawing.Size(117, 42)
        Me.BtnMantenimientoCancelar.TabIndex = 5
        Me.BtnMantenimientoCancelar.Text = "Cancelar"
        Me.BtnMantenimientoCancelar.UseVisualStyleBackColor = False
        '
        'FrmMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1523, 953)
        Me.Controls.Add(Me.GbxIngresoPacientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMantenimiento"
        Me.Text = "FrmMantenimiento"
        Me.GbxIngresoPacientes.ResumeLayout(False)
        Me.GbxIngresoPacientes.PerformLayout()
        CType(Me.PicturemantenimientoPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbxIngresoPacientes As GroupBox
    Friend WithEvents LblApellidoPaterno As Label
    Friend WithEvents LblPrimerNombre As Label
    Friend WithEvents LblCedula As Label
    Friend WithEvents LblApellidoMaterno As Label
    Friend WithEvents LblFechadeNacimiento As Label
    Friend WithEvents LblSegundoNombre As Label
    Friend WithEvents LbxConsultasAnteriores As ListBox
    Friend WithEvents LblConsultasAnteriores As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LbxIngresodeAnalisis As ListBox
    Friend WithEvents LblIngresodeAnalisis As Label
    Friend WithEvents BtnMantenimientoCancelar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PicturemantenimientoPaciente As PictureBox
End Class
