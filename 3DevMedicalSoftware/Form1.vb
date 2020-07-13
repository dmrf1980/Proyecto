Public Class Form1

    ''METODO COLOCAR FORM EN PANEL CENTRAL--------------------------------------------
    Private Sub AbrirFormDentroDePanelPForm(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelPrincipal.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion'
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


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelIzquierdo.Width = 90
    End Sub

    Private Sub BtnIngresoUsuarios_Click(sender As Object, e As EventArgs) Handles BtnIngresoUsuarios.Click
        FrmIngresoUsuarios.Show()

    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click

        If PanelIzquierdo.Width = 90 Then

            PanelIzquierdo.Width = 362

        Else

            PanelIzquierdo.Width = 90

        End If

    End Sub

    Private Sub BtnMantenimiento_Click(sender As Object, e As EventArgs) Handles BtnMantenimiento.Click
        AbrirFormDentroDePanelPForm(Of FrmMantenimiento)()
    End Sub
End Class

