<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadAcessoria
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadAcessoria))
        Me.errErro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblAcessoID = New System.Windows.Forms.Label()
        Me.gbEmpresa = New System.Windows.Forms.GroupBox()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtResponsavel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGerente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btAlterar = New System.Windows.Forms.Button()
        Me.btRegistroAnterior = New System.Windows.Forms.Button()
        Me.btProximoRegistro = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chbGRF = New System.Windows.Forms.CheckBox()
        Me.chbProlabore = New System.Windows.Forms.CheckBox()
        Me.chbFolha = New System.Windows.Forms.CheckBox()
        Me.chbDARF = New System.Windows.Forms.CheckBox()
        Me.chbGRRF = New System.Windows.Forms.CheckBox()
        Me.chbSefip = New System.Windows.Forms.CheckBox()
        Me.chbGPS = New System.Windows.Forms.CheckBox()
        Me.txtTrezesalario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chbECF = New System.Windows.Forms.CheckBox()
        Me.GBsIMPLES = New System.Windows.Forms.GroupBox()
        Me.chbDEFIS = New System.Windows.Forms.CheckBox()
        Me.chbDASZERO = New System.Windows.Forms.CheckBox()
        Me.chbDASN = New System.Windows.Forms.CheckBox()
        Me.chbDAS = New System.Windows.Forms.CheckBox()
        Me.gbDeclaracoes = New System.Windows.Forms.GroupBox()
        Me.chbCAGED = New System.Windows.Forms.CheckBox()
        Me.chbRAISNEGATIVA = New System.Windows.Forms.CheckBox()
        Me.chbGIA = New System.Windows.Forms.CheckBox()
        Me.chbDCTF = New System.Windows.Forms.CheckBox()
        Me.chbEFD = New System.Windows.Forms.CheckBox()
        Me.chbIRRF = New System.Windows.Forms.CheckBox()
        Me.chbRAIS = New System.Windows.Forms.CheckBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEmpresa.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBsIMPLES.SuspendLayout()
        Me.gbDeclaracoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'errErro
        '
        Me.errErro.ContainerControl = Me
        '
        'lblAcessoID
        '
        Me.lblAcessoID.AutoSize = True
        Me.lblAcessoID.Location = New System.Drawing.Point(6, 5)
        Me.lblAcessoID.Name = "lblAcessoID"
        Me.lblAcessoID.Size = New System.Drawing.Size(14, 15)
        Me.lblAcessoID.TabIndex = 0
        Me.lblAcessoID.Text = "0"
        '
        'gbEmpresa
        '
        Me.gbEmpresa.Controls.Add(Me.txtTelefone)
        Me.gbEmpresa.Controls.Add(Me.Label6)
        Me.gbEmpresa.Controls.Add(Me.txtResponsavel)
        Me.gbEmpresa.Controls.Add(Me.Label5)
        Me.gbEmpresa.Controls.Add(Me.txtAno)
        Me.gbEmpresa.Controls.Add(Me.btnPesquisar)
        Me.gbEmpresa.Controls.Add(Me.Label4)
        Me.gbEmpresa.Controls.Add(Me.txtMes)
        Me.gbEmpresa.Controls.Add(Me.Label3)
        Me.gbEmpresa.Controls.Add(Me.txtGerente)
        Me.gbEmpresa.Controls.Add(Me.Label2)
        Me.gbEmpresa.Controls.Add(Me.txtEmpresa)
        Me.gbEmpresa.Controls.Add(Me.Label1)
        Me.gbEmpresa.Location = New System.Drawing.Point(8, 25)
        Me.gbEmpresa.Name = "gbEmpresa"
        Me.gbEmpresa.Size = New System.Drawing.Size(544, 112)
        Me.gbEmpresa.TabIndex = 1
        Me.gbEmpresa.TabStop = False
        Me.gbEmpresa.Text = "Dados da Empresa"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(431, 66)
        Me.txtTelefone.Mask = "(99) 0 0000-0000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(107, 21)
        Me.txtTelefone.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(398, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tel.:"
        '
        'txtResponsavel
        '
        Me.txtResponsavel.Location = New System.Drawing.Point(270, 64)
        Me.txtResponsavel.Name = "txtResponsavel"
        Me.txtResponsavel.Size = New System.Drawing.Size(123, 21)
        Me.txtResponsavel.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(187, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Responsável:"
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(451, 26)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(50, 21)
        Me.txtAno.TabIndex = 7
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisar.FlatAppearance.BorderSize = 0
        Me.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.Location = New System.Drawing.Point(505, 20)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(33, 36)
        Me.btnPesquisar.TabIndex = 2
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(419, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ano:"
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(365, 26)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(50, 21)
        Me.txtMes.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mês:"
        '
        'txtGerente
        '
        Me.txtGerente.Location = New System.Drawing.Point(59, 64)
        Me.txtGerente.Name = "txtGerente"
        Me.txtGerente.Size = New System.Drawing.Size(123, 21)
        Me.txtGerente.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Gerente:"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(66, 24)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(257, 21)
        Me.txtEmpresa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empresa:"
        '
        'btSalvar
        '
        Me.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalvar.FlatAppearance.BorderSize = 0
        Me.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalvar.Image = CType(resources.GetObject("btSalvar.Image"), System.Drawing.Image)
        Me.btSalvar.Location = New System.Drawing.Point(9, 331)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(124, 53)
        Me.btSalvar.TabIndex = 3
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSalvar.UseVisualStyleBackColor = True
        '
        'btAlterar
        '
        Me.btAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAlterar.FlatAppearance.BorderSize = 0
        Me.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAlterar.Image = CType(resources.GetObject("btAlterar.Image"), System.Drawing.Image)
        Me.btAlterar.Location = New System.Drawing.Point(145, 331)
        Me.btAlterar.Name = "btAlterar"
        Me.btAlterar.Size = New System.Drawing.Size(105, 57)
        Me.btAlterar.TabIndex = 4
        Me.btAlterar.Text = "Alterar"
        Me.btAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btAlterar.UseVisualStyleBackColor = True
        '
        'btRegistroAnterior
        '
        Me.btRegistroAnterior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btRegistroAnterior.FlatAppearance.BorderSize = 0
        Me.btRegistroAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btRegistroAnterior.Image = CType(resources.GetObject("btRegistroAnterior.Image"), System.Drawing.Image)
        Me.btRegistroAnterior.Location = New System.Drawing.Point(265, 331)
        Me.btRegistroAnterior.Name = "btRegistroAnterior"
        Me.btRegistroAnterior.Size = New System.Drawing.Size(114, 60)
        Me.btRegistroAnterior.TabIndex = 5
        Me.btRegistroAnterior.Text = "Registro Anterior"
        Me.btRegistroAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btRegistroAnterior.UseVisualStyleBackColor = True
        '
        'btProximoRegistro
        '
        Me.btProximoRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btProximoRegistro.FlatAppearance.BorderSize = 0
        Me.btProximoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btProximoRegistro.Image = CType(resources.GetObject("btProximoRegistro.Image"), System.Drawing.Image)
        Me.btProximoRegistro.Location = New System.Drawing.Point(393, 331)
        Me.btProximoRegistro.Name = "btProximoRegistro"
        Me.btProximoRegistro.Size = New System.Drawing.Size(135, 56)
        Me.btProximoRegistro.TabIndex = 6
        Me.btProximoRegistro.Text = "Próximo Registro"
        Me.btProximoRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btProximoRegistro.UseVisualStyleBackColor = True
        '
        'btSair
        '
        Me.btSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSair.FlatAppearance.BorderSize = 0
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = CType(resources.GetObject("btSair.Image"), System.Drawing.Image)
        Me.btSair.Location = New System.Drawing.Point(529, 331)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(75, 49)
        Me.btSair.TabIndex = 7
        Me.btSair.Text = "Sair"
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chbGRF)
        Me.GroupBox1.Controls.Add(Me.chbProlabore)
        Me.GroupBox1.Controls.Add(Me.chbFolha)
        Me.GroupBox1.Controls.Add(Me.chbDARF)
        Me.GroupBox1.Controls.Add(Me.chbGRRF)
        Me.GroupBox1.Controls.Add(Me.chbSefip)
        Me.GroupBox1.Controls.Add(Me.chbGPS)
        Me.GroupBox1.Controls.Add(Me.txtTrezesalario)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 104)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Folha de Pagamento"
        '
        'chbGRF
        '
        Me.chbGRF.AutoSize = True
        Me.chbGRF.Location = New System.Drawing.Point(297, 70)
        Me.chbGRF.Name = "chbGRF"
        Me.chbGRF.Size = New System.Drawing.Size(51, 19)
        Me.chbGRF.TabIndex = 21
        Me.chbGRF.Text = "GRF"
        Me.chbGRF.UseVisualStyleBackColor = True
        '
        'chbProlabore
        '
        Me.chbProlabore.AutoSize = True
        Me.chbProlabore.Location = New System.Drawing.Point(4, 32)
        Me.chbProlabore.Name = "chbProlabore"
        Me.chbProlabore.Size = New System.Drawing.Size(88, 19)
        Me.chbProlabore.TabIndex = 20
        Me.chbProlabore.Text = "Pro-Labore"
        Me.chbProlabore.UseVisualStyleBackColor = True
        '
        'chbFolha
        '
        Me.chbFolha.AutoSize = True
        Me.chbFolha.Location = New System.Drawing.Point(4, 70)
        Me.chbFolha.Name = "chbFolha"
        Me.chbFolha.Size = New System.Drawing.Size(57, 19)
        Me.chbFolha.TabIndex = 19
        Me.chbFolha.Text = "Folha"
        Me.chbFolha.UseVisualStyleBackColor = True
        '
        'chbDARF
        '
        Me.chbDARF.AutoSize = True
        Me.chbDARF.Location = New System.Drawing.Point(64, 70)
        Me.chbDARF.Name = "chbDARF"
        Me.chbDARF.Size = New System.Drawing.Size(58, 19)
        Me.chbDARF.TabIndex = 18
        Me.chbDARF.Text = "DARF"
        Me.chbDARF.UseVisualStyleBackColor = True
        '
        'chbGRRF
        '
        Me.chbGRRF.AutoSize = True
        Me.chbGRRF.Location = New System.Drawing.Point(121, 70)
        Me.chbGRRF.Name = "chbGRRF"
        Me.chbGRRF.Size = New System.Drawing.Size(60, 19)
        Me.chbGRRF.TabIndex = 17
        Me.chbGRRF.Text = "GRRF"
        Me.chbGRRF.UseVisualStyleBackColor = True
        '
        'chbSefip
        '
        Me.chbSefip.AutoSize = True
        Me.chbSefip.Location = New System.Drawing.Point(185, 70)
        Me.chbSefip.Name = "chbSefip"
        Me.chbSefip.Size = New System.Drawing.Size(54, 19)
        Me.chbSefip.TabIndex = 16
        Me.chbSefip.Text = "Sefip"
        Me.chbSefip.UseVisualStyleBackColor = True
        '
        'chbGPS
        '
        Me.chbGPS.AutoSize = True
        Me.chbGPS.Location = New System.Drawing.Point(243, 70)
        Me.chbGPS.Name = "chbGPS"
        Me.chbGPS.Size = New System.Drawing.Size(51, 19)
        Me.chbGPS.TabIndex = 15
        Me.chbGPS.Text = "GPS"
        Me.chbGPS.UseVisualStyleBackColor = True
        '
        'txtTrezesalario
        '
        Me.txtTrezesalario.Location = New System.Drawing.Point(175, 30)
        Me.txtTrezesalario.Name = "txtTrezesalario"
        Me.txtTrezesalario.Size = New System.Drawing.Size(146, 21)
        Me.txtTrezesalario.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(102, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "13º Salário:"
        '
        'chbECF
        '
        Me.chbECF.AutoSize = True
        Me.chbECF.Location = New System.Drawing.Point(303, 31)
        Me.chbECF.Name = "chbECF"
        Me.chbECF.Size = New System.Drawing.Size(50, 19)
        Me.chbECF.TabIndex = 14
        Me.chbECF.Text = "ECF"
        Me.chbECF.UseVisualStyleBackColor = True
        '
        'GBsIMPLES
        '
        Me.GBsIMPLES.Controls.Add(Me.chbDEFIS)
        Me.GBsIMPLES.Controls.Add(Me.chbDASZERO)
        Me.GBsIMPLES.Controls.Add(Me.chbDASN)
        Me.GBsIMPLES.Controls.Add(Me.chbDAS)
        Me.GBsIMPLES.Location = New System.Drawing.Point(366, 146)
        Me.GBsIMPLES.Name = "GBsIMPLES"
        Me.GBsIMPLES.Size = New System.Drawing.Size(185, 100)
        Me.GBsIMPLES.TabIndex = 9
        Me.GBsIMPLES.TabStop = False
        Me.GBsIMPLES.Text = "Simples"
        '
        'chbDEFIS
        '
        Me.chbDEFIS.AutoSize = True
        Me.chbDEFIS.Location = New System.Drawing.Point(114, 70)
        Me.chbDEFIS.Name = "chbDEFIS"
        Me.chbDEFIS.Size = New System.Drawing.Size(61, 19)
        Me.chbDEFIS.TabIndex = 25
        Me.chbDEFIS.Text = "DEFIS"
        Me.chbDEFIS.UseVisualStyleBackColor = True
        '
        'chbDASZERO
        '
        Me.chbDASZERO.AutoSize = True
        Me.chbDASZERO.Location = New System.Drawing.Point(9, 70)
        Me.chbDASZERO.Name = "chbDASZERO"
        Me.chbDASZERO.Size = New System.Drawing.Size(102, 19)
        Me.chbDASZERO.TabIndex = 24
        Me.chbDASZERO.Text = "DAS ZERADO"
        Me.chbDASZERO.UseVisualStyleBackColor = True
        '
        'chbDASN
        '
        Me.chbDASN.AutoSize = True
        Me.chbDASN.Location = New System.Drawing.Point(114, 29)
        Me.chbDASN.Name = "chbDASN"
        Me.chbDASN.Size = New System.Drawing.Size(59, 19)
        Me.chbDASN.TabIndex = 23
        Me.chbDASN.Text = "DASN"
        Me.chbDASN.UseVisualStyleBackColor = True
        '
        'chbDAS
        '
        Me.chbDAS.AutoSize = True
        Me.chbDAS.Location = New System.Drawing.Point(9, 29)
        Me.chbDAS.Name = "chbDAS"
        Me.chbDAS.Size = New System.Drawing.Size(50, 19)
        Me.chbDAS.TabIndex = 22
        Me.chbDAS.Text = "DAS"
        Me.chbDAS.UseVisualStyleBackColor = True
        '
        'gbDeclaracoes
        '
        Me.gbDeclaracoes.Controls.Add(Me.chbCAGED)
        Me.gbDeclaracoes.Controls.Add(Me.chbRAISNEGATIVA)
        Me.gbDeclaracoes.Controls.Add(Me.chbGIA)
        Me.gbDeclaracoes.Controls.Add(Me.chbDCTF)
        Me.gbDeclaracoes.Controls.Add(Me.chbEFD)
        Me.gbDeclaracoes.Controls.Add(Me.chbIRRF)
        Me.gbDeclaracoes.Controls.Add(Me.chbRAIS)
        Me.gbDeclaracoes.Controls.Add(Me.chbECF)
        Me.gbDeclaracoes.Location = New System.Drawing.Point(8, 253)
        Me.gbDeclaracoes.Name = "gbDeclaracoes"
        Me.gbDeclaracoes.Size = New System.Drawing.Size(544, 67)
        Me.gbDeclaracoes.TabIndex = 10
        Me.gbDeclaracoes.TabStop = False
        Me.gbDeclaracoes.Text = "Declarações"
        '
        'chbCAGED
        '
        Me.chbCAGED.AutoSize = True
        Me.chbCAGED.Location = New System.Drawing.Point(470, 31)
        Me.chbCAGED.Name = "chbCAGED"
        Me.chbCAGED.Size = New System.Drawing.Size(68, 19)
        Me.chbCAGED.TabIndex = 13
        Me.chbCAGED.Text = "CAGED"
        Me.chbCAGED.UseVisualStyleBackColor = True
        '
        'chbRAISNEGATIVA
        '
        Me.chbRAISNEGATIVA.AutoSize = True
        Me.chbRAISNEGATIVA.Location = New System.Drawing.Point(185, 31)
        Me.chbRAISNEGATIVA.Name = "chbRAISNEGATIVA"
        Me.chbRAISNEGATIVA.Size = New System.Drawing.Size(111, 19)
        Me.chbRAISNEGATIVA.TabIndex = 3
        Me.chbRAISNEGATIVA.Text = "RAIS NEGATIVA"
        Me.chbRAISNEGATIVA.UseVisualStyleBackColor = True
        '
        'chbGIA
        '
        Me.chbGIA.AutoSize = True
        Me.chbGIA.Location = New System.Drawing.Point(415, 31)
        Me.chbGIA.Name = "chbGIA"
        Me.chbGIA.Size = New System.Drawing.Size(45, 19)
        Me.chbGIA.TabIndex = 12
        Me.chbGIA.Text = "GIA"
        Me.chbGIA.UseVisualStyleBackColor = True
        '
        'chbDCTF
        '
        Me.chbDCTF.AutoSize = True
        Me.chbDCTF.Location = New System.Drawing.Point(64, 31)
        Me.chbDCTF.Name = "chbDCTF"
        Me.chbDCTF.Size = New System.Drawing.Size(58, 19)
        Me.chbDCTF.TabIndex = 2
        Me.chbDCTF.Text = "DCTF"
        Me.chbDCTF.UseVisualStyleBackColor = True
        '
        'chbEFD
        '
        Me.chbEFD.AutoSize = True
        Me.chbEFD.Location = New System.Drawing.Point(360, 31)
        Me.chbEFD.Name = "chbEFD"
        Me.chbEFD.Size = New System.Drawing.Size(50, 19)
        Me.chbEFD.TabIndex = 11
        Me.chbEFD.Text = "EFD"
        Me.chbEFD.UseVisualStyleBackColor = True
        '
        'chbIRRF
        '
        Me.chbIRRF.AutoSize = True
        Me.chbIRRF.Location = New System.Drawing.Point(4, 31)
        Me.chbIRRF.Name = "chbIRRF"
        Me.chbIRRF.Size = New System.Drawing.Size(54, 19)
        Me.chbIRRF.TabIndex = 1
        Me.chbIRRF.Text = "IRRF"
        Me.chbIRRF.UseVisualStyleBackColor = True
        '
        'chbRAIS
        '
        Me.chbRAIS.AutoSize = True
        Me.chbRAIS.Location = New System.Drawing.Point(125, 31)
        Me.chbRAIS.Name = "chbRAIS"
        Me.chbRAIS.Size = New System.Drawing.Size(53, 19)
        Me.chbRAIS.TabIndex = 0
        Me.chbRAIS.Text = "RAIS"
        Me.chbRAIS.UseVisualStyleBackColor = True
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(558, 48)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(241, 272)
        Me.txtObs.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(643, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Observações:"
        '
        'frmCadAcessoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(804, 441)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.gbDeclaracoes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GBsIMPLES)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.btProximoRegistro)
        Me.Controls.Add(Me.btRegistroAnterior)
        Me.Controls.Add(Me.btAlterar)
        Me.Controls.Add(Me.btSalvar)
        Me.Controls.Add(Me.gbEmpresa)
        Me.Controls.Add(Me.lblAcessoID)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadAcessoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Assessoria de Clientes"
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEmpresa.ResumeLayout(False)
        Me.gbEmpresa.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBsIMPLES.ResumeLayout(False)
        Me.GBsIMPLES.PerformLayout()
        Me.gbDeclaracoes.ResumeLayout(False)
        Me.gbDeclaracoes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents errErro As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents gbDeclaracoes As System.Windows.Forms.GroupBox
    Friend WithEvents chbCAGED As System.Windows.Forms.CheckBox
    Friend WithEvents chbRAISNEGATIVA As System.Windows.Forms.CheckBox
    Friend WithEvents chbGIA As System.Windows.Forms.CheckBox
    Friend WithEvents chbDCTF As System.Windows.Forms.CheckBox
    Friend WithEvents chbEFD As System.Windows.Forms.CheckBox
    Friend WithEvents chbIRRF As System.Windows.Forms.CheckBox
    Friend WithEvents chbRAIS As System.Windows.Forms.CheckBox
    Friend WithEvents chbECF As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GBsIMPLES As System.Windows.Forms.GroupBox
    Friend WithEvents chbDEFIS As System.Windows.Forms.CheckBox
    Friend WithEvents chbDASZERO As System.Windows.Forms.CheckBox
    Friend WithEvents chbDASN As System.Windows.Forms.CheckBox
    Friend WithEvents chbDAS As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chbGRF As System.Windows.Forms.CheckBox
    Friend WithEvents chbProlabore As System.Windows.Forms.CheckBox
    Friend WithEvents chbFolha As System.Windows.Forms.CheckBox
    Friend WithEvents chbDARF As System.Windows.Forms.CheckBox
    Friend WithEvents chbGRRF As System.Windows.Forms.CheckBox
    Friend WithEvents chbSefip As System.Windows.Forms.CheckBox
    Friend WithEvents chbGPS As System.Windows.Forms.CheckBox
    Friend WithEvents txtTrezesalario As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents btProximoRegistro As System.Windows.Forms.Button
    Friend WithEvents btRegistroAnterior As System.Windows.Forms.Button
    Friend WithEvents btAlterar As System.Windows.Forms.Button
    Friend WithEvents btSalvar As System.Windows.Forms.Button
    Friend WithEvents gbEmpresa As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtResponsavel As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGerente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAcessoID As System.Windows.Forms.Label
End Class
