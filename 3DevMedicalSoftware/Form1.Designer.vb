<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxPanelCentral = New System.Windows.Forms.PictureBox()
        Me.PanelIzquierdo = New System.Windows.Forms.Panel()
        Me.PictureBoxIconoPlan = New System.Windows.Forms.PictureBox()
        Me.PictureBoxIconoPreDiagnostico = New System.Windows.Forms.PictureBox()
        Me.PictureBoxIconoEntrevista = New System.Windows.Forms.PictureBox()
        Me.PictureIconoMantenimiento = New System.Windows.Forms.PictureBox()
        Me.BtnPlan = New System.Windows.Forms.Button()
        Me.BtnPreDiaDiagnostico = New System.Windows.Forms.Button()
        Me.BtnEntrevistaInicial = New System.Windows.Forms.Button()
        Me.BtnMantenimiento = New System.Windows.Forms.Button()
        Me.BarraSuperiorVerde = New System.Windows.Forms.Panel()
        Me.PictureBoxIconoUsuario = New System.Windows.Forms.PictureBox()
        Me.BtnIngresoUsuarios = New System.Windows.Forms.Button()
        Me.PanelPrincipal.SuspendLayout()
        CType(Me.PictureBoxPanelCentral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelIzquierdo.SuspendLayout()
        CType(Me.PictureBoxIconoPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxIconoPreDiagnostico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxIconoEntrevista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureIconoMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraSuperiorVerde.SuspendLayout()
        CType(Me.PictureBoxIconoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PanelPrincipal.Controls.Add(Me.Label1)
        Me.PanelPrincipal.Controls.Add(Me.PictureBoxPanelCentral)
        Me.PanelPrincipal.Controls.Add(Me.PanelIzquierdo)
        Me.PanelPrincipal.Controls.Add(Me.BarraSuperiorVerde)
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.PanelPrincipal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(1008, 729)
        Me.PanelPrincipal.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(385, 493)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Medical Software Division"
        '
        'PictureBoxPanelCentral
        '
        Me.PictureBoxPanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxPanelCentral.Image = CType(resources.GetObject("PictureBoxPanelCentral.Image"), System.Drawing.Image)
        Me.PictureBoxPanelCentral.Location = New System.Drawing.Point(346, 50)
        Me.PictureBoxPanelCentral.Name = "PictureBoxPanelCentral"
        Me.PictureBoxPanelCentral.Size = New System.Drawing.Size(662, 679)
        Me.PictureBoxPanelCentral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPanelCentral.TabIndex = 2
        Me.PictureBoxPanelCentral.TabStop = False
        '
        'PanelIzquierdo
        '
        Me.PanelIzquierdo.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.PanelIzquierdo.Controls.Add(Me.PictureBoxIconoPlan)
        Me.PanelIzquierdo.Controls.Add(Me.PictureBoxIconoPreDiagnostico)
        Me.PanelIzquierdo.Controls.Add(Me.PictureBoxIconoEntrevista)
        Me.PanelIzquierdo.Controls.Add(Me.PictureIconoMantenimiento)
        Me.PanelIzquierdo.Controls.Add(Me.BtnPlan)
        Me.PanelIzquierdo.Controls.Add(Me.BtnPreDiaDiagnostico)
        Me.PanelIzquierdo.Controls.Add(Me.BtnEntrevistaInicial)
        Me.PanelIzquierdo.Controls.Add(Me.BtnMantenimiento)
        Me.PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelIzquierdo.Location = New System.Drawing.Point(0, 50)
        Me.PanelIzquierdo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelIzquierdo.Name = "PanelIzquierdo"
        Me.PanelIzquierdo.Size = New System.Drawing.Size(346, 679)
        Me.PanelIzquierdo.TabIndex = 1
        Me.PanelIzquierdo.Visible = False
        '
        'PictureBoxIconoPlan
        '
        Me.PictureBoxIconoPlan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxIconoPlan.Image = CType(resources.GetObject("PictureBoxIconoPlan.Image"), System.Drawing.Image)
        Me.PictureBoxIconoPlan.Location = New System.Drawing.Point(5, 443)
        Me.PictureBoxIconoPlan.Name = "PictureBoxIconoPlan"
        Me.PictureBoxIconoPlan.Size = New System.Drawing.Size(82, 73)
        Me.PictureBoxIconoPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxIconoPlan.TabIndex = 1
        Me.PictureBoxIconoPlan.TabStop = False
        Me.PictureBoxIconoPlan.Visible = False
        '
        'PictureBoxIconoPreDiagnostico
        '
        Me.PictureBoxIconoPreDiagnostico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxIconoPreDiagnostico.Image = CType(resources.GetObject("PictureBoxIconoPreDiagnostico.Image"), System.Drawing.Image)
        Me.PictureBoxIconoPreDiagnostico.Location = New System.Drawing.Point(5, 334)
        Me.PictureBoxIconoPreDiagnostico.Name = "PictureBoxIconoPreDiagnostico"
        Me.PictureBoxIconoPreDiagnostico.Size = New System.Drawing.Size(82, 73)
        Me.PictureBoxIconoPreDiagnostico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxIconoPreDiagnostico.TabIndex = 1
        Me.PictureBoxIconoPreDiagnostico.TabStop = False
        Me.PictureBoxIconoPreDiagnostico.Visible = False
        '
        'PictureBoxIconoEntrevista
        '
        Me.PictureBoxIconoEntrevista.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxIconoEntrevista.Image = CType(resources.GetObject("PictureBoxIconoEntrevista.Image"), System.Drawing.Image)
        Me.PictureBoxIconoEntrevista.Location = New System.Drawing.Point(5, 225)
        Me.PictureBoxIconoEntrevista.Name = "PictureBoxIconoEntrevista"
        Me.PictureBoxIconoEntrevista.Size = New System.Drawing.Size(82, 73)
        Me.PictureBoxIconoEntrevista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxIconoEntrevista.TabIndex = 1
        Me.PictureBoxIconoEntrevista.TabStop = False
        Me.PictureBoxIconoEntrevista.Visible = False
        '
        'PictureIconoMantenimiento
        '
        Me.PictureIconoMantenimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureIconoMantenimiento.Image = CType(resources.GetObject("PictureIconoMantenimiento.Image"), System.Drawing.Image)
        Me.PictureIconoMantenimiento.Location = New System.Drawing.Point(5, 116)
        Me.PictureIconoMantenimiento.Name = "PictureIconoMantenimiento"
        Me.PictureIconoMantenimiento.Size = New System.Drawing.Size(82, 73)
        Me.PictureIconoMantenimiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureIconoMantenimiento.TabIndex = 1
        Me.PictureIconoMantenimiento.TabStop = False
        Me.PictureIconoMantenimiento.Visible = False
        '
        'BtnPlan
        '
        Me.BtnPlan.BackColor = System.Drawing.Color.Transparent
        Me.BtnPlan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPlan.FlatAppearance.BorderSize = 0
        Me.BtnPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPlan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnPlan.Location = New System.Drawing.Point(86, 443)
        Me.BtnPlan.Name = "BtnPlan"
        Me.BtnPlan.Size = New System.Drawing.Size(255, 73)
        Me.BtnPlan.TabIndex = 0
        Me.BtnPlan.Text = "Plan"
        Me.BtnPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPlan.UseVisualStyleBackColor = False
        Me.BtnPlan.Visible = False
        '
        'BtnPreDiaDiagnostico
        '
        Me.BtnPreDiaDiagnostico.BackColor = System.Drawing.Color.Transparent
        Me.BtnPreDiaDiagnostico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPreDiaDiagnostico.FlatAppearance.BorderSize = 0
        Me.BtnPreDiaDiagnostico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPreDiaDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPreDiaDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreDiaDiagnostico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnPreDiaDiagnostico.Location = New System.Drawing.Point(86, 334)
        Me.BtnPreDiaDiagnostico.Name = "BtnPreDiaDiagnostico"
        Me.BtnPreDiaDiagnostico.Size = New System.Drawing.Size(255, 73)
        Me.BtnPreDiaDiagnostico.TabIndex = 0
        Me.BtnPreDiaDiagnostico.Text = "Pre Diagnostico/Diagnostico"
        Me.BtnPreDiaDiagnostico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPreDiaDiagnostico.UseVisualStyleBackColor = False
        Me.BtnPreDiaDiagnostico.Visible = False
        '
        'BtnEntrevistaInicial
        '
        Me.BtnEntrevistaInicial.BackColor = System.Drawing.Color.Transparent
        Me.BtnEntrevistaInicial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEntrevistaInicial.FlatAppearance.BorderSize = 0
        Me.BtnEntrevistaInicial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEntrevistaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntrevistaInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntrevistaInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnEntrevistaInicial.Location = New System.Drawing.Point(85, 225)
        Me.BtnEntrevistaInicial.Name = "BtnEntrevistaInicial"
        Me.BtnEntrevistaInicial.Size = New System.Drawing.Size(255, 73)
        Me.BtnEntrevistaInicial.TabIndex = 0
        Me.BtnEntrevistaInicial.Text = "Entrevista Inicial"
        Me.BtnEntrevistaInicial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEntrevistaInicial.UseVisualStyleBackColor = False
        Me.BtnEntrevistaInicial.Visible = False
        '
        'BtnMantenimiento
        '
        Me.BtnMantenimiento.BackColor = System.Drawing.Color.Transparent
        Me.BtnMantenimiento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMantenimiento.FlatAppearance.BorderSize = 0
        Me.BtnMantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMantenimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnMantenimiento.Location = New System.Drawing.Point(88, 116)
        Me.BtnMantenimiento.Name = "BtnMantenimiento"
        Me.BtnMantenimiento.Size = New System.Drawing.Size(255, 73)
        Me.BtnMantenimiento.TabIndex = 0
        Me.BtnMantenimiento.Text = "Mantenimiento"
        Me.BtnMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMantenimiento.UseVisualStyleBackColor = False
        Me.BtnMantenimiento.Visible = False
        '
        'BarraSuperiorVerde
        '
        Me.BarraSuperiorVerde.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.BarraSuperiorVerde.Controls.Add(Me.PictureBoxIconoUsuario)
        Me.BarraSuperiorVerde.Controls.Add(Me.BtnIngresoUsuarios)
        Me.BarraSuperiorVerde.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraSuperiorVerde.Location = New System.Drawing.Point(0, 0)
        Me.BarraSuperiorVerde.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BarraSuperiorVerde.Name = "BarraSuperiorVerde"
        Me.BarraSuperiorVerde.Size = New System.Drawing.Size(1008, 50)
        Me.BarraSuperiorVerde.TabIndex = 0
        '
        'PictureBoxIconoUsuario
        '
        Me.PictureBoxIconoUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxIconoUsuario.Image = CType(resources.GetObject("PictureBoxIconoUsuario.Image"), System.Drawing.Image)
        Me.PictureBoxIconoUsuario.Location = New System.Drawing.Point(945, 4)
        Me.PictureBoxIconoUsuario.Name = "PictureBoxIconoUsuario"
        Me.PictureBoxIconoUsuario.Size = New System.Drawing.Size(51, 43)
        Me.PictureBoxIconoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxIconoUsuario.TabIndex = 1
        Me.PictureBoxIconoUsuario.TabStop = False
        '
        'BtnIngresoUsuarios
        '
        Me.BtnIngresoUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnIngresoUsuarios.FlatAppearance.BorderSize = 0
        Me.BtnIngresoUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIngresoUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresoUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnIngresoUsuarios.Location = New System.Drawing.Point(800, 12)
        Me.BtnIngresoUsuarios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnIngresoUsuarios.Name = "BtnIngresoUsuarios"
        Me.BtnIngresoUsuarios.Size = New System.Drawing.Size(130, 28)
        Me.BtnIngresoUsuarios.TabIndex = 2
        Me.BtnIngresoUsuarios.Text = "Ingreso Usuarios"
        Me.BtnIngresoUsuarios.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medical Software"
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelPrincipal.PerformLayout()
        CType(Me.PictureBoxPanelCentral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelIzquierdo.ResumeLayout(False)
        CType(Me.PictureBoxIconoPlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxIconoPreDiagnostico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxIconoEntrevista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureIconoMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraSuperiorVerde.ResumeLayout(False)
        CType(Me.PictureBoxIconoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents BarraSuperiorVerde As Panel
    Friend WithEvents PanelIzquierdo As Panel
    Friend WithEvents BtnIngresoUsuarios As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxPanelCentral As PictureBox
    Friend WithEvents BtnMantenimiento As Button
    Friend WithEvents BtnPlan As Button
    Friend WithEvents BtnPreDiaDiagnostico As Button
    Friend WithEvents BtnEntrevistaInicial As Button
    Friend WithEvents PictureBoxIconoUsuario As PictureBox
    Friend WithEvents PictureBoxIconoPlan As PictureBox
    Friend WithEvents PictureBoxIconoPreDiagnostico As PictureBox
    Friend WithEvents PictureBoxIconoEntrevista As PictureBox
    Friend WithEvents PictureIconoMantenimiento As PictureBox
End Class
