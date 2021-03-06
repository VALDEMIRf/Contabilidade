﻿Public Class frmClienteConsulta

    Dim ds As New DataSet
    Dim objClientes As New clsCliente

    Private Sub frmClienteConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaGridNome()
    End Sub


    Public Enum TipoConsulta
        Cliente
        '  Empresa
    End Enum

    Private Sub CarregaGridNome()
        Try

            ds = objClientes.consultarClientesCPF()
            dgvGrid.DataSource = ds.Tables(0)
            '  formataGrid()

        Catch ex As Exception
            MsgBox("Erro ao consultar clientes no Banco de Dados !" & ex.Message.ToString, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub


    Private Sub CarregaGrid()
        Dim dsConsulta As New Data.DataSet
        Select Case _ConsultaTipo
            Case TipoConsulta.Cliente
                Dim clnCliente As New clsCliente
                dsConsulta = clnCliente.ListarCliente(txtCPFPesquisa.Text)

        End Select
        dgvGrid.DataSource = dsConsulta.Tables(0)
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

    Private _cli_id As Integer
    Public Property cli_id() As Integer
        Get
            Return _cli_id
        End Get
        Set(ByVal value As Integer)
            _cli_id = value
        End Set
    End Property


    Private _vinc_id As Integer
    Public Property vinc_id() As Integer
        Get
            Return _vinc_id
        End Get
        Set(ByVal value As Integer)
            _vinc_id = value
        End Set
    End Property

    Private _cli_CPF As String
    Public Property cli_CPF() As String
        Get
            Return _cli_CPF
        End Get
        Set(ByVal value As String)
            _cli_CPF = value
        End Set
    End Property

    Private _cli_Situacao As String
    Public Property cli_Situacao() As String
        Get
            Return _cli_Situacao
        End Get
        Set(ByVal value As String)
            _cli_Situacao = value
        End Set
    End Property

    Private _cli_UF As String
    Public Property cli_UF() As String
        Get
            Return _cli_UF
        End Get
        Set(ByVal value As String)
            _cli_UF = value
        End Set
    End Property

    Private _cli_Nome As String
    Public Property cli_Nome() As String
        Get
            Return _cli_Nome
        End Get
        Set(ByVal value As String)
            _cli_Nome = value
        End Set
    End Property

    Private _cli_RG As String
    Public Property cli_RG() As String
        Get
            Return _cli_RG
        End Get
        Set(ByVal value As String)
            _cli_RG = value
        End Set
    End Property

    Private _cli_PIS As String
    Public Property cli_PIS() As String
        Get
            Return _cli_PIS
        End Get
        Set(ByVal value As String)
            _cli_PIS = value
        End Set
    End Property

    Private _cli_TitEleitoral As String
    Public Property cli_TitEleitoral() As String
        Get
            Return _cli_TitEleitoral
        End Get
        Set(ByVal value As String)
            _cli_TitEleitoral = value
        End Set
    End Property

    Private _cli_Logradouro As String
    Public Property cli_Logradouro() As String
        Get
            Return _cli_Logradouro
        End Get
        Set(ByVal value As String)
            _cli_Logradouro = value
        End Set
    End Property

    Private _cli_Numero As String
    Public Property cli_Numero() As String
        Get
            Return _cli_Numero
        End Get
        Set(ByVal value As String)
            _cli_Numero = value
        End Set
    End Property

    Private _cli_complemento As String
    Public Property cli_complemento() As String
        Get
            Return _cli_complemento
        End Get
        Set(ByVal value As String)
            _cli_complemento = value
        End Set
    End Property

    Private _cli_Bairro As String
    Public Property cli_Bairro() As String
        Get
            Return _cli_Bairro
        End Get
        Set(ByVal value As String)
            _cli_Bairro = value
        End Set
    End Property

    Private _cli_Cidade As String
    Public Property cli_Cidade() As String
        Get
            Return _cli_Cidade
        End Get
        Set(ByVal value As String)
            _cli_Cidade = value
        End Set
    End Property

    Private _cli_CEP As String
    Public Property cli_CEP() As String
        Get
            Return _cli_CEP
        End Get
        Set(ByVal value As String)
            _cli_CEP = value
        End Set
    End Property

    Private _cli_FoneRes As String
    Public Property cli_FoneRes() As String
        Get
            Return _cli_FoneRes
        End Get
        Set(ByVal value As String)
            _cli_FoneRes = value
        End Set
    End Property

    Private _cli_FoneCel As String
    Public Property cli_FoneCel() As String
        Get
            Return _cli_FoneCel
        End Get
        Set(ByVal value As String)
            _cli_FoneCel = value
        End Set
    End Property

    Private _cli_FoneCel2 As String
    Public Property cli_FoneCel2() As String
        Get
            Return _cli_FoneCel2
        End Get
        Set(ByVal value As String)
            _cli_FoneCel2 = value
        End Set
    End Property


    Private _cli_data_nasc As String
    Public Property cli_data_nasc() As String
        Get
            Return _cli_data_nasc
        End Get
        Set(ByVal value As String)
            _cli_data_nasc = value
        End Set
    End Property

    Private _cli_Dia As String
    Public Property cli_Dia() As String
        Get
            Return _cli_Dia
        End Get
        Set(ByVal value As String)
            _cli_Dia = value
        End Set
    End Property

    Private _cli_Mes As String
    Public Property cli_Mes() As String
        Get
            Return _cli_Mes
        End Get
        Set(ByVal value As String)
            _cli_Mes = value
        End Set
    End Property

    Private _cli_Ano As String
    Public Property cli_Ano() As String
        Get
            Return _cli_Ano
        End Get
        Set(ByVal value As String)
            _cli_Ano = value
        End Set
    End Property

    Private _cli_Email As String
    Public Property cli_Email() As String
        Get
            Return _cli_Email
        End Get
        Set(ByVal value As String)
            _cli_Email = value
        End Set
    End Property

    Private _cli_Curriculo As Boolean
    Public Property cli_Curriculo() As Boolean
        Get
            Return _cli_Curriculo
        End Get
        Set(ByVal value As Boolean)
            _cli_Curriculo = value
        End Set
    End Property

    Private _clsCPFVinculado As clsCPFVinculado
    Public Property clnCPFVinculado() As clsCPFVinculado
        Get
            Return _clsCPFVinculado
        End Get
        Set(ByVal value As clsCPFVinculado)
            _clsCPFVinculado = value
        End Set
    End Property

    Private _cli_CPFVinculado As String
    Public Property cli_CPFVinculado() As String
        Get
            Return _cli_CPFVinculado
        End Get
        Set(ByVal value As String)
            _cli_CPFVinculado = value
        End Set
    End Property

    Private _cli_TipoVinculacao As String
    Public Property cli_TipoVinculacao() As String
        Get
            Return _cli_TipoVinculacao
        End Get
        Set(ByVal value As String)
            _cli_TipoVinculacao = value
        End Set
    End Property

    Private _cli_observacoes As String
    Public Property cli_observacoes() As String
        Get
            Return _cli_observacoes
        End Get
        Set(ByVal value As String)
            _cli_observacoes = value
        End Set
    End Property

    Private _cli_Aposentado As Boolean
    Public Property cli_Aposentado() As Boolean
        Get
            Return _cli_Aposentado
        End Get
        Set(ByVal value As Boolean)
            _cli_Aposentado = value
        End Set
    End Property

    Private _cli_NumBeneficio As String
    Public Property cli_NumBeneficio() As String
        Get
            Return _cli_NumBeneficio
        End Get
        Set(ByVal value As String)
            _cli_NumBeneficio = value
        End Set
    End Property

    Private _cli_FuncPublico As Boolean
    Public Property cli_FuncPublico() As Boolean
        Get
            Return _cli_FuncPublico
        End Get
        Set(ByVal value As Boolean)
            _cli_FuncPublico = value
        End Set
    End Property

    Private _cli_NomeFunc As String
    Public Property cli_NomeFunc() As String
        Get
            Return _cli_NomeFunc
        End Get
        Set(ByVal value As String)
            _cli_NomeFunc = value
        End Set
    End Property

    Private _cli_Autonomo As Boolean
    Public Property cli_Autonomo() As Boolean
        Get
            Return _cli_Autonomo
        End Get
        Set(ByVal value As Boolean)
            _cli_Autonomo = value
        End Set
    End Property

    Private _cli_AutonomoNome As String
    Public Property cli_AutonomoNome() As String
        Get
            Return _cli_AutonomoNome
        End Get
        Set(ByVal value As String)
            _cli_AutonomoNome = value
        End Set
    End Property

    Private _cli_Falecido As Boolean
    Public Property cli_Falecido() As Boolean
        Get
            Return _cli_Falecido
        End Get
        Set(ByVal value As Boolean)
            _cli_Falecido = value
        End Set
    End Property

    Private _cli_DataFalecido As String
    Public Property cli_DataFalecido() As String
        Get
            Return _cli_DataFalecido
        End Get
        Set(ByVal value As String)
            _cli_DataFalecido = value
        End Set
    End Property

    Private _cli_Inativo As Boolean
    Public Property cli_Inativo() As Boolean
        Get
            Return _cli_Inativo
        End Get
        Set(ByVal value As Boolean)
            _cli_Inativo = value
        End Set
    End Property

    Private _cli_InativoObs As String
    Public Property cli_InativoObs() As String
        Get
            Return _cli_InativoObs
        End Get
        Set(ByVal value As String)
            _cli_InativoObs = value
        End Set
    End Property

    Private _cli_Parcelamento As Boolean
    Public Property cli_Parcelamento() As Boolean
        Get
            Return _cli_Parcelamento
        End Get
        Set(ByVal value As Boolean)
            _cli_Parcelamento = value
        End Set
    End Property

    Private _cli_NumParcelamento As String
    Public Property cli_NumParcelamento() As String
        Get
            Return _cli_NumParcelamento
        End Get
        Set(ByVal value As String)
            _cli_NumParcelamento = value
        End Set
    End Property

    Private _cli_EmprDom As Boolean
    Public Property cli_EmprDom() As Boolean
        Get
            Return _cli_EmprDom
        End Get
        Set(ByVal value As Boolean)
            _cli_EmprDom = value
        End Set
    End Property

    Private _cli_ESocial As String
    Public Property cli_ESocial() As String
        Get
            Return _cli_ESocial
        End Get
        Set(ByVal value As String)
            _cli_ESocial = value
        End Set
    End Property

    Private _cli_EsocialSenha As String
    Public Property cli_EsocialSenha() As String
        Get
            Return _cli_EsocialSenha
        End Get
        Set(ByVal value As String)
            _cli_EsocialSenha = value
        End Set
    End Property

    Private _cli_VIP As Boolean
    Public Property cli_VIP() As Boolean
        Get
            Return _cli_VIP
        End Get
        Set(ByVal value As Boolean)
            _cli_VIP = value
        End Set
    End Property

    Private _cli_VIPDescricao As String
    Public Property cli_VIPDescricao() As String
        Get
            Return _cli_VIPDescricao
        End Get
        Set(ByVal value As String)
            _cli_VIPDescricao = value
        End Set
    End Property

    Private _cli_PJ As Boolean
    Public Property cli_PJ() As Boolean
        Get
            Return _cli_PJ
        End Get
        Set(ByVal value As Boolean)
            _cli_PJ = value
        End Set
    End Property

    Private _cli_NumPJ As String
    Public Property cli_NumPJ() As String
        Get
            Return _cli_NumPJ
        End Get
        Set(ByVal value As String)
            _cli_NumPJ = value
        End Set
    End Property

    Private _cli_MEI As Boolean
    Public Property cli_MEI() As Boolean
        Get
            Return _cli_MEI
        End Get
        Set(ByVal value As Boolean)
            _cli_MEI = value
        End Set
    End Property

    Private _cli_NumMEI As String
    Public Property cli_NumMEI() As String
        Get
            Return _cli_NumMEI
        End Get
        Set(ByVal value As String)
            _cli_NumMEI = value
        End Set
    End Property

    Private _cli_ITR As Boolean
    Public Property cli_ITR() As Boolean
        Get
            Return _cli_ITR
        End Get
        Set(ByVal value As Boolean)
            _cli_ITR = value
        End Set
    End Property

    Private _cli_NumITR As String
    Public Property cli_NumITR() As String
        Get
            Return _cli_NumITR
        End Get
        Set(ByVal value As String)
            _cli_NumITR = value
        End Set
    End Property

    Private _cli_Mensalista As Boolean
    Public Property cli_Mensalista() As Boolean
        Get
            Return _cli_Mensalista
        End Get
        Set(ByVal value As Boolean)
            _cli_Mensalista = value
        End Set
    End Property

    Private _cli_NomeMensalista As String
    Public Property cli_NomeMensalista() As String
        Get
            Return _cli_NomeMensalista
        End Get
        Set(ByVal value As String)
            _cli_NomeMensalista = value
        End Set
    End Property

    Private _cli_Decore As Boolean
    Public Property cli_Decore() As Boolean
        Get
            Return _cli_Decore
        End Get
        Set(ByVal value As Boolean)
            _cli_Decore = value
        End Set
    End Property

    Private _cli_DecoreDescricao As String
    Public Property cli_DecoreDescricao() As String
        Get
            Return _cli_DecoreDescricao
        End Get
        Set(ByVal value As String)
            _cli_DecoreDescricao = value
        End Set
    End Property

    Private _cli_IRPF As Boolean
    Public Property cli_IRPF() As Boolean
        Get
            Return _cli_IRPF
        End Get
        Set(ByVal value As Boolean)
            _cli_IRPF = value
        End Set
    End Property

    Private _cli_NumIRPF As String
    Public Property cli_NumIRPF() As String
        Get
            Return _cli_NumIRPF
        End Get
        Set(ByVal value As String)
            _cli_NumIRPF = value
        End Set
    End Property

    Private _cli_SenWebPrefeitura As Boolean
    Public Property cli_SenWebPrefeitura() As Boolean
        Get
            Return _cli_SenWebPrefeitura
        End Get
        Set(ByVal value As Boolean)
            _cli_SenWebPrefeitura = value
        End Set
    End Property

    Private _cli_SenhaWebPrefeitura As String
    Public Property cli_SenhaWebPrefeitura() As String
        Get
            Return _cli_SenhaWebPrefeitura
        End Get
        Set(ByVal value As String)
            _cli_SenhaWebPrefeitura = value
        End Set
    End Property

    Private _cli_Redesim As Boolean
    Public Property cli_Redesim() As Boolean
        Get
            Return _cli_Redesim
        End Get
        Set(ByVal value As Boolean)
            _cli_Redesim = value
        End Set
    End Property

    Private _cli_SenhaRedesim As String
    Public Property cli_SenhaRedesim() As String
        Get
            Return _cli_SenhaRedesim
        End Get
        Set(ByVal value As String)
            _cli_SenhaRedesim = value
        End Set
    End Property

    Private _cli_CodRFB As Boolean
    Public Property cli_CodRFB() As Boolean
        Get
            Return _cli_CodRFB
        End Get
        Set(ByVal value As Boolean)
            _cli_CodRFB = value
        End Set
    End Property

    Private _cli_CodRFBNum As String
    Public Property cli_CodRFBNum() As String
        Get
            Return _cli_CodRFBNum
        End Get
        Set(ByVal value As String)
            _cli_CodRFBNum = value
        End Set
    End Property

    Private _cli_CodRFBValidade As String
    Public Property cli_CodRFBValidade() As String
        Get
            Return _cli_CodRFBValidade
        End Get
        Set(ByVal value As String)
            _cli_CodRFBValidade = value
        End Set
    End Property


    Public Sub formataGrid()
        With dgvGrid
            .Columns(0).HeaderText = "Código"
            .Columns(1).HeaderText = "CPF"
            .Columns(2).HeaderText = "Situação"
            .Columns(3).HeaderText = "RG"
            .Columns(4).HeaderText = "Nome"
            .Columns(5).HeaderText = "PIS"
            .Columns(6).HeaderText = "Tit. Eleitoral"
            .Columns(7).HeaderText = "Dia Nasc"
            .Columns(8).HeaderText = "Mês Nasc"
            .Columns(9).HeaderText = "Ano Nasc"
            .Columns(10).HeaderText = "Endereco"
            .Columns(11).HeaderText = "Nº"
            .Columns(12).HeaderText = "Complemento"
            .Columns(13).HeaderText = "Bairro"
            .Columns(14).HeaderText = "Cidade"
            .Columns(15).HeaderText = "UF"
            .Columns(16).HeaderText = "CEP"
            .Columns(17).HeaderText = "Fone Res"
            .Columns(18).HeaderText = "Celular"
            .Columns(19).HeaderText = "Celular 2"
            .Columns(20).HeaderText = "Email"
            .Columns(21).HeaderText = "Obs"
            .Columns(22).HeaderText = "Autonomo"
            .Columns(23).HeaderText = "PJ"
            .Columns(24).HeaderText = "MEI"
            .Columns(25).HeaderText = "Curriculo"
            .Columns(26).HeaderText = "Aposentado"
            .Columns(27).HeaderText = "Benefício"
            .Columns(28).HeaderText = "Func. Público"
            .Columns(29).HeaderText = "Nome Func"
            .Columns(30).HeaderText = "Falecido"
            .Columns(31).HeaderText = "Data Falecimento"
            .Columns(32).HeaderText = "Inativo"
            .Columns(33).HeaderText = "Inativo Obs"
            .Columns(34).HeaderText = "Empr Domestico"
            .Columns(35).HeaderText = "N° ESocial"
            .Columns(36).HeaderText = "Senha ESocial"
            .Columns(37).HeaderText = "Parcelamento"
            .Columns(38).HeaderText = "Numero"
            .Columns(39).HeaderText = "VIP"
            .Columns(40).HeaderText = "Descrição"
            .Columns(41).HeaderText = "ITR"
            .Columns(42).HeaderText = "Numero"
            .Columns(43).HeaderText = "Mensalista"
            .Columns(44).HeaderText = "Nome"
            .Columns(45).HeaderText = "Decore"
            .Columns(46).HeaderText = "Descrição"
            .Columns(47).HeaderText = "IRPF"
            .Columns(48).HeaderText = "Numero"
            .Columns(49).HeaderText = "Senha Web"
            .Columns(50).HeaderText = "Nº Senha Web"
            .Columns(51).HeaderText = "Redesim"
            .Columns(52).HeaderText = "Senha"
            .Columns(53).HeaderText = "Cod RFB"
            .Columns(54).HeaderText = "RFB Num°"
            .Columns(55).HeaderText = "Validade"
            .Columns(56).HeaderText = "Cadastro"



        End With
    End Sub



    '  BOTÃO QUE CARREGA OS DADOS DA PESQUISA PESSOA FÍSICA
    Private Sub btPesquisaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPesquisaCliente.Click
        CarregaGrid()
    End Sub

    'BOTÃO QUE ENVIA DADOS PARA O FORMULARIO PESSOA FÍSICA
    Private Sub btEnviarDados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnviarDados.Click
        dadosEnviados()
    End Sub

    Private Sub dgvGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvGrid.DoubleClick
        dadosEnviados()
    End Sub


    'METODO DE DUPLO CLICK QUE ENVIA DADOS PARA O FORMULARIO PESSOA FÍSICA
    Private Sub dadosEnviados()
        Select Case _ConsultaTipo
            Case TipoConsulta.Cliente

                If dgvGrid.RowCount <> 0 Then
                    _cli_id = dgvGrid.CurrentRow.Cells(0).Value
                    _cli_CPF = dgvGrid.CurrentRow.Cells(1).Value
                    _cli_Situacao = dgvGrid.CurrentRow.Cells(2).Value.ToString
                    _cli_RG = dgvGrid.CurrentRow.Cells(3).Value
                    _cli_Nome = dgvGrid.CurrentRow.Cells(4).Value
                    _cli_PIS = dgvGrid.CurrentRow.Cells(5).Value
                    _cli_TitEleitoral = dgvGrid.CurrentRow.Cells(6).Value
                    _cli_Dia = dgvGrid.CurrentRow.Cells(7).Value.ToString
                    _cli_Mes = dgvGrid.CurrentRow.Cells(8).Value.ToString
                    _cli_Ano = dgvGrid.CurrentRow.Cells(9).Value.ToString
                    _cli_Logradouro = dgvGrid.CurrentRow.Cells(10).Value
                    _cli_Numero = dgvGrid.CurrentRow.Cells(11).Value
                    _cli_complemento = dgvGrid.CurrentRow.Cells(12).Value
                    _cli_Bairro = dgvGrid.CurrentRow.Cells(13).Value
                    _cli_Cidade = dgvGrid.CurrentRow.Cells(14).Value
                    _cli_UF = dgvGrid.CurrentRow.Cells(15).Value
                    _cli_CEP = dgvGrid.CurrentRow.Cells(16).Value
                    _cli_FoneRes = dgvGrid.CurrentRow.Cells(17).Value
                    _cli_FoneCel = dgvGrid.CurrentRow.Cells(18).Value.ToString
                    _cli_FoneCel2 = dgvGrid.CurrentRow.Cells(19).Value.ToString
                    _cli_Email = dgvGrid.CurrentRow.Cells(20).Value
                    _cli_observacoes = dgvGrid.CurrentRow.Cells(21).Value
                    _cli_Autonomo = dgvGrid.CurrentRow.Cells(22).Value
                    _cli_PJ = dgvGrid.CurrentRow.Cells(23).Value
                    _cli_MEI = dgvGrid.CurrentRow.Cells(24).Value
                    _cli_Curriculo = dgvGrid.CurrentRow.Cells(25).Value
                    _cli_Aposentado = dgvGrid.CurrentRow.Cells(26).Value
                    _cli_NumBeneficio = dgvGrid.CurrentRow.Cells(27).Value
                    _cli_FuncPublico = dgvGrid.CurrentRow.Cells(28).Value
                    _cli_NomeFunc = dgvGrid.CurrentRow.Cells(29).Value
                    _cli_Falecido = dgvGrid.CurrentRow.Cells(30).Value
                    _cli_DataFalecido = dgvGrid.CurrentRow.Cells(31).Value
                    _cli_Inativo = dgvGrid.CurrentRow.Cells(32).Value
                    _cli_InativoObs = dgvGrid.CurrentRow.Cells(33).Value
                    _cli_EmprDom = dgvGrid.CurrentRow.Cells(34).Value
                    _cli_ESocial = dgvGrid.CurrentRow.Cells(35).Value
                    _cli_EsocialSenha = dgvGrid.CurrentRow.Cells(36).Value
                    _cli_Parcelamento = dgvGrid.CurrentRow.Cells(37).Value
                    _cli_NumParcelamento = dgvGrid.CurrentRow.Cells(38).Value
                    _cli_VIP = dgvGrid.CurrentRow.Cells(39).Value
                    _cli_VIPDescricao = dgvGrid.CurrentRow.Cells(40).Value
                    _cli_ITR = dgvGrid.CurrentRow.Cells(41).Value
                    _cli_NumITR = dgvGrid.CurrentRow.Cells(42).Value
                    _cli_Mensalista = dgvGrid.CurrentRow.Cells(43).Value
                    _cli_NomeMensalista = dgvGrid.CurrentRow.Cells(44).Value
                    _cli_Decore = dgvGrid.CurrentRow.Cells(45).Value
                    _cli_DecoreDescricao = dgvGrid.CurrentRow.Cells(46).Value
                    _cli_IRPF = dgvGrid.CurrentRow.Cells(47).Value
                    _cli_NumIRPF = dgvGrid.CurrentRow.Cells(48).Value
                    _cli_SenWebPrefeitura = dgvGrid.CurrentRow.Cells(49).Value
                    _cli_SenhaWebPrefeitura = dgvGrid.CurrentRow.Cells(50).Value
                    _cli_Redesim = dgvGrid.CurrentRow.Cells(51).Value
                    _cli_SenhaRedesim = dgvGrid.CurrentRow.Cells(52).Value
                    _cli_CodRFB = dgvGrid.CurrentRow.Cells(53).Value
                    _cli_CodRFBNum = dgvGrid.CurrentRow.Cells(54).Value
                    _cli_CodRFBValidade = dgvGrid.CurrentRow.Cells(55).Value
                    ' _vinc_id = dgvGrid.CurrentRow.Cells(56).Value

                    Me.Close()
                End If

        End Select
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub


    Private Sub txtNomePesquisar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomePesquisar.TextChanged
        Try

            objClientes.cli_Nome = txtNomePesquisar.Text
            ds = objClientes.consultarClientesNome()
            dgvGrid.DataSource = ds.Tables(0)
            ' formataGrid()

        Catch ex As Exception
            MessageBox.Show("não foi possível selecionar o Cliente!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.Message.ToString)
        End Try
    End Sub


   
    Private Sub btRecarregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRecarregar.Click
        CarregaGridNome()

    End Sub
End Class