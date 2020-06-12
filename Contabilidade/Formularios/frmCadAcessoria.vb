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

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click
        Dim frmAcessoriaConsulta As New frmAcessoriaConsulta
        frmAcessoriaConsulta.Text = "Consulta de Cliente"
        frmAcessoriaConsulta.ConsultaTipo = frmAcessoriaConsulta.TipoConsulta.Assessoria
        frmAcessoriaConsulta.ShowDialog()

        CodigoEmpresa = frmAcessoriaConsulta.IdAssessoria
        lblAcessoID.Text = frmAcessoriaConsulta.IdAssessoria
        txtEmpresa.Text = frmAcessoriaConsulta.empresa
        txtMes.Text = frmAcessoriaConsulta.mes
        txtAno.Text = frmAcessoriaConsulta.ano
        txtGerente.Text = frmAcessoriaConsulta.gerente
        txtResponsavel.Text = frmAcessoriaConsulta.responsavel
        txtTelefone.Text = frmAcessoriaConsulta.telefone
        chbProlabore.Checked = frmAcessoriaConsulta.PROLABORE
        txtTrezesalario.Text = frmAcessoriaConsulta.SALARIOTREZE
        chbFolha.Checked = frmAcessoriaConsulta.FOLHA
        chbDARF.Checked = frmAcessoriaConsulta.DARF
        chbGRRF.Checked = frmAcessoriaConsulta.GRRF
        chbSefip.Checked = frmAcessoriaConsulta.SEFIP
        chbGPS.Checked = frmAcessoriaConsulta.GPS
        chbGRF.Checked = frmAcessoriaConsulta.GRF
        chbDAS.Checked = frmAcessoriaConsulta.DAS
        chbDASZERO.Checked = frmAcessoriaConsulta.DASZERADO
        chbDASN.Checked = frmAcessoriaConsulta.DASN
        chbDEFIS.Checked = frmAcessoriaConsulta.DEFIS
        chbIRRF.Checked = frmAcessoriaConsulta.IRRF
        chbDCTF.Checked = frmAcessoriaConsulta.DCTF
        chbRAIS.Checked = frmAcessoriaConsulta.RAIS
        chbRAISNEGATIVA.Checked = frmAcessoriaConsulta.RAISNEGATIVA
        chbECF.Checked = frmAcessoriaConsulta.ECF
        chbEFD.Checked = frmAcessoriaConsulta.EFD
        chbGIA.Checked = frmAcessoriaConsulta.GIA
        chbCAGED.Checked = frmAcessoriaConsulta.CAGED
        txtObs.Text = frmAcessoriaConsulta.obs

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

    Private Sub btAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAlterar.Click
        Try
            assessoria.IdAssessoria = lblAcessoID.Text
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

            assessoria.AlterarDados()

            LimparCampos()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class