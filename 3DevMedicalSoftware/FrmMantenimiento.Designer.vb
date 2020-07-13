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
        Me.LblApellidoPaterno = New System.Windows.Forms.Label()
        Me.LblPrimerNombre = New System.Windows.Forms.Label()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.LblSegundoNombre = New System.Windows.Forms.Label()
        Me.LblApellidoMaterno = New System.Windows.Forms.Label()
        Me.LblFechadeNacimiento = New System.Windows.Forms.Label()
        Me.LbxConsultasAnteriores = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbxIngresoPacientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbxIngresoPacientes
        '
        Me.GbxIngresoPacientes.AutoSize = True
        Me.GbxIngresoPacientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GbxIngresoPacientes.Controls.Add(Me.LbxConsultasAnteriores)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblApellidoMaterno)
        Me.GbxIngresoPacientes.Controls.Add(Me.Label1)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblFechadeNacimiento)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblApellidoPaterno)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblSegundoNombre)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblPrimerNombre)
        Me.GbxIngresoPacientes.Controls.Add(Me.LblCedula)
        Me.GbxIngresoPacientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbxIngresoPacientes.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxIngresoPacientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.GbxIngresoPacientes.Location = New System.Drawing.Point(0, 0)
        Me.GbxIngresoPacientes.Name = "GbxIngresoPacientes"
        Me.GbxIngresoPacientes.Size = New System.Drawing.Size(1008, 729)
        Me.GbxIngresoPacientes.TabIndex = 0
        Me.GbxIngresoPacientes.TabStop = False
        Me.GbxIngresoPacientes.Text = "Ingreso de Pacientes"
        '
        'LblApellidoPaterno
        '
        Me.LblApellidoPaterno.AutoSize = True
        Me.LblApellidoPaterno.Location = New System.Drawing.Point(83, 181)
        Me.LblApellidoPaterno.Name = "LblApellidoPaterno"
        Me.LblApellidoPaterno.Size = New System.Drawing.Size(130, 20)
        Me.LblApellidoPaterno.TabIndex = 0
        Me.LblApellidoPaterno.Text = "Apellido Paterno"
        '
        'LblPrimerNombre
        '
        Me.LblPrimerNombre.AutoSize = True
        Me.LblPrimerNombre.Location = New System.Drawing.Point(95, 125)
        Me.LblPrimerNombre.Name = "LblPrimerNombre"
        Me.LblPrimerNombre.Size = New System.Drawing.Size(118, 20)
        Me.LblPrimerNombre.TabIndex = 0
        Me.LblPrimerNombre.Text = "Primer Nombre"
        '
        'LblCedula
        '
        Me.LblCedula.AutoSize = True
        Me.LblCedula.Location = New System.Drawing.Point(154, 69)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(59, 20)
        Me.LblCedula.TabIndex = 0
        Me.LblCedula.Text = "Cedula"
        '
        'LblSegundoNombre
        '
        Me.LblSegundoNombre.AutoSize = True
        Me.LblSegundoNombre.Location = New System.Drawing.Point(437, 125)
        Me.LblSegundoNombre.Name = "LblSegundoNombre"
        Me.LblSegundoNombre.Size = New System.Drawing.Size(135, 20)
        Me.LblSegundoNombre.TabIndex = 0
        Me.LblSegundoNombre.Text = "Segundo Nombre"
        '
        'LblApellidoMaterno
        '
        Me.LblApellidoMaterno.AutoSize = True
        Me.LblApellidoMaterno.Location = New System.Drawing.Point(439, 181)
        Me.LblApellidoMaterno.Name = "LblApellidoMaterno"
        Me.LblApellidoMaterno.Size = New System.Drawing.Size(133, 20)
        Me.LblApellidoMaterno.TabIndex = 0
        Me.LblApellidoMaterno.Text = "Apellido Materno"
        '
        'LblFechadeNacimiento
        '
        Me.LblFechadeNacimiento.AutoSize = True
        Me.LblFechadeNacimiento.Location = New System.Drawing.Point(57, 237)
        Me.LblFechadeNacimiento.Name = "LblFechadeNacimiento"
        Me.LblFechadeNacimiento.Size = New System.Drawing.Size(156, 20)
        Me.LblFechadeNacimiento.TabIndex = 0
        Me.LblFechadeNacimiento.Text = "Fecha de nacimiento"
        '
        'LbxConsultasAnteriores
        '
        Me.LbxConsultasAnteriores.FormattingEnabled = True
        Me.LbxConsultasAnteriores.ItemHeight = 20
        Me.LbxConsultasAnteriores.Location = New System.Drawing.Point(220, 397)
        Me.LbxConsultasAnteriores.Name = "LbxConsultasAnteriores"
        Me.LbxConsultasAnteriores.Size = New System.Drawing.Size(641, 124)
        Me.LbxConsultasAnteriores.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 397)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consultas anteriores"
        '
        'FrmMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.GbxIngresoPacientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMantenimiento"
        Me.Text = "FrmMantenimiento"
        Me.GbxIngresoPacientes.ResumeLayout(False)
        Me.GbxIngresoPacientes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbxIngresoPacientes As GroupBox
    Friend WithEvents LblApellidoPaterno As Label
    Friend WithEvents LblPrimerNombre As Label
    Friend WithEvents LblCedula As Label
    Friend WithEvents LblApellidoMaterno As Label
    Friend WithEvents LblFechadeNacimiento As Label
    Friend WithEvents LblSegundoNombre As Label
    Friend WithEvents LbxConsultasAnteriores As ListBox
    Friend WithEvents Label1 As Label
End Class
