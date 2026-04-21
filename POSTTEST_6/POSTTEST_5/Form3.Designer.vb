<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransaksi))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        cmbHijab = New ComboBox()
        txtHarga = New TextBox()
        txtJumlah = New TextBox()
        txtTotal = New TextBox()
        GroupBox1 = New GroupBox()
        Label5 = New Label()
        dtTanggal = New DateTimePicker()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        btnSimpan = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvTransaksi = New DataGridView()
        btnKembali = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTransaksi, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(37, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 0
        Label1.Text = "Hijab :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(37, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 15)
        Label2.TabIndex = 1
        Label2.Text = "Harga :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(37, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 15)
        Label3.TabIndex = 2
        Label3.Text = "Jumlah :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(37, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 15)
        Label4.TabIndex = 3
        Label4.Text = "Total :"
        ' 
        ' cmbHijab
        ' 
        cmbHijab.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbHijab.FormattingEnabled = True
        cmbHijab.Location = New Point(109, 40)
        cmbHijab.Name = "cmbHijab"
        cmbHijab.Size = New Size(200, 23)
        cmbHijab.TabIndex = 4
        cmbHijab.Text = "-- Pilih Hijab --"
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(109, 84)
        txtHarga.Name = "txtHarga"
        txtHarga.PlaceholderText = " Rp 0"
        txtHarga.Size = New Size(200, 23)
        txtHarga.TabIndex = 5
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Location = New Point(109, 128)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.PlaceholderText = " 0"
        txtJumlah.Size = New Size(200, 23)
        txtJumlah.TabIndex = 6
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(109, 175)
        txtTotal.Name = "txtTotal"
        txtTotal.PlaceholderText = " Rp 0"
        txtTotal.Size = New Size(200, 23)
        txtTotal.TabIndex = 7
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.SteelBlue
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(678, 243)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "Input Transaksi"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(37, 225)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 9
        Label5.Text = "Tanggal :"
        ' 
        ' dtTanggal
        ' 
        dtTanggal.CustomFormat = "0000-00-00"
        dtTanggal.Location = New Point(109, 219)
        dtTanggal.Name = "dtTanggal"
        dtTanggal.Size = New Size(200, 23)
        dtTanggal.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Lavender
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.MidnightBlue
        Label6.Location = New Point(351, 84)
        Label6.Name = "Label6"
        Label6.Size = New Size(178, 114)
        Label6.TabIndex = 11
        Label6.Text = "!!! " & vbLf & vbLf & "Pilih hijab terlebih dahulu untuk menampilkan harga." & vbLf & "Masukkan jumlah dan total akan dihitung otomatis"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(508, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(204, 222)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.LightSlateGray
        btnSimpan.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = SystemColors.ButtonHighlight
        btnSimpan.Location = New Point(220, 270)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(89, 27)
        btnSimpan.TabIndex = 13
        btnSimpan.Text = "SIMPAN"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.LightSlateGray
        btnHapus.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.ForeColor = SystemColors.ButtonHighlight
        btnHapus.Location = New Point(379, 270)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(89, 27)
        btnHapus.TabIndex = 14
        btnHapus.Text = "HAPUS"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.LightSlateGray
        btnBatal.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBatal.ForeColor = SystemColors.ButtonHighlight
        btnBatal.Location = New Point(532, 270)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(89, 27)
        btnBatal.TabIndex = 15
        btnBatal.Text = "BATAL"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' dgvTransaksi
        ' 
        dgvTransaksi.BackgroundColor = Color.LightSlateGray
        dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransaksi.Location = New Point(12, 310)
        dgvTransaksi.Name = "dgvTransaksi"
        dgvTransaksi.Size = New Size(678, 150)
        dgvTransaksi.TabIndex = 16
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.LightSlateGray
        btnKembali.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.ForeColor = SystemColors.ButtonHighlight
        btnKembali.Location = New Point(70, 270)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(89, 27)
        btnKembali.TabIndex = 17
        btnKembali.Text = "KEMBALI"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' FormTransaksi
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(702, 472)
        Controls.Add(btnKembali)
        Controls.Add(dgvTransaksi)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnSimpan)
        Controls.Add(Label6)
        Controls.Add(dtTanggal)
        Controls.Add(Label5)
        Controls.Add(cmbHijab)
        Controls.Add(txtTotal)
        Controls.Add(txtJumlah)
        Controls.Add(txtHarga)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        Name = "FormTransaksi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormTransaksi"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTransaksi, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbHijab As ComboBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvTransaksi As DataGridView
    Friend WithEvents btnKembali As Button
End Class
