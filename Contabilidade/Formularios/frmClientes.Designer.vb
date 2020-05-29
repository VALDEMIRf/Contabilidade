<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabCliente = New System.Windows.Forms.TabPage()
        Me.txtNumBeneficio = New System.Windows.Forms.MaskedTextBox()
        Me.txtESocial = New System.Windows.Forms.MaskedTextBox()
        Me.txtCPFRedesim = New System.Windows.Forms.MaskedTextBox()
        Me.txtFuncPublico = New System.Windows.Forms.ComboBox()
        Me.txtCodRFB = New System.Windows.Forms.TextBox()
        Me.chbCodRFB = New System.Windows.Forms.CheckBox()
        Me.txtInativo = New System.Windows.Forms.TextBox()
        Me.chbInativo = New System.Windows.Forms.CheckBox()
        Me.txtFalecido = New System.Windows.Forms.MaskedTextBox()
        Me.lblSenhaRedesim = New System.Windows.Forms.Label()
        Me.txtSenhaRedesim = New System.Windows.Forms.TextBox()
        Me.chbRedesim = New System.Windows.Forms.CheckBox()
        Me.lblEsocialSenha = New System.Windows.Forms.Label()
        Me.txtEsocialSenha = New System.Windows.Forms.TextBox()
        Me.txtValidadeRFB = New System.Windows.Forms.MaskedTextBox()
        Me.lblValidoRFB = New System.Windows.Forms.Label()
        Me.txtSenhaWeb = New System.Windows.Forms.TextBox()
        Me.chbSenhaWeb = New System.Windows.Forms.CheckBox()
        Me.chbESocial = New System.Windows.Forms.CheckBox()
        Me.txtMensalista = New System.Windows.Forms.TextBox()
        Me.chbMensalista = New System.Windows.Forms.CheckBox()
        Me.txtIRPF = New System.Windows.Forms.TextBox()
        Me.txtDecore = New System.Windows.Forms.TextBox()
        Me.txtITR = New System.Windows.Forms.TextBox()
        Me.txtVIP = New System.Windows.Forms.TextBox()
        Me.txtParcelamentos = New System.Windows.Forms.TextBox()
        Me.chbVIP = New System.Windows.Forms.CheckBox()
        Me.chbFuncPublico = New System.Windows.Forms.CheckBox()
        Me.chbAposentado = New System.Windows.Forms.CheckBox()
        Me.chbDecore = New System.Windows.Forms.CheckBox()
        Me.chbIRPF = New System.Windows.Forms.CheckBox()
        Me.chbParcelamentos = New System.Windows.Forms.CheckBox()
        Me.chbFalecido = New System.Windows.Forms.CheckBox()
        Me.chbITR = New System.Windows.Forms.CheckBox()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btAlterarDados = New System.Windows.Forms.Button()
        Me.btPesquisarCliente = New System.Windows.Forms.Button()
        Me.chbCurriculo = New System.Windows.Forms.CheckBox()
        Me.chbPJ = New System.Windows.Forms.CheckBox()
        Me.chbMEI = New System.Windows.Forms.CheckBox()
        Me.chbAutonomo = New System.Windows.Forms.CheckBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtFoneCel2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtFoneCel1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtFoneRes = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCEP = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboUF = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtLogradouro = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btPesquisarCPFVinculado = New System.Windows.Forms.Button()
        Me.txtDtNasc = New System.Windows.Forms.MaskedTextBox()
        Me.txtVinculo = New System.Windows.Forms.TextBox()
        Me.txtCPFVinculado = New System.Windows.Forms.ComboBox()
        Me.txtRG = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbAno = New System.Windows.Forms.ComboBox()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.cmbDia = New System.Windows.Forms.ComboBox()
        Me.txtTitEleitoral = New System.Windows.Forms.MaskedTextBox()
        Me.txtPIS = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.cboSituacao = New System.Windows.Forms.ComboBox()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabEmpresa = New System.Windows.Forms.TabPage()
        Me.btSair = New System.Windows.Forms.Button()
        Me.btPesquisaEmpresa = New System.Windows.Forms.Button()
        Me.btLimpar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TabControl1.SuspendLayout()
        Me.TabCliente.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabEmpresa.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabCliente)
        Me.TabControl1.Controls.Add(Me.TabEmpresa)
        Me.TabControl1.Location = New System.Drawing.Point(4, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(588, 660)
        Me.TabControl1.TabIndex = 0
        '
        'TabCliente
        '
        Me.TabCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabCliente.Controls.Add(Me.txtNumBeneficio)
        Me.TabCliente.Controls.Add(Me.txtESocial)
        Me.TabCliente.Controls.Add(Me.txtCPFRedesim)
        Me.TabCliente.Controls.Add(Me.txtFuncPublico)
        Me.TabCliente.Controls.Add(Me.txtCodRFB)
        Me.TabCliente.Controls.Add(Me.chbCodRFB)
        Me.TabCliente.Controls.Add(Me.txtInativo)
        Me.TabCliente.Controls.Add(Me.chbInativo)
        Me.TabCliente.Controls.Add(Me.txtFalecido)
        Me.TabCliente.Controls.Add(Me.lblSenhaRedesim)
        Me.TabCliente.Controls.Add(Me.txtSenhaRedesim)
        Me.TabCliente.Controls.Add(Me.chbRedesim)
        Me.TabCliente.Controls.Add(Me.lblEsocialSenha)
        Me.TabCliente.Controls.Add(Me.txtEsocialSenha)
        Me.TabCliente.Controls.Add(Me.txtValidadeRFB)
        Me.TabCliente.Controls.Add(Me.lblValidoRFB)
        Me.TabCliente.Controls.Add(Me.txtSenhaWeb)
        Me.TabCliente.Controls.Add(Me.chbSenhaWeb)
        Me.TabCliente.Controls.Add(Me.chbESocial)
        Me.TabCliente.Controls.Add(Me.txtMensalista)
        Me.TabCliente.Controls.Add(Me.chbMensalista)
        Me.TabCliente.Controls.Add(Me.txtIRPF)
        Me.TabCliente.Controls.Add(Me.txtDecore)
        Me.TabCliente.Controls.Add(Me.txtITR)
        Me.TabCliente.Controls.Add(Me.txtVIP)
        Me.TabCliente.Controls.Add(Me.txtParcelamentos)
        Me.TabCliente.Controls.Add(Me.chbVIP)
        Me.TabCliente.Controls.Add(Me.chbFuncPublico)
        Me.TabCliente.Controls.Add(Me.chbAposentado)
        Me.TabCliente.Controls.Add(Me.chbDecore)
        Me.TabCliente.Controls.Add(Me.chbIRPF)
        Me.TabCliente.Controls.Add(Me.chbParcelamentos)
        Me.TabCliente.Controls.Add(Me.chbFalecido)
        Me.TabCliente.Controls.Add(Me.chbITR)
        Me.TabCliente.Controls.Add(Me.btSalvar)
        Me.TabCliente.Controls.Add(Me.btAlterarDados)
        Me.TabCliente.Controls.Add(Me.btPesquisarCliente)
        Me.TabCliente.Controls.Add(Me.chbCurriculo)
        Me.TabCliente.Controls.Add(Me.chbPJ)
        Me.TabCliente.Controls.Add(Me.chbMEI)
        Me.TabCliente.Controls.Add(Me.chbAutonomo)
        Me.TabCliente.Controls.Add(Me.txtObs)
        Me.TabCliente.Controls.Add(Me.Label21)
        Me.TabCliente.Controls.Add(Me.GroupBox3)
        Me.TabCliente.Controls.Add(Me.GroupBox2)
        Me.TabCliente.Controls.Add(Me.GroupBox1)
        Me.TabCliente.Location = New System.Drawing.Point(4, 22)
        Me.TabCliente.Name = "TabCliente"
        Me.TabCliente.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCliente.Size = New System.Drawing.Size(580, 634)
        Me.TabCliente.TabIndex = 0
        Me.TabCliente.Text = "Cliente"
        '
        'txtNumBeneficio
        '
        Me.txtNumBeneficio.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.txtNumBeneficio.Location = New System.Drawing.Point(395, 89)
        Me.txtNumBeneficio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNumBeneficio.Name = "txtNumBeneficio"
        Me.txtNumBeneficio.Size = New System.Drawing.Size(100, 20)
        Me.txtNumBeneficio.TabIndex = 200022
        Me.txtNumBeneficio.Visible = False
        '
        'txtESocial
        '
        Me.txtESocial.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.txtESocial.Location = New System.Drawing.Point(363, 203)
        Me.txtESocial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtESocial.Mask = "0000000000"
        Me.txtESocial.Name = "txtESocial"
        Me.txtESocial.Size = New System.Drawing.Size(66, 20)
        Me.txtESocial.TabIndex = 200030
        Me.txtESocial.Visible = False
        '
        'txtCPFRedesim
        '
        Me.txtCPFRedesim.Location = New System.Drawing.Point(355, 429)
        Me.txtCPFRedesim.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCPFRedesim.Mask = "000.000.000-00"
        Me.txtCPFRedesim.Name = "txtCPFRedesim"
        Me.txtCPFRedesim.ReadOnly = True
        Me.txtCPFRedesim.Size = New System.Drawing.Size(102, 20)
        Me.txtCPFRedesim.TabIndex = 200053
        Me.txtCPFRedesim.Visible = False
        '
        'txtFuncPublico
        '
        Me.txtFuncPublico.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.txtFuncPublico.FormattingEnabled = True
        Me.txtFuncPublico.Items.AddRange(New Object() {"Municipal", "Estadual", "Federal"})
        Me.txtFuncPublico.Location = New System.Drawing.Point(396, 117)
        Me.txtFuncPublico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFuncPublico.Name = "txtFuncPublico"
        Me.txtFuncPublico.Size = New System.Drawing.Size(109, 22)
        Me.txtFuncPublico.TabIndex = 200024
        Me.txtFuncPublico.Visible = False
        '
        'txtCodRFB
        '
        Me.txtCodRFB.Location = New System.Drawing.Point(347, 485)
        Me.txtCodRFB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodRFB.Name = "txtCodRFB"
        Me.txtCodRFB.Size = New System.Drawing.Size(123, 20)
        Me.txtCodRFB.TabIndex = 200046
        Me.txtCodRFB.Visible = False
        '
        'chbCodRFB
        '
        Me.chbCodRFB.AutoSize = True
        Me.chbCodRFB.Location = New System.Drawing.Point(280, 487)
        Me.chbCodRFB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chbCodRFB.Name = "chbCodRFB"
        Me.chbCodRFB.Size = New System.Drawing.Size(69, 17)
        Me.chbCodRFB.TabIndex = 200052
        Me.chbCodRFB.Text = "CódRFB:"
        Me.chbCodRFB.UseVisualStyleBackColor = True
        '
        'txtInativo
        '
        Me.txtInativo.Location = New System.Drawing.Point(338, 172)
        Me.txtInativo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInativo.Multiline = True
        Me.txtInativo.Name = "txtInativo"
        Me.txtInativo.Size = New System.Drawing.Size(119, 23)
        Me.txtInativo.TabIndex = 200028
        Me.txtInativo.Visible = False
        '
        'chbInativo
        '
        Me.chbInativo.AutoSize = True
        Me.chbInativo.Location = New System.Drawing.Point(280, 177)
        Me.chbInativo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chbInativo.Name = "chbInativo"
        Me.chbInativo.Size = New System.Drawing.Size(61, 17)
        Me.chbInativo.TabIndex = 200027
        Me.chbInativo.Text = "Inativo:"
        Me.chbInativo.UseVisualStyleBackColor = True
        '
        'txtFalecido
        '
        Me.txtFalecido.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.txtFalecido.Location = New System.Drawing.Point(399, 148)
        Me.txtFalecido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFalecido.Mask = "00/00/0000"
        Me.txtFalecido.Name = "txtFalecido"
        Me.txtFalecido.Size = New System.Drawing.Size(89, 20)
        Me.txtFalecido.TabIndex = 200026
        Me.txtFalecido.ValidatingType = GetType(Date)
        Me.txtFalecido.Visible = False
        '
        'lblSenhaRedesim
        '
        Me.lblSenhaRedesim.AutoSize = True
        Me.lblSenhaRedesim.Location = New System.Drawing.Point(284, 462)
        Me.lblSenhaRedesim.Name = "lblSenhaRedesim"
        Me.lblSenhaRedesim.Size = New System.Drawing.Size(41, 13)
        Me.lblSenhaRedesim.TabIndex = 200051
        Me.lblSenhaRedesim.Text = "Senha:"
        Me.lblSenhaRedesim.Visible = False
        '
        'txtSenhaRedesim
        '
        Me.txtSenhaRedesim.Location = New System.Drawing.Point(329, 459)
        Me.txtSenhaRedesim.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSenhaRedesim.Name = "txtSenhaRedesim"
        Me.txtSenhaRedesim.Size = New System.Drawing.Size(160, 20)
        Me.txtSenhaRedesim.TabIndex = 200045
        Me.txtSenhaRedesim.Visible = False
        '
        'chbRedesim
        '
        Me.chbRedesim.AutoSize = True
        Me.chbRedesim.Location = New System.Drawing.Point(280, 431)
        Me.chbRedesim.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chbRedesim.Name = "chbRedesim"
        Me.chbRedesim.Size = New System.Drawing.Size(70, 17)
        Me.chbRedesim.TabIndex = 200044
        Me.chbRedesim.Text = "Redesim:"
        Me.chbRedesim.UseVisualStyleBackColor = True
        '
        'lblEsocialSenha
        '
        Me.lblEsocialSenha.AutoSize = True
        Me.lblEsocialSenha.Location = New System.Drawing.Point(435, 208)
        Me.lblEsocialSenha.Name = "lblEsocialSenha"
        Me.lblEsocialSenha.Size = New System.Drawing.Size(41, 13)
        Me.lblEsocialSenha.TabIndex = 200031
        Me.lblEsocialSenha.Text = "Senha:"
        Me.lblEsocialSenha.Visible = False
        '
        'txtEsocialSenha
        '
        Me.txtEsocialSenha.Location = New System.Drawing.Point(479, 205)
        Me.txtEsocialSenha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEsocialSenha.Name = "txtEsocialSenha"
        Me.txtEsocialSenha.Size = New System.Drawing.Size(88, 20)
        Me.txtEsocialSenha.TabIndex = 200032
        Me.txtEsocialSenha.Visible = False
        '
        'txtValidadeRFB
        '
        Me.txtValidadeRFB.Location = New System.Drawing.Point(511, 487)
        Me.txtValidadeRFB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtValidadeRFB.Mask = "00/00/0000"
        Me.txtValidadeRFB.Name = "txtValidadeRFB"
        Me.txtValidadeRFB.Size = New System.Drawing.Size(60, 20)
        Me.txtValidadeRFB.TabIndex = 200047
        Me.txtValidadeRFB.ValidatingType = GetType(Date)
        Me.txtValidadeRFB.Visible = False
        '
        'lblValidoRFB
        '
        Me.lblValidoRFB.AutoSize = True
        Me.lblValidoRFB.Location = New System.Drawing.Point(471, 490)
        Me.lblValidoRFB.Name = "lblValidoRFB"
        Me.lblValidoRFB.Size = New System.Drawing.Size(33, 13)
        Me.lblValidoRFB.TabIndex = 200054
        Me.lblValidoRFB.Text = "Valid:"
        Me.lblValidoRFB.Visible = False
        '
        'txtSenhaWeb
        '
        Me.txtSenhaWeb.Location = New System.Drawing.Point(426, 404)
        Me.txtSenhaWeb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSenhaWeb.Name = "txtSenhaWeb"
        Me.txtSenhaWeb.Size = New System.Drawing.Size(86, 20)
        Me.txtSenhaWeb.TabIndex = 200043
        Me.txtSenhaWeb.Visible = False
        '
        'chbSenhaWeb
        '
        Me.chbSenhaWeb.AutoSize = True
        Me.chbSenhaWeb.Location = New System.Drawing.Point(280, 404)
        Me.chbSenhaWeb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chbSenhaWeb.Name = "chbSenhaWeb"
        Me.chbSenhaWeb.Size = New System.Drawing.Size(147, 17)
        Me.chbSenhaWeb.TabIndex = 200042
        Me.chbSenhaWeb.Text = "Senha Web PrefeituraPF:"
        Me.chbSenhaWeb.UseVisualStyleBackColor = True
        '
        'chbESocial
        '
        Me.chbESocial.AutoSize = True
        Me.chbESocial.Location = New System.Drawing.Point(280, 205)
        Me.chbESocial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chbESocial.Name = "chbESocial"
        Me.chbESocial.Size = New System.Drawing.Size(84, 17)
        Me.chbESocial.TabIndex = 200029
        Me.chbESocial.Text = "Empr. Dom.:"
        Me.chbESocial.UseVisualStyleBackColor = True
        '
        'txtMensalista
        '
        Me.txtMensalista.Location = New System.Drawing.Point(379, 320)
        Me.txtMensalista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMensalista.Name = "txtMensalista"
        Me.txtMensalista.Size = New System.Drawing.Size(126, 20)
        Me.txtMensalista.TabIndex = 200050
        Me.txtMensalista.Visible = False
        '
        'chbMensalista
        '
        Me.chbMensalista.AutoSize = True
        Me.chbMensalista.Location = New System.Drawing.Point(280, 322)
        Me.chbMensalista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chbMensalista.Name = "chbMensalista"
        Me.chbMensalista.Size = New System.Drawing.Size(102, 17)
        Me.chbMensalista.TabIndex = 200049
        Me.chbMensalista.Text = "Cliente Contábil:"
        Me.chbMensalista.UseVisualStyleBackColor = True
        '
        'txtIRPF
        '
        Me.txtIRPF.Location = New System.Drawing.Point(335, 376)
        Me.txtIRPF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIRPF.Name = "txtIRPF"
        Me.txtIRPF.Size = New System.Drawing.Size(160, 20)
        Me.txtIRPF.TabIndex = 200040
        Me.txtIRPF.Visible = False
        '
        'txtDecore
        '
        Me.txtDecore.Location = New System.Drawing.Point(352, 348)
        Me.txtDecore.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDecore.Name = "txtDecore"
        Me.txtDecore.Size = New System.Drawing.Size(160, 20)
        Me.txtDecore.TabIndex = 200038
        Me.txtDecore.Visible = False
        '
        'txtITR
        '
        Me.txtITR.Location = New System.Drawing.Point(320, 290)
        Me.txtITR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtITR.Name = "txtITR"
        Me.txtITR.Size = New System.Drawing.Size(160, 20)
        Me.txtITR.TabIndex = 200048
        Me.txtITR.Visible = False
        '
        'txtVIP
        '
        Me.txtVIP.Location = New System.Drawing.Point(329, 259)
        Me.txtVIP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVIP.Name = "txtVIP"
        Me.txtVIP.Size = New System.Drawing.Size(142, 20)
        Me.txtVIP.TabIndex = 200036
        Me.txtVIP.Visible = False
        '
        'txtParcelamentos
        '
        Me.txtParcelamentos.Location = New System.Drawing.Point(377, 234)
        Me.txtParcelamentos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtParcelamentos.Name = "txtParcelamentos"
        Me.txtParcelamentos.Size = New System.Drawing.Size(190, 20)
        Me.txtParcelamentos.TabIndex = 200034
        Me.txtParcelamentos.Visible = False
        '
        'chbVIP
        '
        Me.chbVIP.AutoSize = True
        Me.chbVIP.Location = New System.Drawing.Point(280, 262)
        Me.chbVIP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chbVIP.Name = "chbVIP"
        Me.chbVIP.Size = New System.Drawing.Size(46, 17)
        Me.chbVIP.TabIndex = 200035
        Me.chbVIP.Text = "VIP:"
        Me.chbVIP.UseVisualStyleBackColor = True
        '
        'chbFuncPublico
        '
        Me.chbFuncPublico.AutoSize = True
        Me.chbFuncPublico.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.chbFuncPublico.Location = New System.Drawing.Point(280, 119)
        Me.chbFuncPublico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chbFuncPublico.Name = "chbFuncPublico"
        Me.chbFuncPublico.Size = New System.Drawing.Size(100, 19)
        Me.chbFuncPublico.TabIndex = 200023
        Me.chbFuncPublico.Text = "Func. Público"
        Me.chbFuncPublico.UseVisualStyleBackColor = True
        '
        'chbAposentado
        '
        Me.chbAposentado.AutoSize = True
        Me.chbAposentado.Location = New System.Drawing.Point(280, 91)
        Me.chbAposentado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chbAposentado.Name = "chbAposentado"
        Me.chbAposentado.Size = New System.Drawing.Size(105, 17)
        Me.chbAposentado.TabIndex = 200021
        Me.chbAposentado.Text = "Nº de Benefício "
        Me.chbAposentado.UseVisualStyleBackColor = True
        '
        'chbDecore
        '
        Me.chbDecore.AutoSize = True
        Me.chbDecore.Location = New System.Drawing.Point(280, 349)
        Me.chbDecore.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chbDecore.Name = "chbDecore"
        Me.chbDecore.Size = New System.Drawing.Size(74, 17)
        Me.chbDecore.TabIndex = 200037
        Me.chbDecore.Text = "DECORE:"
        Me.chbDecore.UseVisualStyleBackColor = True
        '
        'chbIRPF
        '
        Me.chbIRPF.AutoSize = True
        Me.chbIRPF.Location = New System.Drawing.Point(280, 378)
        Me.chbIRPF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chbIRPF.Name = "chbIRPF"
        Me.chbIRPF.Size = New System.Drawing.Size(53, 17)
        Me.chbIRPF.TabIndex = 200039
        Me.chbIRPF.Text = "IRPF:"
        Me.chbIRPF.UseVisualStyleBackColor = True
        '
        'chbParcelamentos
        '
        Me.chbParcelamentos.AutoSize = True
        Me.chbParcelamentos.Location = New System.Drawing.Point(280, 237)
        Me.chbParcelamentos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chbParcelamentos.Name = "chbParcelamentos"
        Me.chbParcelamentos.Size = New System.Drawing.Size(99, 17)
        Me.chbParcelamentos.TabIndex = 200033
        Me.chbParcelamentos.Text = "Parcelamentos:"
        Me.chbParcelamentos.UseVisualStyleBackColor = True
        '
        'chbFalecido
        '
        Me.chbFalecido.AutoSize = True
        Me.chbFalecido.Location = New System.Drawing.Point(280, 151)
        Me.chbFalecido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chbFalecido.Name = "chbFalecido"
        Me.chbFalecido.Size = New System.Drawing.Size(110, 17)
        Me.chbFalecido.TabIndex = 200025
        Me.chbFalecido.Text = "Falecido na Data:"
        Me.chbFalecido.UseVisualStyleBackColor = True
        '
        'chbITR
        '
        Me.chbITR.AutoSize = True
        Me.chbITR.Location = New System.Drawing.Point(280, 292)
        Me.chbITR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chbITR.Name = "chbITR"
        Me.chbITR.Size = New System.Drawing.Size(47, 17)
        Me.chbITR.TabIndex = 200041
        Me.chbITR.Text = "ITR:"
        Me.chbITR.UseVisualStyleBackColor = True
        '
        'btSalvar
        '
        Me.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalvar.FlatAppearance.BorderSize = 0
        Me.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalvar.Image = CType(resources.GetObject("btSalvar.Image"), System.Drawing.Image)
        Me.btSalvar.Location = New System.Drawing.Point(471, 9)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(79, 46)
        Me.btSalvar.TabIndex = 200020
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSalvar.UseVisualStyleBackColor = True
        '
        'btAlterarDados
        '
        Me.btAlterarDados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAlterarDados.FlatAppearance.BorderSize = 0
        Me.btAlterarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAlterarDados.Image = CType(resources.GetObject("btAlterarDados.Image"), System.Drawing.Image)
        Me.btAlterarDados.Location = New System.Drawing.Point(387, 7)
        Me.btAlterarDados.Name = "btAlterarDados"
        Me.btAlterarDados.Size = New System.Drawing.Size(78, 48)
        Me.btAlterarDados.TabIndex = 200019
        Me.btAlterarDados.Text = "Alterar Dados"
        Me.btAlterarDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btAlterarDados.UseVisualStyleBackColor = True
        '
        'btPesquisarCliente
        '
        Me.btPesquisarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPesquisarCliente.FlatAppearance.BorderSize = 0
        Me.btPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPesquisarCliente.Image = CType(resources.GetObject("btPesquisarCliente.Image"), System.Drawing.Image)
        Me.btPesquisarCliente.Location = New System.Drawing.Point(287, 6)
        Me.btPesquisarCliente.Name = "btPesquisarCliente"
        Me.btPesquisarCliente.Size = New System.Drawing.Size(94, 49)
        Me.btPesquisarCliente.TabIndex = 200018
        Me.btPesquisarCliente.Text = "Pesquisar Cliente"
        Me.btPesquisarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPesquisarCliente.UseVisualStyleBackColor = True
        '
        'chbCurriculo
        '
        Me.chbCurriculo.AutoSize = True
        Me.chbCurriculo.Location = New System.Drawing.Point(473, 67)
        Me.chbCurriculo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chbCurriculo.Name = "chbCurriculo"
        Me.chbCurriculo.Size = New System.Drawing.Size(67, 17)
        Me.chbCurriculo.TabIndex = 200017
        Me.chbCurriculo.Text = "Curriculo"
        Me.chbCurriculo.UseVisualStyleBackColor = True
        '
        'chbPJ
        '
        Me.chbPJ.AutoSize = True
        Me.chbPJ.Location = New System.Drawing.Point(368, 67)
        Me.chbPJ.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chbPJ.Name = "chbPJ"
        Me.chbPJ.Size = New System.Drawing.Size(41, 17)
        Me.chbPJ.TabIndex = 200015
        Me.chbPJ.Text = "PJ:"
        Me.chbPJ.UseVisualStyleBackColor = True
        '
        'chbMEI
        '
        Me.chbMEI.AutoSize = True
        Me.chbMEI.Location = New System.Drawing.Point(422, 67)
        Me.chbMEI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chbMEI.Name = "chbMEI"
        Me.chbMEI.Size = New System.Drawing.Size(48, 17)
        Me.chbMEI.TabIndex = 200016
        Me.chbMEI.Text = "MEI:"
        Me.chbMEI.UseVisualStyleBackColor = True
        '
        'chbAutonomo
        '
        Me.chbAutonomo.AutoSize = True
        Me.chbAutonomo.Location = New System.Drawing.Point(280, 67)
        Me.chbAutonomo.Name = "chbAutonomo"
        Me.chbAutonomo.Size = New System.Drawing.Size(74, 17)
        Me.chbAutonomo.TabIndex = 200014
        Me.chbAutonomo.Text = "Autonomo"
        Me.chbAutonomo.UseVisualStyleBackColor = True
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(6, 517)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(301, 111)
        Me.txtObs.TabIndex = 24
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 501)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(73, 13)
        Me.Label21.TabIndex = 200012
        Me.Label21.Text = "Observações:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtEmail)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtFoneCel2)
        Me.GroupBox3.Controls.Add(Me.txtFoneCel1)
        Me.GroupBox3.Controls.Add(Me.txtFoneRes)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 378)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(267, 120)
        Me.GroupBox3.TabIndex = 200011
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contato"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(57, 84)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(204, 20)
        Me.txtEmail.TabIndex = 23
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 91)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(35, 13)
        Me.Label20.TabIndex = 200012
        Me.Label20.Text = "Email:"
        '
        'txtFoneCel2
        '
        Me.txtFoneCel2.Location = New System.Drawing.Point(57, 62)
        Me.txtFoneCel2.Mask = "(99)0 0000-0000"
        Me.txtFoneCel2.Name = "txtFoneCel2"
        Me.txtFoneCel2.Size = New System.Drawing.Size(80, 20)
        Me.txtFoneCel2.TabIndex = 22
        '
        'txtFoneCel1
        '
        Me.txtFoneCel1.Location = New System.Drawing.Point(57, 39)
        Me.txtFoneCel1.Mask = "(99)0 0000-0000"
        Me.txtFoneCel1.Name = "txtFoneCel1"
        Me.txtFoneCel1.Size = New System.Drawing.Size(80, 20)
        Me.txtFoneCel1.TabIndex = 21
        '
        'txtFoneRes
        '
        Me.txtFoneRes.Location = New System.Drawing.Point(57, 15)
        Me.txtFoneRes.Mask = "(99) 0000-0000"
        Me.txtFoneRes.Name = "txtFoneRes"
        Me.txtFoneRes.Size = New System.Drawing.Size(80, 20)
        Me.txtFoneRes.TabIndex = 20
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 66)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 200014
        Me.Label18.Text = "Tel Cel2:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(2, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 200013
        Me.Label17.Text = "Tel Cel1:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(2, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 200012
        Me.Label16.Text = "Tel Res:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCEP)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.cboUF)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtCidade)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtBairro)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtComplemento)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtNumero)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtLogradouro)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 215)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 157)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Endereço"
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(127, 130)
        Me.txtCEP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCEP.Mask = "00000-999"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(54, 20)
        Me.txtCEP.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(93, 134)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 13)
        Me.Label15.TabIndex = 200011
        Me.Label15.Text = "CEP:"
        '
        'cboUF
        '
        Me.cboUF.FormattingEnabled = True
        Me.cboUF.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cboUF.Location = New System.Drawing.Point(40, 128)
        Me.cboUF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Size = New System.Drawing.Size(40, 21)
        Me.cboUF.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 131)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 13)
        Me.Label14.TabIndex = 200011
        Me.Label14.Text = "UF:"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(42, 100)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(219, 20)
        Me.txtCidade.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(2, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 200011
        Me.Label13.Text = "Cidade:"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(42, 74)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(219, 20)
        Me.txtBairro.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(2, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 200011
        Me.Label12.Text = "Bairro:"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(128, 48)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(133, 20)
        Me.txtComplemento.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(88, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 200011
        Me.Label11.Text = "Compl:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(37, 48)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(50, 20)
        Me.txtNumero.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 200011
        Me.Label10.Text = "Núm:"
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(37, 22)
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(224, 20)
        Me.txtLogradouro.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 200011
        Me.Label9.Text = "End.:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btPesquisarCPFVinculado)
        Me.GroupBox1.Controls.Add(Me.txtDtNasc)
        Me.GroupBox1.Controls.Add(Me.txtVinculo)
        Me.GroupBox1.Controls.Add(Me.txtCPFVinculado)
        Me.GroupBox1.Controls.Add(Me.txtRG)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbAno)
        Me.GroupBox1.Controls.Add(Me.cmbMes)
        Me.GroupBox1.Controls.Add(Me.cmbDia)
        Me.GroupBox1.Controls.Add(Me.txtTitEleitoral)
        Me.GroupBox1.Controls.Add(Me.txtPIS)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.cboSituacao)
        Me.GroupBox1.Controls.Add(Me.txtCPF)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 203)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do Cliente"
        '
        'btPesquisarCPFVinculado
        '
        Me.btPesquisarCPFVinculado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPesquisarCPFVinculado.FlatAppearance.BorderSize = 0
        Me.btPesquisarCPFVinculado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPesquisarCPFVinculado.Image = CType(resources.GetObject("btPesquisarCPFVinculado.Image"), System.Drawing.Image)
        Me.btPesquisarCPFVinculado.Location = New System.Drawing.Point(178, 145)
        Me.btPesquisarCPFVinculado.Name = "btPesquisarCPFVinculado"
        Me.btPesquisarCPFVinculado.Size = New System.Drawing.Size(31, 29)
        Me.btPesquisarCPFVinculado.TabIndex = 11
        Me.btPesquisarCPFVinculado.UseVisualStyleBackColor = True
        '
        'txtDtNasc
        '
        Me.txtDtNasc.Location = New System.Drawing.Point(202, 177)
        Me.txtDtNasc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDtNasc.Mask = "00/00/0000"
        Me.txtDtNasc.Name = "txtDtNasc"
        Me.txtDtNasc.Size = New System.Drawing.Size(60, 20)
        Me.txtDtNasc.TabIndex = 8
        Me.txtDtNasc.ValidatingType = GetType(Date)
        Me.txtDtNasc.Visible = False
        '
        'txtVinculo
        '
        Me.txtVinculo.Location = New System.Drawing.Point(52, 177)
        Me.txtVinculo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVinculo.Name = "txtVinculo"
        Me.txtVinculo.ReadOnly = True
        Me.txtVinculo.Size = New System.Drawing.Size(74, 20)
        Me.txtVinculo.TabIndex = 12
        '
        'txtCPFVinculado
        '
        Me.txtCPFVinculado.FormattingEnabled = True
        Me.txtCPFVinculado.Location = New System.Drawing.Point(76, 150)
        Me.txtCPFVinculado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCPFVinculado.Name = "txtCPFVinculado"
        Me.txtCPFVinculado.Size = New System.Drawing.Size(105, 21)
        Me.txtCPFVinculado.TabIndex = 10
        '
        'txtRG
        '
        Me.txtRG.Location = New System.Drawing.Point(41, 39)
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(103, 20)
        Me.txtRG.TabIndex = 9
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(5, 180)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(45, 13)
        Me.Label39.TabIndex = 200008
        Me.Label39.Text = "Vinculo:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(7, 153)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 13)
        Me.Label19.TabIndex = 200007
        Me.Label19.Text = "CPF Vinculo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 200006
        Me.Label5.Text = "RG:"
        '
        'cmbAno
        '
        Me.cmbAno.FormattingEnabled = True
        Me.cmbAno.Items.AddRange(New Object() {"1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cmbAno.Location = New System.Drawing.Point(190, 124)
        Me.cmbAno.Name = "cmbAno"
        Me.cmbAno.Size = New System.Drawing.Size(51, 21)
        Me.cmbAno.TabIndex = 8
        '
        'cmbMes
        '
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cmbMes.Location = New System.Drawing.Point(149, 124)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(39, 21)
        Me.cmbMes.TabIndex = 7
        '
        'cmbDia
        '
        Me.cmbDia.FormattingEnabled = True
        Me.cmbDia.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbDia.Location = New System.Drawing.Point(105, 124)
        Me.cmbDia.Name = "cmbDia"
        Me.cmbDia.Size = New System.Drawing.Size(39, 21)
        Me.cmbDia.TabIndex = 6
        '
        'txtTitEleitoral
        '
        Me.txtTitEleitoral.Location = New System.Drawing.Point(171, 93)
        Me.txtTitEleitoral.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTitEleitoral.Mask = "000000000000000"
        Me.txtTitEleitoral.Name = "txtTitEleitoral"
        Me.txtTitEleitoral.Size = New System.Drawing.Size(92, 20)
        Me.txtTitEleitoral.TabIndex = 5
        '
        'txtPIS
        '
        Me.txtPIS.Location = New System.Drawing.Point(32, 93)
        Me.txtPIS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPIS.Mask = "00000000000"
        Me.txtPIS.Name = "txtPIS"
        Me.txtPIS.Size = New System.Drawing.Size(68, 20)
        Me.txtPIS.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(106, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Tit Eleitoral:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(42, 64)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(222, 20)
        Me.txtNome.TabIndex = 3
        '
        'cboSituacao
        '
        Me.cboSituacao.FormattingEnabled = True
        Me.cboSituacao.Items.AddRange(New Object() {"Ativo", "Pendente", "Suspenso", "Cancelado"})
        Me.cboSituacao.Location = New System.Drawing.Point(178, 14)
        Me.cboSituacao.Name = "cboSituacao"
        Me.cboSituacao.Size = New System.Drawing.Size(86, 21)
        Me.cboSituacao.TabIndex = 2
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(42, 13)
        Me.txtCPF.Mask = "000.000.000-00"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(84, 20)
        Me.txtCPF.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Data Nascimento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CPF:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Situação"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nome:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "PIS:"
        '
        'TabEmpresa
        '
        Me.TabEmpresa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabEmpresa.Controls.Add(Me.GroupBox4)
        Me.TabEmpresa.Location = New System.Drawing.Point(4, 22)
        Me.TabEmpresa.Name = "TabEmpresa"
        Me.TabEmpresa.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEmpresa.Size = New System.Drawing.Size(580, 634)
        Me.TabEmpresa.TabIndex = 1
        Me.TabEmpresa.Text = "Empresa"
        '
        'btSair
        '
        Me.btSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSair.FlatAppearance.BorderSize = 0
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = CType(resources.GetObject("btSair.Image"), System.Drawing.Image)
        Me.btSair.Location = New System.Drawing.Point(598, 34)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(88, 41)
        Me.btSair.TabIndex = 1
        Me.btSair.Text = "Sair"
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'btPesquisaEmpresa
        '
        Me.btPesquisaEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPesquisaEmpresa.FlatAppearance.BorderSize = 0
        Me.btPesquisaEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPesquisaEmpresa.Image = CType(resources.GetObject("btPesquisaEmpresa.Image"), System.Drawing.Image)
        Me.btPesquisaEmpresa.Location = New System.Drawing.Point(598, 84)
        Me.btPesquisaEmpresa.Name = "btPesquisaEmpresa"
        Me.btPesquisaEmpresa.Size = New System.Drawing.Size(99, 44)
        Me.btPesquisaEmpresa.TabIndex = 2
        Me.btPesquisaEmpresa.Text = "Pesquisar Empresa"
        Me.btPesquisaEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPesquisaEmpresa.UseVisualStyleBackColor = True
        '
        'btLimpar
        '
        Me.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btLimpar.FlatAppearance.BorderSize = 0
        Me.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btLimpar.Image = CType(resources.GetObject("btLimpar.Image"), System.Drawing.Image)
        Me.btLimpar.Location = New System.Drawing.Point(598, 134)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(107, 53)
        Me.btLimpar.TabIndex = 3
        Me.btLimpar.Text = "Limpar Campos"
        Me.btLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btLimpar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(359, 297)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dados da Empresa"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(709, 671)
        Me.Controls.Add(Me.btLimpar)
        Me.Controls.Add(Me.btPesquisaEmpresa)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manutenção de Clientes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabCliente.ResumeLayout(False)
        Me.TabCliente.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabEmpresa.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabCliente As System.Windows.Forms.TabPage
    Friend WithEvents cmbAno As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTitEleitoral As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPIS As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents cboSituacao As System.Windows.Forms.ComboBox
    Friend WithEvents txtCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabEmpresa As System.Windows.Forms.TabPage
    Public WithEvents txtDtNasc As System.Windows.Forms.MaskedTextBox
    Public WithEvents txtVinculo As System.Windows.Forms.TextBox
    Friend WithEvents txtCPFVinculado As System.Windows.Forms.ComboBox
    Friend WithEvents txtRG As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbDia As System.Windows.Forms.ComboBox
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtFoneCel2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFoneCel1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFoneRes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents cboUF As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtLogradouro As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btPesquisarCPFVinculado As System.Windows.Forms.Button
    Friend WithEvents txtNumBeneficio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtESocial As System.Windows.Forms.MaskedTextBox
    Public WithEvents txtCPFRedesim As System.Windows.Forms.MaskedTextBox
    Public WithEvents txtFuncPublico As System.Windows.Forms.ComboBox
    Public WithEvents txtCodRFB As System.Windows.Forms.TextBox
    Friend WithEvents chbCodRFB As System.Windows.Forms.CheckBox
    Public WithEvents txtInativo As System.Windows.Forms.TextBox
    Friend WithEvents chbInativo As System.Windows.Forms.CheckBox
    Public WithEvents txtFalecido As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblSenhaRedesim As System.Windows.Forms.Label
    Public WithEvents txtSenhaRedesim As System.Windows.Forms.TextBox
    Friend WithEvents chbRedesim As System.Windows.Forms.CheckBox
    Friend WithEvents lblEsocialSenha As System.Windows.Forms.Label
    Public WithEvents txtEsocialSenha As System.Windows.Forms.TextBox
    Public WithEvents txtValidadeRFB As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblValidoRFB As System.Windows.Forms.Label
    Public WithEvents txtSenhaWeb As System.Windows.Forms.TextBox
    Friend WithEvents chbSenhaWeb As System.Windows.Forms.CheckBox
    Friend WithEvents chbESocial As System.Windows.Forms.CheckBox
    Public WithEvents txtMensalista As System.Windows.Forms.TextBox
    Friend WithEvents chbMensalista As System.Windows.Forms.CheckBox
    Public WithEvents txtIRPF As System.Windows.Forms.TextBox
    Public WithEvents txtDecore As System.Windows.Forms.TextBox
    Public WithEvents txtITR As System.Windows.Forms.TextBox
    Public WithEvents txtVIP As System.Windows.Forms.TextBox
    Public WithEvents txtParcelamentos As System.Windows.Forms.TextBox
    Friend WithEvents chbVIP As System.Windows.Forms.CheckBox
    Friend WithEvents chbFuncPublico As System.Windows.Forms.CheckBox
    Friend WithEvents chbAposentado As System.Windows.Forms.CheckBox
    Friend WithEvents chbDecore As System.Windows.Forms.CheckBox
    Friend WithEvents chbIRPF As System.Windows.Forms.CheckBox
    Friend WithEvents chbParcelamentos As System.Windows.Forms.CheckBox
    Friend WithEvents chbFalecido As System.Windows.Forms.CheckBox
    Friend WithEvents chbITR As System.Windows.Forms.CheckBox
    Friend WithEvents btSalvar As System.Windows.Forms.Button
    Friend WithEvents btAlterarDados As System.Windows.Forms.Button
    Friend WithEvents btPesquisarCliente As System.Windows.Forms.Button
    Friend WithEvents chbCurriculo As System.Windows.Forms.CheckBox
    Friend WithEvents chbPJ As System.Windows.Forms.CheckBox
    Friend WithEvents chbMEI As System.Windows.Forms.CheckBox
    Friend WithEvents chbAutonomo As System.Windows.Forms.CheckBox
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents btPesquisaEmpresa As System.Windows.Forms.Button
    Friend WithEvents btLimpar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
End Class
