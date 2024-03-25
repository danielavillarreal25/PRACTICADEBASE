Imports System.Data.SqlClient

Public Class Form2
    Private connectionString As String = "Data Source=DESKTOP-T4HA64H\SQLEXPRESS01;Initial Catalog=NUEVABASE;Integrated Security=True"

    Private Sub btnMostrarDatos_Click(sender As Object, e As EventArgs) Handles btnMostrarCompras.Click
        MostrarCompras()
    End Sub

    Public Sub MostrarCompras()
        Dim query As String = "SELECT IDProveedor, SaldoPendiente, FechaUltimaCompra FROM Compras"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Crear un adaptador de datos y llenar el DataGridView
                    Dim adapter As New SqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvCompras.DataSource = table
                Catch ex As Exception
                    MessageBox.Show("Error al cargar las compras: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub dgvCompras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCompras.CellContentClick

    End Sub
End Class
