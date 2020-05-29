Imports System.Data.OleDb
Public Class frmClienteConsultaGeral
    
    Private Sub frmClienteConsultaGeral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaGrid()


    End Sub

    Private Sub carregaGrid()

        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM tbClientes "

                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvClientesGeral.DataSource = dt


            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally

                con.Close()

            End Try
        End Using

    End Sub

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click
        PPesquisaCliente()
    End Sub

    Private Sub PPesquisaCliente()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM tbClientes WHERE cli_Nome LIKE '%" & txtPesquisa.Text & "%'"

                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvClientesGeral.DataSource = dt


            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally

                con.Close()

            End Try
        End Using
    End Sub
    
End Class