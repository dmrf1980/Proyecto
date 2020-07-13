Public Class FrmIngresoUsuarios


    Private Sub FrmIngresoUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If TxtId.Text = "" And TxtContraseña.Text = "" Then

            If MsgBox("No ingreso ningun dato, Desea salir?", vbYesNo) = MsgBoxResult.Yes Then

                Application.Exit()

            End If

        Else

            MsgBox("Bienvenido " + TxtId.Text)
            Form1.PanelIzquierdo.Visible = True
            Form1.PanelIzqIconos.Visible = True
            Form1.BtnMantenimiento.Visible = True
            Form1.BtnEntrevistaInicial.Visible = True
            Form1.BtnPreDiaDiagnostico.Visible = True
            Form1.BtnPlan.Visible = True
            Form1.PictureIconoMantenimiento.Visible = True
            Form1.PictureBoxIconoEntrevista.Visible = True
            Form1.PictureBoxIconoPreDiagnostico.Visible = True
            Form1.PictureBoxIconoPlan.Visible = True
            Form1.BtnMenu.Visible = True


        End If


        Me.Close()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class