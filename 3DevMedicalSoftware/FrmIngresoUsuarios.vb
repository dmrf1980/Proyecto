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
            If Not TxtId.Text = "" And TxtContraseña.Text = "" Then

            End If

        End If


            Me.Close()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub


End Class