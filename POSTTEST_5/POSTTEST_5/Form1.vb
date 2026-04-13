Public Class FormDashboard
    Private Sub DataHijabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuDataHIjab.Click
        FormHijab.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuKeluar.Click
        Me.Close()
    End Sub
End Class
