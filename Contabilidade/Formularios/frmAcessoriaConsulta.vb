﻿Imports System.Data.OleDb

Public Class frmAcessoriaConsulta
    Private Sub frmAcessoriaConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Enum TipoConsulta
        Assessoria

    End Enum
    Private Sub CarregaGrid()
        Dim dsConsulta As New Data.DataSet
        Select Case _ConsultaTipo
            Case TipoConsulta.Assessoria
                Dim clnAssessoria As New clsAcessoria
                ' dsConsulta = clnAssessoria.Listar(txtPesquisarCliente.Text, txtMes.Text, txtAno.Text)
                dsConsulta = clnAssessoria.Listar(txtPesquisarCliente.Text)


        End Select
        dgvGridAssessoria.DataSource = dsConsulta.Tables(0)
    End Sub

    Private _ConsultaTipo As TipoConsulta
    Public Property ConsultaTipo() As TipoConsulta
        Get
            Return _ConsultaTipo
        End Get
        Set(ByVal value As TipoConsulta)
            _ConsultaTipo = value
        End Set
    End Property

    Private _IdAssessoria As Integer
    Public Property IdAssessoria() As Integer
        Get
            Return _IdAssessoria
        End Get
        Set(ByVal value As Integer)
            _IdAssessoria = value
        End Set
    End Property

    Private _telefone As String

    Public Property telefone() As String
        Get
            Return _telefone
        End Get
        Set(ByVal value As String)
            _telefone = value
        End Set
    End Property

    Private _empresa As String
    Public Property empresa() As String
        Get
            Return _empresa
        End Get
        Set(ByVal value As String)
            _empresa = value
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

    Private _gerente As String
    Public Property gerente() As String
        Get
            Return _gerente
        End Get
        Set(ByVal value As String)
            _gerente = value
        End Set
    End Property

    Private _mes As String
    Public Property mes() As String
        Get
            Return _mes
        End Get
        Set(ByVal value As String)
            _mes = value
        End Set
    End Property

    Private _ano As Integer
    Public Property ano() As Integer
        Get
            Return _ano
        End Get
        Set(ByVal value As Integer)
            _ano = value
        End Set
    End Property

    Private _PROLABORE As Boolean
    Public Property PROLABORE() As Boolean
        Get
            Return _PROLABORE
        End Get
        Set(ByVal value As Boolean)
            _PROLABORE = value
        End Set
    End Property

    Private _SALARIOTREZE As String
    Public Property SALARIOTREZE() As String
        Get
            Return _SALARIOTREZE
        End Get
        Set(ByVal value As String)
            _SALARIOTREZE = value
        End Set
    End Property

    Private _FOLHA As Boolean
    Public Property FOLHA() As Boolean
        Get
            Return _FOLHA
        End Get
        Set(ByVal value As Boolean)
            _FOLHA = value
        End Set
    End Property


    Private _SEFIP As Boolean
    Public Property SEFIP() As Boolean
        Get
            Return _SEFIP
        End Get
        Set(ByVal value As Boolean)
            _SEFIP = value
        End Set
    End Property

    Private _GPS As Boolean
    Public Property GPS() As Boolean
        Get
            Return _GPS
        End Get
        Set(ByVal value As Boolean)
            _GPS = value
        End Set
    End Property

    Private _GRF As Boolean
    Public Property GRF() As Boolean
        Get
            Return _GRF
        End Get
        Set(ByVal value As Boolean)
            _GRF = value
        End Set
    End Property

    Private _IRRF As Boolean
    Public Property IRRF() As Boolean
        Get
            Return _IRRF
        End Get
        Set(ByVal value As Boolean)
            _IRRF = value
        End Set
    End Property

    Private _DARF As Boolean
    Public Property DARF() As Boolean
        Get
            Return _DARF
        End Get
        Set(ByVal value As Boolean)
            _DARF = value
        End Set
    End Property

    Private _GRRF As Boolean
    Public Property GRRF() As Boolean
        Get
            Return _GRRF
        End Get
        Set(ByVal value As Boolean)
            _GRRF = value
        End Set
    End Property

    Private _DEFIS As Boolean
    Public Property DEFIS() As Boolean
        Get
            Return _DEFIS
        End Get
        Set(ByVal value As Boolean)
            _DEFIS = value
        End Set
    End Property

    Private _DAS As Boolean
    Public Property DAS() As Boolean
        Get
            Return _DAS
        End Get
        Set(ByVal value As Boolean)
            _DAS = value
        End Set
    End Property

    Private _DASZERADO As Boolean
    Public Property DASZERADO() As Boolean
        Get
            Return _DASZERADO
        End Get
        Set(ByVal value As Boolean)
            _DASZERADO = value
        End Set
    End Property

    Private _DASN As Boolean
    Public Property DASN() As Boolean
        Get
            Return _DASN
        End Get
        Set(ByVal value As Boolean)
            _DASN = value
        End Set
    End Property

    Private _DCTF As Boolean
    Public Property DCTF() As Boolean
        Get
            Return _DCTF
        End Get
        Set(ByVal value As Boolean)
            _DCTF = value
        End Set
    End Property

    Private _RAIS As Boolean
    Public Property RAIS() As Boolean
        Get
            Return _RAIS
        End Get
        Set(ByVal value As Boolean)
            _RAIS = value
        End Set
    End Property

    Private _RAISNEGATIVA As Boolean
    Public Property RAISNEGATIVA() As Boolean
        Get
            Return _RAISNEGATIVA
        End Get
        Set(ByVal value As Boolean)
            _RAISNEGATIVA = value
        End Set
    End Property

    Private _ECF As Boolean
    Public Property ECF() As Boolean
        Get
            Return _ECF
        End Get
        Set(ByVal value As Boolean)
            _ECF = value
        End Set
    End Property

    Private _EFD As Boolean
    Public Property EFD() As Boolean
        Get
            Return _EFD
        End Get
        Set(ByVal value As Boolean)
            _EFD = value
        End Set
    End Property

    Private _GIA As Boolean
    Public Property GIA() As Boolean
        Get
            Return _GIA
        End Get
        Set(ByVal value As Boolean)
            _GIA = value
        End Set
    End Property

    Private _CAGED As Boolean
    Public Property CAGED() As Boolean
        Get
            Return _CAGED
        End Get
        Set(ByVal value As Boolean)
            _CAGED = value
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

    Private Sub btPesquisarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPesquisarCliente.Click
        CarregaGrid()
    End Sub

    Private Sub txtMes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMes.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtAno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAno.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btEnviarDados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnviarDados.Click
        dadosEnviados()
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub

    Private Sub dgvGridAssessoria_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvGridAssessoria.DoubleClick
        dadosEnviados()
    End Sub

    'METODO DE DUPLO CLICK QUE ENVIA DADOS PARA O FORMULARIO DE CONSULTAR ASSESSORIA
    Private Sub dadosEnviados()
        Select Case _ConsultaTipo
            Case TipoConsulta.Assessoria
                If dgvGridAssessoria.RowCount <> 0 Then
                    _IdAssessoria = dgvGridAssessoria.CurrentRow.Cells(0).Value
                    _empresa = dgvGridAssessoria.CurrentRow.Cells(1).Value
                    _mes = dgvGridAssessoria.CurrentRow.Cells(2).Value.ToString
                    _ano = dgvGridAssessoria.CurrentRow.Cells(3).Value.ToString
                    _gerente = dgvGridAssessoria.CurrentRow.Cells(4).Value
                    _responsavel = dgvGridAssessoria.CurrentRow.Cells(5).Value
                    _telefone = dgvGridAssessoria.CurrentRow.Cells(6).Value.ToString
                    _PROLABORE = dgvGridAssessoria.CurrentRow.Cells(7).Value
                    _SALARIOTREZE = dgvGridAssessoria.CurrentRow.Cells(8).Value.ToString
                    _FOLHA = dgvGridAssessoria.CurrentRow.Cells(9).Value
                    _DARF = dgvGridAssessoria.CurrentRow.Cells(10).Value
                    _GRRF = dgvGridAssessoria.CurrentRow.Cells(11).Value
                    _SEFIP = dgvGridAssessoria.CurrentRow.Cells(12).Value
                    _GPS = dgvGridAssessoria.CurrentRow.Cells(13).Value
                    _GRF = dgvGridAssessoria.CurrentRow.Cells(14).Value
                    _DAS = dgvGridAssessoria.CurrentRow.Cells(15).Value
                    _DASZERADO = dgvGridAssessoria.CurrentRow.Cells(16).Value
                    _DASN = dgvGridAssessoria.CurrentRow.Cells(17).Value
                    _DEFIS = dgvGridAssessoria.CurrentRow.Cells(18).Value
                    _IRRF = dgvGridAssessoria.CurrentRow.Cells(19).Value
                    _DCTF = dgvGridAssessoria.CurrentRow.Cells(20).Value
                    _RAIS = dgvGridAssessoria.CurrentRow.Cells(21).Value
                    _RAISNEGATIVA = dgvGridAssessoria.CurrentRow.Cells(22).Value
                    _ECF = dgvGridAssessoria.CurrentRow.Cells(23).Value
                    _EFD = dgvGridAssessoria.CurrentRow.Cells(24).Value
                    _GIA = dgvGridAssessoria.CurrentRow.Cells(25).Value
                    _CAGED = dgvGridAssessoria.CurrentRow.Cells(26).Value
                    _obs = dgvGridAssessoria.CurrentRow.Cells(27).Value.ToString

                    Me.Close()

                End If
        End Select
    End Sub
End Class