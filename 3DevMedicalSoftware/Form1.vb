Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelIzquierdo.Width = 90
        PictureBoxIconoUsuario.Image = FrmMantenimiento.PictureImagenPerfil.Image
    End Sub

    ''METODO COLOCAR FORM EN PANEL CENTRAL--------------------------------------------
    Public Sub AbrirFormDentroDePanelPForm(Of Miform As {Form, New})()
        Dim Formulario As Form

        'Busca el formulario en la coleccion'
        Formulario = PanelPrincipal.Controls.OfType(Of Miform)().FirstOrDefault()
        'Si form no fue econtrado/ no existe'
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            PanelPrincipal.Controls.Add(Formulario)
            PanelPrincipal.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If

    End Sub




    Private Sub BtnIngresoUsuarios_Click(sender As Object, e As EventArgs) Handles BtnIngresoUsuarios.Click
        FrmIngresoUsuarios.Show()

    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click

        If PanelIzquierdo.Width = 90 Then

            PanelIzquierdo.Width = 370

        Else

            PanelIzquierdo.Width = 90

        End If

    End Sub

    Private Sub BtnMantenimiento_Click(sender As Object, e As EventArgs) Handles BtnMantenimiento.Click
        AbrirFormDentroDePanelPForm(Of FrmMantenimiento)()
        PanelIzquierdo.Width = 90
    End Sub

    Private Sub BtnEntrevistaInicial_Click(sender As Object, e As EventArgs) Handles BtnEntrevistaInicial.Click
        AbrirFormDentroDePanelPForm(Of FrmEntrevistaInicial)()
        PanelIzquierdo.Width = 90
    End Sub
    Private Sub BtnExploracion_Click(sender As Object, e As EventArgs) Handles BtnExploracion.Click
        AbrirFormDentroDePanelPForm(Of FrmExploracionYDolor)()
        PanelIzquierdo.Width = 90
    End Sub
    Private Sub BtnPreDiaDiagnostico_Click(sender As Object, e As EventArgs) Handles BtnPreDiaDiagnostico.Click
        AbrirFormDentroDePanelPForm(Of FrmPreDiagnosticoyDiagnostico)()
        PanelIzquierdo.Width = 90
    End Sub

    Private Sub BtnPlan_Click(sender As Object, e As EventArgs) Handles BtnPlan.Click
        AbrirFormDentroDePanelPForm(Of FrmPlanTratamiento)()
        PanelIzquierdo.Width = 90
    End Sub
End Class

