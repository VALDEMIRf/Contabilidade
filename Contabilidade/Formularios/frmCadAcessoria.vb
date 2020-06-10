Imports System.Data.OleDb
Imports System.Data

Public Class frmCadAcessoria
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao
    Dim CodigoEmpresa As Integer
    Dim assessoria As New clsAcessoria
    Dim i As Integer = 0

    Private Sub frmCadAcessoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtEmpresa.Focus()

    End Sub


    Private Sub btSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSair.Click
        Me.Close()

    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        If txtEmpresa.Text.Equals(String.Empty) Then
            errErro.SetError(txtEmpresa, "Digite o nome da Empresa")
            txtEmpresa.Focus()
            Exit Sub
        Else
            errErro.SetError(txtEmpresa, "")

        End If
        If txtMes.Text.Equals(String.Empty) Then
            errErro.SetError(txtMes, "Digite o Mês")
            Exit Sub
        Else
            errErro.SetError(txtMes, "")
        End If
        If txtAno.Text.Equals(String.Empty) Then
            errErro.SetError(txtAno, "Digite o Ano")
            Exit Sub
        Else
            errErro.SetError(txtAno, "")
        End If

        Try
            assessoria.empresa = txtEmpresa.Text
            assessoria.mes = txtMes.Text
            assessoria.ano = txtAno.Text
            assessoria.gerente = txtGerente.Text
            assessoria.responsavel = txtResponsavel.Text
            assessoria.telefone = txtTelefone.Text
            assessoria.PROLABORE = chbProlabore.Checked
            assessoria.SALARIOTREZE = txtTrezesalario.Text
            assessoria.FOLHA = chbFolha.Checked
            assessoria.DARF = chbDARF.Checked
            assessoria.GRRF = chbGRRF.Checked
            assessoria.SEFIP = chbSefip.Checked
            assessoria.GPS = chbGPS.Checked
            assessoria.GRF = chbGRF.Checked
            assessoria.DAS = chbDAS.Checked
            assessoria.DASZERADO = chbDASZERO.Checked
            assessoria.DASN = chbDASN.Checked
            assessoria.DEFIS = chbDEFIS.Checked
            assessoria.IRRF = chbIRRF.Checked
            assessoria.DCTF = chbDCTF.Checked
            assessoria.RAIS = chbRAIS.Checked
            assessoria.RAISNEGATIVA = chbRAISNEGATIVA.Checked
            assessoria.ECF = chbECF.Checked
            assessoria.EFD = chbEFD.Checked
            assessoria.GIA = chbGIA.Checked
            assessoria.CAGED = chbCAGED.Checked
            assessoria.obs = txtObs.Text

            assessoria.GravarDados()

            LimparCampos()

        Catch ex As Exception
            'MessageBox.Show("não foi possível fazer o gravar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub LimparCampos()

        txtEmpresa.Text = ""
        txtGerente.Text = ""
        txtResponsavel.Text = ""
        txtTelefone.Text = ""
        txtMes.Text = ""
        txtAno.Text = ""
        chbProlabore.Checked = False
        txtTrezesalario.Text = ""
        chbFolha.Checked = False
        chbDARF.Checked = False
        chbGRRF.Checked = False
        chbSefip.Checked = False
        chbGPS.Checked = False
        chbGRF.Checked = False
        chbDAS.Checked = False
        chbDASZERO.Checked = False
        chbDASN.Checked = False
        chbIRRF.Checked = False
        chbDEFIS.Checked = False
        chbDCTF.Checked = False
        chbRAIS.Checked = False
        chbRAISNEGATIVA.Checked = False
        chbECF.Checked = False
        chbEFD.Checked = False
        chbGIA.Checked = False
        chbCAGED.Checked = False
        txtObs.Text = ""
    End Sub

End Class