<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcessoriaConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcessoriaConsulta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btFechar = New System.Windows.Forms.Button()
        Me.btEnviarDados = New System.Windows.Forms.Button()
        Me.btPesquisarCliente = New System.Windows.Forms.Button()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtPesquisarCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.errErro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dgvGridAssessoria = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGridAssessoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btFechar)
        Me.GroupBox1.Controls.Add(Me.btEnviarDados)
        Me.GroupBox1.Controls.Add(Me.btPesquisarCliente)
        Me.GroupBox1.Controls.Add(Me.txtMes)
        Me.GroupBox1.Controls.Add(Me.txtAno)
        Me.GroupBox1.Controls.Add(Me.txtPesquisarCliente)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(706, 122)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Pesquisa"
        '
        'btFechar
        '
        Me.btFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFechar.FlatAppearance.BorderSize = 0
        Me.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFechar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Image = CType(resources.GetObject("btFechar.Image"), System.Drawing.Image)
        Me.btFechar.Location = New System.Drawing.Point(586, 29)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(94, 43)
        Me.btFechar.TabIndex = 8
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btFechar.UseVisualStyleBackColor = True
        '
        'btEnviarDados
        '
        Me.btEnviarDados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEnviarDados.FlatAppearance.BorderSize = 0
        Me.btEnviarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEnviarDados.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEnviarDados.Image = CType(resources.GetObject("btEnviarDados.Image"), System.Drawing.Image)
        Me.btEnviarDados.Location = New System.Drawing.Point(478, 19)
        Me.btEnviarDados.Name = "btEnviarDados"
        Me.btEnviarDados.Size = New System.Drawing.Size(102, 53)
        Me.btEnviarDados.TabIndex = 7
        Me.btEnviarDados.Text = "Enviar Dados"
        Me.btEnviarDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btEnviarDados.UseVisualStyleBackColor = True
        '
        'btPesquisarCliente
        '
        Me.btPesquisarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPesquisarCliente.FlatAppearance.BorderSize = 0
        Me.btPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPesquisarCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPesquisarCliente.Image = CType(resources.GetObject("btPesquisarCliente.Image"), System.Drawing.Image)
        Me.btPesquisarCliente.Location = New System.Drawing.Point(364, 26)
        Me.btPesquisarCliente.Name = "btPesquisarCliente"
        Me.btPesquisarCliente.Size = New System.Drawing.Size(108, 38)
        Me.btPesquisarCliente.TabIndex = 6
        Me.btPesquisarCliente.Text = "Pesquisar"
        Me.btPesquisarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPesquisarCliente.UseVisualStyleBackColor = True
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(42, 76)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(71, 20)
        Me.txtMes.TabIndex = 4
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(172, 74)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(50, 20)
        Me.txtAno.TabIndex = 5
        '
        'txtPesquisarCliente
        '
        Me.txtPesquisarCliente.Location = New System.Drawing.Point(67, 32)
        Me.txtPesquisarCliente.Name = "txtPesquisarCliente"
        Me.txtPesquisarCliente.Size = New System.Drawing.Size(291, 20)
        Me.txtPesquisarCliente.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(129, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ano:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mês:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        '
        'errErro
        '
        Me.errErro.ContainerControl = Me
        '
        'dgvGridAssessoria
        '
        Me.dgvGridAssessoria.BackgroundColor = System.Drawing.Color.White
        Me.dgvGridAssessoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGridAssessoria.Location = New System.Drawing.Point(8, 139)
        Me.dgvGridAssessoria.Name = "dgvGridAssessoria"
        Me.dgvGridAssessoria.Size = New System.Drawing.Size(707, 247)
        Me.dgvGridAssessoria.TabIndex = 1
        '
        'frmAcessoriaConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(721, 391)
        Me.Controls.Add(Me.dgvGridAssessoria)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAcessoriaConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Dados do Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGridAssessoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btFechar As System.Windows.Forms.Button
    Friend WithEvents btEnviarDados As System.Windows.Forms.Button
    Friend WithEvents btPesquisarCliente As System.Windows.Forms.Button
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents txtPesquisarCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents errErro As System.Windows.Forms.ErrorProvider
    Friend WithEvents dgvGridAssessoria As System.Windows.Forms.DataGridView
End Class
