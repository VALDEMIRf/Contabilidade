<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Memorando
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.dgvTesteMemorando = New System.Windows.Forms.DataGridView()
        Me.btPesquisar = New System.Windows.Forms.Button()
        CType(Me.dgvTesteMemorando, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(441, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Obs:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(55, 19)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(42, 20)
        Me.txtCodigo.TabIndex = 2
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(476, 12)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(226, 92)
        Me.txtObs.TabIndex = 3
        '
        'dgvTesteMemorando
        '
        Me.dgvTesteMemorando.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTesteMemorando.Location = New System.Drawing.Point(15, 121)
        Me.dgvTesteMemorando.Name = "dgvTesteMemorando"
        Me.dgvTesteMemorando.Size = New System.Drawing.Size(895, 263)
        Me.dgvTesteMemorando.TabIndex = 4
        '
        'btPesquisar
        '
        Me.btPesquisar.Location = New System.Drawing.Point(195, 22)
        Me.btPesquisar.Name = "btPesquisar"
        Me.btPesquisar.Size = New System.Drawing.Size(75, 23)
        Me.btPesquisar.TabIndex = 5
        Me.btPesquisar.Text = "Pesquisar"
        Me.btPesquisar.UseVisualStyleBackColor = True
        '
        'frm_Memorando
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 396)
        Me.Controls.Add(Me.btPesquisar)
        Me.Controls.Add(Me.dgvTesteMemorando)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_Memorando"
        Me.Text = "frm_Memorando"
        CType(Me.dgvTesteMemorando, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents dgvTesteMemorando As System.Windows.Forms.DataGridView
    Friend WithEvents btPesquisar As System.Windows.Forms.Button
End Class
