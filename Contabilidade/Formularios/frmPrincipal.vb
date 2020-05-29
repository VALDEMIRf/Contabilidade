Public Class frmPrincipal

    Private Sub ManutençãoDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManutençãoDeClientesToolStripMenuItem.Click
        Dim frmClientes As New frmClientes
        frmClientes.ShowDialog()
    End Sub

    Private Sub ConsultaGeralDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaGeralDeClientesToolStripMenuItem.Click
        Dim frmClienteConsultaGeral As New frmClienteConsultaGeral
        frmClienteConsultaGeral.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem1.Click
        Dim frmCliente As New frmClientesTeste
        frmCliente.ShowDialog()
    End Sub

    Private Sub TesteMemorandoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TesteMemorandoToolStripMenuItem.Click
        Dim frmMem As New frm_Memorando
        frmMem.ShowDialog()
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
