<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVinculadoCadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVinculadoCadastro))
        Me.errErro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRecebeIDClienteVinculo = New System.Windows.Forms.Label()
        Me.txtNomeVinculado = New System.Windows.Forms.TextBox()
        Me.txtTipoVinculo = New System.Windows.Forms.TextBox()
        Me.txtCPFVinculado = New System.Windows.Forms.MaskedTextBox()
        Me.btSair = New System.Windows.Forms.Button()
        Me.btGravar = New System.Windows.Forms.Button()
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'errErro
        '
        Me.errErro.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCPFVinculado)
        Me.GroupBox1.Controls.Add(Me.txtTipoVinculo)
        Me.GroupBox1.Controls.Add(Me.txtNomeVinculado)
        Me.GroupBox1.Controls.Add(Me.lblRecebeIDClienteVinculo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 153)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cadastro de Pessoa Vinculada ao Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do Vinculado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CPF:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo de Vínculo:"
        '
        'lblRecebeIDClienteVinculo
        '
        Me.lblRecebeIDClienteVinculo.AutoSize = True
        Me.lblRecebeIDClienteVinculo.Location = New System.Drawing.Point(488, 22)
        Me.lblRecebeIDClienteVinculo.Name = "lblRecebeIDClienteVinculo"
        Me.lblRecebeIDClienteVinculo.Size = New System.Drawing.Size(17, 18)
        Me.lblRecebeIDClienteVinculo.TabIndex = 3
        Me.lblRecebeIDClienteVinculo.Text = "0"
        '
        'txtNomeVinculado
        '
        Me.txtNomeVinculado.Location = New System.Drawing.Point(163, 33)
        Me.txtNomeVinculado.Name = "txtNomeVinculado"
        Me.txtNomeVinculado.Size = New System.Drawing.Size(315, 26)
        Me.txtNomeVinculado.TabIndex = 4
        '
        'txtTipoVinculo
        '
        Me.txtTipoVinculo.Location = New System.Drawing.Point(163, 118)
        Me.txtTipoVinculo.Name = "txtTipoVinculo"
        Me.txtTipoVinculo.Size = New System.Drawing.Size(315, 26)
        Me.txtTipoVinculo.TabIndex = 6
        '
        'txtCPFVinculado
        '
        Me.txtCPFVinculado.Location = New System.Drawing.Point(163, 70)
        Me.txtCPFVinculado.Mask = "000.000.000-00"
        Me.txtCPFVinculado.Name = "txtCPFVinculado"
        Me.txtCPFVinculado.Size = New System.Drawing.Size(129, 26)
        Me.txtCPFVinculado.TabIndex = 7
        '
        'btSair
        '
        Me.btSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSair.FlatAppearance.BorderSize = 0
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = CType(resources.GetObject("btSair.Image"), System.Drawing.Image)
        Me.btSair.Location = New System.Drawing.Point(344, 171)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(74, 46)
        Me.btSair.TabIndex = 1
        Me.btSair.Text = "Sair"
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'btGravar
        '
        Me.btGravar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btGravar.FlatAppearance.BorderSize = 0
        Me.btGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGravar.Image = CType(resources.GetObject("btGravar.Image"), System.Drawing.Image)
        Me.btGravar.Location = New System.Drawing.Point(437, 171)
        Me.btGravar.Name = "btGravar"
        Me.btGravar.Size = New System.Drawing.Size(80, 46)
        Me.btGravar.TabIndex = 2
        Me.btGravar.Text = "Gravar"
        Me.btGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btGravar.UseVisualStyleBackColor = True
        '
        'frmVinculadoCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(524, 222)
        Me.Controls.Add(Me.btGravar)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVinculadoCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Pessoas Vinculadas ao Cliente"
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents errErro As System.Windows.Forms.ErrorProvider
    Friend WithEvents btGravar As System.Windows.Forms.Button
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCPFVinculado As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTipoVinculo As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeVinculado As System.Windows.Forms.TextBox
    Friend WithEvents lblRecebeIDClienteVinculo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
