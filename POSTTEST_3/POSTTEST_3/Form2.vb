Public Class Form2
    Private Sub FormHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = nama
        lblUmur.Text = umur & " Tahun"
        lblNoTelp.Text = telepon
        lblAlamat.Text = alamat
        lblJK.Text = JK
        lblHobby.Text = hobby
        lblTanggalLahir.Text = tanggalLahir

        picProfilHasil.Image = foto
    End Sub
End Class