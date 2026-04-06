Public Class Form1

    'VALIDASI INPUT KARAKTER
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtIDAnggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDAnggota.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub mtxtNoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxtNoTelp.KeyPress
        HanyaAngka(e)
    End Sub


    'VALIDASI LANGSUNG
    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged
        ValidasiTextBox(ErrorProvider1, txtNama, "Nama tidak boleh kosong")
    End Sub

    Private Sub txtIDAnggota_TextChanged(sender As Object, e As EventArgs) Handles txtIDAnggota.TextChanged
        ValidasiTextBox(ErrorProvider1, txtIDAnggota, "ID tidak boleh kosong")
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        ValidasiTextBox(ErrorProvider1, txtEmail, "Email tidak boleh kosong")
    End Sub

    Private Sub txtAlamat_TextChanged(sender As Object, e As EventArgs) Handles txtAlamat.TextChanged
        ValidasiTextBox(ErrorProvider1, txtAlamat, "Alamat tidak boleh kosong")
    End Sub

    Private Sub mtxtNoTelp_TextChanged(sender As Object, e As EventArgs) Handles mtxtNoTelp.TextChanged
        ValidasiMaskedTextBox(ErrorProvider1, mtxtNoTelp, "Nomor HP belum lengkap")
    End Sub

    'Ambil data hobi dan jabatam
    Private Function AmbilHobi() As String
        Dim hasil As String = ""

        If cbCoding.Checked Then
            hasil = cbCoding.Text
        End If

        If cbDiving.Checked Then
            If hasil = "" Then
                hasil = cbDiving.Text
            Else
                hasil &= ", " & cbDiving.Text
            End If
        End If

        If cbFotografi.Checked Then
            If hasil = "" Then
                hasil = cbFotografi.Text
            Else
                hasil &= ", " & cbFotografi.Text
            End If
        End If

        If cbHiking.Checked Then
            If hasil = "" Then
                hasil = cbHiking.Text
            Else
                hasil &= ", " & cbHiking.Text
            End If
        End If

        If cbMancing.Checked Then
            If hasil = "" Then
                hasil = cbMancing.Text
            Else
                hasil &= ", " & cbMancing.Text
            End If
        End If

        If cbMenari.Checked Then
            If hasil = "" Then
                hasil = cbMenari.Text
            Else
                hasil &= ", " & cbMenari.Text
            End If
        End If

        If cbMenyanyi.Checked Then
            If hasil = "" Then
                hasil = cbMenyanyi.Text
            Else
                hasil &= ", " & cbMenyanyi.Text
            End If
        End If

        If cbRenang.Checked Then
            If hasil = "" Then
                hasil = cbRenang.Text
            Else
                hasil &= ", " & cbRenang.Text
            End If
        End If

        If cbTravel.Checked Then
            If hasil = "" Then
                hasil = cbTravel.Text
            Else
                hasil &= ", " & cbTravel.Text
            End If
        End If

        Return hasil
    End Function

    Private Function AmbilJabatan() As String
        If rbKetum.Checked Then
            Return rbKetum.Text
        ElseIf rbWaketum.Checked Then
            Return rbWaketum.Text
        ElseIf rbSekum.Checked Then
            Return rbSekum.Text
        ElseIf rbBendum.Checked Then
            Return rbBendum.Text
        ElseIf rbKediv.Checked Then
            Return rbKediv.Text
        ElseIf rbSekdiv.Checked Then
            Return rbSekdiv.Text
        ElseIf rbBendiv.Checked Then
            Return rbBendiv.Text
        ElseIf rbAnggota.Checked Then
            Return rbAnggota.Text
        End If

        Return ""
    End Function

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pbProfil.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If Not CekValidasi() Then
            MessageBox.Show("Lengkapi data terlebih dahulu!")
            Exit Sub
        End If

        TampilkanFormHasil()

    End Sub

    Private Function CekValidasi() As Boolean
        Return ValidasiSemuaInput(
            ErrorProvider1,
            txtNama,
            txtIDAnggota,
            mtxtNoTelp,
            txtEmail,
            txtAlamat,
            gbJabatan,
            gbJK,
            gbHobby,
            pbProfil
        )
    End Function

    Private Sub menuLihat_Click(sender As Object, e As EventArgs) Handles menuLihatKartu.Click
        If Not CekValidasi() Then
            MessageBox.Show(
                "Lengkapi data terlebih dahulu!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Exit Sub
        End If
        TampilkanFormHasil()
    End Sub

    Private Sub menuSimpan_Click(sender As Object, e As EventArgs) Handles menuSimpanData.Click
        If Not CekValidasi() Then
            MessageBox.Show(
                "Lengkapi data!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Apakah data ingin disimpan?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )
        If konfirmasi = DialogResult.No Then Exit Sub

        Dim isi As String = BuatIsiData()
        If SimpanDataKeFile(SaveFileDialog1, isi, "data.txt") Then
            MessageBox.Show(
                "Data berhasil disimpan",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
        End If
    End Sub

    Private Sub menuBuka_Click(sender As Object, e As EventArgs) Handles menuBukaData.Click
        Dim data = BukaDataDariFile(OpenFileDialog1)
        If data Is Nothing Then Exit Sub

        IsiForm(data)
        MessageBox.Show(
            "Data berhasil dibuka",
            "Informasi",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
    End Sub

    Private Sub menuKeluar_Click(sender As Object, e As EventArgs) Handles menuKeluar.Click
        Dim hasil As DialogResult = MessageBox.Show(
            "Apakah yakin ingin keluar?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )
        If hasil = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub TampilkanFormHasil()
        FormHasil.SetData(
        txtNama.Text,
        txtIDAnggota.Text,
        AmbilJabatan(),
        mtxtNoTelp.Text,
        AmbilHobi(),
        pbProfil.Image
    )
        FormHasil.Show()
    End Sub

    Private Function BuatIsiData() As String
        Dim jk As String = If(rbtnLaki.Checked, "Laki-laki", "Perempuan")
        Return BuatIsiFile(
            txtNama.Text,
            txtIDAnggota.Text,
            dtpTanggalLahir.Text,
            jk,
            AmbilJabatan(),
            mtxtNoTelp.Text,
            txtEmail.Text,
            txtAlamat.Text,
            AmbilHobi()
        )
    End Function

    Private Sub IsiForm(data As Dictionary(Of String, String))
        txtNama.Text = AmbilNilai(data, "Nama")
        txtIDAnggota.Text = AmbilNilai(data, "ID")
        dtpTanggalLahir.Text = AmbilNilai(data, "TanggalLahir")
        mtxtNoTelp.Text = AmbilNilai(data, "NoHP")
        txtEmail.Text = AmbilNilai(data, "Email")
        txtAlamat.Text = AmbilNilai(data, "Alamat")

        Dim jabatan As String = AmbilNilai(data, "Jabatan")
        For Each c As Control In gbJabatan.Controls
            If TypeOf c Is RadioButton AndAlso c.Text = jabatan Then
                DirectCast(c, RadioButton).Checked = True
            End If
        Next

        Dim jk = AmbilNilai(data, "JenisKelamin")
        If jk = "Laki-laki" Then
            rbtnLaki.Checked = True
        ElseIf jk = "Perempuan" Then
            rbtnPerempuan.Checked = True
        End If
    End Sub

End Class