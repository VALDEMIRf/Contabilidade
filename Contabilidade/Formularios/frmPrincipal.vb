Imports System.Data.OleDb
Imports System.Data

Public Class frmPrincipal

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

    Private _Ativo As Boolean
    Public Property Ativo() As Boolean
        Get
            Return _Ativo
        End Get
        Set(ByVal value As Boolean)
            _Ativo = value
        End Set
    End Property

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ' cmbMes.SelectedIndex = 0
        ' PCarregaDadosIniciais()
        ' ListaTarefas()
        CarregaGrid()
    End Sub


    Private Sub CarregaGrid()
        Dim cldTarefa As New clsTarefas
        dgvTarefas.DataSource = cldTarefa.ListTarefa(cbPesquisa.Text).Tables(0)
    End Sub

    Private Sub ManutençãoDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManutençãoDeClientesToolStripMenuItem.Click
        Dim frmClientes As New frmClientes
        frmClientes.ShowDialog()
    End Sub

    Private Sub ConsultaGeralDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaGeralDeClientesToolStripMenuItem.Click
        Dim frmClienteConsultaGeral As New frmClienteConsultaGeral
        frmClienteConsultaGeral.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem1.Click
        Dim frmCliente As New frmClientesTeste
        frmCliente.ShowDialog()
    End Sub

    Private Sub TesteMemorandoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TesteMemorandoToolStripMenuItem.Click
        Dim frmMem As New frm_Memorando
        frmMem.ShowDialog()
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ControleDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControleDeClientesToolStripMenuItem.Click
        Dim frmCadAssessoria As New frmCadAcessoria
        frmCadAssessoria.ShowDialog()
    End Sub

    Private Sub CadastroDeTarefasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroDeTarefasToolStripMenuItem.Click
        Dim frmCadTarefas As New frmTarefasCadastro
        frmCadTarefas.ShowDialog()
    End Sub

    
End Class
