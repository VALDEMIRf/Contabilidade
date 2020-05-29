<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteConsultaGeral
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
        Me.dgvClientesGeral = New System.Windows.Forms.DataGridView()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        CType(Me.dgvClientesGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClientesGeral
        '
        Me.dgvClientesGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientesGeral.Location = New System.Drawing.Point(3, 12)
        Me.dgvClientesGeral.Name = "dgvClientesGeral"
        Me.dgvClientesGeral.Size = New System.Drawing.Size(802, 205)
        Me.dgvClientesGeral.TabIndex = 0
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(282, 292)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisar.TabIndex = 1
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'txtPesquisa
        '
        Me.txtPesquisa.Location = New System.Drawing.Point(13, 294)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(263, 20)
        Me.txtPesquisa.TabIndex = 2
        '
        'frmClienteConsultaGeral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 326)
        Me.Controls.Add(Me.txtPesquisa)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.dgvClientesGeral)
        Me.Name = "frmClienteConsultaGeral"
        Me.Text = "frmClienteConsultaGeral"
        CType(Me.dgvClientesGeral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvClientesGeral As System.Windows.Forms.DataGridView
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents txtPesquisa As System.Windows.Forms.TextBox
End Class
