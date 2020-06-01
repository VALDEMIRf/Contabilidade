Imports System.Data.OleDb

Public Class frmClientes
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao
    Dim CodigoCliente As Integer
    Dim CodigoEmpresa As Integer
    Dim cliente As New clsCliente
    Dim empresa As New clsEmpresa
    Public Enum TipoConsulta
        Cliente
        '  Empresa
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

    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCPF.Focus()
        TabEmpresa.Enabled = False

        Dim clnCategoria As New clsCategoria
        Dim dsCategoria As New Data.DataSet
        dsCategoria = clnCategoria.Listar("")
        With cbTipo
            .DataSource = dsCategoria.Tables(0)
            .DisplayMember = "Descricao"
            .ValueMember = "Codigo"
        End With

        'Dim clnCliente As New clsCliente
        'Dim dsCliente As New Data.DataSet
        'dsCliente = clnCliente.ListarCpf("")
        'With cboCliente
        '    .DataSource = dsCliente.Tables(0)
        '    .DisplayMember = "Descricao"
        '    .ValueMember = "Codigo"
        'End With

    End Sub
    
    'empr_ID,empr_razaosocial,empr_nomefantasia,empr_cnpj,empr_Situacaocnpj,empr_InscrEstadual,empr_NIRE,empr_CCM,empr_Porte,empr_atividade,empr_dataInicio,cli_id,cat_Id,empr_TelCel1,empr_TelCel2,empr_endereco,empr_numero,empr_complemento,empr_bairro,empr_cidade,empr_UF,empr_CEP,empr_obs,empr_Simples,empr_SimplesNacional,empr_Simei,empr_CodSimei,empr_sefaz,empr_SefazUsu,empr_SefazSen,empr_CodReceitaPJ,empr_SenhaCodReceitaPJ,empr_ValReceitaPJ

    'BOTÃO DE CADASTRO DE PESSOA FÍSICA
    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click

        If txtCPF.Text.Equals(String.Empty) Then
            errErro.SetError(txtCPF, "Digite um CPF")
            txtCPF.Focus()
            Exit Sub
        Else
            errErro.SetError(txtCPF, "")

        End If
        If txtNome.Text.Equals(String.Empty) Then
            errErro.SetError(txtNome, "Digite um nome")
            Exit Sub
        Else
            errErro.SetError(txtNome, "")
        End If

        Try
            'cli_id,cli_CPF,cli_Situacao,cli_RG,cli_Nome,cli_PIS,cli_TitEleitoral,cli_Dia,cli_Mes,cli_Ano,cli_Logradouro,cli_Numero,cli_complemento,cli_Bairro,cli_Cidade,cli_UF,cli_CEP,cli_FoneRes,cli_FoneCel,cli_FoneCel2,cli_Email,cli_observacoes,cli_Autonomo,cli_PJ,cli_MEI,cli_Curriculo,cli_Aposentado,cli_NumBeneficio,cli_FuncPublico,cli_NivelFunc,cli_Falecido,cli_DataFalecido,cli_Inativo,cli_InativoObs,cli_EmprDom,cli_ESocial,cli_EsocialSenha,cli_Parcelamento,cli_NumParcelamento,cli_VIP,cli_VIPDescricao,cli_ITR,cli_NumITR,cli_Mensalista,cli_NomeMensalista,cli_Decore,cli_DecoreDescricao,cli_IRPF,cli_NumIRPF,cli_SenWebPrefeitura,cli_SenhaWebPrefeitura,cli_Redesim,cli_SenhaRedesim,cli_CodRFB,cli_CodRFBNum,cli_CodRFBValidade,cli_DtCadastro

            cliente.cli_CPF = txtCPF.Text
            cliente.cli_Situacao = cboSituacao.Text
            cliente.cli_RG = txtRG.Text
            cliente.cli_Nome = txtNome.Text
            cliente.cli_PIS = txtPIS.Text
            cliente.cli_TitEleitoral = txtTitEleitoral.Text
            cliente.cli_Dia = cmbDia.Text
            cliente.cli_Mes = cmbMes.Text
            cliente.cli_Ano = cmbAno.Text
            cliente.cli_Logradouro = txtLogradouro.Text
            cliente.cli_Numero = txtNumero.Text
            cliente.cli_complemento = txtComplemento.Text
            cliente.cli_Bairro = txtBairro.Text
            cliente.cli_Cidade = txtCidade.Text
            cliente.cli_UF = cboUF.Text
            cliente.cli_CEP = txtCEP.Text
            cliente.cli_FoneRes = txtFoneRes.Text
            cliente.cli_FoneCel = txtFoneCel1.Text
            cliente.cli_FoneCel2 = txtFoneCel2.Text
            cliente.cli_Email = txtEmail.Text
            cliente.cli_observacoes = txtObs.Text
            cliente.cli_Autonomo = chbAutonomo.Checked
            cliente.cli_PJ = chbPJ.Checked
            cliente.cli_MEI = chbMEI.Checked
            cliente.cli_Curriculo = chbCurriculo.Checked
            cliente.cli_Aposentado = chbAposentado.Checked
            cliente.cli_NumBeneficio = txtNumBeneficio.Text
            cliente.cli_FuncPublico = chbFuncPublico.Checked
            cliente.cli_NomeFunc = txtFuncPublico.Text
            cliente.cli_Falecido = chbFalecido.Checked
            cliente.cli_DataFalecido = txtFalecido.Text
            cliente.cli_Inativo = chbInativo.Checked
            cliente.cli_InativoObs = txtInativo.Text
            cliente.cli_EmprDom = chbESocial.Checked
            cliente.cli_ESocial = txtESocial.Text
            cliente.cli_EsocialSenha = txtEsocialSenha.Text
            cliente.cli_Parcelamento = chbParcelamentos.Checked
            cliente.cli_NumParcelamento = txtParcelamentos.Text
            cliente.cli_VIP = chbVIP.Checked
            cliente.cli_VIPDescricao = txtVIP.Text
            cliente.cli_ITR = chbITR.Checked
            cliente.cli_NumITR = txtITR.Text
            cliente.cli_Mensalista = chbMensalista.Checked
            cliente.cli_NomeMensalista = txtMensalista.Text
            cliente.cli_Decore = chbDecore.Checked
            cliente.cli_DecoreDescricao = txtDecore.Text
            cliente.cli_IRPF = chbIRPF.Checked
            cliente.cli_NumIRPF = txtIRPF.Text
            cliente.cli_SenWebPrefeitura = chbSenhaWeb.Checked
            cliente.cli_SenhaWebPrefeitura = txtSenhaWeb.Text
            cliente.cli_Redesim = chbRedesim.Checked
            cliente.cli_SenhaRedesim = txtSenhaRedesim.Text
            cliente.cli_CodRFB = chbCodRFB.Checked
            cliente.cli_CodRFBNum = txtCodRFB.Text
            cliente.cli_CodRFBValidade = txtValidadeRFB.Text
            cliente.cli_DtCadastro = Now.Date


            cliente.GravarDados()

            LimparCampos()

        Catch ex As Exception
            MessageBox.Show("não foi possível fazer o gravar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    'BOTÃO QUE PESQUISA PESSOA FÍSICA
    Private Sub btPesquisarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPesquisarCliente.Click
        Dim frmClienteConsulta As New frmClienteConsulta
        frmClienteConsulta.Text = "Consulta de Cliente"
        frmClienteConsulta.ConsultaTipo = frmClienteConsulta.TipoConsulta.Cliente
        frmClienteConsulta.ShowDialog()

        CodigoCliente = frmClienteConsulta.cli_id
        lblciID.Text = frmClienteConsulta.cli_id
        txtEmprCPF.Text = frmClienteConsulta.cli_CPF
        txtCPFRedesim.Text = frmClienteConsulta.cli_CPF
        lblclienteID.Text = frmClienteConsulta.cli_id
        txtCPF.Text = frmClienteConsulta.cli_CPF
        cboSituacao.Text = frmClienteConsulta.cli_Situacao
        txtRG.Text = frmClienteConsulta.cli_RG
        txtNome.Text = frmClienteConsulta.cli_Nome
        txtPIS.Text = frmClienteConsulta.cli_PIS
        txtTitEleitoral.Text = frmClienteConsulta.cli_TitEleitoral
        cmbDia.Text = frmClienteConsulta.cli_Dia
        cmbMes.Text = frmClienteConsulta.cli_Mes
        cmbAno.Text = frmClienteConsulta.cli_Ano
        txtLogradouro.Text = frmClienteConsulta.cli_Logradouro
        txtNumero.Text = frmClienteConsulta.cli_Numero
        txtComplemento.Text = frmClienteConsulta.cli_complemento
        txtBairro.Text = frmClienteConsulta.cli_Bairro
        txtCidade.Text = frmClienteConsulta.cli_Cidade
        cboUF.Text = frmClienteConsulta.cli_UF
        txtCEP.Text = frmClienteConsulta.cli_CEP
        txtFoneRes.Text = frmClienteConsulta.cli_FoneRes
        txtFoneCel1.Text = frmClienteConsulta.cli_FoneCel
        txtFoneCel2.Text = frmClienteConsulta.cli_FoneCel2
        txtEmail.Text = frmClienteConsulta.cli_Email
        txtObs.Text = frmClienteConsulta.cli_observacoes
        chbAutonomo.Checked = frmClienteConsulta.cli_Autonomo
        chbPJ.Checked = frmClienteConsulta.cli_PJ
        chbMEI.Checked = frmClienteConsulta.cli_MEI
        chbCurriculo.Checked = frmClienteConsulta.cli_Curriculo
        chbAposentado.Checked = frmClienteConsulta.cli_Aposentado
        txtNumBeneficio.Text = frmClienteConsulta.cli_NumBeneficio
        chbFuncPublico.Checked = frmClienteConsulta.cli_FuncPublico
        txtFuncPublico.Text = frmClienteConsulta.cli_NomeFunc
        chbFalecido.Checked = frmClienteConsulta.cli_Falecido
        txtFalecido.Text = frmClienteConsulta.cli_DataFalecido
        chbInativo.Checked = frmClienteConsulta.cli_Inativo
        txtInativo.Text = frmClienteConsulta.cli_InativoObs
        chbESocial.Checked = frmClienteConsulta.cli_EmprDom
        txtESocial.Text = frmClienteConsulta.cli_ESocial
        txtEsocialSenha.Text = frmClienteConsulta.cli_EsocialSenha
        chbParcelamentos.Checked = frmClienteConsulta.cli_Parcelamento
        txtParcelamentos.Text = frmClienteConsulta.cli_NumParcelamento
        chbVIP.Checked = frmClienteConsulta.cli_VIP
        txtVIP.Text = frmClienteConsulta.cli_VIPDescricao
        chbITR.Checked = frmClienteConsulta.cli_ITR
        txtITR.Text = frmClienteConsulta.cli_NumITR
        chbMensalista.Checked = frmClienteConsulta.cli_Mensalista
        txtMensalista.Text = frmClienteConsulta.cli_NomeMensalista
        chbDecore.Checked = frmClienteConsulta.cli_Decore
        txtDecore.Text = frmClienteConsulta.cli_DecoreDescricao
        chbIRPF.Checked = frmClienteConsulta.cli_IRPF
        txtIRPF.Text = frmClienteConsulta.cli_NumIRPF
        chbSenhaWeb.Checked = frmClienteConsulta.cli_SenWebPrefeitura
        txtSenhaWeb.Text = frmClienteConsulta.cli_SenhaWebPrefeitura
        chbRedesim.Checked = frmClienteConsulta.cli_Redesim
        txtSenhaRedesim.Text = frmClienteConsulta.cli_SenhaRedesim
        chbCodRFB.Checked = frmClienteConsulta.cli_CodRFB
        txtCodRFB.Text = frmClienteConsulta.cli_CodRFBNum
        txtValidadeRFB.Text = frmClienteConsulta.cli_CodRFBValidade


    End Sub

    Private Sub btSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    'BOTÃO QUE ALTERA DADOS PESSOA FÍSICA
    Private Sub btAlterarDados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAlterarDados.Click
        If txtCPF.Text.Equals(String.Empty) Then
            errErro.SetError(txtCPF, "Digite um CPF")
            txtCPF.Focus()
            Exit Sub
        Else
            errErro.SetError(txtCPF, "")

        End If
        If txtNome.Text.Equals(String.Empty) Then
            errErro.SetError(txtNome, "Digite um nome")
            Exit Sub
        Else
            errErro.SetError(txtNome, "")
        End If

        Try
            cliente.cli_id = lblciID.Text
            cliente.cli_CPF = txtCPF.Text
            cliente.cli_Situacao = cboSituacao.Text
            cliente.cli_RG = txtRG.Text
            cliente.cli_Nome = txtNome.Text
            cliente.cli_PIS = txtPIS.Text
            cliente.cli_TitEleitoral = txtTitEleitoral.Text
            cliente.cli_Dia = cmbDia.Text
            cliente.cli_Mes = cmbMes.Text
            cliente.cli_Ano = cmbAno.Text
            cliente.cli_Logradouro = txtLogradouro.Text
            cliente.cli_Numero = txtNumero.Text
            cliente.cli_complemento = txtComplemento.Text
            cliente.cli_Bairro = txtBairro.Text
            cliente.cli_Cidade = txtCidade.Text
            cliente.cli_UF = cboUF.Text
            cliente.cli_CEP = txtCEP.Text
            cliente.cli_FoneRes = txtFoneRes.Text
            cliente.cli_FoneCel = txtFoneCel1.Text
            cliente.cli_FoneCel2 = txtFoneCel2.Text
            cliente.cli_Email = txtEmail.Text
            cliente.cli_observacoes = txtObs.Text
            cliente.cli_Autonomo = chbAutonomo.Checked
            cliente.cli_PJ = chbPJ.Checked
            cliente.cli_MEI = chbMEI.Checked
            cliente.cli_Curriculo = chbCurriculo.Checked
            cliente.cli_Aposentado = chbAposentado.Checked
            cliente.cli_NumBeneficio = txtNumBeneficio.Text
            cliente.cli_FuncPublico = chbFuncPublico.Checked
            cliente.cli_NomeFunc = txtFuncPublico.Text
            cliente.cli_Falecido = chbFalecido.Checked
            cliente.cli_DataFalecido = txtFalecido.Text
            cliente.cli_Inativo = chbInativo.Checked
            cliente.cli_InativoObs = txtInativo.Text
            cliente.cli_EmprDom = chbESocial.Checked
            cliente.cli_ESocial = txtESocial.Text
            cliente.cli_EsocialSenha = txtEsocialSenha.Text
            cliente.cli_Parcelamento = chbParcelamentos.Checked
            cliente.cli_NumParcelamento = txtParcelamentos.Text
            cliente.cli_VIP = chbVIP.Checked
            cliente.cli_VIPDescricao = txtVIP.Text
            cliente.cli_ITR = chbITR.Checked
            cliente.cli_NumITR = txtITR.Text
            cliente.cli_Mensalista = chbMensalista.Checked
            cliente.cli_NomeMensalista = txtMensalista.Text
            cliente.cli_Decore = chbDecore.Checked
            cliente.cli_DecoreDescricao = txtDecore.Text
            cliente.cli_IRPF = chbIRPF.Checked
            cliente.cli_NumIRPF = txtIRPF.Text
            cliente.cli_SenWebPrefeitura = chbSenhaWeb.Checked
            cliente.cli_SenhaWebPrefeitura = txtSenhaWeb.Text
            cliente.cli_Redesim = chbRedesim.Checked
            cliente.cli_SenhaRedesim = txtSenhaRedesim.Text
            cliente.cli_CodRFB = chbCodRFB.Checked
            cliente.cli_CodRFBNum = txtCodRFB.Text
            cliente.cli_CodRFBValidade = txtValidadeRFB.Text

            cliente.AlterarDados()
            LimparCampos()

        Catch ex As Exception
            MessageBox.Show("não foi possível fazer o gravar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.Message.ToString)
        End Try

    End Sub






    Private Sub LimparCampos()
        lblciID.Text = ""
        lblidEmpresa.Text = ""
        txtCPF.Text = ""
        cboSituacao.Text = ""
        txtRG.Text = ""
        txtNome.Text = ""
        txtPIS.Text = ""
        txtTitEleitoral.Text = ""
        txtLogradouro.Text = ""
        txtNumero.Text = ""
        txtComplemento.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        cboUF.Text = ""
        txtCEP.Text = ""
        txtFoneRes.Text = ""
        txtFoneCel1.Text = ""
        txtFoneCel2.Text = ""
        cmbDia.Text = ""
        cmbMes.Text = ""
        cmbAno.Text = ""
        chbCurriculo.Checked = False
        txtEmail.Text = ""
        txtObs.Text = ""
        chbAposentado.Checked = False
        txtNumBeneficio.Text = ""
        chbFuncPublico.Checked = False
        ' txtFuncPublico_old.Text = ""
        chbAutonomo.Checked = False
        ' txtAutonomo.Text = ""
        chbFalecido.Checked = False
        txtFalecido.Text = ""
        chbInativo.Checked = False
        txtInativo.Text = ""
        chbParcelamentos.Checked = False
        txtParcelamentos.Text = ""
        chbESocial.Checked = False
        txtESocial.Text = ""
        txtEsocialSenha.Text = ""
        chbVIP.Checked = False
        txtVIP.Text = ""
        chbPJ.Checked = False
        ' txtPJ.Text = ""
        chbMEI.Checked = False
        'txtMEI.Text = ""
        chbITR.Checked = False
        txtITR.Text = ""
        chbMensalista.Checked = False
        txtMensalista.Text = ""
        chbDecore.Checked = False
        txtDecore.Text = ""
        chbIRPF.Checked = False
        txtIRPF.Text = ""
        chbSenhaWeb.Checked = False
        txtSenhaWeb.Text = ""
        chbRedesim.Checked = False
        txtSenhaRedesim.Text = ""
        chbCodRFB.Checked = False
        txtCodRFB.Text = ""
        txtValidadeRFB.Text = ""
        txtRazaoSocial.Text = ""
        txtNomeFantasia.Text = ""
        txtCNPJ.Text = ""
        txtNIRE.Text = ""
        txtInscrEstadual.Text = ""
        txtCCM.Text = ""
        txtAtividade.Text = ""
        txtEmprPorte.Text = ""
        dtpDataInicio.Text = ""
        txtEmprEndereco.Text = ""
        txtEmprNum.Text = ""
        txtEmprComplemento.Text = ""
        txtEmprBairro.Text = ""
        txtEmprCidade.Text = ""
        txtEmprCPF.Text = ""
        cboCliente.Text = ""
        txtEmprUF.Text = ""
        txtEmprCEP.Text = ""
        txtEmprObs.Text = ""
        chbSimples.Checked = False
        cboSituacaoCNPJ.Text = ""
        txtSimplesNacional.Text = ""
        chbSIMEI.Checked = False
        txtEmprSimei.Text = ""
        chbSefaz.Checked = False
        txtSefazUsu.Text = ""
        txtSefazSen.Text = ""
        chbSenhaWebPJ.Checked = False
        txtSenhaWebPJ.Text = ""
        lblclienteID.Text = ""
    End Sub




    Private Sub txtPIS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub txtESocial_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtSenhaWeb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSenhaWeb.KeyPress
        ''Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        ''KeyAscii = CShort(SoNumeros(KeyAscii))
        ''If KeyAscii = 0 Then
        ''    e.Handled = True
        ''    MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ''End If
    End Sub

    Private Sub txtCodRFB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodRFB.KeyPress
        'Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        'KeyAscii = CShort(SoNumeros(KeyAscii))
        'If KeyAscii = 0 Then
        '    e.Handled = True
        '    MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub

    Private Sub txtSimplesNacional_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSimplesNacional.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtSenhaWebPJ_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSenhaWebPJ.KeyPress
        'Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        'KeyAscii = CShort(SoNumeros(KeyAscii))
        'If KeyAscii = 0 Then
        '    e.Handled = True
        '    MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub

    Private Sub txtNIRE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtTitEleitoral_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub chbAposentado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbAposentado.CheckedChanged
        If chbAposentado.Checked = True Then
            ' lblNBeneficio.Visible = True
            txtNumBeneficio.Visible = True

        Else
            ' lblNBeneficio.Visible = False
            txtNumBeneficio.Visible = False

        End If
    End Sub

    Private Sub chbFuncPublico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbFuncPublico.CheckedChanged
        If chbFuncPublico.Checked = True Then
            '  lblFuncPublico.Visible = True
            txtFuncPublico.Visible = True

        Else
            '    lblFuncPublico.Visible = False
            txtFuncPublico.Visible = False

        End If
    End Sub

    Private Sub chbAutonomo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbAutonomo.CheckedChanged

    End Sub

    Private Sub chbFalecido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbFalecido.CheckedChanged
        If chbFalecido.Checked = True Then
            '  lblFalecido.Visible = True
            txtFalecido.Visible = True

        Else
            '   lblFalecido.Visible = False
            txtFalecido.Visible = False

        End If
    End Sub

    Private Sub chbInativo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbInativo.CheckedChanged
        If chbInativo.Checked = True Then
            txtInativo.Visible = True

        Else
            txtInativo.Visible = False

        End If
    End Sub

    Private Sub chbParcelamentos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbParcelamentos.CheckedChanged
        If chbParcelamentos.Checked = True Then
            '  lblParcelamentos.Visible = True
            txtParcelamentos.Visible = True

        Else
            '  lblParcelamentos.Visible = False
            txtParcelamentos.Visible = False

        End If
    End Sub

    Private Sub chbESocial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbESocial.CheckedChanged
        If chbESocial.Checked = True Then
            '  lblESocial.Visible = True
            txtESocial.Visible = True
            txtEsocialSenha.Visible = True
            lblEsocialSenha.Visible = True
        Else
            '   lblESocial.Visible = False
            txtESocial.Visible = False
            txtEsocialSenha.Visible = False
            lblEsocialSenha.Visible = False
        End If
    End Sub

    Private Sub chbVIP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbVIP.CheckedChanged
        If chbVIP.Checked = True Then
            '  lblVIP.Visible = True
            txtVIP.Visible = True

        Else
            '  lblVIP.Visible = False
            txtVIP.Visible = False

        End If
    End Sub

    Private Sub chbPJ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbPJ.CheckedChanged
        If chbPJ.Checked = True Then
            ' lblPJ.Visible = True
            '  txtPJ.Visible = True
            TabEmpresa.Enabled = True
            ' TabControl.SelectedTab = TabPage2

        Else
            ' lblPJ.Visible = False
            'txtPJ.Visible = False
            TabEmpresa.Enabled = False
        End If
    End Sub

    Private Sub chbMEI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbMEI.CheckedChanged
        If chbMEI.Checked = True Then
            ' lblMEI.Visible = True
            TabEmpresa.Enabled = True
            ' txtMEI.Visible = True

        Else
            '   lblMEI.Visible = False
            ' txtMEI.Visible = False
            TabEmpresa.Enabled = False
        End If
    End Sub

    Private Sub chbITR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbITR.CheckedChanged
        If chbITR.Checked = True Then
            ' lblITR.Visible = True
            txtITR.Visible = True

        Else
            '   lblITR.Visible = False
            txtITR.Visible = False

        End If
    End Sub

    Private Sub chbMensalista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbMensalista.CheckedChanged
        If chbMensalista.Checked = True Then
            '   lblMensalista.Visible = True
            txtMensalista.Visible = True

        Else
            '   lblMensalista.Visible = False
            txtMensalista.Visible = False

        End If
    End Sub

    Private Sub chbDecore_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbDecore.CheckedChanged
        If chbDecore.Checked = True Then
            '     lblDecore.Visible = True
            txtDecore.Visible = True

        Else
            '   lblDecore.Visible = False
            txtDecore.Visible = False

        End If
    End Sub

    Private Sub chbIRPF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbIRPF.CheckedChanged
        If chbIRPF.Checked = True Then
            '  lblIRPF.Visible = True
            txtIRPF.Visible = True

        Else
            ' lblIRPF.Visible = False
            txtIRPF.Visible = False

        End If
    End Sub

    Private Sub chbSenhaWeb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbSenhaWeb.CheckedChanged
        If chbSenhaWeb.Checked = True Then
            'lblSenhaWeb.Visible = True
            txtSenhaWeb.Visible = True

        Else
            ' lblSenhaWeb.Visible = False
            txtSenhaWeb.Visible = False

        End If
    End Sub

    Private Sub chbRedesim_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbRedesim.CheckedChanged
        If chbRedesim.Checked = True Then
            lblSenhaRedesim.Visible = True
            txtSenhaRedesim.Visible = True
            txtCPFRedesim.Visible = True
            ' lblcpfRedesim.Visible = True
        Else
            lblSenhaRedesim.Visible = False
            txtSenhaRedesim.Visible = False
            txtCPFRedesim.Visible = False
            ' lblcpfRedesim.Visible = False
        End If
    End Sub

    Private Sub chbCodRFB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbCodRFB.CheckedChanged
        If chbCodRFB.Checked = True Then
            txtCodRFB.Visible = True
            lblValidoRFB.Visible = True
            txtValidadeRFB.Visible = True

        Else
            txtCodRFB.Visible = False
            lblValidoRFB.Visible = False
            txtValidadeRFB.Visible = False

        End If
    End Sub

    Private Sub chbSimples_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbSimples.CheckedChanged
        If chbSimples.Checked = True Then
            txtSimplesNacional.Visible = True
        Else
            txtSimplesNacional.Visible = False
        End If
    End Sub

    Private Sub chbSIMEI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbSIMEI.CheckedChanged
        If chbSIMEI.Checked = True Then
            txtEmprSimei.Visible = True
        Else
            txtEmprSimei.Visible = False
        End If
    End Sub

    Private Sub chbSefaz_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbSefaz.CheckedChanged
        If chbSefaz.Checked = True Then
            ' lblUsuario.Visible = True
            ' lblSenhaSefaz.Visible = True
            txtSefazUsu.Visible = True
            txtSefazSen.Visible = True
        Else
            ' lblUsuario.Visible = False
            ' lblSenhaSefaz.Visible = False
            txtSefazUsu.Visible = False
            txtSefazSen.Visible = False
        End If
    End Sub

    Private Sub chbSenhaWebPJ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbSenhaWebPJ.CheckedChanged
        If chbSenhaWebPJ.Checked = True Then
            ' lblSenhaWebPJ.Visible = True
            '  lblSenhaPJValidade.Visible = True
            txtSenhaWebPJ.Visible = True
            txtSenhaPJValidade.Visible = True
        Else
            ' lblSenhaWebPJ.Visible = False
            ' lblSenhaPJValidade.Visible = False
            txtSenhaWebPJ.Visible = False
            txtSenhaPJValidade.Visible = False
        End If
    End Sub
End Class