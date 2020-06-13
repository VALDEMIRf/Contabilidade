Imports System.Data.OleDb

Public Class frmTarefaConsulta
    Public idtarefa As Integer
    Public novatarefa As String

    Public Enum TipoConsulta
        ntarefa

    End Enum

    Private _ConsultaTipo As TipoConsulta
    Public Property ConsultaTipo() As TipoConsulta
        Get
            Return _ConsultaTipo
        End Get
        Set(ByVal value As TipoConsulta)
            _ConsultaTipo = value
        End Set
    End Property

    Private _tarefas_id As Integer
    Public Property tarefas_id() As Integer
        Get
            Return _tarefas_id
        End Get
        Set(ByVal value As Integer)
            _tarefas_id = value
        End Set
    End Property

    Private _tarefa As String

    Public Property tarefa() As String
        Get
            Return _tarefa
        End Get
        Set(ByVal value As String)
            _tarefa = value
        End Set
    End Property

    Private _obs As String
    Public Property obs() As String
        Get
            Return _obs
        End Get
        Set(ByVal value As String)
            _obs = value
        End Set
    End Property

    Private _responsavel As String
    Public Property responsavel() As String
        Get
            Return _responsavel
        End Get
        Set(ByVal value As String)
            _responsavel = value
        End Set
    End Property

    Private _Ativo As Boolean
    Public Property Ativo() As Boolean
        Get
            Return _Ativo
        End Get
        Set(ByVal value As Boolean)
            _Ativo = value
        End Set
    End Property

    Private _dtCadastro As String
    Public Property dtCadastro() As String
        Get
            Return _dtCadastro
        End Get
        Set(ByVal value As String)
            _dtCadastro = value
        End Set
    End Property

    Private _dtConclusao As String
    Public Property dtConclusao() As String
        Get
            Return _dtConclusao
        End Get
        Set(ByVal value As String)
            _dtConclusao = value
        End Set
    End Property


    Private Sub CarregaGrid()
        Dim dsConsulta As New Data.DataSet
        Select _ConsultaTipo
            Case TipoConsulta.ntarefa
                Dim clnTarefa As New clsTarefas
                dsConsulta = clnTarefa.Lista(txtDescricao.Text)

        End Select
        dgdGrid.DataSource = dsConsulta.Tables(0)
    End Sub

    Private Sub btPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPesquisar.Click
        CarregaGrid()
    End Sub

    Private Sub btSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    

    Private Sub btEnviarDados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnviarDados.Click
        DadosEnviados()
    End Sub

    Private Sub dgdGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgdGrid.DoubleClick
        DadosEnviados()
    End Sub

    Private Sub DadosEnviados()
        ' tarefas_id,tarefa,obs,responsavel,Ativo,DtCadastro,dtConclusao
        Select Case _ConsultaTipo
            Case TipoConsulta.ntarefa
                If dgdGrid.RowCount <> 0 Then
                    _tarefas_id = dgdGrid.CurrentRow.Cells(0).Value
                    _tarefa = dgdGrid.CurrentRow.Cells(1).Value
                    _obs = dgdGrid.CurrentRow.Cells(2).Value
                    _responsavel = dgdGrid.CurrentRow.Cells(3).Value
                    _Ativo = dgdGrid.CurrentRow.Cells(4).Value
                    _dtCadastro = dgdGrid.CurrentRow.Cells(5).Value
                    _dtConclusao = dgdGrid.CurrentRow.Cells(6).Value

                    Me.Close()
                   
                End If
        End Select
        
    End Sub

    Private Sub btExcluirTarefa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExcluirTarefa.Click
        If dgdGrid.RowCount <> 0 Then
            If (MessageBox.Show("Deseja excluir o registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub
            Dim cldTarefa As New clsTarefas
            cldTarefa.Excluir(dgdGrid.CurrentRow.Cells(0).Value)
            MessageBox.Show("Registro excluído com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            CarregaGrid()
        Else
            MessageBox.Show("Clique no botão pesquisar e selecione uma Tarefa", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class

