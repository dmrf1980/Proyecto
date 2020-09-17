Imports MySql.Data.MySqlClient


Public Class ConexionBD

    Dim conexion As New MySqlConnection     'clase que administra y abre la conexion con la BD
    Dim comando As New MySqlCommand      ' para ejecutar "sentencias" comandos sql
    Dim adaptor As New MySqlDataAdapter ' convierte los objetos mysql a visual
    Dim datos As New DataSet             'almacena los resultados de SELECT los datos en tablas, "dataset" tiene un conjunto de "datatable"


    Public Function Abrir() As Boolean
        Try

            conexion.ConnectionString = "server=127.0.0.1; database=4devmates; user=administrador; password=administrador"
            conexion.Open()
            Return True
            MsgBox("SE  conecto")
        Catch ex As Exception

            MsgBox("Error al abrir la conexion")

            Return False

        End Try

    End Function

    Public Function SQL(ByVal sentencia As String) As DataTable

        If Abrir() Then

            comando.Connection = conexion
            comando.CommandText = sentencia
            comando.ExecuteNonQuery()        ' ejecuta la sentencia
            adaptor.SelectCommand = comando
            adaptor.Fill(datos, "resultado")
            Return datos.Tables("resultado")

        Else

            Return Nothing

        End If



    End Function


    Public Function DML(ByVal sentencia As String) As Long
        If Abrir() Then

            comando.Connection = conexion
            comando.CommandText = sentencia
            comando.ExecuteNonQuery()

            Return comando.LastInsertedId      'Para atributos Auto_increment

        Else

            Return 0

        End If
    End Function

    '--------------------------

    ' ByVaL recibe una copia del valor si se modifica no cabia en el origen
    ' ByRef recibe una referencia del objeto/variable si se modifica tambien se modifica el original

    Public Sub CargarCombo(ByVal sentencia As String, ByRef combo As ComboBox)

        Dim lector As MySqlDataReader 'Permite leeer informacion del resultado de una consulta fila a fila

        If Abrir() Then

            comando.Connection = conexion
            comando.CommandText = sentencia
            lector = comando.ExecuteReader   ' lee por filas, devuelve verdadero o falso dependiendo si puede leerla
            combo.Items.Clear()
            combo.Items.Add(("Todos"))

            While lector.Read

                combo.Items.Add(lector.GetString(0)) ' 0= es la primer columna

            End While

            combo.SelectedIndex = 0  ' 1er elemento

        End If





    End Sub






End Class
