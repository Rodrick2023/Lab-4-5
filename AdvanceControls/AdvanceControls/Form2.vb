Public Class frmCricket
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        txtPath.Text = TreeView1.SelectedNode.FullPath ' shows the full path of node
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ProgressBar1.Value = 1
        ProgressBar1.Maximum = 10000
        While ProgressBar1.Value <= ProgressBar1.Maximum - 1
            ProgressBar1.Value += 1
        End While
        Panel1.hide()
    End Sub

    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles TabPage1.Enter
        ProgressBar1.Value = 0
        Panel1.Show()
    End Sub

End Class