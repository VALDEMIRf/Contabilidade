<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManutençãoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssessoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControleDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarefasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeTarefasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaGeralDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TesteMemorandoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chbAtivo = New System.Windows.Forms.CheckBox()
        Me.btRecarregarTarefas = New System.Windows.Forms.Button()
        Me.dgvTarefas = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbPesquisa = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvAniversariantes = New System.Windows.Forms.DataGridView()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTarefas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvAniversariantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.CadetBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.AssessoriaToolStripMenuItem, Me.TarefasToolStripMenuItem, Me.RelatóriosToolStripMenuItem, Me.SairToolStripMenuItem, Me.TestesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1012, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SobreToolStripMenuItem.Image = CType(resources.GetObject("SobreToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManutençãoDeClientesToolStripMenuItem})
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ClientesToolStripMenuItem.Image = CType(resources.GetObject("ClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ManutençãoDeClientesToolStripMenuItem
        '
        Me.ManutençãoDeClientesToolStripMenuItem.Image = CType(resources.GetObject("ManutençãoDeClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ManutençãoDeClientesToolStripMenuItem.Name = "ManutençãoDeClientesToolStripMenuItem"
        Me.ManutençãoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ManutençãoDeClientesToolStripMenuItem.Text = "Manutenção de Clientes"
        '
        'AssessoriaToolStripMenuItem
        '
        Me.AssessoriaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControleDeClientesToolStripMenuItem})
        Me.AssessoriaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AssessoriaToolStripMenuItem.Image = CType(resources.GetObject("AssessoriaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AssessoriaToolStripMenuItem.Name = "AssessoriaToolStripMenuItem"
        Me.AssessoriaToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.AssessoriaToolStripMenuItem.Text = "Assessoria"
        '
        'ControleDeClientesToolStripMenuItem
        '
        Me.ControleDeClientesToolStripMenuItem.Image = CType(resources.GetObject("ControleDeClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ControleDeClientesToolStripMenuItem.Name = "ControleDeClientesToolStripMenuItem"
        Me.ControleDeClientesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ControleDeClientesToolStripMenuItem.Text = "Controle de Clientes"
        '
        'TarefasToolStripMenuItem
        '
        Me.TarefasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeTarefasToolStripMenuItem})
        Me.TarefasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TarefasToolStripMenuItem.Image = CType(resources.GetObject("TarefasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TarefasToolStripMenuItem.Name = "TarefasToolStripMenuItem"
        Me.TarefasToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.TarefasToolStripMenuItem.Text = "Tarefas"
        '
        'CadastroDeTarefasToolStripMenuItem
        '
        Me.CadastroDeTarefasToolStripMenuItem.Image = CType(resources.GetObject("CadastroDeTarefasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastroDeTarefasToolStripMenuItem.Name = "CadastroDeTarefasToolStripMenuItem"
        Me.CadastroDeTarefasToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CadastroDeTarefasToolStripMenuItem.Text = "Cadastro de Tarefas"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RelatóriosToolStripMenuItem.Image = CType(resources.GetObject("RelatóriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'TestesToolStripMenuItem
        '
        Me.TestesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaGeralDeClientesToolStripMenuItem, Me.ClientesToolStripMenuItem1, Me.TesteMemorandoToolStripMenuItem})
        Me.TestesToolStripMenuItem.Name = "TestesToolStripMenuItem"
        Me.TestesToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.TestesToolStripMenuItem.Text = "Testes"
        '
        'ConsultaGeralDeClientesToolStripMenuItem
        '
        Me.ConsultaGeralDeClientesToolStripMenuItem.Name = "ConsultaGeralDeClientesToolStripMenuItem"
        Me.ConsultaGeralDeClientesToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ConsultaGeralDeClientesToolStripMenuItem.Text = "Consulta Geral de Clientes"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(201, 22)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'TesteMemorandoToolStripMenuItem
        '
        Me.TesteMemorandoToolStripMenuItem.Name = "TesteMemorandoToolStripMenuItem"
        Me.TesteMemorandoToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.TesteMemorandoToolStripMenuItem.Text = "TesteMemorando"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1012, 79)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(269, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manutenção de Clientes"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1012, 27)
        Me.Panel2.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chbAtivo)
        Me.GroupBox1.Controls.Add(Me.btRecarregarTarefas)
        Me.GroupBox1.Controls.Add(Me.dgvTarefas)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbPesquisa)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(510, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 271)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Tarefas"
        '
        'chbAtivo
        '
        Me.chbAtivo.AutoSize = True
        Me.chbAtivo.Location = New System.Drawing.Point(286, 20)
        Me.chbAtivo.Name = "chbAtivo"
        Me.chbAtivo.Size = New System.Drawing.Size(58, 21)
        Me.chbAtivo.TabIndex = 5
        Me.chbAtivo.Text = "Ativo"
        Me.chbAtivo.UseVisualStyleBackColor = True
        '
        'btRecarregarTarefas
        '
        Me.btRecarregarTarefas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btRecarregarTarefas.FlatAppearance.BorderSize = 0
        Me.btRecarregarTarefas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btRecarregarTarefas.Image = CType(resources.GetObject("btRecarregarTarefas.Image"), System.Drawing.Image)
        Me.btRecarregarTarefas.Location = New System.Drawing.Point(416, 14)
        Me.btRecarregarTarefas.Name = "btRecarregarTarefas"
        Me.btRecarregarTarefas.Size = New System.Drawing.Size(28, 27)
        Me.btRecarregarTarefas.TabIndex = 4
        Me.btRecarregarTarefas.UseVisualStyleBackColor = True
        '
        'dgvTarefas
        '
        Me.dgvTarefas.BackgroundColor = System.Drawing.Color.White
        Me.dgvTarefas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTarefas.Location = New System.Drawing.Point(8, 46)
        Me.dgvTarefas.Name = "dgvTarefas"
        Me.dgvTarefas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTarefas.Size = New System.Drawing.Size(428, 216)
        Me.dgvTarefas.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Selecione a Atividade:"
        '
        'cbPesquisa
        '
        Me.cbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPesquisa.FormattingEnabled = True
        Me.cbPesquisa.Items.AddRange(New Object() {"<Selecione a Atividade>", "Ativo"})
        Me.cbPesquisa.Location = New System.Drawing.Point(7, 19)
        Me.cbPesquisa.Name = "cbPesquisa"
        Me.cbPesquisa.Size = New System.Drawing.Size(121, 25)
        Me.cbPesquisa.TabIndex = 0
        Me.cbPesquisa.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvAniversariantes)
        Me.GroupBox2.Controls.Add(Me.cmbMes)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(463, 265)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Aniversariantes"
        '
        'dgvAniversariantes
        '
        Me.dgvAniversariantes.BackgroundColor = System.Drawing.Color.White
        Me.dgvAniversariantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAniversariantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAniversariantes.Location = New System.Drawing.Point(6, 56)
        Me.dgvAniversariantes.Name = "dgvAniversariantes"
        Me.dgvAniversariantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAniversariantes.Size = New System.Drawing.Size(449, 200)
        Me.dgvAniversariantes.TabIndex = 2
        '
        'cmbMes
        '
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Items.AddRange(New Object() {"<Selecione o Mês>", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cmbMes.Location = New System.Drawing.Point(58, 25)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(158, 25)
        Me.cmbMes.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mês:"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1012, 566)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilidade"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvTarefas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvAniversariantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManutençãoDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TarefasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroDeTarefasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssessoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControleDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaGeralDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TesteMemorandoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTarefas As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btRecarregarTarefas As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvAniversariantes As System.Windows.Forms.DataGridView
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chbAtivo As System.Windows.Forms.CheckBox
    Friend WithEvents cbPesquisa As System.Windows.Forms.ComboBox

End Class
