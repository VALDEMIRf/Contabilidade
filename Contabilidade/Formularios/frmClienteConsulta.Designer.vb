<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClienteConsulta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomePesquisar = New System.Windows.Forms.TextBox()
        Me.btFechar = New System.Windows.Forms.Button()
        Me.btEnviarDados = New System.Windows.Forms.Button()
        Me.btPesquisaCliente = New System.Windows.Forms.Button()
        Me.txtCPFPesquisa = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvGrid = New System.Windows.Forms.DataGridView()
        Me.btRecarregar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btRecarregar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNomePesquisar)
        Me.GroupBox1.Controls.Add(Me.btFechar)
        Me.GroupBox1.Controls.Add(Me.btEnviarDados)
        Me.GroupBox1.Controls.Add(Me.btPesquisaCliente)
        Me.GroupBox1.Controls.Add(Me.txtCPFPesquisa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(870, 90)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Pesquisa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Pesquisar por Nome:"
        '
        'txtNomePesquisar
        '
        Me.txtNomePesquisar.Location = New System.Drawing.Point(15, 49)
        Me.txtNomePesquisar.Name = "txtNomePesquisar"
        Me.txtNomePesquisar.Size = New System.Drawing.Size(208, 26)
        Me.txtNomePesquisar.TabIndex = 5
        '
        'btFechar
        '
        Me.btFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFechar.FlatAppearance.BorderSize = 0
        Me.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFechar.Image = CType(resources.GetObject("btFechar.Image"), System.Drawing.Image)
        Me.btFechar.Location = New System.Drawing.Point(768, 25)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(93, 46)
        Me.btFechar.TabIndex = 4
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btFechar.UseVisualStyleBackColor = True
        '
        'btEnviarDados
        '
        Me.btEnviarDados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEnviarDados.FlatAppearance.BorderSize = 0
        Me.btEnviarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEnviarDados.Image = CType(resources.GetObject("btEnviarDados.Image"), System.Drawing.Image)
        Me.btEnviarDados.Location = New System.Drawing.Point(654, 22)
        Me.btEnviarDados.Name = "btEnviarDados"
        Me.btEnviarDados.Size = New System.Drawing.Size(108, 49)
        Me.btEnviarDados.TabIndex = 3
        Me.btEnviarDados.Text = "Enviar Dados"
        Me.btEnviarDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btEnviarDados.UseVisualStyleBackColor = True
        '
        'btPesquisaCliente
        '
        Me.btPesquisaCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPesquisaCliente.FlatAppearance.BorderSize = 0
        Me.btPesquisaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPesquisaCliente.Image = CType(resources.GetObject("btPesquisaCliente.Image"), System.Drawing.Image)
        Me.btPesquisaCliente.Location = New System.Drawing.Point(513, 25)
        Me.btPesquisaCliente.Name = "btPesquisaCliente"
        Me.btPesquisaCliente.Size = New System.Drawing.Size(111, 46)
        Me.btPesquisaCliente.TabIndex = 2
        Me.btPesquisaCliente.Text = "Pesquisar"
        Me.btPesquisaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPesquisaCliente.UseVisualStyleBackColor = True
        '
        'txtCPFPesquisa
        '
        Me.txtCPFPesquisa.Location = New System.Drawing.Point(378, 49)
        Me.txtCPFPesquisa.Mask = "000.000.000-00"
        Me.txtCPFPesquisa.Name = "txtCPFPesquisa"
        Me.txtCPFPesquisa.Size = New System.Drawing.Size(100, 26)
        Me.txtCPFPesquisa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(374, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pesquisar por CPF:"
        '
        'dgvGrid
        '
        Me.dgvGrid.BackgroundColor = System.Drawing.Color.White
        Me.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrid.GridColor = System.Drawing.Color.DarkGray
        Me.dgvGrid.Location = New System.Drawing.Point(12, 108)
        Me.dgvGrid.Name = "dgvGrid"
        Me.dgvGrid.Size = New System.Drawing.Size(870, 300)
        Me.dgvGrid.TabIndex = 1
        '
        'btRecarregar
        '
        Me.btRecarregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btRecarregar.FlatAppearance.BorderSize = 0
        Me.btRecarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btRecarregar.Image = CType(resources.GetObject("btRecarregar.Image"), System.Drawing.Image)
        Me.btRecarregar.Location = New System.Drawing.Point(229, 25)
        Me.btRecarregar.Name = "btRecarregar"
        Me.btRecarregar.Size = New System.Drawing.Size(139, 59)
        Me.btRecarregar.TabIndex = 7
        Me.btRecarregar.Text = "Recarregar"
        Me.btRecarregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btRecarregar.UseVisualStyleBackColor = True
        '
        'frmClienteConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(894, 411)
        Me.Controls.Add(Me.dgvGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmClienteConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btFechar As System.Windows.Forms.Button
    Friend WithEvents btEnviarDados As System.Windows.Forms.Button
    Friend WithEvents btPesquisaCliente As System.Windows.Forms.Button
    Friend WithEvents txtCPFPesquisa As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvGrid As System.Windows.Forms.DataGridView
    Friend WithEvents txtNomePesquisar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btRecarregar As System.Windows.Forms.Button
End Class
