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
        Me.PanelIzquierdo = New System.Windows.Forms.Panel()
        Me.PanelIzqIconos = New System.Windows.Forms.Panel()
        Me.LblMenu = New System.Windows.Forms.Label()
        Me.PnlSeparadorPequeño = New System.Windows.Forms.Panel()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.PictureBoxIconoPlan = New System.Windows.Forms.PictureBox()
        Me.PictureIconoMantenimiento = New System.Windows.Forms.PictureBox()
        Me.PictureBoxIconoExploracion = New System.Windows.Forms.PictureBox()
        Me.PictureBoxIconoPreDiagnostico = New System.Windows.Forms.PictureBox()
        Me.PictureBoxIconoEntrevista = New System.Windows.Forms.PictureBox()
        Me.BtnPlan = New System.Windows.Forms.Button()
        Me.BtnPreDiaDiagnostico = New System.Windows.Forms.Button()
        Me.BtnExploracion = New System.Windows.Forms.Button()
        Me.BtnEntrevistaInicial = New System.Windows.Forms.Button()
        Me.BtnMantenimiento = New System.Windows.Forms.Button()
        Me.LblMedicalSoftwdivision = New System.Windows.Forms.Label()
        Me.BarraSuperiorVerde = New System.Windows.Forms.Panel()
        Me.PictureLoguito = New System.Windows.Forms.PictureBox()
        Me.PictureBoxIconoUsuario = New System.Windows.Forms.PictureBox()
        Me.BtnIngresoUsuarios = New System.Windows.Forms.Button()
        Me.PictureBoxPanelCentral = New System.Windows.Forms.PictureBox()
        Me.PanelPrincipal.SuspendLayout()
        Me.PanelIzquierdo.SuspendLayout()
        Me.PanelIzqIconos.SuspendLayout()
        CType(Me.PictureBoxIconoPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureIconoMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxIconoExploracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxIconoPreDiagnostico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxIconoEntrevista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraSuperiorVerde.SuspendLayout()
        CType(Me.PictureLoguito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxIconoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPanelCentral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.AutoScroll = True
        Me.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PanelPrincipal.Controls.Add(Me.PanelIzquierdo)
        Me.PanelPrincipal.Controls.Add(Me.LblMedicalSoftwdivision)
        Me.PanelPrincipal.Controls.Add(Me.BarraSuperiorVerde)
        Me.PanelPrincipal.Controls.Add(Me.PictureBoxPanelCentral)
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.PanelPrincipal.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(1184, 820)
        Me.PanelPrincipal.TabIndex = 0
        '
        'PanelIzquierdo
        '
        Me.PanelIzquierdo.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.PanelIzquierdo.Controls.Add(Me.PanelIzqIconos)
        Me.PanelIzquierdo.Controls.Add(Me.BtnPlan)
        Me.PanelIzquierdo.Controls.Add(Me.BtnPreDiaDiagnostico)
        Me.PanelIzquierdo.Controls.Add(Me.BtnExploracion)
        Me.PanelIzquierdo.Controls.Add(Me.BtnEntrevistaInicial)
        Me.PanelIzquierdo.Controls.Add(Me.BtnMantenimiento)
        Me.PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelIzquierdo.Location = New System.Drawing.Point(0, 62)
        Me.PanelIzquierdo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PanelIzquierdo.Name = "PanelIzquierdo"
        Me.PanelIzquierdo.Size = New System.Drawing.Size(376, 758)
        Me.PanelIzquierdo.TabIndex = 1
        Me.PanelIzquierdo.Visible = False
        '
        'PanelIzqIconos
        '
        Me.PanelIzqIconos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelIzqIconos.Controls.Add(Me.LblMenu)
        Me.PanelIzqIconos.Controls.Add(Me.PnlSeparadorPequeño)
        Me.PanelIzqIconos.Controls.Add(Me.BtnMenu)
        Me.PanelIzqIconos.Controls.Add(Me.PictureBoxIconoPlan)
        Me.PanelIzqIconos.Controls.Add(Me.PictureIconoMantenimiento)
        Me.PanelIzqIconos.Controls.Add(Me.PictureBoxIconoExploracion)
        Me.PanelIzqIconos.Controls.Add(Me.PictureBoxIconoPreDiagnostico)
        Me.PanelIzqIconos.Controls.Add(Me.PictureBoxIconoEntrevista)
        Me.PanelIzqIconos.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelIzqIconos.Location = New System.Drawing.Point(0, 0)
        Me.PanelIzqIconos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelIzqIconos.Name = "PanelIzqIconos"
        Me.PanelIzqIconos.Size = New System.Drawing.Size(91, 758)
        Me.PanelIzqIconos.TabIndex = 2
        Me.PanelIzqIconos.Visible = False
        '
        'LblMenu
        '
        Me.LblMenu.AutoSize = True
        Me.LblMenu.BackColor = System.Drawing.Color.Transparent
        Me.LblMenu.Font = New System.Drawing.Font("Ubuntu", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LblMenu.Location = New System.Drawing.Point(13, 2)
        Me.LblMenu.Name = "LblMenu"
        Me.LblMenu.Size = New System.Drawing.Size(62, 25)
        Me.LblMenu.TabIndex = 3
        Me.LblMenu.Text = "Menu"
        '
        'PnlSeparadorPequeño
        '
        Me.PnlSeparadorPequeño.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PnlSeparadorPequeño.Location = New System.Drawing.Point(3, 125)
        Me.PnlSeparadorPequeño.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PnlSeparadorPequeño.Name = "PnlSeparadorPequeño"
        Me.PnlSeparadorPequeño.Size = New System.Drawing.Size(83, 6)
        Me.PnlSeparadorPequeño.TabIndex = 3
        '
        'BtnMenu
        '
        Me.BtnMenu.BackColor = System.Drawing.Color.Transparent
        Me.BtnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMenu.FlatAppearance.BorderSize = 0
        Me.BtnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnMenu.Image = CType(resources.GetObject("BtnMenu.Image"), System.Drawing.Image)
        Me.BtnMenu.Location = New System.Drawing.Point(3, 29)
        Me.BtnMenu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(82, 90)
        Me.BtnMenu.TabIndex = 2
        Me.BtnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMenu.UseVisualStyleBackColor = False
        Me.BtnMenu.Visible = False
        '
        'PictureBoxIconoPlan
        '
        Me.PictureBoxIconoPlan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxIconoPlan.Image = CType(resources.GetObject("PictureBoxIconoPlan.Image"), System.Drawing.Image)
        Me.PictureBoxIconoPlan.Location = New System.Drawing.Point(4, 571)
        Me.PictureBoxIconoPlan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBoxIconoPlan.Name = "PictureBoxIconoPlan"
        Me.PictureBoxIconoPlan.Size = New System.Drawing.Size(82, 90)
        Me.PictureBoxIconoPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxIconoPlan.TabIndex = 1
        Me.PictureBoxIconoPlan.TabStop = False
        Me.PictureBoxIconoPlan.Visible = False
        '
        'PictureIconoMantenimiento
        '
        Me.PictureIconoMantenimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureIconoMantenimiento.Image = CType(resources.GetObject("PictureIconoMantenimiento.Image"), System.Drawing.Image)
        Me.PictureIconoMantenimiento.Location = New System.Drawing.Point(6, 137)
        Me.PictureIconoMantenimiento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureIconoMantenimiento.Name = "PictureIconoMantenimiento"
        Me.PictureIconoMantenimiento.Size = New System.Drawing.Size(82, 90)
        Me.PictureIconoMantenimiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureIconoMantenimiento.TabIndex = 1
        Me.PictureIconoMantenimiento.TabStop = False
        Me.PictureIconoMantenimiento.Visible = False
        '
        'PictureBoxIconoExploracion
        '
        Me.PictureBoxIconoExploracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxIconoExploracion.Image = CType(resources.GetObject("PictureBoxIconoExploracion.Image"), System.Drawing.Image)
        Me.PictureBoxIconoExploracion.Location = New System.Drawing.Point(3, 355)
        Me.PictureBoxIconoExploracion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBoxIconoExploracion.Name = "PictureBoxIconoExploracion"
        Me.PictureBoxIconoExploracion.Size = New System.Drawing.Size(82, 90)
        Me.PictureBoxIconoExploracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxIconoExploracion.TabIndex = 1
        Me.PictureBoxIconoExploracion.TabStop = False
        Me.PictureBoxIconoExploracion.Visible = False
        '
        'PictureBoxIconoPreDiagnostico
        '
        Me.PictureBoxIconoPreDiagnostico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxIconoPreDiagnostico.Image = CType(resources.GetObject("PictureBoxIconoPreDiagnostico.Image"), System.Drawing.Image)
        Me.PictureBoxIconoPreDiagnostico.Location = New System.Drawing.Point(8, 464)
        Me.PictureBoxIconoPreDiagnostico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBoxIconoPreDiagnostico.Name = "PictureBoxIconoPreDiagnostico"
        Me.PictureBoxIconoPreDiagnostico.Size = New System.Drawing.Size(79, 88)
        Me.PictureBoxIconoPreDiagnostico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxIconoPreDiagnostico.TabIndex = 1
        Me.PictureBoxIconoPreDiagnostico.TabStop = False
        Me.PictureBoxIconoPreDiagnostico.Visible = False
        '
        'PictureBoxIconoEntrevista
        '
        Me.PictureBoxIconoEntrevista.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxIconoEntrevista.Image = CType(resources.GetObject("PictureBoxIconoEntrevista.Image"), System.Drawing.Image)
        Me.PictureBoxIconoEntrevista.Location = New System.Drawing.Point(0, 246)
        Me.PictureBoxIconoEntrevista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBoxIconoEntrevista.Name = "PictureBoxIconoEntrevista"
        Me.PictureBoxIconoEntrevista.Size = New System.Drawing.Size(82, 90)
        Me.PictureBoxIconoEntrevista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxIconoEntrevista.TabIndex = 1
        Me.PictureBoxIconoEntrevista.TabStop = False
        Me.PictureBoxIconoEntrevista.Visible = False
        '
        'BtnPlan
        '
        Me.BtnPlan.BackColor = System.Drawing.Color.Transparent
        Me.BtnPlan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPlan.FlatAppearance.BorderSize = 0
        Me.BtnPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPlan.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPlan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnPlan.Location = New System.Drawing.Point(93, 572)
        Me.BtnPlan.Margin = New System.Windows.Forms.Padding(10, 4, 3, 4)
        Me.BtnPlan.Name = "BtnPlan"
        Me.BtnPlan.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.BtnPlan.Size = New System.Drawing.Size(283, 90)
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
        Me.BtnPreDiaDiagnostico.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreDiaDiagnostico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnPreDiaDiagnostico.Location = New System.Drawing.Point(92, 465)
        Me.BtnPreDiaDiagnostico.Margin = New System.Windows.Forms.Padding(10, 4, 3, 4)
        Me.BtnPreDiaDiagnostico.Name = "BtnPreDiaDiagnostico"
        Me.BtnPreDiaDiagnostico.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.BtnPreDiaDiagnostico.Size = New System.Drawing.Size(293, 90)
        Me.BtnPreDiaDiagnostico.TabIndex = 0
        Me.BtnPreDiaDiagnostico.Text = "Pre Diagnostico/Diagnostico"
        Me.BtnPreDiaDiagnostico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPreDiaDiagnostico.UseVisualStyleBackColor = False
        Me.BtnPreDiaDiagnostico.Visible = False
        '
        'BtnExploracion
        '
        Me.BtnExploracion.BackColor = System.Drawing.Color.Transparent
        Me.BtnExploracion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnExploracion.FlatAppearance.BorderSize = 0
        Me.BtnExploracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnExploracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExploracion.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExploracion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnExploracion.Location = New System.Drawing.Point(92, 356)
        Me.BtnExploracion.Margin = New System.Windows.Forms.Padding(10, 4, 3, 4)
        Me.BtnExploracion.Name = "BtnExploracion"
        Me.BtnExploracion.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.BtnExploracion.Size = New System.Drawing.Size(284, 90)
        Me.BtnExploracion.TabIndex = 0
        Me.BtnExploracion.Text = "Exploracion"
        Me.BtnExploracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExploracion.UseVisualStyleBackColor = False
        '
        'BtnEntrevistaInicial
        '
        Me.BtnEntrevistaInicial.BackColor = System.Drawing.Color.Transparent
        Me.BtnEntrevistaInicial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEntrevistaInicial.FlatAppearance.BorderSize = 0
        Me.BtnEntrevistaInicial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEntrevistaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntrevistaInicial.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntrevistaInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnEntrevistaInicial.Location = New System.Drawing.Point(92, 244)
        Me.BtnEntrevistaInicial.Margin = New System.Windows.Forms.Padding(10, 4, 3, 4)
        Me.BtnEntrevistaInicial.Name = "BtnEntrevistaInicial"
        Me.BtnEntrevistaInicial.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.BtnEntrevistaInicial.Size = New System.Drawing.Size(284, 90)
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
        Me.BtnMantenimiento.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMantenimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnMantenimiento.Location = New System.Drawing.Point(93, 138)
        Me.BtnMantenimiento.Margin = New System.Windows.Forms.Padding(10, 4, 3, 4)
        Me.BtnMantenimiento.Name = "BtnMantenimiento"
        Me.BtnMantenimiento.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.BtnMantenimiento.Size = New System.Drawing.Size(283, 90)
        Me.BtnMantenimiento.TabIndex = 0
        Me.BtnMantenimiento.Text = "Mantenimiento"
        Me.BtnMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMantenimiento.UseVisualStyleBackColor = False
        Me.BtnMantenimiento.Visible = False
        '
        'LblMedicalSoftwdivision
        '
        Me.LblMedicalSoftwdivision.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblMedicalSoftwdivision.AutoSize = True
        Me.LblMedicalSoftwdivision.BackColor = System.Drawing.Color.Transparent
        Me.LblMedicalSoftwdivision.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMedicalSoftwdivision.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.LblMedicalSoftwdivision.Location = New System.Drawing.Point(802, 650)
        Me.LblMedicalSoftwdivision.Name = "LblMedicalSoftwdivision"
        Me.LblMedicalSoftwdivision.Size = New System.Drawing.Size(252, 27)
        Me.LblMedicalSoftwdivision.TabIndex = 3
        Me.LblMedicalSoftwdivision.Text = "Medical Software Division"
        '
        'BarraSuperiorVerde
        '
        Me.BarraSuperiorVerde.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.BarraSuperiorVerde.Controls.Add(Me.PictureLoguito)
        Me.BarraSuperiorVerde.Controls.Add(Me.PictureBoxIconoUsuario)
        Me.BarraSuperiorVerde.Controls.Add(Me.BtnIngresoUsuarios)
        Me.BarraSuperiorVerde.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraSuperiorVerde.Location = New System.Drawing.Point(0, 0)
        Me.BarraSuperiorVerde.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BarraSuperiorVerde.Name = "BarraSuperiorVerde"
        Me.BarraSuperiorVerde.Size = New System.Drawing.Size(1184, 62)
        Me.BarraSuperiorVerde.TabIndex = 0
        '
        'PictureLoguito
        '
        Me.PictureLoguito.Image = CType(resources.GetObject("PictureLoguito.Image"), System.Drawing.Image)
        Me.PictureLoguito.Location = New System.Drawing.Point(21, 5)
        Me.PictureLoguito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureLoguito.Name = "PictureLoguito"
        Me.PictureLoguito.Size = New System.Drawing.Size(40, 49)
        Me.PictureLoguito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureLoguito.TabIndex = 3
        Me.PictureLoguito.TabStop = False
        '
        'PictureBoxIconoUsuario
        '
        Me.PictureBoxIconoUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxIconoUsuario.BackgroundImage = Global._3DevMedicalSoftware.My.Resources.Resources.user2
        Me.PictureBoxIconoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxIconoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxIconoUsuario.Location = New System.Drawing.Point(1121, 5)
        Me.PictureBoxIconoUsuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBoxIconoUsuario.Name = "PictureBoxIconoUsuario"
        Me.PictureBoxIconoUsuario.Size = New System.Drawing.Size(51, 53)
        Me.PictureBoxIconoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxIconoUsuario.TabIndex = 1
        Me.PictureBoxIconoUsuario.TabStop = False
        '
        'BtnIngresoUsuarios
        '
        Me.BtnIngresoUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnIngresoUsuarios.AutoSize = True
        Me.BtnIngresoUsuarios.FlatAppearance.BorderSize = 0
        Me.BtnIngresoUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIngresoUsuarios.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresoUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnIngresoUsuarios.Location = New System.Drawing.Point(979, 15)
        Me.BtnIngresoUsuarios.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BtnIngresoUsuarios.Name = "BtnIngresoUsuarios"
        Me.BtnIngresoUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnIngresoUsuarios.Size = New System.Drawing.Size(127, 34)
        Me.BtnIngresoUsuarios.TabIndex = 2
        Me.BtnIngresoUsuarios.Text = "Ingreso Usuarios"
        Me.BtnIngresoUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnIngresoUsuarios.UseVisualStyleBackColor = True
        '
        'PictureBoxPanelCentral
        '
        Me.PictureBoxPanelCentral.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxPanelCentral.Image = CType(resources.GetObject("PictureBoxPanelCentral.Image"), System.Drawing.Image)
        Me.PictureBoxPanelCentral.Location = New System.Drawing.Point(594, 245)
        Me.PictureBoxPanelCentral.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBoxPanelCentral.Name = "PictureBoxPanelCentral"
        Me.PictureBoxPanelCentral.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.PictureBoxPanelCentral.Size = New System.Drawing.Size(582, 624)
        Me.PictureBoxPanelCentral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPanelCentral.TabIndex = 2
        Me.PictureBoxPanelCentral.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1184, 820)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MinimumSize = New System.Drawing.Size(1200, 745)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medical Software"
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelPrincipal.PerformLayout()
        Me.PanelIzquierdo.ResumeLayout(False)
        Me.PanelIzqIconos.ResumeLayout(False)
        Me.PanelIzqIconos.PerformLayout()
        CType(Me.PictureBoxIconoPlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureIconoMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxIconoExploracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxIconoPreDiagnostico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxIconoEntrevista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraSuperiorVerde.ResumeLayout(False)
        Me.BarraSuperiorVerde.PerformLayout()
        CType(Me.PictureLoguito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxIconoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPanelCentral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents BarraSuperiorVerde As Panel
    Friend WithEvents PanelIzquierdo As Panel
    Friend WithEvents BtnIngresoUsuarios As Button
    Friend WithEvents PictureBoxPanelCentral As PictureBox
    Friend WithEvents BtnMantenimiento As Button
    Friend WithEvents BtnPlan As Button
    Friend WithEvents BtnPreDiaDiagnostico As Button
    Friend WithEvents BtnEntrevistaInicial As Button
    Friend WithEvents PictureBoxIconoUsuario As PictureBox
    Friend WithEvents PictureBoxIconoPlan As PictureBox
    Friend WithEvents PictureBoxIconoExploracion As PictureBox
    Friend WithEvents PictureBoxIconoEntrevista As PictureBox
    Friend WithEvents PictureIconoMantenimiento As PictureBox
    Friend WithEvents PanelIzqIconos As Panel
    Friend WithEvents BtnMenu As Button
    Friend WithEvents LblMedicalSoftwdivision As Label
    Friend WithEvents PictureLoguito As PictureBox
    Friend WithEvents PnlSeparadorPequeño As Panel
    Friend WithEvents LblMenu As Label
    Friend WithEvents PictureBoxIconoPreDiagnostico As PictureBox
    Friend WithEvents BtnExploracion As Button
End Class
