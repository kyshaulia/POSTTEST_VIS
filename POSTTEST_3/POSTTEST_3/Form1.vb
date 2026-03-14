Public Class Form1
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFile As New OpenFileDialog
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openFile.ShowDialog = DialogResult.OK Then
            pictureProfil.Image = Image.FromFile(openFile.FileName)
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        'error handling textbox
        If txtNama.Text = "" Or txtUmur.Text = "" Or txtNoTelp.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        'error handling radio button
        If rbtnLaki.Checked = False And rbtnPerempuan.Checked = False Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        'error handling checkbox
        If Not cbMembaca.Checked And
           Not cbOlahraga.Checked And
           Not cbCoding.Checked And
           Not cbGaming.Checked And
           Not cbTravel.Checked And
           Not cbMemancing.Checked And
           Not cbMenulis.Checked And
           Not cbMenari.Checked And
           Not cbMenggambar.Checked And
           Not cbMenyanyi.Checked Then

            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If


        'nyimpan
        nama = txtNama.Text
        umur = txtUmur.Text
        telepon = txtNoTelp.Text
        alamat = txtAlamat.Text
        tanggalLahir = dtpTanggalLahir.Text
        foto = pictureProfil.Image

        'JK
        If rbtnLaki.Checked Then
            JK = "Laki-Laki"
        Else
            JK = "Perempuan"
        End If


        'hobby
        hobby = ""

        If cbMembaca.Checked Then hobby &= "Membaca, "
        If cbOlahraga.Checked Then hobby &= "Olahraga, "
        If cbCoding.Checked Then hobby &= "Coding, "
        If cbGaming.Checked Then hobby &= "Gaming, "
        If cbTravel.Checked Then hobby &= "Travel, "
        If cbMemancing.Checked Then hobby &= "Memancing, "
        If cbMenulis.Checked Then hobby &= "Menulis, "
        If cbMenari.Checked Then hobby &= "Menari, "
        If cbMenggambar.Checked Then hobby &= "Menggambar, "
        If cbMenyanyi.Checked Then hobby &= "Menyanyi, "

        Form2.Show()

    End Sub

    'hanya huruf (nama)
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    'hanya angka (umur)
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'hanya angka (no.telp)
    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelp.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class
