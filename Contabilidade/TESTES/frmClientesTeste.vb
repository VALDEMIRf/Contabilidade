Imports System.Data.OleDb
Public Class frmClientesTeste
    '    Dim sql As String
    '    Dim ds As New DataSet
    '    Dim con As New Conexao
    '    Dim CodigoCliente As Integer
    '    Dim CodigoEmpresa As Integer
    '    Dim cliente As New clsCliente
    '    Dim empresa As New clsEmpresa
    '    Public Enum TipoConsulta
    '        Cliente
    '        '  Empresa
    '    End Enum
    '    Private _ConsultaTipo As TipoConsulta
    '    Public Property ConsultaTipo() As TipoConsulta
    '        Get
    '            Return _ConsultaTipo
    '        End Get
    '        Set(ByVal value As TipoConsulta)
    '            _ConsultaTipo = value
    '        End Set
    '    End Property

    '    Private _cli_id As Integer
    '    Public Property cli_id() As Integer
    '        Get
    '            Return _cli_id
    '        End Get
    '        Set(ByVal value As Integer)
    '            _cli_id = value
    '        End Set
    '    End Property

    '    Private _cli_Nome As String
    '    Public Property cli_Nome() As String
    '        Get
    '            Return _cli_Nome
    '        End Get
    '        Set(ByVal value As String)
    '            _cli_Nome = value
    '        End Set
    '    End Property

    '    Private Sub frmClientesTeste_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '        txtCPF.Focus()
    '        TabEmpresa.Enabled = False

    '        Dim clnCategoria As New clsCategoria
    '        Dim dsCategoria As New Data.DataSet
    '        dsCategoria = clnCategoria.Listar("")
    '        With cbTipo
    '            .DataSource = dsCategoria.Tables(0)
    '            .DisplayMember = "Descricao"
    '            .ValueMember = "Codigo"
    '        End With

    '        Dim clnCliente As New clsCliente
    '        Dim dsCliente As New Data.DataSet
    '        dsCliente = clnCliente.ListarCpf("")
    '        With cboCliente
    '            .DataSource = dsCliente.Tables(0)
    '            .DisplayMember = "Descricao"
    '            .ValueMember = "Codigo"
    '        End With

    '    End Sub



    '    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
    '        If txtCPF.Text.Equals(String.Empty) Then
    '            errErro.SetError(txtCPF, "Digite um CPF")
    '            txtCPF.Focus()
    '            Exit Sub
    '        Else
    '            errErro.SetError(txtCPF, "")

    '        End If
    '        If txtNome.Text.Equals(String.Empty) Then
    '            errErro.SetError(txtNome, "Digite um nome")
    '            Exit Sub
    '        Else
    '            errErro.SetError(txtNome, "")
    '        End If


    '        Try

    '            cliente.cli_CPF = txtCPF.Text
    '            cliente.cli_Situacao = cboSituacao.Text
    '            cliente.cli_Nome = txtNome.Text
    '            cliente.cli_PIS = txtPIS.Text
    '            cliente.cli_TitEleitoral = txtTitEleitoral.Text
    '            cliente.cli_Dia = cmbDia.Text
    '            cliente.cli_Mes = cmbMes.Text
    '            cliente.cli_Ano = cmbAno.Text
    '            cliente.cli_RG = txtRG.Text
    '            cliente.cli_Logradouro = txtLogradouro.Text
    '            cliente.cli_Numero = txtNumero.Text
    '            cliente.cli_complemento = txtComplemento.Text
    '            cliente.cli_Bairro = txtBairro.Text
    '            cliente.cli_Cidade = txtCidade.Text
    '            cliente.cli_UF = cboUF.Text
    '            cliente.cli_CEP = txtCEP.Text
    '            cliente.cli_FoneRes = txtFoneRes.Text
    '            cliente.cli_FoneCel = txtFoneCel.Text

    '            cliente.cli_Curriculo = chbCurriculo.Checked
    '            cliente.cli_Email = txtEmail.Text
    '            cliente.cli_observacoes = txtObs.Text
    '            cliente.cli_Aposentado = chbAposentado.Checked
    '            cliente.cli_NumBeneficio = txtNumBeneficio.Text
    '            cliente.cli_FuncPublico = chbFuncPublico.Checked
    '            cliente.cli_NomeFunc = txtFuncPublico.Text
    '            cliente.cli_Autonomo = chbAutonomo.Checked
    '            cliente.cli_AutonomoNome = txtAutonomo.Text
    '            cliente.cli_Falecido = chbFalecido.Checked
    '            cliente.cli_NomeFalecido = txtFalecido.Text
    '            cliente.cli_Inativo = chbInativo.Checked
    '            cliente.cli_InativoObs = txtInativo.Text
    '            cliente.cli_Parcelamento = chbParcelamentos.Checked
    '            cliente.cli_NumParcelamento = txtParcelamentos.Text
    '            cliente.cli_EmprDom = chbESocial.Checked
    '            cliente.cli_ESocial = txtESocial.Text
    '            cliente.cli_EsocialSenha = txtEsocialSenha.Text
    '            cliente.cli_VIP = chbVIP.Checked
    '            cliente.cli_VIPDescricao = txtVIP.Text
    '            cliente.cli_PJ = chbPJ.Checked
    '            cliente.cli_NumPJ = txtPJ.Text
    '            cliente.cli_MEI = chbMEI.Checked
    '            cliente.cli_NumMEI = txtMEI.Text
    '            cliente.cli_ITR = chbITR.Checked
    '            cliente.cli_NumITR = txtITR.Text
    '            cliente.cli_Mensalista = chbMensalista.Checked
    '            cliente.cli_NomeMensalista = txtMensalista.Text
    '            cliente.cli_Decore = chbDecore.Checked
    '            cliente.cli_DecoreDescricao = txtDecore.Text
    '            cliente.cli_IRPF = chbIRPF.Checked
    '            cliente.cli_NumIRPF = txtIRPF.Text
    '            cliente.cli_SenWebPrefeitura = chbSenhaWeb.Checked
    '            cliente.cli_SenhaWebPrefeitura = txtSenhaWeb.Text
    '            cliente.cli_Redesim = chbRedesim.Checked
    '            cliente.cli_SenhaRedesim = txtSenhaRedesim.Text
    '            cliente.cli_CodRFB = chbCodRFB.Checked
    '            cliente.cli_CodRFBNum = txtCodRFB.Text
    '            cliente.cli_CodRFBValidade = txtValidadeRFB.Text
    '            cliente.cli_DtCadastro = Now.Date

    '            cliente.GravarDados()

    '            LimparCampos()

    '        Catch ex As Exception
    '            MessageBox.Show("não foi possível fazer o gravar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            MsgBox(ex.Message.ToString)
    '        End Try



    '    End Sub
End Class