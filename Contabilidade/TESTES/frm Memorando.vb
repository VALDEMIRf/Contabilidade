Imports System.Data.OleDb

Public Class frm_Memorando

    Private Sub frm_Memorando_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaGrid()
    End Sub

    Private Sub carregaGrid()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM teste "

                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvTesteMemorando.DataSource = dt

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally

                con.Close()
            End Try
        End Using
    End Sub

    Private Sub btPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPesquisar.Click
        carregaTexto()

    End Sub


    Private Sub carregaTexto()

        Dim dr As OleDbDataReader = Nothing

        Using con As OleDbConnection = GetConnection()

            Try

                con.Open()
                Dim sql As String = "SELECT * FROM teste WHERE codigo=" & CInt(txtCodigo.Text)

                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                'Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                'Dim dt As DataTable = New DataTable
                'da.Fill(dt)

                dr = cmd.ExecuteReader(Data.CommandBehavior.SingleRow)

                If dr.HasRows Then
                    dr.Read()
                    txtObs.Text = dr.Item("obs")

                Else
                    MsgBox("Não foi posssível carregar os Dados.!", MsgBoxStyle.Critical, "Observações!")
                End If


            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally

                con.Close()
            End Try

        End Using
    End Sub
End Class