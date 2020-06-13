<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarefaConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTarefaConsulta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.dgdGrid = New System.Windows.Forms.DataGridView()
        Me.btPesquisar = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.btEnviarDados = New System.Windows.Forms.Button()
        CType(Me.dgdGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(91, 20)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(267, 20)
        Me.txtDescricao.TabIndex = 1
        '
        'dgdGrid
        '
        Me.dgdGrid.BackgroundColor = System.Drawing.Color.White
        Me.dgdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdGrid.Location = New System.Drawing.Point(9, 64)
        Me.dgdGrid.Name = "dgdGrid"
        Me.dgdGrid.Size = New System.Drawing.Size(470, 220)
        Me.dgdGrid.TabIndex = 2
        '
        'btPesquisar
        '
        Me.btPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPesquisar.FlatAppearance.BorderSize = 0
        Me.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPesquisar.Image = CType(resources.GetObject("btPesquisar.Image"), System.Drawing.Image)
        Me.btPesquisar.Location = New System.Drawing.Point(380, 12)
        Me.btPesquisar.Name = "btPesquisar"
        Me.btPesquisar.Size = New System.Drawing.Size(98, 40)
        Me.btPesquisar.TabIndex = 3
        Me.btPesquisar.Text = "Pesquisar"
        Me.btPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPesquisar.UseVisualStyleBackColor = True
        '
        'btNovo
        '
        Me.btNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNovo.FlatAppearance.BorderSize = 0
        Me.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNovo.Image = CType(resources.GetObject("btNovo.Image"), System.Drawing.Image)
        Me.btNovo.Location = New System.Drawing.Point(313, 290)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(90, 57)
        Me.btNovo.TabIndex = 6
        Me.btNovo.Text = "Novo"
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btNovo.UseVisualStyleBackColor = True
        '
        'btSair
        '
        Me.btSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSair.FlatAppearance.BorderSize = 0
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = CType(resources.GetObject("btSair.Image"), System.Drawing.Image)
        Me.btSair.Location = New System.Drawing.Point(409, 296)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(70, 44)
        Me.btSair.TabIndex = 7
        Me.btSair.Text = "Sair"
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'btEnviarDados
        '
        Me.btEnviarDados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEnviarDados.FlatAppearance.BorderSize = 0
        Me.btEnviarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEnviarDados.Image = CType(resources.GetObject("btEnviarDados.Image"), System.Drawing.Image)
        Me.btEnviarDados.Location = New System.Drawing.Point(203, 297)
        Me.btEnviarDados.Name = "btEnviarDados"
        Me.btEnviarDados.Size = New System.Drawing.Size(104, 50)
        Me.btEnviarDados.TabIndex = 8
        Me.btEnviarDados.Text = "Enviar Dados"
        Me.btEnviarDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btEnviarDados.UseVisualStyleBackColor = True
        '
        'frmTarefaConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(487, 361)
        Me.Controls.Add(Me.btEnviarDados)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.btPesquisar)
        Me.Controls.Add(Me.dgdGrid)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTarefaConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Tarefas"
        CType(Me.dgdGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents dgdGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btPesquisar As System.Windows.Forms.Button
    Friend WithEvents btNovo As System.Windows.Forms.Button
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents btEnviarDados As System.Windows.Forms.Button
End Class
