Public Class frmAdvanceControls
    Private Sub CricketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CricketToolStripMenuItem.Click
        frmCricket.Show()
    End Sub

    Private Sub frmAdvanceControls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TSSLblDateTime.Text = System.DateTime.Now ' displays date and time on status bar
    End Sub
End Class
