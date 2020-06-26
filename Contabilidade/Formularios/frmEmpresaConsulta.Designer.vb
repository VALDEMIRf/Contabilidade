<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpresaConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpresaConsulta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btRecarregarDados = New System.Windows.Forms.Button()
        Me.txtPesquisarNomeEmpresa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btFecharEmpresa = New System.Windows.Forms.Button()
        Me.btEnviarDadosEmpresa = New System.Windows.Forms.Button()
        Me.btPesquisaEmpresa = New System.Windows.Forms.Button()
        Me.txtCPFConsulta = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvGridEmpresa = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvGridEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btRecarregarDados)
        Me.GroupBox1.Controls.Add(Me.txtPesquisarNomeEmpresa)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btFecharEmpresa)
        Me.GroupBox1.Controls.Add(Me.btEnviarDadosEmpresa)
        Me.GroupBox1.Controls.Add(Me.btPesquisaEmpresa)
        Me.GroupBox1.Controls.Add(Me.txtCPFConsulta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(870, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Pesquisa"
        '
        'btRecarregarDados
        '
        Me.btRecarregarDados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btRecarregarDados.FlatAppearance.BorderSize = 0
        Me.btRecarregarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btRecarregarDados.Image = CType(resources.GetObject("btRecarregarDados.Image"), System.Drawing.Image)
        Me.btRecarregarDados.Location = New System.Drawing.Point(216, 26)
        Me.btRecarregarDados.Name = "btRecarregarDados"
        Me.btRecarregarDados.Size = New System.Drawing.Size(151, 57)
        Me.btRecarregarDados.TabIndex = 7
        Me.btRecarregarDados.Text = "Recarregar Dados"
        Me.btRecarregarDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btRecarregarDados.UseVisualStyleBackColor = True
        '
        'txtPesquisarNomeEmpresa
        '
        Me.txtPesquisarNomeEmpresa.Location = New System.Drawing.Point(6, 48)
        Me.txtPesquisarNomeEmpresa.Name = "txtPesquisarNomeEmpresa"
        Me.txtPesquisarNomeEmpresa.Size = New System.Drawing.Size(206, 26)
        Me.txtPesquisarNomeEmpresa.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Pesquisa por Nome:"
        '
        'btFecharEmpresa
        '
        Me.btFecharEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFecharEmpresa.FlatAppearance.BorderSize = 0
        Me.btFecharEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFecharEmpresa.Image = CType(resources.GetObject("btFecharEmpresa.Image"), System.Drawing.Image)
        Me.btFecharEmpresa.Location = New System.Drawing.Point(760, 26)
        Me.btFecharEmpresa.Name = "btFecharEmpresa"
        Me.btFecharEmpresa.Size = New System.Drawing.Size(104, 49)
        Me.btFecharEmpresa.TabIndex = 4
        Me.btFecharEmpresa.Text = "Fechar"
        Me.btFecharEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btFecharEmpresa.UseVisualStyleBackColor = True
        '
        'btEnviarDadosEmpresa
        '
        Me.btEnviarDadosEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEnviarDadosEmpresa.FlatAppearance.BorderSize = 0
        Me.btEnviarDadosEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEnviarDadosEmpresa.Image = CType(resources.GetObject("btEnviarDadosEmpresa.Image"), System.Drawing.Image)
        Me.btEnviarDadosEmpresa.Location = New System.Drawing.Point(643, 24)
        Me.btEnviarDadosEmpresa.Name = "btEnviarDadosEmpresa"
        Me.btEnviarDadosEmpresa.Size = New System.Drawing.Size(117, 52)
        Me.btEnviarDadosEmpresa.TabIndex = 3
        Me.btEnviarDadosEmpresa.Text = "Enviar Dados"
        Me.btEnviarDadosEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btEnviarDadosEmpresa.UseVisualStyleBackColor = True
        '
        'btPesquisaEmpresa
        '
        Me.btPesquisaEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPesquisaEmpresa.FlatAppearance.BorderSize = 0
        Me.btPesquisaEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPesquisaEmpresa.Image = CType(resources.GetObject("btPesquisaEmpresa.Image"), System.Drawing.Image)
        Me.btPesquisaEmpresa.Location = New System.Drawing.Point(528, 25)
        Me.btPesquisaEmpresa.Name = "btPesquisaEmpresa"
        Me.btPesquisaEmpresa.Size = New System.Drawing.Size(120, 48)
        Me.btPesquisaEmpresa.TabIndex = 2
        Me.btPesquisaEmpresa.Text = "Pesquisar"
        Me.btPesquisaEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPesquisaEmpresa.UseVisualStyleBackColor = True
        '
        'txtCPFConsulta
        '
        Me.txtCPFConsulta.Location = New System.Drawing.Point(397, 49)
        Me.txtCPFConsulta.Mask = "000.000.000-00"
        Me.txtCPFConsulta.Name = "txtCPFConsulta"
        Me.txtCPFConsulta.Size = New System.Drawing.Size(122, 26)
        Me.txtCPFConsulta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(385, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pesquisa por CPF:"
        '
        'dgvGridEmpresa
        '
        Me.dgvGridEmpresa.BackgroundColor = System.Drawing.Color.White
        Me.dgvGridEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGridEmpresa.Location = New System.Drawing.Point(10, 109)
        Me.dgvGridEmpresa.Name = "dgvGridEmpresa"
        Me.dgvGridEmpresa.Size = New System.Drawing.Size(872, 290)
        Me.dgvGridEmpresa.TabIndex = 1
        '
        'frmEmpresaConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(894, 411)
        Me.Controls.Add(Me.dgvGridEmpresa)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEmpresaConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Clientes com Empresa "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvGridEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btFecharEmpresa As System.Windows.Forms.Button
    Friend WithEvents btEnviarDadosEmpresa As System.Windows.Forms.Button
    Friend WithEvents btPesquisaEmpresa As System.Windows.Forms.Button
    Friend WithEvents txtCPFConsulta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvGridEmpresa As System.Windows.Forms.DataGridView
    Friend WithEvents btRecarregarDados As System.Windows.Forms.Button
    Friend WithEvents txtPesquisarNomeEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
