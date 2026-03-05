Public Class Form1

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        TambahBuku(txtJudulTambah.Text, txtGenre.Text)
        txtJudulTambah.Clear()
        txtGenre.Clear()

        lblTotal.Text = "Total Buku : " & HitungJumlahBuku()
        TampilBuku()

    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status As Boolean

        HapusBuku(txtJudulHapus.Text, status)
        txtJudulHapus.Clear()
        txtGenre.Clear()

        lblTotal.Text = "Total Buku : " & HitungJumlahBuku()
        TampilBuku()

    End Sub

    Private Sub TampilBuku()
        lstBuku.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            lstBuku.Items.Add(daftarBuku(i))
        Next

    End Sub

End Class
