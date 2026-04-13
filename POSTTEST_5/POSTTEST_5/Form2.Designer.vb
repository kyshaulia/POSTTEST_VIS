<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHijab
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
        components = New ComponentModel.Container()
        GroupBox1 = New GroupBox()
        cmbKategori = New ComboBox()
        txtStok = New TextBox()
        txtHarga = New TextBox()
        txtWarna = New TextBox()
        txtNama = New TextBox()
        txtKode = New TextBox()
        lblStok = New Label()
        lblHarga = New Label()
        lblWarna = New Label()
        lblNama = New Label()
        lblKategori = New Label()
        lblKode = New Label()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvHijab = New DataGridView()
        GroupBox2 = New GroupBox()
        txtSearch = New TextBox()
        Label1 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(dgvHijab, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cmbKategori)
        GroupBox1.Controls.Add(txtStok)
        GroupBox1.Controls.Add(txtHarga)
        GroupBox1.Controls.Add(txtWarna)
        GroupBox1.Controls.Add(txtNama)
        GroupBox1.Controls.Add(txtKode)
        GroupBox1.Controls.Add(lblStok)
        GroupBox1.Controls.Add(lblHarga)
        GroupBox1.Controls.Add(lblWarna)
        GroupBox1.Controls.Add(lblNama)
        GroupBox1.Controls.Add(lblKategori)
        GroupBox1.Controls.Add(lblKode)
        GroupBox1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.LightSlateGray
        GroupBox1.Location = New Point(16, 16)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(739, 192)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Input Data Hijab"
        ' 
        ' cmbKategori
        ' 
        cmbKategori.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        cmbKategori.FormattingEnabled = True
        cmbKategori.Items.AddRange(New Object() {"Pashmina", "Segi Empat", "Instan", "Bergo", "Khimar"})
        cmbKategori.Location = New Point(120, 76)
        cmbKategori.Name = "cmbKategori"
        cmbKategori.Size = New Size(224, 23)
        cmbKategori.TabIndex = 12
        ' 
        ' txtStok
        ' 
        txtStok.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        txtStok.Location = New Point(487, 159)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(224, 23)
        txtStok.TabIndex = 11
        ' 
        ' txtHarga
        ' 
        txtHarga.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        txtHarga.Location = New Point(487, 120)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(224, 23)
        txtHarga.TabIndex = 10
        ' 
        ' txtWarna
        ' 
        txtWarna.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        txtWarna.Location = New Point(487, 76)
        txtWarna.Name = "txtWarna"
        txtWarna.Size = New Size(224, 23)
        txtWarna.TabIndex = 9
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        txtNama.Location = New Point(487, 31)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(224, 23)
        txtNama.TabIndex = 8
        ' 
        ' txtKode
        ' 
        txtKode.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        txtKode.Location = New Point(120, 31)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(224, 23)
        txtKode.TabIndex = 6
        ' 
        ' lblStok
        ' 
        lblStok.AutoSize = True
        lblStok.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStok.ForeColor = SystemColors.ActiveCaptionText
        lblStok.Location = New Point(381, 167)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(34, 15)
        lblStok.TabIndex = 5
        lblStok.Text = "Stok:"
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHarga.ForeColor = SystemColors.ActiveCaptionText
        lblHarga.Location = New Point(381, 123)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(42, 15)
        lblHarga.TabIndex = 4
        lblHarga.Text = "Harga:"
        ' 
        ' lblWarna
        ' 
        lblWarna.AutoSize = True
        lblWarna.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWarna.ForeColor = SystemColors.ActiveCaptionText
        lblWarna.Location = New Point(381, 79)
        lblWarna.Name = "lblWarna"
        lblWarna.Size = New Size(76, 15)
        lblWarna.TabIndex = 3
        lblWarna.Text = "Warna Hijab:"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.ForeColor = SystemColors.ActiveCaptionText
        lblNama.Location = New Point(381, 34)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(73, 15)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama Hijab:"
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKategori.ForeColor = SystemColors.ActiveCaptionText
        lblKategori.Location = New Point(18, 79)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(54, 15)
        lblKategori.TabIndex = 1
        lblKategori.Text = "Kategori:"
        ' 
        ' lblKode
        ' 
        lblKode.AutoSize = True
        lblKode.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKode.ForeColor = SystemColors.ActiveCaptionText
        lblKode.Location = New Point(18, 34)
        lblKode.Name = "lblKode"
        lblKode.Size = New Size(68, 15)
        lblKode.TabIndex = 0
        lblKode.Text = "Kode Hijab:"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.LightSlateGray
        btnSimpan.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(346, 214)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(92, 31)
        btnSimpan.TabIndex = 1
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.LightSlateGray
        btnUbah.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(450, 214)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(89, 31)
        btnUbah.TabIndex = 2
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.LightSlateGray
        btnHapus.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(551, 214)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(92, 31)
        btnHapus.TabIndex = 3
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.LightSlateGray
        btnBatal.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(656, 214)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(99, 31)
        btnBatal.TabIndex = 4
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' dgvHijab
        ' 
        dgvHijab.BackgroundColor = Color.LightSlateGray
        dgvHijab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHijab.GridColor = Color.LightBlue
        dgvHijab.Location = New Point(0, 66)
        dgvHijab.Name = "dgvHijab"
        dgvHijab.Size = New Size(644, 212)
        dgvHijab.TabIndex = 6
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtSearch)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(dgvHijab)
        GroupBox2.Controls.Add(PictureBox2)
        GroupBox2.Location = New Point(16, 251)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(739, 280)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        txtSearch.Location = New Point(80, 28)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(224, 23)
        txtSearch.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(6, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 17)
        Label1.TabIndex = 13
        Label1.Text = "Search:"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.aset1_removebg_preview
        PictureBox1.Location = New Point(16, 121)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(147, 143)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.aset2_removebg_preview
        PictureBox2.Location = New Point(609, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(177, 278)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' FormHijab
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(767, 543)
        Controls.Add(PictureBox1)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Name = "FormHijab"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Hijab"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvHijab, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblWarna As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblKategori As Label
    Friend WithEvents lblKode As Label
    Friend WithEvents lblStok As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents cmbKategori As ComboBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtWarna As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtKode As TextBox
    Friend WithEvents dgvHijab As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
