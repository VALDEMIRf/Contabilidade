﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarefasCadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTarefasCadastro))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDtConclusao = New System.Windows.Forms.MaskedTextBox()
        Me.lblRecebeIDTarefa = New System.Windows.Forms.Label()
        Me.btPesquisar = New System.Windows.Forms.Button()
        Me.txtDtCadastro = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chbAtivo = New System.Windows.Forms.CheckBox()
        Me.txtResponsavel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTarefa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btAlterarTarefa = New System.Windows.Forms.Button()
        Me.btGravar = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDtConclusao)
        Me.GroupBox1.Controls.Add(Me.lblRecebeIDTarefa)
        Me.GroupBox1.Controls.Add(Me.btPesquisar)
        Me.GroupBox1.Controls.Add(Me.txtDtCadastro)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.chbAtivo)
        Me.GroupBox1.Controls.Add(Me.txtResponsavel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtObs)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTarefa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(691, 251)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Descrição da Tarefa"
        '
        'txtDtConclusao
        '
        Me.txtDtConclusao.Location = New System.Drawing.Point(492, 203)
        Me.txtDtConclusao.Mask = "00/00/0000"
        Me.txtDtConclusao.Name = "txtDtConclusao"
        Me.txtDtConclusao.Size = New System.Drawing.Size(100, 22)
        Me.txtDtConclusao.TabIndex = 12
        Me.txtDtConclusao.ValidatingType = GetType(Date)
        '
        'lblRecebeIDTarefa
        '
        Me.lblRecebeIDTarefa.AutoSize = True
        Me.lblRecebeIDTarefa.Location = New System.Drawing.Point(647, 146)
        Me.lblRecebeIDTarefa.Name = "lblRecebeIDTarefa"
        Me.lblRecebeIDTarefa.Size = New System.Drawing.Size(15, 16)
        Me.lblRecebeIDTarefa.TabIndex = 11
        Me.lblRecebeIDTarefa.Text = "0"
        '
        'btPesquisar
        '
        Me.btPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPesquisar.FlatAppearance.BorderSize = 0
        Me.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPesquisar.Image = CType(resources.GetObject("btPesquisar.Image"), System.Drawing.Image)
        Me.btPesquisar.Location = New System.Drawing.Point(569, 49)
        Me.btPesquisar.Name = "btPesquisar"
        Me.btPesquisar.Size = New System.Drawing.Size(106, 46)
        Me.btPesquisar.TabIndex = 3
        Me.btPesquisar.Text = "Pesquisar"
        Me.btPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPesquisar.UseVisualStyleBackColor = True
        '
        'txtDtCadastro
        '
        Me.txtDtCadastro.Location = New System.Drawing.Point(127, 200)
        Me.txtDtCadastro.Mask = "00/00/0000"
        Me.txtDtCadastro.Name = "txtDtCadastro"
        Me.txtDtCadastro.Size = New System.Drawing.Size(79, 22)
        Me.txtDtCadastro.TabIndex = 9
        Me.txtDtCadastro.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 203)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Data de Cadastro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(365, 206)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Data de Conclusão:"
        '
        'chbAtivo
        '
        Me.chbAtivo.AutoSize = True
        Me.chbAtivo.Location = New System.Drawing.Point(371, 166)
        Me.chbAtivo.Name = "chbAtivo"
        Me.chbAtivo.Size = New System.Drawing.Size(55, 20)
        Me.chbAtivo.TabIndex = 6
        Me.chbAtivo.Text = "Ativo"
        Me.chbAtivo.UseVisualStyleBackColor = True
        '
        'txtResponsavel
        '
        Me.txtResponsavel.Location = New System.Drawing.Point(94, 162)
        Me.txtResponsavel.Name = "txtResponsavel"
        Me.txtResponsavel.Size = New System.Drawing.Size(183, 22)
        Me.txtResponsavel.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Responsável:"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(243, 48)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(309, 91)
        Me.txtObs.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Observações:"
        '
        'txtTarefa
        '
        Me.txtTarefa.Location = New System.Drawing.Point(5, 49)
        Me.txtTarefa.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtTarefa.Multiline = True
        Me.txtTarefa.Name = "txtTarefa"
        Me.txtTarefa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTarefa.Size = New System.Drawing.Size(216, 90)
        Me.txtTarefa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tarefa:"
        '
        'btAlterarTarefa
        '
        Me.btAlterarTarefa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAlterarTarefa.FlatAppearance.BorderSize = 0
        Me.btAlterarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAlterarTarefa.Image = CType(resources.GetObject("btAlterarTarefa.Image"), System.Drawing.Image)
        Me.btAlterarTarefa.Location = New System.Drawing.Point(375, 276)
        Me.btAlterarTarefa.Name = "btAlterarTarefa"
        Me.btAlterarTarefa.Size = New System.Drawing.Size(121, 64)
        Me.btAlterarTarefa.TabIndex = 2
        Me.btAlterarTarefa.Text = "Alterar Tarefa"
        Me.btAlterarTarefa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btAlterarTarefa.UseVisualStyleBackColor = True
        '
        'btGravar
        '
        Me.btGravar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btGravar.FlatAppearance.BorderSize = 0
        Me.btGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGravar.Image = CType(resources.GetObject("btGravar.Image"), System.Drawing.Image)
        Me.btGravar.Location = New System.Drawing.Point(488, 281)
        Me.btGravar.Name = "btGravar"
        Me.btGravar.Size = New System.Drawing.Size(113, 55)
        Me.btGravar.TabIndex = 4
        Me.btGravar.Text = "Salvar Tarefa"
        Me.btGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btGravar.UseVisualStyleBackColor = True
        '
        'btSair
        '
        Me.btSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSair.FlatAppearance.BorderSize = 0
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = CType(resources.GetObject("btSair.Image"), System.Drawing.Image)
        Me.btSair.Location = New System.Drawing.Point(607, 281)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(91, 51)
        Me.btSair.TabIndex = 5
        Me.btSair.Text = "Sair"
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'frmTarefasCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(711, 393)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.btGravar)
        Me.Controls.Add(Me.btAlterarTarefa)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmTarefasCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Tarefas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTarefa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDtCadastro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chbAtivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtResponsavel As System.Windows.Forms.TextBox
    Friend WithEvents btAlterarTarefa As System.Windows.Forms.Button
    Friend WithEvents btPesquisar As System.Windows.Forms.Button
    Friend WithEvents btGravar As System.Windows.Forms.Button
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents lblRecebeIDTarefa As System.Windows.Forms.Label
    Friend WithEvents txtDtConclusao As System.Windows.Forms.MaskedTextBox
End Class
