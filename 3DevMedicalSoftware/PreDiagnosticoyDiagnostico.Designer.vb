﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPreDiagnosticoyDiagnostico
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
        Me.TxtIngresoDeAnalisisClinicos = New System.Windows.Forms.TextBox()
        Me.TxtSolicitudDeAnalisisClinicos = New System.Windows.Forms.TextBox()
        Me.TxtRegistroDeDiagnostico = New System.Windows.Forms.TextBox()
        Me.CbxTipoDeDiagnostico = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrxBotonesGuardarCancelarContinuar = New System.Windows.Forms.GroupBox()
        Me.BtnVolverAEntrevista = New System.Windows.Forms.Button()
        Me.BtnPreDigCancelar = New System.Windows.Forms.Button()
        Me.BtnPreDiagGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnContinuarAPlan = New System.Windows.Forms.Button()
        Me.BtnGuargarDiagnostico = New System.Windows.Forms.Button()
        Me.GbxEntrevistaInicial.SuspendLayout()
        Me.GrxBotonesGuardarCancelarContinuar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbxEntrevistaInicial
        '
        Me.GbxEntrevistaInicial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GbxEntrevistaInicial.Controls.Add(Me.TxtIngresoDeAnalisisClinicos)
        Me.GbxEntrevistaInicial.Controls.Add(Me.TxtSolicitudDeAnalisisClinicos)
        Me.GbxEntrevistaInicial.Controls.Add(Me.TxtRegistroDeDiagnostico)
        Me.GbxEntrevistaInicial.Controls.Add(Me.CbxTipoDeDiagnostico)
        Me.GbxEntrevistaInicial.Controls.Add(Me.Label4)
        Me.GbxEntrevistaInicial.Controls.Add(Me.Label3)
        Me.GbxEntrevistaInicial.Controls.Add(Me.Label1)
        Me.GbxEntrevistaInicial.Controls.Add(Me.Label2)
        Me.GbxEntrevistaInicial.Controls.Add(Me.GrxBotonesGuardarCancelarContinuar)
        Me.GbxEntrevistaInicial.Font = New System.Drawing.Font("Ubuntu", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxEntrevistaInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.GbxEntrevistaInicial.Location = New System.Drawing.Point(22, 25)
        Me.GbxEntrevistaInicial.MaximumSize = New System.Drawing.Size(1000, 1063)
        Me.GbxEntrevistaInicial.Name = "GbxEntrevistaInicial"
        Me.GbxEntrevistaInicial.Size = New System.Drawing.Size(850, 1054)
        Me.GbxEntrevistaInicial.TabIndex = 2
        Me.GbxEntrevistaInicial.TabStop = False
        Me.GbxEntrevistaInicial.Text = "PreDiagnostico"
        '
        'TxtIngresoDeAnalisisClinicos
        '
        Me.TxtIngresoDeAnalisisClinicos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtIngresoDeAnalisisClinicos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIngresoDeAnalisisClinicos.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIngresoDeAnalisisClinicos.Location = New System.Drawing.Point(256, 427)
        Me.TxtIngresoDeAnalisisClinicos.MaxLength = 250
        Me.TxtIngresoDeAnalisisClinicos.MinimumSize = New System.Drawing.Size(214, 26)
        Me.TxtIngresoDeAnalisisClinicos.Multiline = True
        Me.TxtIngresoDeAnalisisClinicos.Name = "TxtIngresoDeAnalisisClinicos"
        Me.TxtIngresoDeAnalisisClinicos.Size = New System.Drawing.Size(353, 86)
        Me.TxtIngresoDeAnalisisClinicos.TabIndex = 11
        '
        'TxtSolicitudDeAnalisisClinicos
        '
        Me.TxtSolicitudDeAnalisisClinicos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSolicitudDeAnalisisClinicos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSolicitudDeAnalisisClinicos.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSolicitudDeAnalisisClinicos.Location = New System.Drawing.Point(256, 293)
        Me.TxtSolicitudDeAnalisisClinicos.MaxLength = 250
        Me.TxtSolicitudDeAnalisisClinicos.MinimumSize = New System.Drawing.Size(214, 26)
        Me.TxtSolicitudDeAnalisisClinicos.Multiline = True
        Me.TxtSolicitudDeAnalisisClinicos.Name = "TxtSolicitudDeAnalisisClinicos"
        Me.TxtSolicitudDeAnalisisClinicos.Size = New System.Drawing.Size(353, 86)
        Me.TxtSolicitudDeAnalisisClinicos.TabIndex = 11
        '
        'TxtRegistroDeDiagnostico
        '
        Me.TxtRegistroDeDiagnostico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRegistroDeDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtRegistroDeDiagnostico.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRegistroDeDiagnostico.Location = New System.Drawing.Point(256, 159)
        Me.TxtRegistroDeDiagnostico.MaxLength = 250
        Me.TxtRegistroDeDiagnostico.MinimumSize = New System.Drawing.Size(214, 26)
        Me.TxtRegistroDeDiagnostico.Multiline = True
        Me.TxtRegistroDeDiagnostico.Name = "TxtRegistroDeDiagnostico"
        Me.TxtRegistroDeDiagnostico.Size = New System.Drawing.Size(353, 86)
        Me.TxtRegistroDeDiagnostico.TabIndex = 11
        '
        'CbxTipoDeDiagnostico
        '
        Me.CbxTipoDeDiagnostico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbxTipoDeDiagnostico.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxTipoDeDiagnostico.FormattingEnabled = True
        Me.CbxTipoDeDiagnostico.Items.AddRange(New Object() {"Diagnostico individual", "Diagnostico de certeza", "Diagnostico diferencia", "Diagnostico etiologico", "Diagnostico generico", "Diagnostico heroico", "Diagnostico lesional, anatomico o topografico", "Diagnostico nosologico", "Diagnostico patojenico", "Diagnostico presuntivo", "Diagnostico sindromico funcional", "Diagnostico sintomatico"})
        Me.CbxTipoDeDiagnostico.Location = New System.Drawing.Point(256, 83)
        Me.CbxTipoDeDiagnostico.Name = "CbxTipoDeDiagnostico"
        Me.CbxTipoDeDiagnostico.Size = New System.Drawing.Size(353, 28)
        Me.CbxTipoDeDiagnostico.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 430)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Ingreso de analisis clinicos"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 296)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Solicitud de analisis clinicos"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Registro de diagnostico"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tipo de diagnostico"
        '
        'GrxBotonesGuardarCancelarContinuar
        '
        Me.GrxBotonesGuardarCancelarContinuar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrxBotonesGuardarCancelarContinuar.Controls.Add(Me.BtnVolverAEntrevista)
        Me.GrxBotonesGuardarCancelarContinuar.Controls.Add(Me.BtnPreDigCancelar)
        Me.GrxBotonesGuardarCancelarContinuar.Controls.Add(Me.BtnPreDiagGuardar)
        Me.GrxBotonesGuardarCancelarContinuar.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrxBotonesGuardarCancelarContinuar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrxBotonesGuardarCancelarContinuar.Location = New System.Drawing.Point(26, 952)
        Me.GrxBotonesGuardarCancelarContinuar.Name = "GrxBotonesGuardarCancelarContinuar"
        Me.GrxBotonesGuardarCancelarContinuar.Size = New System.Drawing.Size(798, 79)
        Me.GrxBotonesGuardarCancelarContinuar.TabIndex = 7
        Me.GrxBotonesGuardarCancelarContinuar.TabStop = False
        '
        'BtnVolverAEntrevista
        '
        Me.BtnVolverAEntrevista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnVolverAEntrevista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnVolverAEntrevista.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnVolverAEntrevista.FlatAppearance.BorderSize = 0
        Me.BtnVolverAEntrevista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolverAEntrevista.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolverAEntrevista.Location = New System.Drawing.Point(16, 23)
        Me.BtnVolverAEntrevista.Name = "BtnVolverAEntrevista"
        Me.BtnVolverAEntrevista.Size = New System.Drawing.Size(224, 42)
        Me.BtnVolverAEntrevista.TabIndex = 6
        Me.BtnVolverAEntrevista.Text = "<<< Volver a entrevista inicial"
        Me.BtnVolverAEntrevista.UseVisualStyleBackColor = False
        '
        'BtnPreDigCancelar
        '
        Me.BtnPreDigCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPreDigCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnPreDigCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPreDigCancelar.FlatAppearance.BorderSize = 0
        Me.BtnPreDigCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPreDigCancelar.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreDigCancelar.Location = New System.Drawing.Point(516, 23)
        Me.BtnPreDigCancelar.Name = "BtnPreDigCancelar"
        Me.BtnPreDigCancelar.Size = New System.Drawing.Size(117, 42)
        Me.BtnPreDigCancelar.TabIndex = 5
        Me.BtnPreDigCancelar.Text = "Cancelar"
        Me.BtnPreDigCancelar.UseVisualStyleBackColor = False
        '
        'BtnPreDiagGuardar
        '
        Me.BtnPreDiagGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPreDiagGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnPreDiagGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPreDiagGuardar.FlatAppearance.BorderSize = 0
        Me.BtnPreDiagGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPreDiagGuardar.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreDiagGuardar.Location = New System.Drawing.Point(664, 23)
        Me.BtnPreDiagGuardar.Name = "BtnPreDiagGuardar"
        Me.BtnPreDiagGuardar.Size = New System.Drawing.Size(117, 42)
        Me.BtnPreDiagGuardar.TabIndex = 5
        Me.BtnPreDiagGuardar.Text = "Guardar"
        Me.BtnPreDiagGuardar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Ubuntu", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(898, 25)
        Me.GroupBox1.MaximumSize = New System.Drawing.Size(1000, 1063)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(850, 1054)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Diagnostico"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.BtnContinuarAPlan)
        Me.GroupBox2.Controls.Add(Me.BtnGuargarDiagnostico)
        Me.GroupBox2.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(27, 953)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(798, 79)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'BtnContinuarAPlan
        '
        Me.BtnContinuarAPlan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnContinuarAPlan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnContinuarAPlan.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnContinuarAPlan.FlatAppearance.BorderSize = 0
        Me.BtnContinuarAPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnContinuarAPlan.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContinuarAPlan.Location = New System.Drawing.Point(553, 26)
        Me.BtnContinuarAPlan.Name = "BtnContinuarAPlan"
        Me.BtnContinuarAPlan.Size = New System.Drawing.Size(224, 42)
        Me.BtnContinuarAPlan.TabIndex = 5
        Me.BtnContinuarAPlan.Text = "Continuar a Plan >>>"
        Me.BtnContinuarAPlan.UseVisualStyleBackColor = False
        '
        'BtnGuargarDiagnostico
        '
        Me.BtnGuargarDiagnostico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuargarDiagnostico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnGuargarDiagnostico.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGuargarDiagnostico.FlatAppearance.BorderSize = 0
        Me.BtnGuargarDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuargarDiagnostico.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuargarDiagnostico.Location = New System.Drawing.Point(411, 26)
        Me.BtnGuargarDiagnostico.Name = "BtnGuargarDiagnostico"
        Me.BtnGuargarDiagnostico.Size = New System.Drawing.Size(117, 42)
        Me.BtnGuargarDiagnostico.TabIndex = 5
        Me.BtnGuargarDiagnostico.Text = "Guardar"
        Me.BtnGuargarDiagnostico.UseVisualStyleBackColor = False
        '
        'FrmPreDiagnosticoyDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1773, 1100)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GbxEntrevistaInicial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPreDiagnosticoyDiagnostico"
        Me.Text = "PreDiagnosticoyDiagnostico"
        Me.GbxEntrevistaInicial.ResumeLayout(False)
        Me.GbxEntrevistaInicial.PerformLayout()
        Me.GrxBotonesGuardarCancelarContinuar.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbxEntrevistaInicial As GroupBox
    Friend WithEvents GrxBotonesGuardarCancelarContinuar As GroupBox
    Friend WithEvents BtnPreDigCancelar As Button
    Friend WithEvents BtnPreDiagGuardar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnContinuarAPlan As Button
    Friend WithEvents BtnGuargarDiagnostico As Button
    Friend WithEvents CbxTipoDeDiagnostico As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtRegistroDeDiagnostico As TextBox
    Friend WithEvents TxtIngresoDeAnalisisClinicos As TextBox
    Friend WithEvents TxtSolicitudDeAnalisisClinicos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnVolverAEntrevista As Button
End Class
