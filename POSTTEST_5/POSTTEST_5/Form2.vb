Public Class FormHijab

    Private Sub TampilData()
        dgvHijab.DataSource = GetAllHijab()
    End Sub

    Private Sub Kosong()
        txtKode.Clear()
        txtNama.Clear()
        txtWarna.Clear()
        txtHarga.Clear()
        txtStok.Clear()
        txtSearch.Clear()
        cmbKategori.SelectedIndex = -1
    End Sub

    Private Sub FormHijab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If txtKode.Text.Trim = "" Then
            ErrorProvider1.SetError(txtKode, "Kode wajib diisi")
            txtKode.Focus()
            Exit Sub
        Else
            ErrorProvider1.SetError(txtKode, "")
        End If

        If txtNama.Text.Trim = "" Then
            ErrorProvider1.SetError(txtNama, "Nama wajib diisi")
            txtNama.Focus()
            Exit Sub
        Else
            ErrorProvider1.SetError(txtNama, "")
        End If

        If Not IsNumeric(txtHarga.Text) Then
            ErrorProvider1.SetError(txtHarga, "Harga harus angka")
            txtHarga.Focus()
            Exit Sub
        Else
            ErrorProvider1.SetError(txtHarga, "")
        End If

        If cmbKategori.Text = "" Then
            MessageBox.Show("Kategori wajib dipilih")
            cmbKategori.Focus()
            Exit Sub
        End If

        If CekKodeHijab(txtKode.Text) Then
            MessageBox.Show("Kode hijab sudah digunakan! Silakan gunakan kode lain.",
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKode.Focus()
            Exit Sub
        End If

        If SimpanHijab(txtKode.Text, txtNama.Text, cmbKategori.Text,
                   txtWarna.Text, txtHarga.Text, txtStok.Text) Then

            MessageBox.Show("Data berhasil disimpan")
            TampilData()
            Kosong()
        End If

    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If UbahHijab(txtKode.Text, txtNama.Text, cmbKategori.Text,
                     txtWarna.Text, txtHarga.Text, txtStok.Text) Then
            MessageBox.Show("Data berhasil diubah")
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Hapus data?", "Konfirmasi",
                                MessageBoxButtons.YesNo)

        If hasil = DialogResult.Yes Then
            If HapusHijab(txtKode.Text) Then
                MessageBox.Show("Data berhasil dihapus")
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
    End Sub

    Private Sub dgvHijab_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHijab.CellClick
        If e.RowIndex >= 0 Then
            txtKode.Text = dgvHijab.Rows(e.RowIndex).Cells(0).Value
            txtNama.Text = dgvHijab.Rows(e.RowIndex).Cells(1).Value
            cmbKategori.Text = dgvHijab.Rows(e.RowIndex).Cells(2).Value
            txtWarna.Text = dgvHijab.Rows(e.RowIndex).Cells(3).Value
            txtHarga.Text = dgvHijab.Rows(e.RowIndex).Cells(4).Value
            txtStok.Text = dgvHijab.Rows(e.RowIndex).Cells(5).Value
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            TampilData()
        Else
            dgvHijab.DataSource = SearchHijab(txtSearch.Text)
        End If
    End Sub

    Private Sub txtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKode.KeyPress
        WajibIsiKeyPress(txtKode, ErrorProvider1, "Kode wajib diisi")
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e, ErrorProvider1, txtNama, "Nama hanya huruf")
    End Sub

    Private Sub txtWarna_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWarna.KeyPress
        HanyaHuruf(e, ErrorProvider1, txtWarna, "Warna hanya huruf")
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        HanyaAngka(e, ErrorProvider1, txtHarga, "Harga hanya angka")
    End Sub

    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        HanyaAngka(e, ErrorProvider1, txtStok, "Stok hanya angka")
    End Sub

End Class