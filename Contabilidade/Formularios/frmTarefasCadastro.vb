Public Class frmTarefasCadastro

    Dim CodigoTarefa As Integer
    Dim novaTarefa As New clsTarefas

    Public Enum TipoConsulta
        ntarefa

    End Enum

    Dim _Operacao As clsFuncoesGerais.Operacao
    Public Property Operacao() As clsFuncoesGerais.Operacao
        Get
            Return _Operacao

        End Get
        Set(ByVal value As clsFuncoesGerais.Operacao)
            _Operacao = value

        End Set
    End Property

    Dim _Codigo As Integer
    Public Property Codigo() As Integer
        Get
            Return _Codigo
        End Get
        Set(ByVal value As Integer)
            _Codigo = value
        End Set
    End Property

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

    Private Sub frmTarefasCadastro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtTarefa.Focus()

    End Sub

    Private Sub btSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSair.Click
        Me.Close()
    End Sub
    ' tarefas_id,tarefa,obs,responsavel,Ativo,DtCadastro,dtConclusao
    Private Sub btGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGravar.Click
        Try
            novaTarefa.tarefa = txtTarefa.Text
            novaTarefa.obs = txtObs.Text
            novaTarefa.responsavel = txtResponsavel.Text
            novaTarefa.Ativo = chbAtivo.Checked
            novaTarefa.DtCadastro = txtDtCadastro.Text
            novaTarefa.dtConclusao = txtDtConclusao.Text

            novaTarefa.GravarDados()

            LimparCampos()
        Catch ex As Exception
            MessageBox.Show("não foi possível fazer o gravar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub btPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPesquisar.Click
        Dim frmTarefaConsulta As New frmTarefaConsulta
        frmTarefaConsulta.Text = "Consulta de Tarefas"
        frmTarefaConsulta.ConsultaTipo = frmTarefaConsulta.TipoConsulta.ntarefa
        frmTarefaConsulta.ShowDialog()

        CodigoTarefa = frmTarefaConsulta.tarefas_id
        lblRecebeIDTarefa.Text = frmTarefaConsulta.tarefas_id
        txtTarefa.Text = frmTarefaConsulta.tarefa
        txtObs.Text = frmTarefaConsulta.obs
        txtResponsavel.Text = frmTarefaConsulta.responsavel
        chbAtivo.Checked = frmTarefaConsulta.Ativo
        txtDtCadastro.Text = frmTarefaConsulta.dtCadastro
        txtDtConclusao.Text = frmTarefaConsulta.dtConclusao

    End Sub

    Private Sub LimparCampos()
        txtTarefa.Text = ""
        txtObs.Text = ""
        txtResponsavel.Text = ""
        chbAtivo.Checked = False
        txtDtCadastro.Text = ""
        txtDtConclusao.Text = ""
    End Sub

    Private Sub btAlterarTarefa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAlterarTarefa.Click
        Try
            novaTarefa.tarefas_id = lblRecebeIDTarefa.Text
            novaTarefa.tarefa = txtTarefa.Text
            novaTarefa.obs = txtObs.Text
            novaTarefa.responsavel = txtResponsavel.Text
            novaTarefa.Ativo = chbAtivo.Checked
            novaTarefa.DtCadastro = txtDtCadastro.Text
            novaTarefa.dtConclusao = txtDtConclusao.Text

            novaTarefa.AlterarDados()

            LimparCampos()

        Catch ex As Exception
            MessageBox.Show("não foi possível fazer o alterar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

   
End Class