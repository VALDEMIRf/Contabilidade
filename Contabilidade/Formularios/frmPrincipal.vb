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
        cmbMes.SelectedIndex = 0
        PCarregaDadosIniciais()

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

    'MÉTODO QUE LISTA DADOS DAS TAREFAS 
    Private Sub ListadeTarefas(ByVal strPesquisa As String)
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String
                sql = "SELECT tarefa,responsavel,DtCadastro,dtConclusao,"
                sql += "Ativo,obs FROM tbTarefas Where Ativo=" & chbAtivo.Checked

                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvTarefas.DataSource = dt

            Catch ex As Exception
                MsgBox("Ocorreu um erro ao carregar os dados. Erro: " & ex.Message.ToString, MsgBoxStyle.Critical, "Aniversariantes")
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub btRecarregarTarefas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRecarregarTarefas.Click
        CarregaGrid()
    End Sub

    'MÉTODO QUE LISTA DADOS DAS CLIENTES PARA VER OS ANIVERSARIANTES
    Private Sub PCarregaDadosIniciais()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String
                sql = "SELECT cli_id,cli_Nome,cli_Logradouro,cli_CEP,cli_Cidade,cli_UF,cli_Ano,"
                sql += "cli_FoneCel,cli_Dia,cli_Mes,cli_Email From tbClientes ORDER BY cli_Mes"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvAniversariantes.DataSource = dt

                'Formata a gridview
                PFormataDataGridView()

            Catch ex As Exception
                MsgBox("Ocorreu um erro ao carregar os dados. Erro: " & ex.Message.ToString, MsgBoxStyle.Critical, "Aniversariantes")
            Finally
                con.Close()
            End Try
        End Using
    End Sub


    Private Sub PFormataDataGridView()
        With dgvAniversariantes
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AllowUserToResizeColumns = False
            .EnableHeadersVisualStyles = False

            .Columns(0).HeaderText = "Código"
            .Columns(1).HeaderText = "Nome"
            .Columns(2).HeaderText = "Endereço"
            .Columns(3).HeaderText = "Cep"
            .Columns(4).HeaderText = "Cidade"
            .Columns(5).HeaderText = "Estado"
            .Columns(6).HeaderText = "Telefone"
            .Columns(7).HeaderText = "Celular"
            .Columns(8).HeaderText = "Dia"
            .Columns(9).HeaderText = "Mês"
            .Columns(10).HeaderText = "E-mail"

            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    'MÉTODO QUE LISTA OS ANIVERSARIANTES POR MES
    Private Sub PCarregaDados(ByVal strMes As String)
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String

                sql = "SELECT cli_id,cli_Nome,cli_Logradouro,cli_CEP,cli_Cidade,cli_UF,cli_FoneRes, "
                sql += "cli_FoneCel,cli_Dia,cli_Mes,cli_Email From tbClientes Where cli_Mes='" & strMes & "' ORDER BY cli_Dia"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvAniversariantes.DataSource = dt

                'Formata a gridview
                PFormataDataGridView()
            Catch ex As Exception
                MsgBox(ex.Message).ToString()
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub cmbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMes.SelectedIndexChanged
        If cmbMes.SelectedIndex = 0 Then
            PCarregaDadosIniciais()
        Else
            PCarregaDados(cmbMes.Text)
        End If
    End Sub

    Private Sub chbAtivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbAtivo.CheckedChanged
        If chbAtivo.Checked = False Then
            CarregaGrid()
        Else
            ListadeTarefas(cbPesquisa.Text)
        End If
    End Sub

   
End Class
