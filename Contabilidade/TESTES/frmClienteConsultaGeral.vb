Imports System.Data.OleDb
Public Class frmClienteConsultaGeral
    
    Private Sub frmClienteConsultaGeral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaGrid()


    End Sub

    Private Sub carregaGrid()
        'Dim strQuery As New StringBuilder
        'strQuery.Append(" SELECT c.cli_id as codigo,c.cli_CPF as CPF,c.cli_Situacao as Situacao,c.cli_RG as RG,c.cli_Nome as Nome,c.cli_PIS,c.cli_TitEleitoral,c.cli_Logradouro,c.cli_Numero,c.cli_complemento,c.cli_Bairro,c.cli_Cidade,c.cli_UF,c.cli_CEP,c.cli_FoneRes,c.cli_FoneCel,c.cli_Dia,c.cli_Mes,c.cli_Ano,c.cli_Curriculo,c.cli_Email,c.cli_observacoes,c.cli_Aposentado,c.cli_NumBeneficio,c.cli_FuncPublico,c.cli_NomeFunc,c.cli_Autonomo,c.cli_AutonomoNome,c.cli_Falecido,c.cli_NomeFalecido,c.cli_Inativo,c.cli_InativoObs,c.cli_Parcelamento,c.cli_NumParcelamento,c.cli_EmprDom,c.cli_ESocial,c.cli_EsocialSenha,c.cli_VIP,c.cli_VIPDescricao,c.cli_PJ,c.cli_NumPJ,c.cli_MEI,c.cli_NumMEI,c.cli_ITR,c.cli_NumITR,c.cli_Mensalista,c.cli_NomeMensalista,c.cli_Decore,c.cli_DecoreDescricao,c.cli_IRPF,c.cli_NumIRPF,c.cli_SenWebPrefeitura,c.cli_SenhaWebPrefeitura,c.cli_Redesim,c.cli_SenhaRedesim,c.cli_CodRFB,c.cli_CodRFBNum,c.cli_CodRFBValidade,e.empr_ID,e.empr_razaosocial as Empresa,e.empr_nomefantasia,e.empr_cnpj as CNPJ,e.empr_Situacaocnpj,e.empr_NIRE,e.empr_InscrEstadual,e.empr_CCM,e.empr_atividade,e.empr_Porte,e.cli_id,e.cat_Id,e.empr_dataInicio,e.empr_endereco,e.empr_numero,e.empr_complemento,e.empr_bairro,e.empr_cidade,e.empr_UF,e.empr_CEP,e.empr_obs,e.empr_Simples,e.empr_SimplesNacional,e.empr_Simei,e.empr_CodSimei,e.empr_sefaz,e.empr_SefazUsu,e.empr_SefazSen,e.empr_CodReceitaPJ,e.empr_NumCodReceitaPJ ")
        'strQuery.Append(" FROM tbClientes as c INNER JOIN tbEmpresas as e ")
        'strQuery.Append(" ON c.cli_id = e.cli_id")
        'If Not strDescricao.Equals(String.Empty) Then
        '    strQuery.Append(" WHERE c.cli_CPF like '%" & strDescricao & "%'")
        'End If
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String
                sql = "SELECT c.cli_id,c.cli_CPF,c.cli_Situacao,c.cli_RG,c.cli_Nome,c.cli_PIS,c.cli_TitEleitoral,c.cli_Dia,"
                sql += "c.cli_Mes,c.cli_Ano,c.cli_Logradouro,c.cli_Numero,c.cli_complemento,c.cli_Bairro,c.cli_Cidade,"
                sql += "c.cli_UF,c.cli_CEP,c.cli_FoneRes,c.cli_FoneCel,c.cli_FoneCel2,c.cli_Email,c.cli_observacoes,"
                sql += "c.cli_Autonomo,c.cli_PJ,c.cli_MEI,c.cli_Curriculo,c.cli_Aposentado,c.cli_NumBeneficio,"
                sql += "c.cli_FuncPublico,c.cli_NivelFunc,c.cli_Falecido,c.cli_DataFalecido,c.cli_Inativo,c.cli_InativoObs,"
                sql += "c.cli_EmprDom,c.cli_ESocial,c.cli_EsocialSenha,c.cli_Parcelamento,c.cli_NumParcelamento,c.cli_VIP,"
                sql += "c.cli_VIPDescricao,c.cli_ITR,c.cli_NumITR,c.cli_Mensalista,c.cli_NomeMensalista,c.cli_Decore,"
                sql += "c.cli_DecoreDescricao,c.cli_IRPF,c.cli_NumIRPF,c.cli_SenWebPrefeitura,c.cli_SenhaWebPrefeitura,"
                sql += "c.cli_Redesim,c.cli_SenhaRedesim,c.cli_CodRFB,c.cli_CodRFBNum,c.cli_CodRFBValidade, "
                sql += "e.empr_ID,e.empr_razaosocial,e.empr_nomefantasia,e.empr_cnpj,e.empr_Situacaocnpj,"
                sql += "e.empr_InscrEstadual,e.empr_NIRE,e.empr_CCM,e.empr_Porte,e.empr_atividade,e.empr_dataInicio,"
                sql += "e.cli_id,e.cat_Id,e.empr_TelCel1,e.empr_TelCel2,e.empr_endereco,e.empr_numero,e.empr_complemento,"
                sql += "e.empr_bairro,e.empr_cidade,e.empr_UF,e.empr_CEP,e.empr_obs,e.empr_Simples,e.empr_SimplesNacional,"
                sql += "e.empr_Simei,e.empr_CodSimei,e.empr_sefaz,e.empr_SefazUsu,e.empr_SefazSen,e.empr_CodReceitaPJ,"
                sql += "e.empr_SenhaCodReceitaPJ,e.empr_ValReceitaPJ"
                sql += " FROM tbClientes as c,tbEmpresas as e "
                ' sql += "FROM tbClientes as c ORDER BY e.cli_id ASC"


                'sql += "e.empr_ID as codEmpresa,e.cli_id,e.cat_Id  FROM tbClientes as c, tbEmpresas as e WHERE c.cli_id = e.cli_id"

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