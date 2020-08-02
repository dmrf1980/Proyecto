<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.BtnVolverAExploracion = New System.Windows.Forms.Button()
        Me.BtnPreDigCancelar = New System.Windows.Forms.Button()
        Me.BtnPreDiagGuardar = New System.Windows.Forms.Button()
        Me.BtnContinuarAPlan = New System.Windows.Forms.Button()
        Me.GbxEntrevistaInicial.SuspendLayout()
        Me.GrxBotonesGuardarCancelarContinuar.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbxEntrevistaInicial
        '
        Me.GbxEntrevistaInicial.Controls.Add(Me.TxtIngresoDeAnalisisClinicos)
        Me.GbxEntrevistaInicial.Controls.Add(Me.TxtSolicitudDeAnalisisClinicos)
        Me.GbxEntrevistaInicial.Controls.Add(Me.TxtRegistroDeDiagnostico)
        Me.GbxEntrevistaInicial.Controls.Add(Me.CbxTipoDeDiagnostico)
        Me.GbxEntrevistaInicial.Controls.Add(Me.Label4)
        Me.GbxEntrevistaInicial.Controls.Add(Me.Label3)
        Me.GbxEntrevistaInicial.Controls.Add(Me.Label1)
        Me.GbxEntrevistaInicial.Controls.Add(Me.Label2)
        Me.GbxEntrevistaInicial.Font = New System.Drawing.Font("Ubuntu", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxEntrevistaInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.GbxEntrevistaInicial.Location = New System.Drawing.Point(25, 5)
        Me.GbxEntrevistaInicial.MaximumSize = New System.Drawing.Size(1000, 1063)
        Me.GbxEntrevistaInicial.Name = "GbxEntrevistaInicial"
        Me.GbxEntrevistaInicial.Size = New System.Drawing.Size(850, 530)
        Me.GbxEntrevistaInicial.TabIndex = 2
        Me.GbxEntrevistaInicial.TabStop = False
        Me.GbxEntrevistaInicial.Text = "PreDiagnostico"
        '
        'TxtIngresoDeAnalisisClinicos
        '
        Me.TxtIngresoDeAnalisisClinicos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtIngresoDeAnalisisClinicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIngresoDeAnalisisClinicos.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIngresoDeAnalisisClinicos.Location = New System.Drawing.Point(256, 427)
        Me.TxtIngresoDeAnalisisClinicos.MaximumSize = New System.Drawing.Size(571, 86)
        Me.TxtIngresoDeAnalisisClinicos.MaxLength = 250
        Me.TxtIngresoDeAnalisisClinicos.MinimumSize = New System.Drawing.Size(353, 86)
        Me.TxtIngresoDeAnalisisClinicos.Multiline = True
        Me.TxtIngresoDeAnalisisClinicos.Name = "TxtIngresoDeAnalisisClinicos"
        Me.TxtIngresoDeAnalisisClinicos.Size = New System.Drawing.Size(571, 86)
        Me.TxtIngresoDeAnalisisClinicos.TabIndex = 11
        '
        'TxtSolicitudDeAnalisisClinicos
        '
        Me.TxtSolicitudDeAnalisisClinicos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSolicitudDeAnalisisClinicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSolicitudDeAnalisisClinicos.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSolicitudDeAnalisisClinicos.Location = New System.Drawing.Point(256, 293)
        Me.TxtSolicitudDeAnalisisClinicos.MaximumSize = New System.Drawing.Size(571, 86)
        Me.TxtSolicitudDeAnalisisClinicos.MaxLength = 250
        Me.TxtSolicitudDeAnalisisClinicos.MinimumSize = New System.Drawing.Size(353, 86)
        Me.TxtSolicitudDeAnalisisClinicos.Multiline = True
        Me.TxtSolicitudDeAnalisisClinicos.Name = "TxtSolicitudDeAnalisisClinicos"
        Me.TxtSolicitudDeAnalisisClinicos.Size = New System.Drawing.Size(571, 86)
        Me.TxtSolicitudDeAnalisisClinicos.TabIndex = 11
        '
        'TxtRegistroDeDiagnostico
        '
        Me.TxtRegistroDeDiagnostico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRegistroDeDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRegistroDeDiagnostico.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRegistroDeDiagnostico.Location = New System.Drawing.Point(256, 159)
        Me.TxtRegistroDeDiagnostico.MaximumSize = New System.Drawing.Size(571, 86)
        Me.TxtRegistroDeDiagnostico.MaxLength = 250
        Me.TxtRegistroDeDiagnostico.MinimumSize = New System.Drawing.Size(353, 86)
        Me.TxtRegistroDeDiagnostico.Multiline = True
        Me.TxtRegistroDeDiagnostico.Name = "TxtRegistroDeDiagnostico"
        Me.TxtRegistroDeDiagnostico.Size = New System.Drawing.Size(571, 86)
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
        Me.CbxTipoDeDiagnostico.Size = New System.Drawing.Size(352, 28)
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
        Me.GrxBotonesGuardarCancelarContinuar.Controls.Add(Me.BtnContinuarAPlan)
        Me.GrxBotonesGuardarCancelarContinuar.Controls.Add(Me.BtnVolverAExploracion)
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
        'BtnVolverAExploracion
        '
        Me.BtnVolverAExploracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnVolverAExploracion.FlatAppearance.BorderSize = 0
        Me.BtnVolverAExploracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolverAExploracion.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolverAExploracion.Location = New System.Drawing.Point(18, 23)
        Me.BtnVolverAExploracion.MaximumSize = New System.Drawing.Size(260, 42)
        Me.BtnVolverAExploracion.Name = "BtnVolverAExploracion"
        Me.BtnVolverAExploracion.Size = New System.Drawing.Size(260, 42)
        Me.BtnVolverAExploracion.TabIndex = 6
        Me.BtnVolverAExploracion.Text = "<<< Volver a exploracion"
        Me.BtnVolverAExploracion.UseVisualStyleBackColor = False
        '
        'BtnPreDigCancelar
        '
        Me.BtnPreDigCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPreDigCancelar.FlatAppearance.BorderSize = 0
        Me.BtnPreDigCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPreDigCancelar.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreDigCancelar.Location = New System.Drawing.Point(300, 24)
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
        Me.BtnPreDiagGuardar.Location = New System.Drawing.Point(439, 24)
        Me.BtnPreDiagGuardar.Name = "BtnPreDiagGuardar"
        Me.BtnPreDiagGuardar.Size = New System.Drawing.Size(117, 42)
        Me.BtnPreDiagGuardar.TabIndex = 5
        Me.BtnPreDiagGuardar.Text = "Guardar"
        Me.BtnPreDiagGuardar.UseVisualStyleBackColor = False
        '
        'BtnContinuarAPlan
        '
        Me.BtnContinuarAPlan.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnContinuarAPlan.FlatAppearance.BorderSize = 0
        Me.BtnContinuarAPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnContinuarAPlan.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContinuarAPlan.Location = New System.Drawing.Point(578, 24)
        Me.BtnContinuarAPlan.MaximumSize = New System.Drawing.Size(260, 42)
        Me.BtnContinuarAPlan.Name = "BtnContinuarAPlan"
        Me.BtnContinuarAPlan.Size = New System.Drawing.Size(260, 42)
        Me.BtnContinuarAPlan.TabIndex = 5
        Me.BtnContinuarAPlan.Text = "Continuar a Plan >>>"
        Me.BtnContinuarAPlan.UseVisualStyleBackColor = False
        '
        'FrmPreDiagnosticoyDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(905, 800)
        Me.Controls.Add(Me.GbxEntrevistaInicial)
        Me.Controls.Add(Me.GrxBotonesGuardarCancelarContinuar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPreDiagnosticoyDiagnostico"
        Me.Padding = New System.Windows.Forms.Padding(25, 5, 25, 10)
        Me.Text = "PreDiagnosticoyDiagnostico"
        Me.GbxEntrevistaInicial.ResumeLayout(False)
        Me.GbxEntrevistaInicial.PerformLayout()
        Me.GrxBotonesGuardarCancelarContinuar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbxEntrevistaInicial As GroupBox
    Friend WithEvents GrxBotonesGuardarCancelarContinuar As GroupBox
    Friend WithEvents BtnPreDigCancelar As Button
    Friend WithEvents BtnPreDiagGuardar As Button
    Friend WithEvents BtnContinuarAPlan As Button
    Friend WithEvents CbxTipoDeDiagnostico As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtRegistroDeDiagnostico As TextBox
    Friend WithEvents TxtIngresoDeAnalisisClinicos As TextBox
    Friend WithEvents TxtSolicitudDeAnalisisClinicos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnVolverAExploracion As Button
End Class
