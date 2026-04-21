Imports MySqlConnector

Public Class FormTransaksi
    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadHijab()
        TampilData()
        dtTanggal.Value = DateTime.Now

    End Sub

    Private Sub LoadHijab()
        Dim dt As DataTable = GetAllHijab()
        cmbHijab.DataSource = dt
        cmbHijab.DisplayMember = "namaHijab"
        cmbHijab.ValueMember = "kodeHijab"
        cmbHijab.SelectedIndex = -1

    End Sub

    Private Sub TampilData()
        dgvTransaksi.DataSource = GetAllTransaksi()
        dgvTransaksi.Columns("tanggal").DefaultCellStyle.Format = "dd/MM/yyyy"
    End Sub

    Private Sub cmbHijab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHijab.SelectedIndexChanged

        If cmbHijab.SelectedIndex = -1 Then Exit Sub
        If cmbHijab.SelectedValue Is Nothing Then Exit Sub
        If TypeOf cmbHijab.SelectedValue Is DataRowView Then Exit Sub

        Dim query As String = "SELECT harga FROM tbhijab WHERE kodeHijab='" & cmbHijab.SelectedValue & "'"

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim cmd As New MySqlCommand(query, conn)
        Dim hasil = cmd.ExecuteScalar()

        If hasil IsNot Nothing Then
            txtHarga.Text = hasil.ToString()
        Else
            txtHarga.Text = ""
        End If

        conn.Close()
    End Sub

    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged

        If txtJumlah.Text <> "" And txtHarga.Text <> "" Then
            txtTotal.Text = Val(txtJumlah.Text) * Val(txtHarga.Text)
        End If

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If dtTanggal.Value = DateTime.MinValue Then
            MessageBox.Show("Tanggal tidak valid!")
            Exit Sub
        End If

        Dim tgl As Date = dtTanggal.Value.Date

        If txtJumlah.Text = "" Then
            MessageBox.Show("Jumlah harus diisi")
            Exit Sub
        End If

        If Not CekStok(cmbHijab.SelectedValue, Val(txtJumlah.Text)) Then
            MessageBox.Show("Stok tidak mencukupi!")
            Exit Sub
        End If

        If SimpanTransaksi(cmbHijab.SelectedValue, tgl, Val(txtJumlah.Text), Val(txtTotal.Text)) Then
            UpdateStok(cmbHijab.SelectedValue, Val(txtJumlah.Text))
            MessageBox.Show("Transaksi berhasil disimpan")
            TampilData()
        End If

    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        FormDashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If dgvTransaksi.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih data yang ingin dihapus!")
            Exit Sub
        End If

        Dim id As Integer = dgvTransaksi.CurrentRow.Cells("idTransaksi").Value

        Dim konfirmasi As DialogResult = MessageBox.Show("Yakin hapus data?", "Konfirmasi", MessageBoxButtons.YesNo)

        If konfirmasi = DialogResult.Yes Then
            If HapusTransaksi(id) Then
                MessageBox.Show("Data berhasil dihapus")
                TampilData()
            End If
        End If

    End Sub

    Private Sub Kosong()
        cmbHijab.SelectedIndex = -1
        txtHarga.Clear()
        txtJumlah.Clear()
        txtTotal.Clear()
        dtTanggal.Value = DateTime.Now
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
    End Sub

End Class